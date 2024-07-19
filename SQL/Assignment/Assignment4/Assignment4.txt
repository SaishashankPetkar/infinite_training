--Assignment 4
--que1.Write a T-SQL Program to find the factorial of a given number.
declare @num int = 6,@fact int = 1,@temp int
set @temp = @num
while @temp>0
 begin
  set @fact=@fact*@temp
  set @temp=@temp-1
 end

print 'The factroial of '+cast(@num as varchar(4))+' is : '+cast(@fact as varchar(4))

--que2.Create a stored procedure to generate multiplication table that accepts a number and generates up to a given number. 
create or alter proc Multiplication_Table(@num int)
as
begin
 declare @tbl_upto_num int = 10,@counter int=1
 print 'The multiplication table of '+cast(@num as varchar(4))+' is :'
 while(@counter<=@tbl_upto_num)
 begin
  print cast(@num as varchar(4))+' X '+cast(@counter as varchar(4))+' = '+cast(@num*@counter as varchar(4))
  set @counter=@counter+1
 end
end
Multiplication_Table 7

--que3.Create a trigger to restrict data manipulation on EMP table during General holidays. 
--Display the error message like “Due to Independence day you cannot manipulate data” or "Due To Diwali", 
--you cannot manipulate" etc

--Note: Create holiday table as (holiday_date,Holiday_name) store at least 4 holiday details. 
--try to match and stop manipulation 
create table holiday (
    holiday_date date primary key,
    holiday_name varchar(50) not null
)

insert into holiday values ('2024-08-15', 'Independence Day'),
('2024-10-27', 'Diwali'),
('2024-12-25', 'Christmas'),
('2025-01-01', 'New Year')

select * from holiday

create or alter trigger Restrict_data_manipulation
on EMP
for insert,update,delete
as
begin
 declare @holiday int
 set @holiday= (select COUNT(*) from holiday where holiday_date = '2024-08-15')
 if @holiday>0
 begin
  declare @Holidayname varchar(50);
   set @Holidayname = (select holiday_name from holiday where holiday_date = '2024-08-15')
   print('Due to '+cast(@Holidayname as varchar(20))+' you cannot manipulate data')
   rollback transaction
 end
end

update EMP set sal = 3272 where empno = 7566