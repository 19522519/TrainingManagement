using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingManagement.Controller;

namespace TrainingManagement.Controller
{
    class StudentController
    {
        TrainingManagementEntities entities = new TrainingManagementEntities();
        UserController userController = new UserController();

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

        public int insertStudent(student student, int userId)
        {
            student.users_id = userId;
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

        public void updateStudent(student stu, users u)
        {
            student student = entities.student.Find(stu.id);
            student.first_name = stu.first_name;
            student.last_name = stu.last_name;
            student.gender = stu.gender;
            student.phone = stu.phone;
            student.citizen_id = stu.citizen_id;
            student.birth_place = stu.birth_place;
            student.household = stu.household;
            student.is_in_dormitory = student.is_in_dormitory;
            entities.SaveChanges();

            users users = student.users;
            users.email = u.email;
            users.username = u.username;
            if(u.pass != "")
                users.pass = u.pass;
            users.avatar = u.avatar;
            entities.SaveChanges();
        }

        public void updateStudentProfile(student stu, users u)
        {
            student student = entities.student.Find(stu.id);
            student.first_name = stu.first_name;
            student.last_name = stu.last_name;
            student.gender = stu.gender;
            student.phone = stu.phone;
            student.citizen_id = stu.citizen_id;
            student.birth_place = stu.birth_place;
            student.household = stu.household;
            student.is_in_dormitory = student.is_in_dormitory;
            entities.SaveChanges();

            users users = student.users;
            users.avatar = u.avatar;
            entities.SaveChanges();
        }

        public int insertLecturer(student student)
        {
            entities.student.Add(student);
            entities.SaveChanges();
            return student.id;
        }

        public dynamic findStudent(string studentID, string firstName, string major)
        {
            var result = from c in entities.student
                         select c;
            if (studentID != "")
                result = from c in result
                         where c.ID_Student.Contains(studentID)
                         select c;

            if (firstName != "")
                result = from c in result
                         where c.first_name.Contains(firstName)
                         select c;

            var data = from c in result
                       where c.major.name.Equals(major)
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
            return data.ToList();
        }

        public void deleteStudent(int ID)
        {
            student student = entities.student.Find(ID);

            int userId = student.users_id.Value;

            if (student != null)
            {
                entities.student.Remove(student);
                entities.SaveChanges();
            }

            userController.deleteUser(userId);
        }

        public string getStudentCodeById (int stuId)
        {
            student student = entities.student.Find(stuId);
            return student.ID_Student;
        }

        public dynamic getAllSchoolYearBasedOnStudentId(int studentId)
        {
            var data = entities.studying
                .Where(x => x.id == studentId)
                .GroupBy(x => x.lesson.class_module.module.school_year)
                .Select(g => g.FirstOrDefault().lesson.class_module.module.school_year);
            return data.ToList();
        }

        public dynamic getTimetableBasedOnStudentId(int studentId, string schoolYear, string semester)
        {
            var data = from c in entities.studying
                       where c.lesson.class_module.module.school_year.Equals(schoolYear) && c.lesson.class_module.module.semester.Equals(semester) && c.student_id == studentId
                       select new
                       {
                           ClassCode = c.lesson.class_module.ID_Class_module,
                           ClassName = c.lesson.class_module.module.name,
                           Room = c.lesson.classroom.name,
                           StartTime = c.lesson.start_time,
                           EndTime = c.lesson.end_time,
                           StartDate = c.lesson.class_module.start_date,
                           EndDate = c.lesson.class_module.end_date,
                           Lecturer = c.lesson.teaching.lecturer.name
                       };
            return data.ToList();
        }
    }
}
