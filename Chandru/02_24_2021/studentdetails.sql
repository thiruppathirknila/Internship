Create Database StudentDetails

Use StudentDetails

Create table tblstudent
(
RoleNo int identity(1,1) primary key,
Std_Name varchar(40),
std_Class varchar(40),
std_Section varchar(40))

select * from tblstudent 

alter table tblstudent add IsActive bit

alter table tblstudent drop column Active

Create table tblMark
(
Id int identity(1,1) Primary key ,
Mark1 int,
Mark2 int,
Mark3 int,
Mark4 int,
Mark5 int,
Total int ,
StdId int
)


select * from tblstudent inner join tblMark on tblstudent.RoleNo=tblMark.id

delete from tblstudent  where RoleNo=22


select * from tblMark
~																																																																																																																																															

delete from  


SELECT SUM(Total) from tblstudent;


select * from tblMark where Total=(select max(Total) from tblMark)


SELECT * FROM tblMark t
join tblstudent s on (s.RoleNo=t.StdId)
 ORDER BY Total desc



delete from tblstudent


select *  from tblMark


select mark1,mark2,mark3,mark4,mark5,Total,
 RANK() OVER (ORDER BY Total DESC) AS DenseRank from tblMark

 
Create table tblStudentDetails 
(
studentId int identity(1,1)  primary key ,
FirstName varchar(20),
LastName varchar(20),
FatherName varchar(20),
Gender varchar(20),
DateOfBirth varchar(20),
MobNo varchar(50),
Email varchar(50),
Password varchar(50),
Country varchar(20),
State varchar(20),
City varchar(20))


alter table tblStudentDetails add Active bit
alter table tblStudentDetails Drop column Active

select * from tblStudentDetails



select * from tblStudentDetails
select * from tblstudent
select * from tblMark


select * from tblMark
select * from tblStudentDetails
select * from tblstudent

