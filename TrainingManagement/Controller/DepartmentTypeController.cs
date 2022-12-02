using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagement.Controller
{
    class DepartmentTypeController
    {
        TrainingManagementEntities entities = new TrainingManagementEntities();
        public dynamic getAll()
        {
            var data = from c in entities.departments
                       select new { ID = c.id, Name = c.name, Phone = c.phone, Address = c.address };
            return data.ToList();
        }
        public void AddDepartment(department department)
        {
            entities.departments.Add(department);
            entities.SaveChanges();
        }

        public void DeleteDepartment(int ID)
        {
            department  department = new department();
            if (department != null)
            {
                department = entities.departments.Where(p => p.id == ID).SingleOrDefault();
                entities.departments.Remove(department);
                entities.SaveChanges();
            }

        }

        public void UpdateDepartment(department department)
        {
            department ldepartment = entities.departments.Find(department.id);
            ldepartment.name = department.name;
            ldepartment.phone = department.phone;
            ldepartment.address = department.address;
            entities.SaveChanges();
        }
    }
}
