use BikeStore-----DBName

create table stores
(store_id int identity(1,1), 
store_name varchar(50) not null,
phone varchar(10) ,
email varchar(50),
street varchar (100),
city varchar (50),
state varchar (20),
zip_code varchar(6),
constraint store_id primary key (store_id));

select * from stores
insert into stores values('Manuja Autospare','1236547890','manujaautospare@gmail.com','Rahul Nagar', 'Napure','Maharashtra','001601')

create table staffs(
staff_id int identity(1,1) ,
first_name varchar (20),
last_name varchar (20),
email varchar (50),
phone varchar (10),
active tinyint not null,
store_id int not null,
manager_id int,
 primary key(staff_id, manager_id),
foreign key (store_id) references stores(store_id)
	on delete cascade on update cascade);
--foreign key (manager_id) 
	--references staffs(staff_id)
	--on delete no action on update no action);
	select*from staffs
insert into staffs values()

create table categories(
category_id int primary key identity(1,1),
catagory_name varchar (40));
select * from categories

create table brands(
brand_id int primary key identity(1,1),
brand_name varchar (40));
select * from brands

create table products (
product_id int primary key identity(1,1),
product_name varchar(50),
brand_id int foreign key references brands(brand_id) on delete cascade on update cascade not null,
category_id int foreign key (category_id) references brands(brand_id)  not null,
model_year smallint not null,
list_price decimal(10,2) not null); 
select*from products










