using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagement.Controller
{
    class ClassroomController
    {
        TrainingManagementEntities entities = new TrainingManagementEntities();

        public dynamic getAllClassroomBasedOnFunction(string function)
        {
            var data = from c in entities.classroom
                       where c.function_name.Equals(function)
                       select new
                       {
                           Id = c.id,
                           Name = c.name
                       };
            return data.ToList();
        }

        public dynamic findClassroomBasedOnName(string name)
        {
            var data = from c in entities.classroom
                       where c.name.Equals(name)
                       select new
                       {
                           Id = c.id
                       };
            return data.ToList().FirstOrDefault();
        }
    }
}
