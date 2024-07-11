--Assignment 1
create database assign1_spsoftwaresdb
use assign1_spsoftwaresdb

--client table creation
create table Clients (
    Client_ID int primary key,
    Cname varchar(40) not null,
    Address varchar(30),
    Email varchar(30) unique,
    Phone bigint,
    Business varchar(20) not null check(Business in ('Manufacturer','Reseller','Consultant','Professional')) 
);

--department table creation
create table Departments (
    Deptno int primary key,
    Dname varchar(15) not null,
    Loc varchar(20)
);

--employee table creation
create table Employees (
    Empno int primary key,
    Ename varchar(20) not null,
    Job varchar(15),
    Salary decimal(7, 2) constraint chk_sal check (salary > 0),
    Deptno int, foreign key (deptno) references departments(deptno)
);

--projects table creation
create table Projects (
    Project_id int primary key,
    Descr varchar(30) not null,
    Start_date_ date,
    Planned_end_date date,
    Actual_end_date date,
    Budget bigint constraint chk_budget check (budget > 0),
    Client_id int, foreign key (client_id) references clients(client_id)
);

--EmpProjectTasks table creation
create table EmpProjectTasks (
    Project_id int,
    Empno int,
    Start_date_ date,
    End_date date,
    Task varchar(25) not null,
    Status_ varchar(15) not null check (status_ in ('In Progress', 'Completed', 'Cancelled')),
    primary key (project_id, empno),
    foreign key (project_id) references projects(project_id),
    foreign key (empno) references employees(empno)
);

--insertion into clients table
insert into clients (client_id, cname, address, email, phone, business)
values (1001, 'ACME Utilities', 'Noida', 'contact@acmeutil.com', 9567880032, 'Manufacturer'),
(1002, 'Trackon Consultants', 'Mumbai', 'consult@trackon.com', 8734210090, 'Consultant'),
(1003, 'MoneySaver Distributors', 'Kolkata', 'save@moneysaver.com', 7799886555, 'Reseller'),
(1004, 'Lawful Corp', 'Chennai', 'justice@lawful.com', 9210342219, 'Professional');

--display client data
select * from Clients

--insertation into departments table
insert into Departments (Deptno, Dname, Loc)
values(10, 'Design', 'Pune'),
(20, 'Development', 'Pune'),
(30, 'Testing', 'Mumbai'),
(40, 'Document', 'Mumbai');

--display departments data
select * from Departments

--insertaion into employees table
insert into Employees (Empno,Ename, Job, Salary, Deptno)
values (7001,'Sandeep', 'Analyst', 25000, 10),
(7002,'Rajesh', 'Designer', 30000, 10),
(7003,'Madhav', 'Developer', 40000, 20),
(7004,'Manoj', 'Developer', 40000, 20),
(7005,'Abhay', 'Designer', 35000, 10),
(7006,'Uma', 'Tester', 30000, 30),
(7007,'Gita', 'Tech. Writer', 30000, 40),
(7008,'Priya', 'Tester', 35000, 30),
(7009,'Nutan', 'Developer', 45000, 20),
(7010,'Smita', 'Analyst', 20000, 10),
(7011,'Anand', 'Project Mgr', 65000, 10);

--display employees table
select * from Employees

--insertaion into projects table
insert into Projects (Project_id, Descr, Start_date_, Planned_End_Date, Actual_End_date, Budget, Client_ID)
values ('401', 'Inventory', '2011-04-01', '2011-10-01', '2011-10-31', 150000, 1001),
('402', 'Accounting', '2011-08-01', '2012-01-01', NULL, 500000, 1002),
('403', 'Payroll', '2011-10-01', '2011-12-31', NULL, 75000, 1003),
('404', 'Contact Mgmt', '2011-11-01', '2011-12-31', NULL, 50000, 1004);

--display projects table
select * from Projects

--insertaion into empprojecttasks table
insert into EmpProjectTasks (Project_id, Empno, Start_date_, End_Date, Task, Status_)
values (401, 7001, '2011-04-01', '2011-04-20', 'System Analysis', 'Completed'),
(401, 7002, '2011-04-21', '2011-05-30', 'System Design', 'Completed'),
(401, 7003, '2011-06-01', '2011-07-15', 'Coding', 'Completed'),
(401, 7004, '2011-07-18', '2011-09-01', 'Coding', 'Completed'),
(401, 7006, '2011-09-03', '2011-09-15', 'Testing', 'Completed'),
(401, 7009, '2011-09-18', '2011-10-05', 'Code Change', 'Completed'),
(401, 7008, '2011-10-06', '2011-10-16', 'Testing', 'Completed'),
(401, 7007, '2011-10-06', '2011-10-22', 'Documentation', 'Completed'),
(401, 7011, '2011-10-22', '2011-10-31', 'Sign off', 'Completed'),
(402, 7010, '2011-08-01', '2011-08-20', 'System Analysis', 'Completed'),
(402, 7002, '2011-08-22', '2011-09-30', 'System Design', 'Completed'),
(402, 7004, '2011-10-01', NULL, 'Coding', 'In Progress');

--display empprojecttasks table
select * from EmpProjectTasks

