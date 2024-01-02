use studentconnection--DBName


create table student(
userid numeric(18,0) not null identity(1,1),
username varchar(20),
password varchar(20))

insert into student values('Palash','123456789'),('likhesh','987654321')
select * from student


