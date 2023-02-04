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

        public dynamic getAllScore(string semester, string schoolYear, int stuId)
        {
            var data = from c in entities.studying
                       where c.lesson.class_module.module.semester.Equals(semester) && c.lesson.class_module.module.school_year.Equals(schoolYear) && c.student.id == stuId
                       select new
                       {
                           SchoolYear = c.lesson.class_module.module.school_year,
                           Semester = c.lesson.class_module.module.semester,
                           Name = c.lesson.class_module.module.name,
                           ModuleCode = c.lesson.class_module.ID_Class_module,
                           Credits = c.lesson.class_module.module.credits,
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
            var data = from c in entities.studying
                       where c.student.id == stuId
                       orderby c.lesson.class_module.module.school_year ascending
                       select new
                       {
                           SchoolYear = c.lesson.class_module.module.school_year,
                           Semester = c.lesson.class_module.module.semester,
                           Name = c.lesson.class_module.module.name,
                           ModuleCode = c.lesson.class_module.ID_Class_module,
                           Credits = c.lesson.class_module.module.credits,
                           AvgScore = c.score
                       };
            return data.ToList();
        }

        public dynamic getAllSchoolYear(int stuId)
        {
            var data = entities.studying
                .Where(x => x.student.id == stuId)
                .GroupBy(x => x.lesson.class_module.module.school_year)
                .Select(g => g.FirstOrDefault().lesson.class_module.module.school_year)
                .ToList();
            return data;
        }

        public int insertStudying(int studentId, int lessonId, studying studying)
        {
            studying.student_id = studentId;
            studying.lesson_id = lessonId;
            entities.studying.Add(studying);
            entities.SaveChanges();
            return studying.id;
        }

        public void deleteStudying(int studyingId)
        {
            studying studying = entities.studying.Find(studyingId);
            if(studying != null)
            {
                entities.studying.Remove(studying);
                entities.SaveChanges();
            }
        }

        public dynamic getAllStudyingWithoutScore()
        {
            var data = from c in entities.studying
                       where c.score.Value.ToString() == ""
                       select new
                       {
                           Id = c.id,
                           TrainingType = c.lesson.class_module.module.curriculum.training_type,
                           TrainingSystem = c.lesson.class_module.module.curriculum.training_system,
                           Semester = c.lesson.class_module.module.semester,
                           SchoolYear = c.lesson.class_module.module.school_year,
                           ClassCode = c.lesson.class_module.ID_Class_module,
                           ClassName = c.lesson.class_module.module.name,
                           Credits = c.lesson.class_module.module.credits,
                           Day = c.lesson.day_in_week,
                           StartTime = c.lesson.start_time,
                           EndTime = c.lesson.end_time,
                           StartDate = c.lesson.class_module.start_date,
                           EndDate = c.lesson.class_module.end_date,
                           Room = c.lesson.classroom.name,
                           Size = c.lesson.classroom.max_size,
                           Lecturer = c.lesson.teaching.lecturer.name
                       };
            return data.ToList();
        }

        public dynamic getAllStudying(int studentId)
        {
            var data = from c in entities.studying
                       where c.score.Value.ToString() == "" && c.student_id == studentId
                       select new
                       {
                           Id = c.id,
                           StudentId = c.student_id,
                           LessonId = c.lesson_id
                       };
            return data.ToList();
        }
    }
}
