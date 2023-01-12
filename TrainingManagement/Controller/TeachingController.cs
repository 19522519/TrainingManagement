using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagement.Controller
{
    class TeachingController
    {
        TrainingManagementEntities entities = new TrainingManagementEntities();

        public dynamic getAllScore(int semester, int schoolYear, string classMoule)
        {
            var data = from c in entities.studying
                       where c.class_module.semester == semester && c.class_module.school_year == schoolYear
                       select new
                       {
                           ID = c.id,
                           StudentID = c.student.ID_Student,
                           LastName = c.student.last_name,
                           FirstName = c.student.first_name,
                           AvgScore = c.score,
                       };
            return data.ToList();
        }

        

        public dynamic getAllSchoolYear(int lecId)
        {
            var data = entities.teaching
                .Where(x => x.lecturer_id == lecId)
                .GroupBy(x => x.class_module.school_year)
                .Select(g => g.FirstOrDefault().class_module.school_year)
                .ToList();
            return data;
        }

        public dynamic getAllClassModule(int semester, int schoolYear, int lecId)
        {
            var data = entities.teaching
                .Where(x => x.class_module.semester == semester && x.class_module.school_year == schoolYear && x.lecturer_id == lecId)
                .GroupBy(x => x.class_module.ID_Class_module)
                .Select(g => g.FirstOrDefault().class_module.ID_Class_module)
                .ToList();
            return data;
        }

        public void updateScore(studying studying)
        {
            studying ls = entities.studying.Find(studying.id);
            ls.score = studying.score;
            entities.SaveChanges();
        }



    }


}
