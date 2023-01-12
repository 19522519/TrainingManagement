using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace TrainingManagement.Controller
{
    class CurriculumController
    {
        TrainingManagementEntities entities = new TrainingManagementEntities();

        public dynamic getAll(String major)
        {
            var data = from c in entities.curriculum
                       where c.major.name.Equals(major)
                       select new
                       {
                           Id = c.id,
                           Name = c.name,
                           TrainingSystem = c.training_system,
                           TrainingType = c.training_type,
                           SchoolYear = c.school_year
                       };
            return data.ToList();
        }

        public int insertCurriculum(curriculum curriculum, String major)
        {
            major major1 = entities.major.FirstOrDefault(m => m.name.Equals(major));
            curriculum.major = major1;

            entities.curriculum.Add(curriculum);
            entities.SaveChanges();
            return curriculum.id;
        }

        public void updateCurriculum(curriculum curriculum)
        {
            curriculum curriculum1 = entities.curriculum.Find(curriculum.id);
            curriculum1.name = curriculum.name;
            curriculum1.training_system = curriculum.training_system;
            curriculum1.training_type = curriculum.training_type;
            curriculum1.school_year = curriculum.school_year;
            entities.SaveChanges();
        }

        public dynamic getAllSchoolYearOnMajor(string right)
        {
            var data = entities.curriculum
                .Where(x => x.major.name.Equals(right))
                .GroupBy(x => x.school_year)
                .Select(g => g.FirstOrDefault().school_year);
            return data.ToList();
        }

        public dynamic getAllCurriculumNameOnYearAndMajor(int year, string right)
        {
            var data = from c in entities.curriculum
                       where c.major.name.Equals(right) && c.school_year.Equals(year)
                       select new
                       {
                           Name = c.name
                       };
            return data.ToList();
        }
    }
}
