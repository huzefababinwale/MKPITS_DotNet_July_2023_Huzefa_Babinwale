create table price_list (product_id int identity(1,1), valid_from Date, price DEC(10,2) Not null constraint ck_positive_price Check(price>=0), discount DEC(10,2) not null, note varchar(255), primary key (product_id, valid_from));
select * from price_list

--to drop the whole table 
Drop table price_list
--to drop specific column with constraint
alter table price_list drop constraint ck_positive_price ;
alter table price_list drop column price

--these is how we enter date 
insert into price_list values(2023-12-13, 100,10,'Good Product')


-------------------------------------------------------------------------------------------

create table students(first_name varchar(20), last_name varchar(20))

insert into students values('Vrushali','Mohite')

select * from students

alter table students drop column mobno 
alter table students add mobno int default(10)

insert into students values('Mayur','Pale',5)
insert into students values('David','kothe',12)
insert into students values ('Remember','ToGo',1212)
insert into students values('Hi','Nice to meet you',1245)

--to add column rollno into table with auto increment
alter table students add rollno int identity(1,1)

--to arrange by roll number descending
select *from students order by rollno desc

--to find by firstname
select * from students where first_name ='Remember'

--to find by lastname
select*from students where last_name='nice to meet you'

--to find by two parameters(--no object will display if one of them is abscent)
select * from students where first_name='Remeber' and last_name='nice to meet you'
--to find by any field we can use where clause

alter table students add city varchar(20)

insert into students values('Ram','krishna',888,'mumbai')

select count(*) from students where rollno<>7
select*from students




