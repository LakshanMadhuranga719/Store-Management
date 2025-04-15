create table Add_Employee(
Emp_ID int not null identity (1,1)primary key ,
Employee_name varchar (150) not null,
Emp_No varchar (250)not null,
Address varchar (150) not null,
E_Mail varchar (100) not null,
Phone_NO int not null,  
Date varchar (100) not null,
)

select  *
from  Add_Employee
