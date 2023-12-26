use Joins----DB name

select * from orders
select * from customer

alter table customer
add state varchar (20)
alter table customer
add city varchar (20)

update customer
 set state='mah', city ='ngp'
where custid=1

update customer 
set state ='mah', city='mumbai'
where custid=7

update customer set state ='mah', city='mumbai'
where custid=8

alter table customer
alter column custid unique

select * from customer
select custid,custname,state, city, telno from customer where city='ngp'

select * from orders 
select orders.orderid, orders.orderdate, orders.custid ,customer.custid, customer.custname, customer.city 
from orders
inner join customer on orders.custid=customer.custid

----------------------------------subquery------------------

select orderid, custid ,orderdate,prodname, qty,rate
from orders
where custid in 
(select custid from customer where city='ngp')
order by orderdate desc

--let us see one more example of subquery
select * from orders, customer
select orderid, custid, orderdate, city, custname
from orders 
where custid IN (                  --subquery starts here
	select custid 
	from customer
	where city='bilaspur'
	)





-----------------------
assignment
create a table student having columns rno,name,email,city,courseid
insert some records into student table
create a table fees having columns feesid,rno,feesdate,amount,courseid
write a query to display fees details of those student whose city=nagpur
write a query to display fees details of those student whose city=mumbai
write a query to display fees details of those student whose city=delhi
------------------------------------------------------------------
create table students (
	rno int identity primary key,
	stud_name varchar (20),
	email varchar (50),
	city varchar (45),
	courseid int )

	
	insert into students values('huzefa','huzefa@gmail.com','gondia',1),
								('priyanka','priyanka@gmail.com','nagpur',1),
								('prachi','prachi@gmail.com','raipur',2),
								('kitachi','psdhi@gmail.com','raipur',2),
								('pointless','pointless@gmail.com','bilaspur',3),
								('pointfull','pointfull@gmail.com','bilaspur',3)

create table fees (
	feesid int ,
	rno int,
	feesdate date,
	amount decimal(10,2),
	courseid int)

	insert into fees values(121,1,'2022-10-10',12000,1)
	insert into fees values(122,2,'2022-12-01',15000,1)
	insert into fees values(123,3,'2022-11-23',17000,2)
	insert into fees values(124,4,'2022-10-23',18000,2)
	insert into fees values(125,5,'2022-07-3',20000,3)
	insert into fees values(126,6,'2022-03-7',22000,3)
	insert into fees values(127,7,'2023-01-20',16000,1)
	insert into fees values(128,8,'2022-06-23',14000,2)
	
	delete from fees where rno=3 --delete row
	
	select * from fees
	
	select * from students
	select feesid, rno, amount
	from fees 
	where rno IN(
	select rno 
	from students 
	where city='nagpur');

	select feesid, rno, amount, courseid
	from fees
	where rno IN(
	select rno from students where city='bilaspur');
	select*from students

	select feesid, rno,amount, courseid
	from fees
	where rno IN(
	select rno from students where city ='raipur');
	------------------------------------------------


create a table courses having column courseid, coursename,fees , duration
write a query to get student details whose course is java
write a query to get student details whose course is dotnet
write a query to get student details whose course is php
------------------------------------------------------------------------
create table courses (
	courseid int , course_name varchar (20), fees decimal(10,2), duration_in_days int) ;
	select * from courses

insert into courses values(1,'dotnet',4500,45),(2,'java',6000,60),(3,'php',10000,100)
select *from courses
select * from students

select stud_name,email,city,courseid
from students
where courseid IN(
select courseid from courses where courseid=2)


select stud_name,email,city,courseid
from students
where courseid IN(
select courseid from courses where courseid=1)

select stud_name,email,city, courseid
from students where courseid IN(
select courseid from courses where courseid=3)

