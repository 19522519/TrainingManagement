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
            class_Module1.school_year = class_Module.school_year;
            class_Module1.semester = class_Module.semester;
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
    }
}
