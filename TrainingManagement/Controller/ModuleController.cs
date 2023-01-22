using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagement.Controller
{
    class ModuleController
    {
        TrainingManagementEntities entities = new TrainingManagementEntities();

        public int insertModule(int curriculumId, module module)
        {
            module.curriculum_id = curriculumId;
            entities.module.Add(module);
            entities.SaveChanges();
            return module.id;
        }

        public dynamic getAllModuleBaseOnCurriculum(int curriculumId)
        {
            var data = from c in entities.module
                       where c.curriculum_id == curriculumId
                       select new
                       {
                           Id = c.id,
                           Code = c.ID_Module,
                           Name = c.name,
                           TheoryLessons = c.theory_lessons,
                           PracticeLessons = c.practice_lessons,
                           SelfStudyLessons = c.self_study_lessons,
                           VisitingLessons = c.visiting_lessons
                       };
            return data.ToList();
        }

        public void updateModule(module module)
        {
            module module1 = entities.module.Find(module.id);
            module1.ID_Module = module.ID_Module;
            module1.name = module.name;
            module1.theory_lessons = module.theory_lessons;
            module1.practice_lessons = module.practice_lessons;
            module1.self_study_lessons = module.self_study_lessons;
            module1.visiting_lessons = module.visiting_lessons;
            entities.SaveChanges();
        } 

        public void deleteModule(int moduleId)
        {
            module module = entities.module.Find(moduleId);
            if(module != null)
            {
                entities.module.Remove(module);
                entities.SaveChanges();
            }
        }

        public dynamic getAllModulesBasedOnShoolYear(string schoolYear)
        {
            var data = from c in entities.module
                       where c.curriculum.school_year.Equals(schoolYear)
                       select new
                       {
                           Id = c.id,
                           Code = c.ID_Module,
                           Name = c.name,
                           TheoryLessons = c.theory_lessons,
                           PracticeLessons = c.practice_lessons,
                           SelfStudyLessons = c.self_study_lessons,
                           VisitingLessons = c.visiting_lessons
                       };
            return data.ToList();
        }
    }
}
