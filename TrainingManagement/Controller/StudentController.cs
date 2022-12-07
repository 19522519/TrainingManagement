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
                              Major = c.major.name,
                              IsInDorm = c.is_in_dormitory,
                              Household = c.household,
                              Username = c.user.username,
                              Password = c.user.pass,
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

        public student getStudentById(int id)
        {
            return entities.students.Find(id);
        }

        public dynamic getStudentByUserId(int userId)
        {
            var student = from c in entities.students
                          where c.users_id == userId
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
                              Major = c.major.name,
                              IsInDorm = c.is_in_dormitory,
                              Household = c.household,
                              Username = c.user.username,
                              Password = c.user.pass,
                              Right = c.user.access_right,
                              Avatar = c.user.avatar
                          };
            return student.FirstOrDefault();
        }

        public void updateStudent(student stu)
        {
            student student = entities.students.Find(stu.id);
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
