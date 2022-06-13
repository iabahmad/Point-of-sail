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
Price int,

)
create table Inventory_control(
Product_ID int foreign key references Product(Product_ID),
Outlet_ID int foreign key references Outlet(Outlet_ID),
I_quantity int,

)


 create table Order_Placed(
 Order_ID int primary key identity(1,1),
 Payment_ID int foreign key references Payment_method(Payment_ID),

 )

create table Order_Details(
 Order_ID int foreign key references Order_Placed(Order_ID),
 Emp_ID int foreign key references Employee(Emp_ID),
 Consumer_ID int foreign key references Consumer(Consumer_ID),
 Payment_ID int foreign key references Payment_method(Payment_ID),

)

create table lgi(
id int,
pass varchar,
)
insert into lgi values(1,"pass")