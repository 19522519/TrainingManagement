using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagement.Controller
{
    class MajorController
    {
        TrainingManagementEntities entities = new TrainingManagementEntities();

        public dynamic getAll()
        {
            var data = from c in entities.major
                       select new
                       {
                           ID = c.id,
                           Name = c.name,
                       };

            return data.ToList();
        }
    }
}
