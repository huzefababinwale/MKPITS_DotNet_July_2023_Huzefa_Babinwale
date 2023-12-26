use Joins--DBMS name 

create table student (
id int primary key identity ,
admission_no varchar (45) not null,
first_name varchar(45) not null,
last_name varchar (45) not null,
age int ,
city varchar(25) not null);

 select * from student
 select * from fee 
create table fee(
admission_no varchar (45) not null,
course varchar (45) not null,
amount_paid int);


INSERT INTO Student (admission_no, first_name, last_name, age, city)       
    VALUES (3354,'Luisa', 'Evans', 13, 'Texas'),       
    (2135, 'Paul', 'Ward', 15, 'Alaska'),       
    (4321, 'Peter', 'Bennett', 14, 'California'),    
    (4213,'Carlos', 'Patterson', 17, 'New York'),       
    (5112, 'Rose', 'Huges', 16, 'Florida'),  
    (6113, 'Marielia', 'Simmons', 15, 'Arizona'),    
    (7555,'Antonio', 'Butler', 14, 'New York'),       
    (8345, 'Diego', 'Cox', 13, 'California');  
      
      
    INSERT INTO Fee (admission_no, course, amount_paid)       
    VALUES (3354,'Java', 20000),       
    (7555, 'Android', 22000),       
    (4321, 'Python', 18000),    
    (8345,'SQL', 15000),       
    (5112, 'Machine Learning', 30000);  

	--------------------------------INNER JOIN------------------------------------------

	select student.id , student.first_name, student.last_name,fee.admission_no, fee.course, fee.amount_paid
	from student 
	inner join fee
	on student.admission_no = fee.admission_no
	
	
	--------------------------------OUTER JOIN-------------------------------------------
	select student.id, student.first_name, student.last_name, fee.admission_no, fee.course, fee.amount_paid
	from student 
	left outer join fee 
	on student.admission_no=fee.admission_no

	select student.id, student.first_name, student.last_name, fee.admission_no, fee.course, fee.amount_paid
	from student 
	right outer join fee 
	on student.admission_no=fee.admission_no

	select student.id, student.first_name, student.last_name, fee.admission_no, fee.course, fee.amount_paid
	from student 
	full outer join fee 
	on student.admission_no=fee.admission_no

	-------------------------------------CROSS JOIN-----------------------------------------------
	select student.admission_no, student.first_name, student.last_name, student.id, fee.course, fee.amount_paid
	from student
	cross join fee
	--------------------------------------SELF JOIN----------------------------------------------

	create table mmstudent (
	id int primary key identity,
	first_name varchar (10), 
	last_name varchar (20),
	city varchar (20));

	insert into mmstudent values 
	('sahil', 'sharm','nagpur'), ('ravi','kumar','nagpur'),('manoj','kumar','mumbai'),
     ('dinesh','sharma','mumbai'),('kishore','kumar','delhi')
	 select * from mmstudent

	select s1.first_name, s2.last_name, s2.city 
	from mmstudent s1, mmstudent s2
	where s1.id <> s2.id and s1.city=s2.city
	order by s2.city

	-------------------------------------------------------------------------------------------

	create table customer2 (custid int identity, 
	custname varchar (45), 
	state varchar (30),
	city varchar(30));
	insert into customer2 
	values ('amit','mah','nagpur'),('sumit','mah','solapur'),('amit','mah','solapur'),('changesh','mp','bilaspur'),('mangesh','mp','bilaspur');
	select * from customer2
	select c1.custid, c1.custname,  c1.city, c2.state
	from customer2 c1, customer2 c2
	where c1.custid<>c2.custid and c1.city = c2.city
	order by city

