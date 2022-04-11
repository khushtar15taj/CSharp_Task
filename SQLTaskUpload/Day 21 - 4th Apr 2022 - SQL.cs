--task2

create FUNCTION fn_Currenys(@money int)
returns nvarchar(10)
as
begin
return (select format(@money, 'C', 'hi-IN'))
end
go

PRINT AdventureWorks.dbo.fn_Currenys(10)


--task3

  CREATE VIEW vw_DetailsView 
  AS
SELECT [STUDENT_ID], [SUBJECT_ID],[MARKS]
FROM[dbo].[MARKS_INFO]
WHERE[STUDENT_ID] < 5;
INSERT INTO dbo.vw_DetailsView ([STUDENT_ID],[SUBJECT_ID],[MARKS])  VALUES(1, 2, 43);
INSERT INTO[dbo].[MARKS_INFO] ([STUDENT_ID],[SUBJECT_ID],[MARKS])  VALUES(1, 2, 78);
go

--task4

create PROCEDURE sp_Masterinsertupdatedelete (@id            INTEGER,
                                          @first_name    VARCHAR(10),
                                          @last_name VARCHAR(10),
                                          @salary DECIMAL(10, 2),
                                          @city VARCHAR(20),
                                          @StatementType NVARCHAR(20) = '')
AS
  BEGIN
      IF @StatementType = 'Insert'
        BEGIN
            INSERT INTO employee
                        (id,
                         first_name,
                         last_name,
                         salary,
                         city)
            VALUES(@id,
                         @first_name,
                         @last_name,
                         @salary,
                         @city)
        END

      IF @StatementType = 'Select'
        BEGIN
            SELECT *
            FROM   employee
        END

      IF @StatementType = 'Update'
        BEGIN
            UPDATE employee
            SET    first_name = @first_name,
                   last_name = @last_name,
                   salary = @salary,
                   city = @city
            WHERE  id = @id
        END
      ELSE IF @StatementType = 'Delete'
        BEGIN
            DELETE FROM employee
            WHERE  id = @id
        END
  END
  go;

EXEC dbo.uspGetEmployeeManagers @id = 1, @first_name = 'Monu', @last_name = 'Rathor', @salary = 4789, @city = 'Agra' @StatementType = 'Insert';
go;

--task5

  select Name from Production.Product where ( DaysToManufacture  = (select DaysToManufacture  from Production.Product where Name like 'Blade')) 
	go

    --task6

    SELECT[Name]
FROM [Production].[Product]
WHERE[Weight] = ANY
(select maxval = max(weight) from Production.Product  group by ProductModelID);

SELECT[Name]
FROM[Production].[Product]
WHERE[Weight] = ALL
  (select maxval = max(weight) from Production.Product  group by ProductModelID);

SELECT[Name]
FROM[Production].[Product]
WHERE[Weight] = SOME
  (select maxval = max(weight) from Production.Product  group by ProductModelID);


--task7

    select p.FirstName, p.Lastname, [TerritoryName] = st.[Name], s.[SalesYTD]
    FROM [Sales].[SalesPerson] s
    INNER JOIN[Person].[Person] p
    ON p.[BusinessEntityID] = s.[BusinessEntityID]

    inner JOIN  [Sales].[SalesTerritory] st
    ON st.[TerritoryID] = s.[TerritoryID] where s.[SalesYTD] in (select max(SalesYTD) from [Sales].[SalesPerson] group by [TerritoryID] )




