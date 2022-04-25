create table product(
ProdID int IDENTITY(1,1) Primary key,
ProdName nvarchar(100),
price int,
ManufacturedDate datetime not null default getdate(),
ExpiryDate datetime)

insert into product(ProdName, price, ExpiryDate)
values('Lays', 20, DATEADD(year, 1, getdate()))
insert into product(ProdName, price, ExpiryDate)
values('DairyMilk', 60, DATEADD(month, 8, getdate()))
insert into product(ProdName, price, ExpiryDate)
values('Bourbon', 10, DATEADD(month, 9, getdate()))
insert into product(ProdName, price, ExpiryDate)
values('milkbikis', 15, DATEADD(year, 1, getdate()))


create table Customer(
CustID int IDENTITY(1,1) Primary key,
Name nvarchar(100),
Gender Varchar(10) check(gender in ('Female', 'Male')),
DoB date not null,
ContactNo varchar(15) UNIQUE,
EmailID nvarchar(255),
city varchar(20))


insert into Customer(Name, Gender, DoB, ContactNo, EmailID, city)
values('Sania', 'Female', '2008-11-11', '9949000563', 'Sania123@gmail.com', 'Chennai')
insert into Customer(Name, Gender, DoB, ContactNo, EmailID, city)
values('Salman', 'Male', '2008-11-11', '6281450313', 'Salmanx123@gmail.com', 'Mumbai')
insert into Customer(Name, Gender, DoB, ContactNo, EmailID, city)
values('Sania', 'Female', 2008 - 11 - 11, 9949000563, 'Sania123@gmail.com', 'Chennai')
insert into product(ProdName, price, ExpiryDate)
values('Bourbon', 10, DATEADD(month, 9, getdate()))
insert into product(ProdName, price, ExpiryDate)
values('milkbikis', 15, DATEADD(year, 1, getdate()))

select* from product


create table Purchase(
BillNo int IDENTITY(1,1) Primary key,
CustID int,
ProdID int,
Quantity int,
TotalAmount int,
 FOREIGN KEY (CustID) REFERENCES Customer(CustID),
 FOREIGN KEY(ProdID) REFERENCES Product(ProdID),)


go;



create procedure sp_InsertPurchase 
@CustID int,
@ProdID int,
@Quantity int
as
begin
declare @price as int
set @price = (select [price] from[dbo].[product] where product.ProdID = @ProdID)
insert into  purchase (CustID, ProdID, Quantity, TotalAmount) 
values(@CustID, @ProdID, @Quantity, @price * @Quantity)
end
go;




create procedure sp_Billing 
@CustID int
as
begin
declare @BillNo as int
set @BillNo = (select MAX(BillNo) from purchase);
select TotalAmount from purchase where purchase.CustID = @CustID and purchase.[BillNo] = @BillNo
end

go;

create procedure sp_Billing_CustID 
@CustID int
as
begin
select pr.ProdName, p.TotalAmount, p.Quantity, c.Name from purchase p inner join Customer c on  c.[CustID] = p.CustID and c.[CustID] = @CustID
   inner join product pr
   on
   p.ProdID = pr.ProdID
   end
   go;

drop procedure sp_Billing_CustID
go;
create procedure sp_Billing_Date
@Date date
as
begin
select pr.ProdName, p.TotalAmount, p.Quantity, c.Name from purchase p inner join Customer c on  c.[CustID] = p.CustID and c.[DoB] = @Date
   inner join product pr
   on
   p.ProdID = pr.ProdID
   end

   go;
create procedure sp_NewCustID 
as
begin
select max(CustID) from Customer
end
go;


select* from purchase
EXECUTE sp_Billing 
  @CustID = 2
GO

select * from purchase
select * from customer




