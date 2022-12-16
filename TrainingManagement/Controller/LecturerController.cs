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

        public dynamic getAll()
        {
            var lecturer = from c in entities.lecturers
                           select new
                           {
                               ID = c.id,
                               Name = c.name,
                               Major = c.major.name,
                               Level = c.level,
                               Contract = c.contract
                           };
            return lecturer.ToList();
        }

        public int insertLecturer(lecturer lecturer)
        {
            entities.lecturers.Add(lecturer);
            entities.SaveChanges();
            return lecturer.id;
        }

        public lecturer getLecturerById(int id)
        {
            return entities.lecturers.Find(id);
        }

        public dynamic getLecturerByUserId(int userId)
        {
            var lecturer = from c in entities.lecturers
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


        public void updateLecturer(lecturer lecturer)
        {
            lecturer l = entities.lecturers.Find(lecturer.id);
            l.name = lecturer.name;
            l.major_id = lecturer.major_id;
            l.level = lecturer.level;
            l.contract = lecturer.contract;
            entities.SaveChanges();
        }

        public void deleteLecturer(int ID)
        {
            lecturer lecturer = entities.lecturers.Find(ID);
            if (lecturer != null)
            {
                entities.lecturers.Remove(lecturer);
                entities.SaveChanges();
            }
        }

        public dynamic findLecturer(string lecturerName)
        {
            var result = from c in entities.lecturers
                         select c;
            if (lecturerName != "")
                result = from c in result
                         where c.name.Contains(lecturerName)
                         select c;

            var data = from c in result
                       select new
                       {
                           ID = c.id,
                           Name = c.name,
                           Major = c.major.name,
                           Level = c.level,
                           Contract = c.contract,
                       };
            return data.ToList();
        }
    }
}
