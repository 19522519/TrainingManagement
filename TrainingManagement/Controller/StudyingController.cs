using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagement.Controller
{
    class StudyingController
    {
        TrainingManagementEntities entities = new TrainingManagementEntities();

        public dynamic getAllScore(int semester, int schoolYear, int stuId)
        {
            var data = from c in entities.studyings
                       where c.class_module.semester == semester && c.class_module.school_year == schoolYear && c.student_id == stuId
                       select new
                       {
                           Name = c.class_module.module.name,
                           ModuleCode = c.class_module.ID_Class_module,
                           TheoryCredits = c.class_module.module.theory_credits,
                           PracticeCredits = c.class_module.module.practice_credits,
                           SelfStudyCredits = c.class_module.module.self_study_credits,
                           VisitingCredits = c.class_module.module.visiting_credits,
                           AvgScore = c.score
                       };
            // Cách 2
            //var data = entities.studyings
            //    .Where(x => x.class_module.semester == semester && x.class_module.school_year == schoolYear)
            //    .Select(g => new
            //    {
            //        Name = g.class_module.module.name,
            //        ModuleCode = g.class_module.module.ID_Module,
            //        TheoryCredits = g.class_module.module.theory_credits,
            //        PracticeCredits = g.class_module.module.practice_credits,
            //        SelfStudyCredits = g.class_module.module.self_study_credits,
            //        VisitingCredits = g.class_module.module.visiting_credits,
            //        AvgScore = g.score
            //    });

            return data.ToList();
        }

        public dynamic getAllScore(int stuId)
        {
            var data = from c in entities.studyings
                       where c.student.id == stuId
                       orderby c.class_module.school_year ascending
                       select new
                       {
                           Name = c.class_module.module.name,
                           ModuleCode = c.class_module.ID_Class_module,
                           TheoryCredits = c.class_module.module.theory_credits,
                           PracticeCredits = c.class_module.module.practice_credits,
                           SelfStudyCredits = c.class_module.module.self_study_credits,
                           VisitingCredits = c.class_module.module.visiting_credits,
                           AvgScore = c.score
                       };
            return data.ToList();
        }

        public dynamic getAllSchoolYear(int stuId)
        {
            var data = entities.studyings
                .Where(x => x.student_id == stuId)
                .GroupBy(x => x.class_module.school_year)
                .Select(g => g.FirstOrDefault().class_module.school_year)
                .ToList();
            return data;
        }
    }
}
