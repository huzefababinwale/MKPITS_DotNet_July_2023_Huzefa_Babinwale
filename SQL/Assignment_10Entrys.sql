use mkpits1;

create table student(rollno int primary key identity(1,1),name varchar(20),address varchar(20),mobno bigint );

insert into student values('Anshul','Nagpur',9834146770)

delete from student where rollno=2;

insert into student values('Aman','Goregaon',5552223641)
insert into student values('Ahira','Ahmedabad',0001110002)

insert into student values ('Bablu','Bulbulapur',456987412)
insert into student values ('Chandu','Chandra Yaan',200012351)
insert into student values ('Daddu','Dharmpur',456987123)
insert into student values ('Empty','Egatpuri',785469321)
insert into student values ('Farukh','Fakirpur',965823147)
insert into student values ('gopaal','gondia',582369741)
insert into student values ('Huzefa','Home', 441601) 

select * from student;

create table customers (custid int primary key identity(1,2), custname varchar(20),custaddress varchar(101)) 
insert into customers values ('Abijeet','Amar Villa, Godhani, Nagpur, 440001')

insert into customers values('Rakhi','Near Rakhi park, Rakh maidan, Rakhpur, 999999')
insert into customers values('Sonu','Near Hospital, Hamza square, Hamaspur, 545687')
insert into customers values('Priya','Behind Nexa, Nagpur, 45695')
insert into customers values('Supriya', 'Front of Mgzine Page, TimeIndia, 45236')

insert into customers values('Simon','Go Back, to NewYork')
insert into customers values('Solaman','King of Valley, Historical Site, 4585, Misr, Egypt')
insert into customers values('Situ Mama', 'Beside the Door, Godhani')
insert into customers values('Jakir Hussain', 'Hinganghat me Famous 911')
insert into customers values('Jumbo','I dont know where to keep it <3')

select * from customers;



create table users(userid int primary key identity(0,2), username varchar(20),password1 varchar(10), emailid varchar(30), gender varchar(6), cit varchar(20), counutry varchar(20) )
select * from users
insert into users values ('Govinda','GoGo123','Govinda@gmail.com','Male','Gondia','Georgea')


insert into users values ('Humayu','HuHu123','HumayuHu@gmail.com','Male','Husanpur','Hastinnapur')
insert into users values ('Gauri','Gauri123','Gaurinda@gmail.com','Male','Gumgaon','India')
insert into users values ('Shati','ShantaBai','Sakittnada@gmail.com','Female','Gossel','America')
insert into users values ('Sahias','Sahias123','Sahilyscanner@gmail.com','FeMale','Sahillly','San Frensisco')
insert into users values ('Amlaid ','AmAm123','Amalai@gmail.com','Female','Amlapur','Allahuddingy')
insert into users values ('Guarav','Gaurav123','Gaurav@gmail.com','FeMale','Gauravpur','Georgea')
insert into users values ('Ghumakkd','Ghumakkd3','Ghumne@gmail.com','Male','Bali','indonesssia')
insert into users values ('Mahima','Mahima123','Mahitama@gmail.com','FeMale','Masmta','Masmta')
insert into users values ('Govinda','Go123','Govda@gmail.com','Male','Gondia','Georgea')


select * from users
