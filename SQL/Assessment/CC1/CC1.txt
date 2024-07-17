--Coding Challenge 1 SQL

--que1.Write a query to display your birthday( day of week)
select '24-04-2002' 'Brithdate',DATENAME(WEEKDAY,'2002-04-24') 'birthday day of week'

--que2.Write a query to display your age in days
select DATEDIFF(DD,'2002-04-24',GETDATE()) 'Age in Days'

--que3.Write a query to display all employees information those who joined before 5 years in the current month
use assign2_Db
select * from EMP
update EMP set hiredate='2022-04-02' where empno=7566

select empno'Employee ID',ename 'Employee Name',hiredate 'Employee Hiredate',
DATEDIFF(YY,hiredate,GETDATE()) 'Joined Years' from EMP 
where DATEDIFF(YY,hiredate,GETDATE()) > 5

--que4.Create table Employee with empno, ename, sal, doj columns and perform the following operations in a single transaction
	--a. First insert 3 rows 
	--b. Update the second row sal with 15% increment  
    --c. Delete first row.
--After completing above all actions how to recall the deleted row without losing increment of second row.
create table Employee(
empno int ,
ename varchar(20),
sal float,
doj date
)

--a.First insert 3 rows 
insert into Employee values (1,'Shashank',30000,'2024-05-30'),
(2,'Jhon',20000,'2023-06-28'),
(3,'Max',35000,'2022-02-20')
select * from Employee

--b.Update the second row sal with 15% increment  
update Employee set sal=sal+(sal*0.15) where empno=2
select * from Employee

begin transaction
--c.Delete first row.
delete Employee where empno=1
select * from Employee

rollback transaction
select * from Employee

--que5.Create a user defined function calculate Bonus for all employees of a  given job using 	following conditions
	--a.     For Deptno 10 employees 15% of sal as bonus.
	--b.     For Deptno 20 employees  20% of sal as bonus
	--c      For Others employees 5%of sal as bonus

create or alter function CalcBonus(@deptno int,@sal float)
returns float
as
begin
declare @bonus float
set @bonus = case
when @deptno=10 then @sal*0.15
when @deptno=20 then @sal*0.2
else @sal*0.05
end
return @bonus
end
select empno'ID',ename'Name',deptno'Department No',sal'Salary',dbo.CalcBonus(deptno,sal) 'Bonus' from EMP