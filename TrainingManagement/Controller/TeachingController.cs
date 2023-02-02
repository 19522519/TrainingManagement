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

        public dynamic getAllScore(string semester, string schoolYear, string classMoule)
        {
            var data = from c in entities.studying
                       where c.lesson.class_module.module.semester.Equals(semester) && c.lesson.class_module.module.school_year.Equals(schoolYear) && c.lesson.class_module.ID_Class_module.Equals(classMoule)
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
                .GroupBy(x => x.class_module.module.school_year)
                .Select(g => g.FirstOrDefault().class_module.module.school_year)
                .ToList();
            return data;
        }

        public dynamic getAllClassModule(string semester, string schoolYear, int lecId)
        {
            var data = entities.teaching
                .Where(x => x.class_module.module.semester.Equals(semester) && x.class_module.module.school_year.Equals(schoolYear) && x.lecturer_id == lecId)
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

        public int insertTeaching(int classModuleId, int lecturerId, teaching teaching)
        {
            teaching.class_module_id = classModuleId;
            teaching.lecturer_id = lecturerId;
            entities.teaching.Add(teaching);
            entities.SaveChanges();
            return teaching.id;
        }

        public void deleteTeaching(int teachingId)
        {
            teaching teaching = entities.teaching.Find(teachingId);
            if(teaching != null)
            {
                entities.teaching.Remove(teaching);
                entities.SaveChanges();
            }
        }

        public void updateTeaching(int lecturerId, teaching teaching)
        {
            teaching teaching1 = entities.teaching.Find(teaching.id);
            teaching1.lecturer_id = lecturerId;
            entities.SaveChanges();
        }
    }


}
