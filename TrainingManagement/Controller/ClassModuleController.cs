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

        public dynamic getAllByMajor(String major)
        {
            var cm = from c in entities.class_module
                     where c.module.curriculum.major.Equals(major)
                     select new
                     {
                         Semester = c.semester,
                         School_Year = c.school_year,
                         ID = c.ID_Class_module,
                         Name = c.module.name,
                         Start_Date = c.start_date,
                         End_Date = c.end_date
                     };
            return cm.ToList();
        }  

        public int insertClassModule(int moduleId, class_module class_Module)
        {
            class_Module.id = moduleId;
            entities.class_module.Add(class_Module);
            entities.SaveChanges();
            return class_Module.id;
        }
    }
}
