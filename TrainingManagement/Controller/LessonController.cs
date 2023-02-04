using System.Linq;

namespace TrainingManagement.Controller
{
    class LessonController
    {
        TrainingManagementEntities entities = new TrainingManagementEntities();

        public dynamic getAllTimeable(string semester, string schoolYear, int lecId)
        {
            var data = from c in entities.lesson
                       where c.class_module.module.semester.Equals(semester) && c.class_module.module.school_year.Equals(schoolYear) && c.teaching.lecturer.id == lecId
                       select new
                          {
                              Id = c.id,
                              ClassModuleID = c.class_module.ID_Class_module,
                              Name = c.class_module.module.name,
                              DayInWeek = c.day_in_week,
                              StartTime = c.start_time,
                              EndTime = c.end_time,
                              RoomName = c.classroom.name,
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
                           Semester = c.class_module.module.semester,
                           SchoolYear = c.class_module.module.school_year,
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

        public dynamic getAllLessons(string semester, string schoolYear)
        {
            var data = from c in entities.lesson
                       where c.class_module.module.semester.Equals(semester) && c.class_module.module.school_year.Equals(schoolYear)
                       select new
                       {
                           Id = c.id,
                           TrainingType = c.class_module.module.curriculum.training_type,
                           TrainingSystem = c.class_module.module.curriculum.training_system,
                           Curriculum = c.class_module.module.curriculum.name,
                           Semester = c.class_module.module.semester,
                           SchoolYear = c.class_module.module.school_year,
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
                           Semester = c.class_module.module.semester,
                           SchoolYear = c.class_module.module.school_year,
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

        public dynamic getAllLessonsBasedOnSemesterAndSchoolYearAndMajor(string semester, string schoolYear, string major)
        {
            var result = from c in entities.lesson
                         select c;

            if (schoolYear != "")
                result = from c in entities.lesson
                         where c.class_module.module.school_year.Equals(schoolYear)
                         select c;

            if (semester != "")
                result = from c in entities.lesson
                         where c.class_module.module.semester.Equals(semester)
                         select c;

            var data = from c in result
                       where c.class_module.module.curriculum.major.name.Equals(major)
                       orderby c.class_module.ID_Class_module ascending
                       select new
                       {
                           Id = c.id,
                           Semester = c.class_module.module.semester,
                           SchoolYear = c.class_module.module.school_year,
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

        public dynamic calculateStudentRegisterModule(string major, string schoolYear, string semester)
        {
            var data = from c in entities.lesson
                       where c.class_module.module.curriculum.major.name.Equals(major) && c.class_module.module.school_year.Equals(schoolYear) && c.class_module.module.semester.Equals(semester)
                       select new
                       {
                           ClassCode = c.class_module.ID_Class_module,
                           ActualSize = c.class_module.actual_size,
                       };
            return data.ToList();
        }
    }
}
