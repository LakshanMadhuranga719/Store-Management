create table Hand_Over(
Hand_Over_ID int not null IDENTITY (1,1) primary key,
Employee_name varchar (250)not null,
Emp_No varchar (250)not null,
Address  varchar (250)not null,
E_mail varchar (250)not null,
Phone_NO bigint not null,
Material_name varchar (250)not null,
Material_QTY int not null,
Hand_Over_Date varchar (250) NOT NULL,
);

select * from Hand_Over

