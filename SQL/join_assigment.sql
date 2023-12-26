----------------------------------assignment----------------------------------------
--assignment :
--create a table customer having custid,custname,telno
--create a table orders having orderid,orderdate,custid ,prodname,qty,rate
--then write a query to display records from customer and orders tables using inner join
------------------------------------------------------------------------------------

create table customer (
custid int primary key identity,
custname varchar(45),
telno varchar(10));
select * from customer
insert into customer (custname,telno)
values('manoj','1234567890'),('santosh','1234567890'),('vinod','1234567890'),('binod','1234567890'),('pramod','1234567890'),('sonu','1234567890'),('monu','1234567890'),('tonu','1234567890');

create table orders (
orderid int ,
orderdate date,
custid int,
prodname varchar (45),
qty int,
rate dec(10,2));

select * from orders
insert into orders(orderid, orderdate, custid, prodname,qty,rate)
values(121,'2012-02-02',1,'Cycle',2,200),(232,'2012-02-07',2,'Oil',1,900),(1212,'2012-07-02',3,'Petrol',2,5200),(4571,'2012-09-02',4,'tyre',7,400),(1654,'2012-10-12',5,'ByCycle',5,500),(859,'2013-01-01',6,'tryCycle',4,700)
select*from orders

select customer.custid, customer.custname, customer.telno, orders.orderdate, orders.prodname, orders.qty, orders.rate 
from customer
inner join orders ON customer.custid=orders.custid;





