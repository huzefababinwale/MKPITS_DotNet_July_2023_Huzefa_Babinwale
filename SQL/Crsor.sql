use production--DB name

create table products(
product_id int primary key,
product_name varchar (20))
alter table products add price int 

insert into products values(1,'abc',100),(2,'bcc',200),(3,'cvb',300),(4,'def',400)
select * from products

declare 
@products_name varchar(max),
@lists_price decimal ;

declare c_product cursor
for select product_name ,price from products

open c_product ;
Fetch next from c_product into 
@products_name,
@lists_price

while @@fetch_status=0
begin 
print @products_name +cast(@lists_price as varchar);
fetch next from c_product into
@products_name,
@lists_price;
end;

close c_product;
deallocate c_product;
-------------------------------------------------------------------------------------------------------------------

Declare 
@product2 varchar(20),
@price2 decimal;

Declare cu_product2 cursor
for select product_name,price
from products

open cu_product2
fetch next from cu_product2 into 
@product2,
@price2;

print @product2+cast(@price2 as varchar);
while @@fetch_status =0
begin 
fetch next  from cu_product2 into @product2, @price2

print @product2+ cast(@price2 as varchar);
end;
close cu_product2;
deallocate cu_product2;
--------------------------------------------------------------------------------------------------------

create table customer(
custid int primary key,
custname varchar(20),
custage decimal )

insert into customer values(1,'Bhushan',12),(2,'Shushil',22)
select * from customer

declare
@custname varchar(max),
@custage decimal;

declare cursor_cust cursor
for select custname, custage
from customer

open cursor_cust 
fetch next from cursor_cust into @custname, @custage

print @custname+ cast(@custage as varchar);
while @@fetch_status =0
begin 
	fetch next from cursor_cust into @custname, @custage

	print @custname+cast(@custage as varchar)
	end;

close cursor_cust;
deallocate cursor_cust;

------------------------------------------------------------------------------------------------------------------------
select * from customer
insert into customer values(3,'Huzefa',42),(4,'Jyros',23)

declare
@custname varchar(max),
@custage decimal;

declare cursor_cust cursor
for select custname, custage
from customer where custid>3

open cursor_cust 
fetch next from cursor_cust into @custname, @custage

print @custname+ cast(@custage as varchar);
while @@fetch_status =0
begin 
	fetch next from cursor_cust into @custname, @custage

	--print @custname+cast(@custage as varchar)
	end;

close cursor_cust;
deallocate cursor_cust;
-------------------------------------------------------------------------------------------------------------

create table product(
product_id int primary key,
product_name varchar (20))
alter table product add price int 

insert into product values(1,'mouse',100),(2,'keyboard',200),(3,'pen drive',300),(4,'hard disk',400),(5,'mouse',500)
select * from product

declare 
@product_id decimal ,
@product_name varchar(20),
@price decimal

declare curs_prod cursor
for select product_id, product_name, price from product where product_name='mouse'
open curs_prod

fetch next from curs_prod into @product_id , @product_name, @price
	print cast(@product_id as varchar)+ @product_name+cast(@price as varchar)
	while @@FETCH_STATUS=0
	begin
	fetch next from curs_prod into @product_id, @product_name, @price
	print cast(@product_id as varchar)+ @product_name+cast(@price as varchar)
	end
	
	close curs_prod
	deallocate curs_prod
--------------------------------------------------------------------------------------------------------------

declare 
@product_id decimal ,
@product_name varchar(20),
@price decimal

declare curs_prod cursor
for select product_id, product_name, price from product where price>=300
open curs_prod

fetch next from curs_prod into @product_id , @product_name, @price
	print cast(@product_id as varchar)+ @product_name+cast(@price as varchar)
	while @@FETCH_STATUS=0
	begin
	fetch next from curs_prod into @product_id, @product_name, @price
	print cast(@product_id as varchar)+ @product_name+cast(@price as varchar)
	end
	
	close curs_prod
	deallocate curs_prod














