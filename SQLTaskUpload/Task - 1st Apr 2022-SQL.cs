--task1
select firstName, lastName from person.person 
where [Title] IS NOT NULL;

--task2

Select firstName, lastName  from person.person
    WHERE ( firstName like '%a%' and LastName like '%a%');

--task3
select[CurrencyCode],[Name] from Sales.Currency
  UNION
   select  [CurrencyCode],[Name] from Sales.CountryRegionCurrency


 --task4
 SELECT* INTO humanresources.Dept FROM humanresources.department; --task4

--task5
CREATE TABLE Employee (
	[EmpID][int] IDENTITY(1,1) NOT NULL,

   [FirstName] [nvarchar] (50) DEFAULT 'Harry' not null,
	[LastName][nvarchar] (50) DEFAULT 'Potter' NOT NULL,
	[Age] [int] DEFAULT 35 not null,
	[Gender][Varchar] (10) DEFAULT 'Male'
	);
SET NOCOUNT off 
 BEGIN TRAN 
 DECLARE @i INT 
 SET @i = 1 
 WHILE @i <= 20
 BEGIN 
 INSERT INTO Employee DEFAULT VALUES 
 SET @i = @i + 1 
 END 
 COMMIT TRAN

 select * from employee; --task5

 --task6
 SELECT businessentityid, addresstypeid
FROM humanresources.department  hd
INNER JOIN Person.BusinessEntityAddress  pb ON pb.businessentityid = hd.businessentityid; --task 6

--task 7
SELECT DISTINCT[GroupName] 
FROM humanresources.department; --task7

--task8

SELECT SUM(pp.ListPrice) AS TotalListPrice, pp.StandardCost , pch.StandardCost FROM 
Production.Product pp , Production.ProductCostHistory pch
group by pp.StandardCost , pch.StandardCost;


--task9

SELECT DATEDIFF(month, Startdate, EndDate) AS DateDiff
FROM HumanResources.EmployeeDepartmentHistory;


--task10

select* from Sales.SalesPersonQuotaHistory as sp
where (sp.SalesQuota + 5000) > 10000 ORDER BY(sp.SalesQuota + 5000) ASC

--task 11
SELECT MAX(taxrate) AS Max_taxrat FROM sales.salestaxrate;

--task12


SELECT hd.DepartmentID, he.BusinessentityId, hdh.ShiftId, he.BirthDate , DATEDIFF(year, he.BirthDate, GetDate()) AS Age
FROM HumanResources.Employee as he
INNER JOIN HumanResources.EmployeeDepartmentHistory as hdh on hdh.BusinessEntityID = he.BusinessEntityID
inner join HumanResources.Department as hd on hd.DepartmentID = hdh.DepartmentID;
go;

--task13


CREATE VIEW vw_Humanresources AS
SELECT hd.DepartmentID, he.BusinessentityId, hdh.ShiftId, he.BirthDate , DATEDIFF(year, he.BirthDate, GetDate()) AS Age
FROM HumanResources.Employee as he
INNER JOIN HumanResources.EmployeeDepartmentHistory as hdh on hdh.BusinessEntityID = he.BusinessEntityID
inner join HumanResources.Department as hd on hd.DepartmentID = hdh.DepartmentID;

--task14
SELECT SCHEMA_NAME(A.schema_id) +'.' +
	 A.Name as name, sum(B.rows) AS 'No_of_rows_hr'
FROM sys.objects A
INNER JOIN sys.partitions B ON A.object_id = B.object_id
WHERE A.type = 'U' AND A.schema_id = 5--Since the schema id for human resources is 5
GROUP BY    A.schema_id, A.Name -- task14

--task 15

SELECT MAX(rate) AS maximumRate
FROM HumanResources.Department;


--task16

SELECT pp.FirstName, pp.MiddleName , pba.AddressTypeID , pba.businessentityID, pp.Title
FROM Person.Person as pp
LEFT JOIN Person.BusinessEntityAddress as pba
ON pp.businessentityID = pba.businessentityID and pp.Title IS NOT NULL;


--task17


select ProductID, LocationID, Shelf from Production.ProductInventory
where (ProductID BETWEEN 300 AND 350) AND(LocationID = 50 OR Shelf like 'a');

--task18

select ppi.LocationID, ppi.Shelf , pl.Name
FROM Production.ProductInventory as ppi
INNER JOIN Production.Location pl ON ppi.LocationID = pl.LocationID;


--task 19


SELECT pa.AddressID, pa.AddressLine1 , pa.AddressLine2, psp.StateProvinceCode, psp.CountryRegionCode
FROM Person.Address pa
CROSS JOIN Person.StateProvince psp; --this solution is with cross join

SELECT pa.AddressID, pa.AddressLine1 ,pa.AddressLine2, psp.StateProvinceCode,psp.CountryRegionCode
FROM Person.Address pa, Person.StateProvince psp; --this solution is without any joins--task19

--task20
SELECT scr.currencycode, (sso.subtotal + sso.TaxAmt) as total
FROM Sales.SalesOrderHeader sso, Sales.CountryRegionCurrency scr;


















