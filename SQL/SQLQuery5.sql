create table Add_Suppliers(
Supplier_ID int not null identity (1,1)primary key ,
Supplier_Name varchar (150) not null,
Address varchar (150) not null,
Company_Name varchar (150) not null,
phone_Number bigint not null,
E_mail  varchar (150) not null, 
Date varchar (100) not null,

)

select  *
from  Add_Suppliers