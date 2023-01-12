create database TrainingManagement
use TrainingManagement
set dateformat dmy

-- Hệ đào tạo: hệ đại học, hệ cao đẳng
-- Chuyên ngành: công nghệ phần mềm, mạng máy tính, hệ thống thông tin, khoa học máy tính
-- Loại hình đào tạo: chính quy, liên thông , vừa học vừa làm
create table curriculum (
	id int identity(1,1) primary key,
	name nvarchar(50),
	training_system nvarchar(50),
	training_type nvarchar(50),
	school_year nvarchar(50)	
)

-- 1 chương trình đào tạo có ds học phần
create table module (
	id int identity(1,1) primary key,
	ID_Module nvarchar(20),
	name nvarchar(50),
	theory_lessons int,
	practice_lessons int,
	self_study_lessons int,
	visiting_lessons int
)

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
	code nvarchar(50),
	name nvarchar(50)
)

create table class_module (
	id int identity(1,1) primary key,
	ID_Class_module nvarchar(20),
	start_date date,
	end_date date,
	semester int,
	school_year int
)

-- Hợp đồng: hợp đồng chính thức, giảng viên thỉnh giảng, giảng viên mời giảng
-- Trình độ: tiến sĩ, thạc sĩ, đại học
-- 1 giáo viên thuộc sự quản lý của 1 khoa
create table lecturer (
	id int identity(1,1) primary key,
	name nvarchar(50),
	contract nvarchar(50),
	level nvarchar(50)
)

-- Giảng viên đk các học phần
-- Có thể có 2 giảng viên cùng giảng
create table teaching (
	id int identity(1,1) primary key
)

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
	is_deleted nvarchar(50)
)

create table studying (
	id int identity(1,1) primary key,
	score float
)

-- Chức năng: phòng học lý thuyết, phòng học thực hành, phòng hội thảo
create table classroom (
	id int identity(1,1) primary key,
	function_name nvarchar(100),
	max_size int
)

create table lesson (
	id int identity(1,1) primary key,
	day_in_week nvarchar(50),
	start_time date,
	end_time date
)

create table users (
	id int identity(1,1) primary key,
	email nvarchar(100),
	pass nvarchar(50),
	username nvarchar(50),
	access_right nvarchar(50),
	avatar int
)

create table module_list ( 
	id int identity(1,1) primary key,
	code nvarchar(50),
	name nvarchar(50),
	credits int
)


alter table curriculum add major_id int references major (id)
alter table module add curriculum_id int references curriculum (id)
alter table major add department_id int references department (id)
alter table class_module add module_id int references module (id)
alter table lecturer add major_id int references major (id)
alter table teaching add class_module_id int references class_module (id)
alter table teaching add lecturer_id int references lecturer (id)
alter table studying add student_id int references student (id)
alter table studying add class_module_id int references class_module (id)
alter table lesson add classroom_id int references classroom (id)
alter table lesson add teaching_id int references teaching (id)
alter table lesson add class_module_id int references class_module (id)
alter table student add major_id int references major (id)
alter table student add users_id int references users (id)
alter table lecturer add users_id int references users (id)
alter table module_list add major_id int references major (id)



INSERT INTO users VALUES 
       (N'19522015@gm.uit.edu.vn',N'202CB962AC59075B964B07152D234B70',N'DongPhong','Student',1),
	   (N'anv@gm.uit.edu.vn',N'202CB962AC59075B964B07152D234B70',N'a',N'Lecturer',2),
	   (N'bnv@gm.uit.edu.vn',N'202CB962AC59075B964B07152D234B70',N'b',N'Lecturer',3),
	   (N'cnv@gm.uit.edu.vn',N'202CB962AC59075B964B07152D234B70',N'c',N'Lecturer',4),
	   (N'dnv@uit.edu.vn',N'202CB962AC59075B964B07152D234B70',N'manager',N'HeadOfTraining',5),
	   (N'19522519@gm.uit.edu.vn',N'202CB962AC59075B964B07152D234B70',N'19522519',N'Student',1),
	   (N'20521049@gm.uit.edu.vn',N'202CB962AC59075B964B07152D234B70',N'dan',N'Student',1),
	   (N'19522115@gm.uit.edu.vn',N'202CB962AC59075B964B07152D234B70',N'tuan',N'Student',1),
	   (N'20522134@gm.uit.edu.vn',N'202CB962AC59075B964B07152D234B70',N'nghi',N'Student',1),
	(N'env@gm.uit.edu.vn',N'202CB962AC59075B964B07152D234B70',N'se',N'SEDean',1),
	(N'fnv@gm.uit.edu.vn',N'202CB962AC59075B964B07152D234B70',N'cs',N'CSDean',1),
	(N'gnv@gm.uit.edu.vn',N'202CB962AC59075B964B07152D234B70',N'is',N'ISDean',1);

INSERT INTO department VALUES 
	(N'Software Engirneering','0837251993',N'Khu phố 6, Phường Linh Trung, Quận Thủ Đức, Tp. Hồ Chí Minh'),
	(N'Information System','02837252002',N'Khu phố 6, Phường Linh Trung, Quận Thủ Đức, Tp. Hồ Chí Minh'),
	(N'Computer Science','028372538',N'Khu phố 6, Phường Linh Trung, Quận Thủ Đức, Tp. Hồ Chí Minh');

insert into major values
	(N'SE', N'Software Engirneering', 1),
	(N'IS', N'Information System', 2),
	(N'CS', N'Computer Science', 3);

