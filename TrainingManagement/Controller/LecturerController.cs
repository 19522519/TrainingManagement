using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagement.Controller
{
    class LecturerController
    {
        TrainingManagementEntities entities = new TrainingManagementEntities();

        public dynamic getAll(String major)
        {
            var data = from c in entities.lecturers
                       where c.major.name.Equals(major)
                       select new
                       {
                           name = c.name
                       };
            return data;
        }
    }
}
