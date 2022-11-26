create database TrainingManagement
use TrainingManagement
set dateformat dmy

-- Hệ đào tạo: hệ đại học, hệ cao đẳng)
-- Chuyên ngành: công nghệ phần mềm, mạng máy tính, hệ thống thông tin, khoa học máy tính
-- Loại hình đào tạo: chính quy, liên thông , vừa học vừa làm

create table curriculum (
	id int identity(1,1) primary key,
	name nvarchar(50),
	training_system nvarchar(50),
	major nvarchar(50),
	training_type nvarchar(50)	
)

-- 1 chương trình đào tạo có ds học phần
create table module (
	id int identity(1,1) primary key,
	ID_Module nvarchar(20),
	name nvarchar(50),
	theory_credits int,
	practice_credits int,
	self_study_credits int,
	visiting_credits int,
)
alter table module add curriculum_id int references curriculum (id)

create table department (
	id int identity(1,1) primary key,
	name nvarchar(100),
	phone nvarchar(20),
	address nvarchar(100),
)

-- 1 khoa có 1 hoặc n chuyên ngành
-- 1 chương trình đào tạo thuộc về 1 chuyên ngành
create table major (
	id int identity(1,1) primary key,
	name nvarchar(100)
)
alter table major add department_id int references department (id)
alter table major add curriculum_id int references curriculum (id)

-- Năm học 2019-2020, 2020-2021
create table school_year (
	id int identity(1,1) primary key,
	name nvarchar(50)
)
-- Học kỳ 1, 2
create table semester (
	id int identity(1,1) primary key,
	name nvarchar(50)
)
alter table semester add school_year_id int references school_year (id)

create table class_module (
	id int identity(1,1) primary key,
	ID_Class_module nvarchar(20),
	name nvarchar(50),
	start_date date,
	end_date date
)
alter table class_module add module_id int references module (id)
alter table class_module add semester_id int references semester (id)

-- Hợp đồng: hợp đồng chính thức, giảng viên thỉnh giảng, giảng viên mời giảng
-- Trình độ: tiến sĩ, thạc sĩ, đại học
-- 1 giáo viên thuộc sự quản lý của 1 khoa
create table lecturer (
	id int identity(1,1) primary key,
	contract nvarchar(50),
	major nvarchar(50),
	level nvarchar(50)
)
alter table lecturer add department_id int references department (id)

-- Giảng viên đk các học phần
-- Có thể có 2 giảng viên cùng giảng
create table teaching_assignment (
	id int identity(1,1) primary key,
)
alter table teaching_assignment add module_id int references module (id)
alter table teaching_assignment add lecturer_id int references lecturer (id)


create table teaching (
	id int identity(1,1) primary key
)
alter table teaching add class_module_id int references class_module (id)
alter table teaching add lecturer_id int references lecturer (id)


-- 1 sinh viên thuộc 1 khoa
create table student (
	id int identity(1,1) primary key,
	ID_Student nvarchar(20),
	first_name nvarchar(50),
	last_name nvarchar(50),
	gender nvarchar(50),
	birth_place nvarchar(50),
	household nvarchar (200),
	is_in_dormitory nvarchar(50),
	phone nvarchar(50),
	citizen_id nvarchar(50),
	is_deleted nvarchar(50),
	avatar nvarchar(50)
)
alter table student add department_id int references department (id)


create table studying (
	id int identity(1,1) primary key,
	score float
)
alter table studying add student_id int references student (id)
alter table studying add class_module_id int references class_module (id)
alter table studying add semester_id int references semester (id)


-- Chức năng: phòng học lý thuyết, phòng học thực hành, phòng hội thảo
create table classroom (
	id int identity(1,1) primary key,
	function_name nvarchar(100),
	max_size int
)


create table week_in_term (
	id int identity(1,1) primary key,
	week_number nvarchar(50),	
	term_number nvarchar(50)
)

create table lesson (
	id int identity(1,1) primary key,
	day_in_week nvarchar(50),
	start_time date,
	end_time date
)
alter table lesson add classroom_id int references classroom (id)
alter table lesson add teaching_id int references teaching (id)
alter table lesson add class_module_id int references class_module (id)
alter table lesson add week_in_term_id int references week_in_term (id)


