create database assign2_Db
use assign2_Db

--EMP Table Creation
create table EMP (
    empno int primary key,
    ename varchar(50) not null,
    job varchar(50),
    mgr_id int,
    hiredate date,
    sal float,
    comm float,
    deptno int
);

--Insertion in to EMP table 
insert into EMP(empno, ename, job, mgr_id, hiredate, sal, comm, deptno) values (7369, 'SMITH', 'CLERK', 7902, '1980-12-17', 800, null, 20),
(7499, 'ALLEN', 'SALESMAN', 7698, '1981-02-20', 1600, 300, 30),
(7521, 'WARD', 'SALESMAN', 7698, '1981-02-22', 1250, 500, 30),
(7566, 'JONES', 'MANAGER', 7839, '1981-04-02', 2975, null, 20),
(7654, 'MARTIN', 'SALESMAN', 7698, '1981-09-28', 1250, 1400, 30),
(7698, 'BLAKE', 'MANAGER', 7839, '1981-05-01', 2850, null, 30),
(7782, 'CLARK', 'MANAGER', 7839, '1981-06-09', 2450, null, 10),
(7788, 'SCOTT', 'ANALYST', 7566, '1987-04-19', 3000, null, 20),
(7839, 'KING', 'PRESIDENT', null, '1981-11-17', 5000, null, 10),
(7844, 'TURNER', 'SALESMAN', 7698, '1981-09-08', 1500, 0, 30),
(7876, 'ADAMS', 'CLERK', 7788, '1987-05-23', 1100, null, 20),
(7900, 'JAMES', 'CLERK', 7698, '1981-12-03', 950, null, 30),
(7902, 'FORD', 'ANALYST', 7566, '1981-12-03', 3000, null, 20),
(7934, 'MILLER', 'CLERK', 7782, '1982-01-23', 1300, null, 10)

--display emp table
select * from EMP

--DEPT table creation 
create table DEPT(
deptno int primary key, 
dname varchar(20) not null, 
loc varchar(20) not null
);

--insertion into DEPT table
insert into DEPT(deptno,dname,loc) values (10, 'ACCOUNTING', 'NEW YORK'),
(20, 'RESEARCH', 'DALLAS'),
(30, 'SALES', 'CHICAGO'),
(40, 'OPERATIONS', 'BOSTON')

--display DEPT table
select * from DEPT

--que1.List all employees whose name begins with 'A'. 
select * from EMP where ename like 'A%'

--que2.Select all those employees who don't have a manager.
select * from EMP where mgr_id IS NUll

--que3.List employee name, number and salary for those employees who earn in the range 1200 to 1400.
select empno'Employee Number',ename'Employee Name',sal'Salary' from EMP where sal between 1200 and 1400

--que4.Give all the employees in the RESEARCH department a 10% pay rise. Verify that this has been done by listing all their details before and after the rise. 
select empno'Employee Number',ename'Employee Name',sal'Salary Before Raise',e.deptno'Department Number',d.dname'Department Name' 
from emp e
join dept d on e.deptno = d.deptno
where d.dname='RESEARCH'

update EMP set sal=sal+(sal*0.1) where deptno = (SELECT deptno FROM dept WHERE dname = 'RESEARCH')

select empno'Employee Number',ename'Employee Name',sal'Salary After Raise',e.deptno'Department Number',d.dname'Department Name' 
from emp e
join dept d on e.deptno = d.deptno
where d.dname='RESEARCH'

--que5.Find the number of CLERKS employed. Give it a descriptive heading. 
select count(empno)'Number Of Clerk Employed' from EMP where job='CLERK'

--que6.Find the average salary for each job type and the number of people employed in each job. 
select job,AVG(sal)'Average Salay Of Job Group',COUNT(empno)'Number of employess in the job group' 
from EMP group by job

--que7.List the employees with the lowest and highest salary. 
select * from EMP where sal = (select max(sal) from EMP) or sal=(select min(sal) from EMP)

--que8.List full details of departments that don't have any employees. 
select d.* from DEPT d 
left join EMP e on d.deptno=e.deptno
where e.empno is null

--que9.Get the names and salaries of all the analysts earning more than 1200 who are based in department 20. Sort the answer by ascending order of name. 
select ename 'Employee Name',sal 'Salary' from EMP where job='ANALYST' and sal > 1200 and deptno=20
order by ename asc

--que10.For each department, list its name and number together with the total salary paid to employees in that department. 
select d.deptno,d.dname,sum(e.sal) 'Total Salaries paid the department' from DEPT d 
left join EMP e on d.deptno=e.deptno
group by d.deptno,d.dname

--que11.Find out salary of both MILLER and SMITH.
select ename 'Employee Name',sal 'Salary' from EMP
where ename in('MILLER','SMITH')

--que12.Find out the names of the employees whose name begin with ‘A’ or ‘M’. 
select ename 'Employees whose name starts with "A" or "M"' from EMP
where ename like 'A%' or ename like 'M%'

--que13.Compute yearly salary of SMITH. 
select ename 'Employee Name', sal*12 'Yearly Salary' from EMP where ename = 'SMITH'

--que14.List the name and salary for all employees whose salary is not in the range of 1500 and 2850. 
select ename'Employee Name',sal'Salary' from EMP where sal not between 1200 and 1400

--que15.Find all managers who have more than 2 employees reporting to them
select m.ename 'Manager Name', COUNT(e.empno) 'Number of Employees Reporting'
FROM emp e inner join EMP m on e.mgr_id=m.empno
group by m.ename
having COUNT(e.empno)>2