INSERT INTO curriculum VALUES 
      (N'Cử nhân ngành kỹ thuật phần mềm', N'hệ đại học', N'chính quy', 2019, 1),
	  (N'Cử nhân ngành hệ thống thông tin', N'hệ cao đẳng', N'liên thông', 2020, 2);

INSERT INTO module VALUES 
      ('SE104', N'Nhập môn công nghệ phần mềm',3,1,1,1,1),
	  ('SE208', N'Kiểm chứng phần mềm',2,1,1,1,1),
	  ('SE102', N'Nhập môn phát triển game',3,1,1,1,1),
	  ('IS216', N'Lập trình Java',3,1,1,1,2),
	  ('IS252', N'Khai thác dữ liệu',3,1,1,1,2);

INSERT INTO class_module VALUES
        (N'SE104.M11','5/9/2021','31/12/2021',1,2019,1),
		(N'SE104.M13','5/9/2021','31/12/2021',1,2020,1),
		(N'SE208.M11','28/2/2022','30/6/2022',2,2019,2),
		(N'SE208.M12','28/2/2022','30/6/2022',2,2020,2),
        (N'SE216.M11','5/9/2021','31/12/2021',1,2019,1),
		(N'SE216.M13','5/9/2021','31/12/2021',1,2020,1),
		(N'SE252.M11','28/2/2022','30/6/2022',2,2019,2),
		(N'SE252.M12','28/2/2022','30/6/2022',2,2020,2);

INSERT INTO lecturer VALUES 
        (N'Nguyễn Văn A',N'hợp đồng chính thức',N'thạc sĩ',1,2),
		(N'Nguyễn Văn B',N'giảng viên thỉnh giảng',N'thạc sĩ',2,3),
		(N'Nguyễn Văn C',N'Kỹ thuật máy tính',N'thạc sĩ',2,4);

INSERT INTO teaching VALUES
        (1,1),
		(2,2),
		(3,3);

INSERT INTO student VALUES 
       ('19522015',N'Đông Phong',N'Võ','Nam',N'Phù Cát',N'Bình Định',N'Có',N'0909123456',N'123456',N'Không',1,1),
	('19522519',N'Tấn Việt',N'Võ','Nam',N'TPHCM',N'TPHCM',N'Có',N'0909123456',N'123456',N'Không',1,6),
	('20521049',N'Hoài Linh Đan',N'Trần','Nam',N'An Giang',N'An Giang',N'Có',N'0909123456',N'123456',N'Không',1,7),
	   ('19522115',N'Thanh Tuấn',N'Nguyễn','Nam',N'Huế',N'Hà Nội',N'Không',N'0909654321',N'654321',N'Không',2,8),
	   ('20522134',N'Thanh Nghị',N'Lê','Nữ',N'Huế',N'Quảng Nam',N'Không',N'09092468',N'2468',N'Không',2,9);

INSERT INTO studying VALUES
       (7,1,1),
	   (8,1,2),
	   (9,2,1),
	   (9,2,3);

INSERT INTO classroom VALUES
      (N'phòng lý thuyết',45),
	  (N'phòng thực hành',150);

INSERT INTO lesson VALUES
       (N'Thứ 2','','',1,1,1),
	   (N'Thứ 3','','',1,1,1);

insert into module_list values
	(N'SE104', N'Nhập môn công nghệ phần mềm', 1),
	(N'SE100', N'Phương pháp phát triển phần mềm hướng đối tượng', 1),
	(N'SE330', N'Ngôn ngữ lập trình Java', 1),
	(N'SE113', N'Kiểm chứng phần mềm', 1),
	(N'SE106', N'Đặc tả hình thức', 1),
	(N'SE347', N'Công nghệ Web và ứng dụng', 1),
	(N'SE104', N'Nhập môn công nghệ phần mềm', 1),
	(N'SE356', N'Kiến trúc phần mềm', 1),
	(N'SE121', N'Đồ án 1', 1),
	(N'SE122', N'Đồ án 2', 1),

	(N'CS217', N'Các hệ cơ sở tri thức', 3),
	(N'CS315', N'Máy học nâng cao', 3),
	(N'CS106', N'Trí tuệ nhân tạo', 3),
	(N'CS114', N'Máy học', 3, 3),
	(N'CS325', N'Dịch máy', 3, 3),
	(N'CS105', N'Đồ hoạ máy tính', 3),
	(N'CS338', N'Nhận dạng', 3),
	(N'CS312', N'Hệ thống đa tác tử', 3),
	(N'CS313', N'Khai thác dữ liệu và ứng dụng', 3),
	(N'CS221', N'Xử lý ngôn ngữ tự nhiên', 3),

	(N'IS220', N'Xây dựng HTTT trên các framework', 2),
	(N'IS210', N'Hệ quản trị cơ sở dữ liệu', 2),
	(N'IS216', N'Lập trình Java', 2),
	(N'IS336', N'Hoạch định nguồn lực doanh nghiệp', 2),
	(N'IS207', N'Phát triển ứng dụng Web', 2),
	(N'IS211', N'Cơ sở dữ liệu phân tán', 2),
	(N'IS252', N'Khai thác dữ liệu', 2),
	(N'IS217', N'Kho dữ liệu và OLAP', 2),
	(N'IS403', N'Phân tích dữ liệu kinh doanh', 2),
	(N'IS334', N'Thương mại điện tử', 2);