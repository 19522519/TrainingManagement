using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagement.Controller
{
    class ClassModuleController
    {
        TrainingManagementEntities entities = new TrainingManagementEntities();

/*        public dynamic getAllByMajor(String major)
        {
            var data = from c in entities.class_module
                     where c.module.curriculum.major.name.Equals(major)
                     orderby c.ID_Class_module ascending
                     select new
                     {
                         Id = c.id,
                         Semester = c.semester,
                         SchoolYear = c.school_year,
                         ClassCode = c.ID_Class_module,
                         Name = c.module.name,
                         StartDate = c.start_date,
                         EndDate = c.end_date
                     };
            return data.ToList();
        }*/  

        public int insertClassModule(int moduleId, class_module class_Module)
        {
            class_Module.module_id = moduleId;
            class_Module.register = "close";
            class_Module.actual_size = 0;
            entities.class_module.Add(class_Module);
            entities.SaveChanges();
            return class_Module.id;
        }

        public void deleteClassModule(int classModuleId)
        {
            class_module class_Module = entities.class_module.Find(classModuleId);
            if (class_Module != null)
            {
                entities.class_module.Remove(class_Module);
                entities.SaveChanges();
            }
        }

        public void updateClassModule(int moduleId, class_module class_Module)
        {
            class_module class_Module1 = entities.class_module.Find(class_Module.id);
            class_Module1.ID_Class_module = class_Module.ID_Class_module;
            class_Module1.start_date = class_Module.start_date;
            class_Module1.end_date = class_Module.end_date;
            class_Module1.module_id = moduleId;
            entities.SaveChanges();
        }

        public void setRegister(int lessonId, string register)
        {
            lesson lesson = entities.lesson.Find(lessonId);
            class_module class_Module = lesson.class_module;
            class_Module.register = register;
            entities.SaveChanges();
        }

        public void setActualSizePlusByLessonId(int lessonId)
        {
            lesson lesson = entities.lesson.Find(lessonId);
            class_module class_Module = entities.class_module.Find(lesson.class_module.id);
            class_Module.actual_size++;
            entities.SaveChanges();
        }


        public void setActualSizeMinusByLessonId(int studyingId)
        {
            studying studying = entities.studying.Find(studyingId);
            lesson lesson = entities.lesson.Find(studying.lesson.id);
            class_module class_Module = entities.class_module.Find(lesson.class_module.id);
            class_Module.actual_size--;
            entities.SaveChanges();
        }

        public string getClassModuleById(int classModuleId)
        {
            class_module class_Module = entities.class_module.Find(classModuleId);
            return class_Module.ID_Class_module;
        }

        public dynamic getAllSchoolYear()
        {
            var data = entities.class_module
                .GroupBy(x => x.module.school_year)
                .Select(g => g.FirstOrDefault().module.school_year);
            return data.ToList();
        }
    }
}
