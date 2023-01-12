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
            var student = from c in entities.student
                          select new
                          {
                              Id = c.id,
                              StudentId = c.ID_Student,
                              CitizenId = c.citizen_id,
                              LastName = c.last_name,
                              FirstName = c.first_name,
                              Email = c.users.email,
                              Gender = c.gender,
                              Phone = c.phone,                        
                              BirthPlace = c.birth_place,
                              Major = c.major.name,
                              IsInDorm = c.is_in_dormitory,
                              Household = c.household,
                              Username = c.users.username,
                              Password = c.users.pass,
                              Right = c.users.access_right,
                              Avatar = c.users.avatar
                          };
            return student.ToList();
        }

        public int insertStudent(student student)
        {
            entities.student.Add(student);
            entities.SaveChanges();
            return student.id;
        }

        public student getStudentById(int id)
        {
            return entities.student.Find(id);
        }

        public dynamic getStudentByUserId(int userId)
        {
            var student = from c in entities.student
                          where c.users.id == userId
                          select new
                          {
                              Id = c.id,
                              StudentId = c.ID_Student,
                              CitizenId = c.citizen_id,
                              LastName = c.last_name,
                              FirstName = c.first_name,
                              Email = c.users.email,
                              Gender = c.gender,
                              Phone = c.phone,
                              BirthPlace = c.birth_place,
                              Major = c.major.name,
                              IsInDorm = c.is_in_dormitory,
                              Household = c.household,
                              Username = c.users.username,
                              Password = c.users.pass,
                              Right = c.users.access_right,
                              Avatar = c.users.avatar
                          };
            return student.FirstOrDefault();
        }

        public void updateStudent(student stu)
        {
            student student = entities.student.Find(stu.id);
            student.gender = stu.gender;
            student.phone = stu.phone;
            student.citizen_id = stu.citizen_id;
            student.birth_place = stu.birth_place;
            student.household = stu.household;
            student.is_in_dormitory = student.is_in_dormitory;
            entities.SaveChanges();
        }
    }
}
