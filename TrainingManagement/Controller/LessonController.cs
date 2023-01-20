using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagement.Controller
{
    class LessonController
    {
        TrainingManagementEntities entities = new TrainingManagementEntities();

        public dynamic getAllTimeable(int semester, int schoolYear, int lecId)
        {
            var data = from c in entities.lesson
                       where c.class_module.semester == semester && c.class_module.school_year == schoolYear && c.teaching.lecturer.id == lecId
                       select new
                          {
                              Id = c.id,
                              ClassModuleID = c.class_module.ID_Class_module,
                              Name = c.class_module.module.name,
                              DayInWeek = c.day_in_week,
                              StartTime = c.start_time,
                              EndTime = c.end_time,
                              MaxSize = c.classroom.max_size,
                              StartDay = c.class_module.start_date,
                              EndDay = c.class_module.end_date,
                          };
            return data.ToList();
        }
    }
}
