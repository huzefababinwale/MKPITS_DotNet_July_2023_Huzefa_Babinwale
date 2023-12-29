ues joins----------DB name 

create table studentnormalize (
rollno int ,
name varchar(20),
class varchar(20),
section varchar (1),
mobile varchar(10),
primary key (mobile, rollno));
select * from student

insert into student values(1,'amit','dotnet','i','1234567890'),(1,'amit','dotnet','i','1234567891')
select * from studentnormalize
drop table studentnormalize

