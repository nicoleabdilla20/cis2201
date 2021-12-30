CREATE SCHEMA [Hospital]  
    AUTHORIZATION [dbo];  
    GO  
PRINT N'Creating Public.Medication...';  
GO  
CREATE TABLE [Hospital].[Medication] (
    [TypeOfMed]          NVARCHAR (40) NOT NULL,
    [NameOfMed]          NVARCHAR (40) NULL,
    [bloodType]          NVARCHAR (40) NULL,
    [stockAmount]        NVARCHAR (40) NOT NULL,
    [price]              NVARCHAR (40) NOT NULL,
    [requireMaintenance] VARCHAR(40)  NOT NULL
);
  

GO
INSERT INTO [Hospital].[Medication] (TypeOfMed, NameOfMed, bloodType, stockAmount, price, requireMaintenance)
VALUES('Medicine', 'Caughing syrup', NULL, '175', '15',  'no');
INSERT INTO [Hospital].[Medication] (TypeOfMed, NameOfMed, bloodType, stockAmount, price, requireMaintenance)
VALUES('Blood Samples', NULL ,'B', '50', '6',  'yes' );

GO
CREATE PROCEDURE [Hospital].[addMedication]
	@TypeOfMed NVARCHAR(40), @NameOfMed NVARCHAR(40), @bloodType NVARCHAR(40), @stockAmount NVARCHAR(40), @price NVARCHAR(40), @requireMaintenance VARCHAR(40)
AS
BEGIN
BEGIN TRANSACTION  
INSERT INTO [Hospital].[Medication] (TypeOfMed, NameOfMed, bloodType, stockAmount,  price, requireMaintenance)   
     VALUES (@TypeOfMed, @NameOfMed, @bloodType, @stockAmount, @price, @requireMaintenance);
COMMIT TRANSACTION
END

GO
CREATE PROCEDURE [Hospital].[searchMedication]
@NameOfMed VARCHAR(10)
AS  
BEGIN
BEGIN TRANSACTION  
SELECT * FROM [Hospital].[Medication] WHERE NameOfMed = @NameOfMed;
COMMIT TRANSACTION
END
GO


SELECT * FROM [Hospital].[Medication];

SELECT * FROM [Hospital].[Staff];