CREATE SCHEMA [Hospital]  
    AUTHORIZATION [dbo];  
GO  
PRINT N'Creating Public.issue...';  
GO  
CREATE TABLE [Hospital].[issue] (  

    [StaffID]       VARCHAR(10) PRIMARY KEY NOT NULL,  
    [StaffDate]     DATE NOT NULL,
    [Details]       VARCHAR(500) NOT NULL,
); 

GO
INSERT INTO [Hospital].[issue](StaffID, StaffDate, Details)
VALUES( '12431', '27.OCT.2021', 'Staff Tab not opening');
INSERT INTO [Hospital].[issues](StaffID, StaffDate, Details)
VALUES('31435',  '14.DEC.2021', 'Staff not working');

GO 
SELECT * FROM [Hospital].[issue]; 

GO
CREATE PROCEDURE [Hospital].[addIssue]  
@StaffID VARCHAR(10), @StaffDate DATE, @Details VARCHAR(500)
AS  
BEGIN
BEGIN TRANSACTION  
INSERT INTO [Hospital].[issue] (StaffID, StaffDate, Details)   
     VALUES (@StaffID, @StaffDate, @Details);
COMMIT TRANSACTION
END