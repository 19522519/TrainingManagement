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

        public dynamic getAllLessons(string major)
        {
            var data = from c in entities.lesson
                       where c.class_module.module.curriculum.major.name.Equals(major)
                       select new
                       {
                           Id = c.id,
                           Semester = c.class_module.semester,
                           SchoolYear = c.class_module.school_year,
                           ClassCode = c.class_module.ID_Class_module,
                           ClassName = c.class_module.module.name,
                           Day = c.day_in_week,
                           StartTime = c.start_time,
                           EndTime = c.end_time,
                           StartDate = c.class_module.start_date,
                           EndDate = c.class_module.end_date,
                           Room = c.classroom.name,
                           Lecturer = c.teaching.lecturer.name
                       };
            return data.ToList();
        }

        public dynamic getAllLessons(int semester, int schoolYear)
        {
            var data = from c in entities.lesson
                       where c.class_module.semester == semester && c.class_module.school_year == schoolYear
                       select new
                       {
                           Id = c.id,
                           TrainingType = c.class_module.module.curriculum.training_type,
                           TrainingSystem = c.class_module.module.curriculum.training_system,
                           Curriculum = c.class_module.module.curriculum.name,
                           Semester = c.class_module.semester,
                           SchoolYear = c.class_module.school_year,
                           ClassCode = c.class_module.ID_Class_module,
                           ClassName = c.class_module.module.name,
                           Credits = c.class_module.module.credits,
                           TheoryLessons = c.class_module.module.theory_lessons,
                           PracticeLessons = c.class_module.module.practice_lessons,
                           SelfStudyLessons = c.class_module.module.self_study_lessons,
                           VisitingLessons = c.class_module.module.visiting_lessons,
                           Day = c.day_in_week,
                           StartTime = c.start_time,
                           EndTime = c.end_time,
                           StartDate = c.class_module.start_date,
                           EndDate = c.class_module.end_date,
                           Room = c.classroom.name,
                           Size = c.classroom.max_size,
                           Lecturer = c.teaching.lecturer.name,
                           Register = c.class_module.register
                       };
            return data.ToList();
        }

        public dynamic getAllLessonsWithOpen()
        {
            var data = from c in entities.lesson
                       where c.class_module.register.Equals("open")
                       select new
                       {
                           Id = c.id,
                           TrainingType = c.class_module.module.curriculum.training_type,
                           TrainingSystem = c.class_module.module.curriculum.training_system,
                           Curriculum = c.class_module.module.curriculum.name,
                           Semester = c.class_module.semester,
                           SchoolYear = c.class_module.school_year,
                           ClassCode = c.class_module.ID_Class_module,
                           ClassName = c.class_module.module.name,
                           Credits = c.class_module.module.credits,
                           TheoryLessons = c.class_module.module.theory_lessons,
                           PracticeLessons = c.class_module.module.practice_lessons,
                           SelfStudyLessons = c.class_module.module.self_study_lessons,
                           VisitingLessons = c.class_module.module.visiting_lessons,
                           Day = c.day_in_week,
                           StartTime = c.start_time,
                           EndTime = c.end_time,
                           StartDate = c.class_module.start_date,
                           EndDate = c.class_module.end_date,
                           Room = c.classroom.name,
                           Size = c.classroom.max_size,
                           Lecturer = c.teaching.lecturer.name,
                           Register = c.class_module.register
                       };
            return data.ToList();
        }

        public dynamic getAllLessonsBasedOnSemesterAndSchoolYear(int semester, int schoolYear, string major)
        {
            var result = from c in entities.lesson
                         select c;

            if(semester.ToString() != "")
                result = from c in entities.lesson
                         where c.class_module.semester == semester
                         select c;

            var data = from c in result
                       where c.class_module.school_year == schoolYear && c.class_module.module.curriculum.major.name.Equals(major)
                       orderby c.class_module.ID_Class_module ascending
                       select new
                       {
                           Id = c.id,
                           Semester = c.class_module.semester,
                           SchoolYear = c.class_module.school_year,
                           ClassCode = c.class_module.ID_Class_module,
                           ClassName = c.class_module.module.name,
                           Day = c.day_in_week,
                           StartTime = c.start_time,
                           EndTime = c.end_time,
                           StartDate = c.class_module.start_date,
                           EndDate = c.class_module.end_date,
                           Room = c.classroom.name,
                           Lecturer = c.teaching.lecturer.name
                       };

            return data.ToList();
        }

        public int insertLesson(int classroomId, int teachingId, int classModuleId, lesson lesson)
        {
            lesson.classroom_id = classroomId;
            lesson.teaching_id = teachingId;
            lesson.class_module_id = classModuleId;
            entities.lesson.Add(lesson);
            entities.SaveChanges();
            return lesson.id;
        }

        public void deleteLesson(int lessonId)
        {
            lesson lesson = entities.lesson.Find(lessonId);
            if(lesson != null)
            {
                entities.lesson.Remove(lesson);
                entities.SaveChanges();
            }
        }

        public int findTeachingBasedOnLesson(int lessonId)
        {
            lesson lesson = entities.lesson.Find(lessonId);
            return (int)lesson.teaching_id;
        }

        public int findClassModuleBasedOnLesson(int lessonId)
        {
            lesson lesson = entities.lesson.Find(lessonId);
            return (int)lesson.class_module_id;
        }

        public int findLecturerBasedOnLesson(int lessonId)
        {
            lesson lesson = entities.lesson.Find(lessonId);
            lecturer lecturer = lesson.teaching.lecturer;
            return lecturer.id;
        }

        public int findModuleBasedOnLesson(int lessonId)
        {
            lesson lesson = entities.lesson.Find(lessonId);
            module module = lesson.class_module.module;
            return module.id;
        }

        public int findClassroomBasedOnLesson(int lessonId)
        {
            lesson lesson = entities.lesson.Find(lessonId);
            classroom classroom = lesson.classroom;
            return classroom.id;
        }

        public void updateLesson(int classroomId, lesson lesson)
        {
            lesson lesson1 = entities.lesson.Find(lesson.id);
            lesson1.day_in_week = lesson.day_in_week;
            lesson1.start_time = lesson.start_time;
            lesson1.end_time = lesson.end_time;
            lesson1.classroom_id = classroomId;
            entities.SaveChanges();
        }
    }
}
