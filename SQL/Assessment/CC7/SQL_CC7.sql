use DummyDB
create table books (
id int primary key,
title varchar(50),
author varchar(30),
isbn varchar(15) unique,
published_date datetime
)

insert into books(id,title,author,isbn,published_date)values
(1,'My First SQL book','Mary Parker','981483029127','2012-02-22 12:08:17'),
(2,'My Second SQL book','John Mayer','857300923713','1972-07-03 09:22:45'),
(3,'My Third SQL book','Cary Flint','523120967812','2015-10-18 14:05:44')

--que1.Write a query to fetch the details of the books written by author whose name ends with er.
select * from books where author like '%er'

create table reviews (
id int primary key,
book_id int references books(id),
reviewer_name varchar(30),
content varchar(50),
rating int,
published_date datetime
)

insert into reviews(id, book_id, reviewer_name, content, rating, published_date)values
(1,1,'John Smith','My first review',4,'2017-12-10 05:50:11.1'),
(2,2,'John Smith','My second review',5,'2017-10-13 15:05:12.6'),
(3,2,'Alice Walker','Another review',1,'2017-10-22 23:47:10')

--que2.Display the Title ,Author and ReviewerName for all the books from the above table
select books.title'Title',books.author'Author',reviews.reviewer_name'ReviewerName' 
from books full outer join reviews on reviews.book_id=books.id

--que3.Display the reviewer name who reviewed more than one book.
select reviewer_name'ReviewerName' from reviews
group by reviewer_name having COUNT(*)>1

create table customers (
ID int primary key,
NAME varchar(20),
AGE int,
ADDRESS varchar(20),
salary float
)

insert into customers values (1,'Ramesh',32,'Ahmedabad',2000.00),
(2,'Khilan',25,'Delhi',1500.00),
(3,'kaushik',23,'Kota',2000.00),
(4,'Chaitali',25,'Mumbai',6500.00),
(5,'Hardik',27,'Bhopal',8500.00),
(6, 'Komal', 22,'MP', 4500.00),
(7, 'Muffy', 24, 'Indore', 10000.00)  

--que4.Display the Name for the customer from above customer table who live in same address which has character o anywhere 
--in address
select * from customers where ADDRESS like ('%o%')

create table orders (
OID int primary key,
DATE datetime,
CUSTOMER_ID int references customers(ID),
AMOUNT float
)

insert into orders values (102,'2009-10-08 00:00:00',3,3000),
(100,'2009-10-08 00:00:00',3,1500),
(101,'2009-11-20 00:00:00',2,1560),
(103,'2008-05-20 00:00:00',4,2060)

--que5.Write a query to display the Date,Total no of customer placed order on same Date.
select DATE,COUNT(CUSTOMER_ID)'Total no of customer placed order' from orders group by DATE

create table employee (
ID int primary key,
NAME varchar(20),
AGE int,
ADDRESS varchar(20),
SALARY float
)

insert into employee values (1,'Ramesh',32,'Ahmedabad',2000.00),
(2,'Khilan',25,'Delhi',1500.00),
(3,'kaushik',23,'Kota',2000.00),
(4,'Chaitali',25,'Mumbai',6500.00),
(5,'Hardik',27,'Bhopal',8500.00),
(6,'Komal',22,'MP',NULL),
(7,'Muffy',24,'Indore',NULL)  

--que6. Display the Names of the Employee in lower case, whose salary is null
select LOWER(NAME)'Employee Name' from employee where SALARY is null

create table Studentdetails (
    RegisterNo int primary key,
    Name varchar(50),
    Age int,
    Qualification varchar(50),
    MobileNo varchar(15),
    Mail_id varchar(50),
    Location varchar(50),
    Gender CHAR(1)
)

insert into Studentdetails values (2, 'Sai', 22, 'B.E', 9952836777, 'Sai@gmail.com', 'Chennai', 'M'),
(3, 'Kumar', 20, 'BSC', 7890125648, 'Kumar@gmail.com', 'Madurai', 'M'),
(4, 'Selvi', 22, 'B.Tech', 8904567342, 'selvi@gmail.com', 'Selam', 'F'),
(5, 'Nisha', 25, 'M.E', 7834672310, 'Nisha@gmail.com', 'Theni', 'F'),
(6, 'SaiSaran', 21, 'B.A', 7890345678, 'saran@gmail.com', 'Madurai', 'F'),
(7, 'Tom', 23, 'BCA', 8901234675, 'Tom@gmail.com', 'Pune', 'M')

--que7.Write a sql server query to display the Gender,Total no of male and female from the above relation
select Gender,COUNT(Gender)'Total Count' from Studentdetails group by Gender

