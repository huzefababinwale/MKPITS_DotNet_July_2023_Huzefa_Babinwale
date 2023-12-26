use functions --DB name


create table product (
Id int primary key identity, 
Region varchar (20),
product varchar (30),
Year int ,
Quantity int,
Price int )

insert into product values('North','Computer',2020,250,40000),
('East','Hard Disk',2020,190,5500),
('West','Computer',2021,250,45000),
('South','Hard Disk',2021,550,4400),
('West','Hard Disk',2021,650,7500),
('East','Pen Drive',2021,120,800),
('North','Mouse',2019,160,1500),
('South','Pen Drive',2019,270,750),
('East','Mouse',2019,2000,1200),
('West','Pen Drive',2019,190,650)
select * from product

---------------------------------min()--------------------------------
select min(Quantity) as "Minimum Quantity" from product 
select min(Price) as "Minimum Price" from product 
select min(Year) as "Minimum Year" from product

--------------------------------max()----------------------------------
select max(Quantity) as "Maximum Quantity" from product
select max(Price) as "Maximum Price" from product
select max(year) as "Max Year" from product

-----------------------min max with WHERE clause-----------------
select Product, Year , Quantity, Price 
from product
where Quantity=(
select min(Quantity) as "Minimum Quantity" from product)

select Product, Year, Quantity, Price
from product 
Where Price=(
select min(Price) as "Minimum Price" from product)
select * from product

select Product, Year, Quantity, Price
from product 
where price=(
select max(price) as "Maximum Price" from product)
select * from product

-----------------------Group by clause---------------------

select product ,  min(Quantity) as "Minimum Quantity" from product group by product

select  product, max(Quantity) as "Max Quantity" from product group by product

----------------------Having clause-------------------------

select product,Min(Quantity) as "Minimum Quantity" from product group by product having min(Quantity)>100;

select product , Max(Quantity) as "Maximum Quantity" from product group by product having max(Quantity)>100;

------------------AVG----------------------------
select product, AVG(Price) as "Average Price" from product group by product 
select product ,max(price) as "MaxPrice" from product group by product
select product, min(price) as "MinPrice" from product group by product

select avg(year) as "Average Year" from product where product ='Mouse'

-----------------SUM-------------------------------
select product,sum(price) as "Total Price" , sum(quantity) as "Total Quantity" from product group by product

select product, sum(Price)as  "Total Price" from product group by product

----------------COUNT------------------------------
select product ,count(product) as "Total Product" from product group by product

select count(price) as 'Total' from product where product='mouse'

----------------USER DEFINED FUNCTIONS--------------------------------------------------------------------

--in next .sql















