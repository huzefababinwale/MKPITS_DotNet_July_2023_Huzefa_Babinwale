select * from salesmen

drop table salesmen
create table salesmen (salesmen_id int identity(5001,1),names varchar(30),city varchar(30), commision float)

insert into salesmen values('James Hoog', 'New York ',0.15)
insert into salesmen values ('Nail Knite ','Paris',0.13)
insert into salesmen values ('Lauson Hen','San Jose',0.12)
insert into salesmen values ('isko Delete','Krna h',1)
insert into salesmen values ('Pit Alex','London',0.11)
insert into salesmen values('Mc Lyon','Paris',0.14)
insert into salesmen values('Paul Adam','Rome',0.13)

select names,commision from salesmen order by names desc
delete from salesmen where commision=1

--alter table salesmen drop constraint ord_no 



create table orders (ord_no int, purch_amt float, ord_date date,customer_id int, salesman_id int)
select * from orders

select
insert into orders values (7001, 150.0, '2012-10-5',3005,5002)
insert into orders values (7009, 270.65, '2012-09-10',3001,5005)
insert into orders values (7002, 65.26, '2012-10-5',3002,5001)
insert into orders values (7004, 110.5, '2012-08-17',3009,5003)
insert into orders values (7007, 948.5, '2012-09-10',3005,5002)
insert into orders values (7005, 2400.6, '2012-07-27',3007,5001)
insert into orders values (7008, 5760.0, '2012-09-10',3002,5001)
select * from orders
select ord_no from orders order by ord_no desc
