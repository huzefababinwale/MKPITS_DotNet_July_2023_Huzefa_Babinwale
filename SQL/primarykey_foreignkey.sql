create table vendor_groups(
				group_id int identity primary key,
				group_name varchar(100) not null);

create table vendors(
				vendor_id int identity primary key,
				vendor_name varchar (100) not null,
				group_id int not null,);

				select * from vendor_groups
				select * from vendors
				--below is not executed because of identity tag
				insert into vendors (vendor_id, vendor_name)values(123,'amit')



				--let us drop these table and create new one 
				drop table vendors
				create table vendors (
							vendor_id int identity primary key,
							vendor_name varchar(100) not null,
							group_id int not null,
							constraint fk_group foreign key (group_id)
							REFERENCES vendor_groups(group_id)
							);
		--first insert in parant table then you will be able to refer same group_id for child table
				insert into vendor_groups values ('MKPITS')
				
				insert into vendors(vendor_name,group_id) values('amit',1)
				select*from vendors
				select* from vendor_groups
				insert into vendor_groups values('Tutions')
				insert into vendors (vendor_name,group_id) values('sumit',2)

				insert into vendor_groups values('niit')
				select*from vendor_groups
				select * from vendors
				insert into vendors(vendor_name,group_id) values('arjun',3)

				insert into vendor_groups values('JNIT')
				insert into vendors(vendor_name, group_id) values('David',4)

				--------------------------------------------

				create table orders(orderid int primary key,orddate date, custid int)

				create table order_details(order_id int , 
											product_name varchar(20),quantity int,
											constraint fk1 foreign key (order_id)
											references orders(orderid)	)

				insert into orders values(1,'2022-9-7',101)
				select*from orders
				insert into order_details values(1,'mouse',5)
				insert into order_details values(1,'keyboard',5)
				
				select * from orders
				select*from order_details
				delete from orders where orderid=2
				--------------------Refral Actions----------------------------

				select * from vendor_groups
				--delete by group id
				delete from vendor_groups where group_id=2 --not good to go yet some permission required
				insert into vendor_groups values('aptech')
				select *from vendor_groups
				select * from vendors
				insert into vendors values('kailash',5)

				delete from vendors where group_id=3
				delete from vendor_groups	where group_id=3

				----------------ON DELETE evenet-----------------------------
				drop table vendors
CREATE TABLE vendors (
        vendor_id INT IDENTITY PRIMARY KEY,
        vendor_name VARCHAR(100) NOT NULL,
        group_id INT NOT NULL,
        constraint fk11  foreign key(group_id)
        references vendor_groups(group_id)
        on delete no action
        )
insert into vendors values('amit',1)
select*from vendors
select* from vendor_groups
delete from vendor_groups where group_id=1

---------------ON DELETE CASCADE--------------------
drop table vendors
CREATE TABLE vendors (
        vendor_id INT IDENTITY PRIMARY KEY,
        vendor_name VARCHAR(100) NOT NULL,
        group_id INT NOT NULL,
        constraint fk2  foreign key(group_id)
        references vendor_groups(group_id)
		on delete cascade )

		insert into vendors values('amit',1)
        select * from vendor_groups
        select * from vendors
        delete from vendors where group_id=2

		---------------------ON DELETE SET NULL---------------------
		drop table vendors
		CREATE TABLE vendors (
        vendor_id INT IDENTITY PRIMARY KEY,
        vendor_name VARCHAR(100) NOT NULL,
        group_id INT ,
        constraint fk3  foreign key(group_id)
        references vendor_groups(group_id)
		on delete set null)

		select * from vendors
		insert into vendor_groups values('tcs')
        insert into vendors values('amitabh',3)
-----------------------Assignment on keys---------------------------------------



