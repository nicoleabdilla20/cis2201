CREATE SCHEMA [Hospital]  
    AUTHORIZATION [dbo];  
GO  
CREATE TABLE [Hospital].[Medication] (
    [TypeOfMed]          NVARCHAR (40) NOT NULL,
    [NameOfMed]          NVARCHAR (40) NULL,
    [bloodType]          NVARCHAR (40) NULL,
    [stockAmount]        NVARCHAR (40) NOT NULL,
    [price]              NVARCHAR (40) NOT NULL,
    [requireMaintenance] NVARCHAR(40)  NOT NULL
);
  

GO
INSERT INTO [Hospital].[Medication] (TypeOfMed, NameOfMed, bloodType, stockAmount, price, requireMaintenance)
VALUES('Medicine', 'Caughing syrup', NULL, '175', '15',  'no');
INSERT INTO [Hospital].[Medication] (TypeOfMed, NameOfMed, bloodType, stockAmount, price, requireMaintenance)
VALUES('Blood Samples', NULL ,'B', '50', '6',  'yes' );

GO
SELECT * FROM [Hospital].[Medication]; 



