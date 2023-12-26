use functions --DB name

create table Employee(
EmpId int primary key identity,
EmpName varchar(20),
EmpContact varchar(10),
EmpEmail varchar(50),
EmpDepartnment varchar (20),
EmpCity varchar (30),
Salary int)

insert into Employee values('Rakesh','1234567890','Email@gmail.com','computer','ahmedabad',20000),
('karan','123654987','kk@gmail.com','account','mumbai',19000),
('Keval','940557886','keval@gmail.com','managment', 'mumbai',17000),
('Rina','879654123','Rina@gmail.com','account','ahmedabad',25000),
('Rahul','986547123','rahul@gmail.com','account','vishakhapatnam',15000),
('Rohan','123654789','rohan@gmail.com','computer','vishakhapatnam',10000),
('ketan','753196428','ketan@gmail.com','computer','mumbai',16000),
('aman','963258741','aman@gmail.com','managment','ahmedabad',23000)

select * from Employee

---------------------Function without Parameter------------------------
create function f1()
returns table as return(select * from Employee)

-------------------------With Parametres-------------------------------
drop function Emptable
create function Emptable(
@EmpName nchar(20),
@EmpContact varchar(40),
@EmpDepartnment varchar(30)
)
returns varchar (100)
as 
begin return (select @EmpName +' '+@EmpContact+' '+@EmpDepartnment)
end

select dbo.Emptable(EmpName,EmpContact,EmpDepartnment) as 'details' from Employee

---------------------------------------------------------------------------------------------------

create table stud1(rno int,m1 int,m2 int,m3 int)
	insert into stud1 values(1,88,87,89),(2,77,76,78)
	insert into stud1 values(3,11,11,11)
	select * from stud1

	create function total( @m1 int, @m2 int , @m3 int)
	returns int as begin 
	return (select @m1 + @m2+ @m3)
	end

	select dbo.total(m1, m2, m3) as 'Total Marks' from stud1

	create function Percentage(@m1 int, @m2 int, @m3 int)
	returns int as begin 
	return (select (@m1 + @m2 + @m3)*0.3)
	end

	select dbo.Percentage(m1, m2, m3) as 'Percentage' from stud1










