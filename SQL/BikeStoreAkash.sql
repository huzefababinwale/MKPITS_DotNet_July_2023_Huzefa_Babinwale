/*-----------------------------------------STORES-------------------------------------------------------*/
CREATE TABLE Stores( Store_id int primary key,Store_name varchar(20),Phone bigint,Email varchar(20),Street varchar(20),City varchar(20), State varchar(20),Zip_code bigint)
insert into Stores values(1,'Akash Stores',887878,'akash@123','1Nagpr','Nagpur','Maharashtra',0010)
insert into Stores values(2,'Sahil Stores',887878,'sahil@123','2Nagpr','Amravti','Maharashtra',0010)
insert into Stores values(3,'David Stores',887878,'david@123','3Nagpr','Wardha','Maharashtra',0010)
insert into Stores values(4,'Sarang Stores',887878,'sarang@123','4Nagpr','Gondia','Maharashtra',0010)
insert into Stores values(5,'Lucky Stores',887878,'lucky@123','5Nagpr','Jalna','Mp',0010)
select *from Stores

/*-----------------------------------------STAFFS-------------------------------------------------------*/
CREATE TABLE Staffs(Staff_id int primary key,First_name varchar(20),Last_name varchar(20),Email varchar(20),Phone bigint,Active varchar(20),Store_id int foreign key references Stores (Store_id),Manager_id int)
insert into Staffs values(101,'Akash','Gautam','akash@123',8878785,'Yes',1,111)
insert into Staffs values(102,'Sahil','Kalwe','sahil@123',8878785,'Yes',2,112)
insert into Staffs values(103,'Sooraj','Gautam','sooraj@123',8878785,'Yes',3,113)
insert into Staffs values(104,'Piysh','Narole','sahill@123',8878785,'Yes',4,114)
insert into Staffs values(105,'Akash','Gautam','akash@123',8878785,'Yes',5,115)
select *from Staffs

/*----------------------------------------CATEGORIES----------------------------------------------------*/
CREATE TABLE Categories1(Category_id int primary key,Category_name varchar(20))
insert into Categories1 values(1,'Heamnt')
insert into Categories1 values(2,'Raj')
insert into Categories1 values(3,'Yash')
insert into Categories1 values(4,'Sarang')
insert into Categories1 values(5,'Huzefa')
select * from Categories1

/*----------------------------------------BRAND---------------------------------------------------------*/
CREATE TABLE Brand(Brand_id int primary key,Brand_name varchar(20))
insert into Brand values(1,'Sooraj')
insert into Brand values(2,'Chandu')
insert into Brand values(3,'Ved')
insert into Brand values(4,'Siddhart')
insert into Brand values(5,'Devanshu')
select * from Brand

/*----------------------------------------PRODUCTS------------------------------------------------------*/
CREATE TABLE Products1(Product_id int primary key,Product_name varchar(20),Brand_id int constraint z1 foreign key (Brand_id) references Brand(Brand_id),Category_id int constraint p1 foreign key(Category_id) references Categories1(Category_id) ,Model_year int,List_price int)
insert into Products1 values(1,'Soaf',1,1,2011,55)
insert into Products1 values(2,'Soaf',2,2,2012,56)
insert into Products1 values(3,'Soaf',3,3,2013,57)
insert into Products1 values(4,'Soaf',4,4,2014,58)
insert into Products1 values(5,'Soaf',5,5,2015,59)
select * from Products1


/*---------------------------------------CUSTOMERS------------------------------------------------------*/
CREATE TABLE  Customers1(Customer_id int primary key,First_name varchar(20),Last_name varchar(20),Email varchar(20),Phone bigint,Street varchar(20),City varchar(20), State varchar(20),Zip_code bigint)
insert into Customers1 values(1,'Akash','Gautam','akash@123',55655,'bansinagar','Nagpur','Maharashtra',0010)
insert into Customers1 values(2,'David','Kothe','david@123',55655,'pardhinagar','Nagpur','Maharashtra',0010)
insert into Customers1 values(3,'Sooraj','Shrivastav','sooraj@123',55655,'sainagar','Nagpur','Maharashtra',0010)
insert into Customers1 values(4,'Ajinkya','Rahane','ajinkya@123',55585,'bansinagar','Nagpur','Maharashtra',0010)
insert into Customers1 values(5,'Swapnil','Gautam','swapnil@123',55655,'bansinagar','Nagpur','Maharashtra',0010)
select * from Customers1
drop table Customers1

/*---------------------------------------ORDER----------------------------------------------------------*/
CREATE TABLE Orders1(Order_Id int primary key,Customer_id int foreign key references Customers1(Customer_id),Order_status varchar(20),Order_date date,Required_date date,Shipped_date date,Store_id int foreign key references Stores(Store_Id),Staff_id int foreign key references Staffs(Staff_id))
insert into Orders1 values(10,1,'True','2022-10-15','2022-10-16','2022-10-17',1,101)
insert into Orders1 values(11,2,'True','2022-10-25','2022-10-26','2022-10-27',1,101)
insert into Orders1 values(12,3,'True','2022-10-09','2022-10-10','2022-10-11',1,101)
insert into Orders1 values(13,4,'True','2022-10-12','2022-10-13','2022-10-14',1,101)
insert into Orders1 values(14,5,'True','2022-10-05','2022-10-06','2022-10-07',1,101)
select * from Orders1

/*---------------------------------------ORDERITEMS----------------------------------------------------*/
CREATE TABLE Orders_Items(Order_Id int foreign key references Orders1(Order_Id),Item_id int,Product_id int primary key,Quantity int,List_price int ,Discount int)
insert into Orders_Items values(10,1,1,1,1,50)
insert into Orders_Items values(11,2,2,2,2,60)
insert into Orders_Items values(12,3,3,3,3,70)
insert into Orders_Items values(13,4,4,4,4,80)
insert into Orders_Items values(14,5,5,5,5,90)
select * from Orders_Items
drop table Orders_Items

/*------------------------------------STOCKS------------------------------------------------------------*/
CREATE TABLE Stocks(Stock_id int,Product_id int foreign key references Products1 (Product_id),Quantity int)
insert into Stocks values(1,1,10)
insert into Stocks values(2,2,20)
insert into Stocks values(3,3,30)
insert into Stocks values(4,4,40)
insert into Stocks values(5,5,50)
select * from Stocks