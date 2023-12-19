use keys --dbms

create table productS(
prodect_id int identity primary key ,
product_name varchar(20) not null,
unit_price Dec (10,3) check (unit_price>0));

select * from productS

insert into productS values
('mouse',1),('keyboard',4)
insert into productS values('pendrive',-1)

alter table productS
alter column unit_price Dec(10,2) 

---to test 0 value after drop constraint 
insert into productS values
('Light',0)

---to drop table check statement from table
alter table productS
drop constraint CK__productS__unit_p__6FE99F9F ;

--revoke constraint
alter table productS
add constraint CK_product check (unit_price>0)
--to xecute above command i have to remove 0 from existing table so that i can move on
update productS 
set product_name='Tube Light', unit_price=10 where prodect_id=8;

--let us try to insert once so we get sure about updatation succesfully
insert into productS values
('fan',100)
select*from productS

---------------------------------------------------------------------------------

--let us create 2nd table for multiple constraints and check values

create table productP
(prodect_id int primary key ,
unit_price int constraint Cons_unit_price check (unit_price>0),
dis_price int constraint Cons_dis_price check (dis_price>0),
check (dis_price <unit_price));
select * from productP
insert into productP values(1,1100,400)
insert into productP values(2,200,100)

create table ProductR
(prodect_id int primary key,
product_name varchar(20) not null,
unit_price dec(10,2),
dis_price dec(10,2),

check (unit_price>0),
check (dis_price<unit_price));
select*from productR

insert into productR values
(1,'',78,70)

insert into productR values
(2,'',77,74)

drop table productR

--------------to get help---------------------
sp_help productS     --or sp_help table name
----------------------------------------------
create table persons(
person_id int primary key identity,
first_name varchar (20),
last_name varchar (20),
email varchar(50) unique);

select * from persons

insert into persons values 
('rohan','soham','b@gmail.com')

insert into persons values 
('gati','hamehame','b@gmail.com')
select*from persons

insert into persons(first_name, last_name, email)
values ('joe','Bidon','joe.biden@gmail.com')

insert into hr.persons (first_name, last_name, email)
values ('jwwe','Bidon','jwwwe.biden@gmail.com')

