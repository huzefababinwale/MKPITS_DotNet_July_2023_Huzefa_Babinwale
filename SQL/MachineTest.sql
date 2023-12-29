use PracticeDB-------------------------------Machine Test Fendahl

select * from TableNation
select * from TableState
select * from TableCity
select * from TableCourseRegDetail
select * from TableRegAddress
select *from TableFeeDetail
------------------------------References data Table----------------------------------
create table TableNation(
NationID int primary key,
NationName varchar(500))

create table TableState(
stateID int primary key,
NationID int foreign key references TableNation(NationID),
StateName varchar(500))

create table TableCity(
CityID int primary key,
StateID int foreign key references TableState(stateID),
CityName varchar(500))

-------------------------------------------Tables-------------------------------------

create table TableCourseRegDetail(
CourseRegID int primary key,
CategoryInd int not null,
FullName varchar (1500) not null,
GenderInd int not null) 

create table TableRegAddress (
RegAddresslD int primary key,
CourseRegID int foreign key references TableCourseRegDetail(CourseRegID) not null,
NationID int foreign key references TableNation(NationID) not null,
StateID int foreign key references TableState(stateID) not null,
CityID int foreign key references TableCity(CityID)not null)

create table TableFeeDetail(
FeeID int primary key,
CourseRegID  int foreign key references TableCourseRegDetail(CourseRegID),
TotalAmount decimal not null,
MinPer decimal not null,
PaidAmount decimal not null,
BalAmount decimal not null,
PaidDate dateTime not null)

-----------------------------------Insertion values-----------------------

select * from TableNation
select * from TableState
select * from TableCity
select * from TableCourseRegDetail
select * from TableRegAddress
select *from TableFeeDetail


insert into  TableNation values(1, 'France'),(2,'India'),(3,'Russia'),(4,'Poland')
insert into TableState values(556,4,'Postate'),(582,3,'Rustate'),(111,2,'India State'),(414,1,'France State')
insert into TableCity values(100,2,'Mumbai'),(200,3,'Mosco'),(300,4,'Santana'),(4,1,'Sanfranscisco')
insert into TableCourseRegDetail values(101,2,'Rahul Yadav',1),(102,2,'Kunal Patil',1),(103,3,'Pankaj Tripathi',1),(104,3,'Prajakta ',2)
insert into TableRegAddress values(11011,101,1,556,300),(22022,102,3,582,200),(33033,103,4,556,400),(44044,104,2,111,100)
insert into TableFeeDetail values(9101,104,500,40,250,250,'2023-10-22'),(9102,103,1000,50,500,500,'2023-11-25'),(9103,102,1500,55,750,750,'2023-1-12'),(9104,101,500,60,250,250,'2023-1-12')