create table users (
	id int identity(1,1) primary key,
	role_name nvarchar(50),
	email nvarchar(100),
	password nvarchar(50),
	username nvarchar(50),
	access_right nvarchar(50),
	avatar int
)
alter table student add users_id int references users (id)
alter table lecturer add users_id int references users (id)
alter table department add users_id int references users (id)


INSERT INTO users VALUES 
       (N'Sinh viên','19522015@gm.uit.edu.vn','1234','DongPhong','Student',1),
	   (N'Giảng viên','tronglt@uit.edu.vn','1225','ThanhTrong','Lecturer',2),
	   (N'Giáo vụ','xuanth@uit.edu.vn','1100','Xuan','Ministry',3);

INSERT INTO curriculum VALUES 
      (N'Cử nhân ngành kỹ thuật phần mềm', N'hệ đại học', N'Công nghệ phần mềm', N'chính quy'),
	  (N'Cử nhân ngành kỹ thuật máy tính', N'hệ cao đẳng', N'Kỹ thuật máy tính', N'liên thông');

INSERT INTO module VALUES 
      ('SE104', N'Nhập môn công nghệ phần mềm',3,1,1,1,1),
	  ('SE208', N'Kiểm chứng phần mềm',2,1,1,1,1),
	  ('SE102', N'Nhập môn phát triển game',3,1,1,1,1),
	  ('IT010', N'Tổ chức và cấu trúc máy tính',3,1,1,1,2);

INSERT INTO department VALUES 
      (N'Khoa Công nghệ Phần mềm','0837251993',N'Khu phố 6, Phường Linh Trung, Quận Thủ Đức, Tp. Hồ Chí Minh',3),
	  (N'Khoa Kỹ thuật Máy tính','0283725 2002',N'Khu phố 6, Phường Linh Trung, Quận Thủ Đức, Tp. Hồ Chí Minh',3);

INSERT INTO major VALUES
       (N'Công nghệ phần mềm',1,1),
	   (N'Kỹ thuật máy tính',2,2);

INSERT INTO school_year VALUES
       ('2021-2022'),
	   ('2022-2023');

INSERT INTO semester VALUES
       (N'Học kỳ 1',1),
	   (N'Học kỳ 2',1);

INSERT INTO class_module VALUES
        ('SE104.M11',N'Nhập môn công nghệ phần mềm','5/9/2021','31/12/2021',1,1),
		('SE104.M13',N'Nhập môn công nghệ phần mềm','5/9/2021','31/12/2021',1,1),
		('SE208.M11',N'Kiểm chứng phần mềm','28/2/2022','30/6/2022',1,2);

INSERT INTO lecturer VALUES 
        (N'hợp đồng chính thức',N'Công nghệ phần mềm',N'thạc sĩ',1,2),
		(N'giảng viên thỉnh giảng',N'Kỹ thuật máy tính',N'thạc sĩ',2,2),
		(N'giảng viên mời giảng',N'Kỹ thuật máy tính',N'thạc sĩ',2,2);

INSERT INTO teaching_assignment VALUES 
        (1,1),
		(1,1),
		(2,2);

INSERT INTO teaching VALUES
        (1,1),
		(2,1),
		(3,2);

INSERT INTO student VALUES 
       ('19522015',N'Đông Phong',N'Võ','Nam',N'Phù Cát',N'Bình Định',N'Có',N'0909123456',N'123456',N'Không','',1,1),
	   ('19522115',N'Thanh Tuấn',N'Nguyễn','Nam',N'Huế',N'Hà Nội',N'Không',N'0909654321',N'654321',N'Không','',1,1),
	   ('20522134',N'Thanh Nghị',N'Lê','Nữ',N'Huế',N'Quảng Nam',N'Không',N'09092468',N'2468',N'Không','',2,1);

INSERT INTO studying VALUES
       (7,1,1,1),
	   (8,1,2,1),
	   (9,2,3,2);

INSERT INTO classroom VALUES
      (N'phòng học lý thuyết',45),
	  (N'phòng thực hành',150);


INSERT INTO week_in_term VALUES
       (N'15 tuần',''),
	   (N'12 tuần','');

INSERT INTO lesson VALUES
       (N'Thứ 2','','',1,1,1,1),
	   (N'Thứ 3','','',1,1,1,1);

