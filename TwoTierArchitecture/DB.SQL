Create Database SoftwareArchitectureCourse
go

Use SoftwareArchitectureCourse
go

Create Table Users
(
	UserId int Primary Key identity(1,1),
	UserFullName nvarchar(200) not null,
	Username nvarchar(50) not null,
	Password nvarchar(50) not null
)
go

Create Table Employees
(
	EmployeeId int Primary Key identity(1,1),
	EmployeeFullName nvarchar(200) not null
)
go