--database creation
create database Employeemanagement
use Employeemanagement

--table creation
create table Employee_Details (Empno int Primary Key,
EmpName varchar(50) not null,
Empsal float check (empsal >=25000),
Emptype char(1) check (emptype in ('F','P'))
)

--procedure creation
create or alter procedure AddrowstoEmpDetailstbl(@empname varchar(50),@empsal float,@emptype char(1))
as
begin
 declare @genratedempno int
 select @genratedempno = case when max(Empno) is null then 0
 else max(Empno) 
 end from Employee_Details
 set @genratedempno=@genratedempno+1

 insert into Employee_Details values (@genratedempno,@empname,@empsal,@emptype)

 select @genratedempno 'Generated Employee Number'
 select * from Employee_Details
end

AddrowstoEmpDetailstbl 'Sai',30000,'F'
