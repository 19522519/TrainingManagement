using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainingManagement.Controller;

namespace TrainingManagement.Controller
{
    class LecturerController
    {
        TrainingManagementEntities entities = new TrainingManagementEntities();
        UserController userController = new UserController();

        public dynamic getAllLecturerBasedOnMajor(String major)
        {
            var data = from c in entities.lecturer
                       where c.major.name.Equals(major)
                       select new
                       {
                           Id = c.id,
                           Name = c.name,
                           Contract = c.contract,
                           Level = c.level
                       };
            return data.ToList();
        }

        public dynamic getAll()
        {
            var lecturer = from c in entities.lecturer
                           select new
                           {
                               ID = c.id,
                               Name = c.name,
                               Major = c.major.name,
                               Level = c.level,
                               Contract = c.contract,
                               Email = c.users.email,
                               Username = c.users.username,
                               Passsword = c.users.pass
                           };
            return lecturer.ToList();
        }

        public dynamic All()
        {
            var data = entities.lecturer;
            return data.ToList();
        }

      

        public int insertLecturer(lecturer lecturer, int userId)
        {
            lecturer.users_id = userId;
            entities.lecturer.Add(lecturer);
            entities.SaveChanges();
            return lecturer.id;
        }

        public lecturer getLecturerById(int id)
        {
            return entities.lecturer.Find(id);
        }

        public dynamic getLecturerByUserId(int userId)
        {
            var lecturer = from c in entities.lecturer
                          where c.users_id == userId
                          select new
                          {
                              ID = c.id,
                              Name = c.name,
                              Major = c.major.name,
                              Level = c.level,
                              Contract = c.contract
                          };
            return lecturer.FirstOrDefault();
        }


        public void updateLecturer(lecturer lecturer, users u)
        {
            lecturer l = entities.lecturer.Find(lecturer.id);
            l.name = lecturer.name;
            l.major_id = lecturer.major_id;
            l.level = lecturer.level;
            l.contract = lecturer.contract;

            users users = l.users;
            users.username = u.username;
            users.email = u.email;
            if (u.pass != "")
                users.pass = u.pass;
            entities.SaveChanges();
        }

        public void deleteLecturer(int ID)
        { 
            lecturer lecturer = entities.lecturer.Find(ID);

            int userId = lecturer.users_id.Value;

            if (lecturer != null)
            {
                entities.lecturer.Remove(lecturer);
                entities.SaveChanges();
            }

            userController.deleteUser(userId);
        }

        public dynamic findLecturer(string lecturerName, string major)
        {
            var result = from c in entities.lecturer
                         select c;

            if (lecturerName != "")
                result = from c in result
                         where c.name.Contains(lecturerName)
                         select c;

            var data = from c in result
                       where c.major.name.Equals(major)
                       select new
                       {
                           ID = c.id,
                           Name = c.name,
                           Major = c.major.name,
                           Level = c.level,
                           Contract = c.contract,
                           Email = c.users.email,
                           Username = c.users.username,
                           Passsword = c.users.pass
                       };
            return data.ToList();
        }

        public dynamic findAllLevelOnMajor(string major)
        {
            var data = from c in entities.lecturer
                       where c.major.name.Equals(major)
                       select new
                       {
                           Level = c.level
                       };
            return data.ToList();
        }

        public dynamic findLecturerOnNameAndLevel(string lecturerName, string level, string major)
        {
            var result = from c in entities.lecturer
                         select c;

            if (lecturerName != "")
                result = from c in entities.lecturer
                         where c.name.Contains(lecturerName)
                         select c;

            if (level != "")
                result = from c in entities.lecturer
                         where c.level.Equals(level)
                         select c;

            var data = from c in result
                       where c.major.name.Equals(major)
                       select new
                       {
                           ID = c.id,
                           Name = c.name,
                           Major = c.major.name,
                           Level = c.level,
                           Contract = c.contract,
                           Email = c.users.email,
                           Username = c.users.username,
                           Passsword = c.users.pass
                       };
            return data.ToList();
        }
    }
}
