create database PointofSale


create table Enterprise (
E_id int primary key identity(1,1),
E_name varchar(50),
E_address varchar(50),
E_phone varchar(50),

)

create table Employee(
Emp_id int primary key identity(1,1),
Emp_name varchar(50),
Emp_address varchar(50),
Emp_phone varchar(50),

)

create table Outlet(
Outlet_ID int primary key identity(1,1),
Outlet_name varchar(50),
Outlet_address varchar(50),

)
create table Consumer(
Consumer_ID int primary key identity(1,1),
Consumer_name varchar(50),
Consumer_address varchar(50),
Consumer_phone int,
)

create table Payment_method(
Payment_ID int primary key identity(1,1),
Payment_name varchar(50),
Payment_description varchar(50),
Payment_Status varchar(50),

)

create table Product(
Product_ID int primary key identity(1,1),
Product_name varchar(50),

)
create table Inventory_control(
Product_ID int primary key identity(1,1),
Outlet_ID int,

)
