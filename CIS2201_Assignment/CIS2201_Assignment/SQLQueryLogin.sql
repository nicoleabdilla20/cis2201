CREATE SCHEMA [Hospital]  
    AUTHORIZATION [dbo];  
GO  
PRINT N'Creating Public.patients...';  
GO  
CREATE TABLE [Hospital].[login] (  
    [Username] NVARCHAR (40) NOT NULL,  
    [Password] NVARCHAR (40) NOT NULL
);  
GO
INSERT INTO [Hospital].[login](Username, Password)
VALUES('Admin', 'Test');
INSERT INTO [Hospital].[login](Username, Password)
VALUES('Ronald', 'Test01');
INSERT INTO [Hospital].[login](Username, Password)
VALUES('John', 'Test02');
GO
SELECT * FROM [Hospital].[login];
