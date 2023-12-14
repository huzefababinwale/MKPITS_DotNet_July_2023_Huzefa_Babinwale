create table person(person_id int primary key identity(1,1),first_name varchar(20), last_namen varchar(20),gender char(1))

select * from person;

insert into person values('Mohan','Bhardwaj','M')
insert into person values ('Sohan','Baramate','M')
insert into person values('Rohan','Kokate','M')
insert into person values ('Sakshi','Gajgate','F')
insert into person values('Roshni','Fulbandhe','F')
insert into person values ('Deepika','Mohan','F')
insert into person values('Rakshika','Pyarelal','F')


Alter table person add age int not null default (10);

alter table person alter column gender varchar(2) 
insert into person values('Gomti','Gwaliyar','Fe',22)

delete from person where gender='Fe'
alter table person alter column gender varchar(1)

alter table person drop column last_namen;
alter table person drop constraint age ;
alter table person drop column age

