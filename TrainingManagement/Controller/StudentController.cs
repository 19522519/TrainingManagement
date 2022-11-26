using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagement.Controller
{
    class StudentController
    {
        TrainingManagementEntities entities = new TrainingManagementEntities();

        public dynamic getAll()
        {
            var student = from c in entities.students
                          select new
                          {
                              Id = c.id,
                              StudentId = c.ID_Student,
                              CitizenId = c.citizen_id,
                              LastName = c.last_name,
                              FirstName = c.first_name,
                              Email = c.user.email,
                              Gender = c.gender,
                              Phone = c.phone,                        
                              BirthPlace = c.birth_place,
                              Department = c.department,
                              IsInDorm = c.is_in_dormitory,
                              Household = c.household,
                              Username = c.user.username,
                              Password = c.user.password,
                              Right = c.user.access_right,
                              Avatar = c.user.avatar
                          };
            return student.ToList();
        }

        public int insertStudent(student student)
        {
            entities.students.Add(student);
            entities.SaveChanges();
            return student.id;
        }
    }
}
