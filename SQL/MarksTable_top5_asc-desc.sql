select *from person

select top 3 gender, age from person order by age desc

create table Marks(rollno int primary key identity(1,1) , first_name varchar (20), last_name varchar(20), marks int, fees bigint not null, attendence int )

drop table Marks
select * from Marks

insert into Marks values('Ramesh','Ramlal',74,1000,74)


insert into Marks values('Abijeet','Klayan',72,10000,78)
insert into Marks values('Ankita','Chouhan',60,1200,79)
insert into Marks values('Babulal','Mattha',85,10000,44)
insert into Marks values('Chirnjiv','Kishor',88,1300,89)
insert into Marks values('Doodhnath','Kot',55,1500,40)
insert into Marks values('Soham','palliwar',90,10000,35)
insert into Marks values('Varsha','Telang',74,1000,74)
insert into Marks values('Talwar','Toplal',74,1000,74)
insert into Marks values('Urwa','shi',74,1000,74)
insert into Marks values('Wanda','Witch',74,1000,74)

--query to find top 5 student who scored maximum marks in exam 
select top 5 marks from Marks order by marks desc

--query to find top 3 student who had paid less fees
select top 3 fees from Marks order by fees asc

--query to find top 5 students who has highest attendance percentage
select top 5 first_name, last_name, attendence from Marks order by attendence asc

select top 50 percent attendence from Marks order by first_name desc

select distinct first_name from Marks order by first_name asc


select first_name, last_name from Marks order by last_name, first_name







select * from Marks
