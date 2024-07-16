--Assignment 3
use assign2_Db
--que1.Retrieve a list of MANAGERS. 
select * from EMP where job='MANAGER'

--que2.Find out the names and salaries of all employees earning more than 1000 per month.
select ename 'Employee Name',sal 'Salary' from EMP where sal>1000