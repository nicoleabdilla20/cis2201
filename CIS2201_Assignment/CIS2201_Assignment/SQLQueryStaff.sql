CREATE SCHEMA [Hospital]  
    AUTHORIZATION [dbo];  
GO  
PRINT N'Creating Public.Staff...';  
GO  
CREATE TABLE [Hospital].[staff] (  

    [StaffID]            VARCHAR(10) PRIMARY KEY NOT NULL,  
    [StaffName]          NVARCHAR (40) NOT NULL,  
    [StaffSurnameName]   NVARCHAR (40) NOT NULL,
    [StaffGender]        NVARCHAR (40) NOT NULL,  
    [StaffAge]           INT NOT NULL,
    [StaffDateOfBirth]   DATE NOT NULL,
    [StaffAddress]       VARCHAR(100) NOT NULL,
    [StaffEmail]         NVARCHAR (40) NOT NULL,
    [StaffPhoneNumber]   INT NOT NULL,
    [StaffBloodType]     VARCHAR(10) NOT NULL,
    [StaffInsurance]     CHAR (1) NOT NULL,
    [StaffRole]          NVARCHAR (10) NOT NULL,
); 
 
GO
ALTER TABLE [Hospital].[staff]
ALTER COLUMN [StaffBloodType]     VARCHAR(10);
GO
INSERT INTO [Hospital].[staff](StaffID, StaffName, StaffSurnameName, StaffGender, StaffAge, StaffDateOfBirth, StaffAddress, StaffEmail, StaffPhoneNumber, StaffBloodType, StaffInsurance, StaffRole)
VALUES( '12431', 'Ronald', 'Abela', 'Male', 40, '27.OCT.1981', 'Triq Ghar Dalam, Birzebuggia', 'ronald_abela@gmail.com', 79465623, 'O', 'X', 'Doctor');
INSERT INTO [Hospital].[staff](StaffID, StaffName, StaffSurnameName, StaffGender, StaffAge, StaffDateOfBirth, StaffAddress, StaffEmail, StaffPhoneNumber, StaffBloodType, StaffInsurance, StaffRole)
VALUES('31435', 'Elizabeth', 'Smith', 'Female', 38, '14.JUN.1983', 'Triq Gorg Borg Olivier, il-Mellieha','eliSmith20@gmail.com', 77162349, 'A', 'Z', 'Nurse');
INSERT INTO [Hospital].[staff](StaffID, StaffName, StaffSurnameName, StaffGender, StaffAge, StaffDateOfBirth, StaffAddress, StaffEmail, StaffPhoneNumber, StaffBloodType, StaffInsurance, StaffRole)
VALUES('15343', 'George', 'Williams', 'Male', 29,'04.JAN.1992', 'Triq idmejda, Hal Balzan', 'george_williams@gmail.com', 99118831,'B', 'Z', 'Therapist');
INSERT INTO [Hospital].[staff](StaffID, StaffName, StaffSurnameName, StaffGender, StaffAge, StaffDateOfBirth, StaffAddress, StaffEmail, StaffPhoneNumber, StaffBloodType, StaffInsurance, StaffRole)
VALUES('4685','David', 'Brown', 'Male', 30,'04.JAN.1993', '113, Triq is-Saghtar, St Paul Bay', 'brownDavid@gmail.com', '79798612', 'O', 'Y', 'Physicians');
GO
DELETE FROM [Hospital].[patients]
WHERE [StaffID] = '12431';
GO
SELECT * FROM [Hospital].[staff];
GO
CREATE TABLE [Hospital].[staffDetails] (  
    [StaffID]               VARCHAR(40) NOT NULL,  
    [StaffName]             NVARCHAR (40) NOT NULL,  
    [StaffSurname]          NVARCHAR (40) NOT NULL,
    [StartOfContract]       DATE NOT NULL,
    [EndOfContract]         DATE NOT NULL,
    [TypeOfContract]        VARCHAR (40) NOT NULL,
    [NumberOfHours]         INT NOT NULL,
    [Bonus]                 VARCHAR (100) NOT NULL,

); 
GO
ALTER TABLE [Hospital].[staffDetails]
ALTER COLUMN [StaffID] VARCHAR(10) NOT NULL;
GO
INSERT INTO [Hospital].[staffDetails](StaffID, StaffName, StaffSurname, StartOfContract, EndOfContract, TypeOfContract, NumberOfHours, Bonus)
VALUES( '12431', 'Ronald', 'Abela', '27.OCT.1981', '01.SEP.2023', 'Definite', 20, '200');
INSERT INTO [Hospital].[staffDetails](StaffID, StaffName, StaffSurname, StartOfContract, EndOfContract, TypeOfContract, NumberOfHours, Bonus)
VALUES( '4685','David', 'Brown', '27.OCT.2010', '01.SEP.2025', 'Indefinite', 40, '500');

SELECT * FROM [Hospital].[staffDetails];

GO
CREATE PROCEDURE [Hospital].[addStaff]  
@StaffID VARCHAR(10), @StaffName NVARCHAR(40), @StaffSurnameName NVARCHAR(40), @StaffGender NVARCHAR(40), @StaffDateOfBirth DATE, @StaffAddress VARCHAR(100), @StaffEmail NVARCHAR(40), @StaffPhoneNumber INT, @StaffBloodType VARCHAR(10), @StaffInsurance CHAR(1), @StaffRole NVARCHAR(10) 
AS  
BEGIN
BEGIN TRANSACTION  
INSERT INTO [Hospital].[staff] (StaffID, StaffName, StaffSurnameName, StaffGender,  StaffDateOfBirth, StaffAddress, StaffEmail, StaffPhoneNumber, StaffBloodType, StaffInsurance, StaffRole)   
     VALUES (@StaffID, @StaffName, @StaffSurnameName, @StaffGender, @StaffDateOfBirth, @StaffAddress, @StaffEmail, @StaffPhoneNumber, @StaffBloodType, @StaffInsurance, @StaffRole);
COMMIT TRANSACTION
END

GO
CREATE PROCEDURE [Hospital].[addStaffDetails]  
@StaffID VARCHAR(10), @StaffName  NVARCHAR (40), @StaffSurname  NVARCHAR (40),@StartOfContract  DATE, @EndOfContract DATE, @TypeOfContract VARCHAR(40), @NumberOfHours INT, @Bonus VARCHAR(10)
AS  
BEGIN
BEGIN TRANSACTION  
INSERT INTO [Hospital].[staffDetails] (StaffID,StaffName, StaffSurname, StartOfContract, EndOfContract, TypeOfContract, NumberOfHours, Bonus)   
     VALUES (@StaffID, @StaffName, @StaffSurname,@StartOfContract,@EndOfContract, @TypeOfContract,@NumberOfHours, @Bonus);
COMMIT TRANSACTION
END


