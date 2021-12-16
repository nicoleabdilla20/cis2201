CREATE SCHEMA [Hospital]  
    AUTHORIZATION [dbo];  
GO  
PRINT N'Creating Public.patients...';  
GO  
CREATE TABLE [Hospital].[patients] (  
    [PatientsID]   INT  IDENTITY NOT NULL,  
    [PatientsName] NVARCHAR (40) NOT NULL,  
    [PatientsSurnameName] NVARCHAR (40) NOT NULL,
    [PatientsGender] NVARCHAR (40) NOT NULL,  
    [PatientsAge]     INT           NOT NULL,
    [PatientsInsurance] CHAR (1) NOT NULL,
    [PatientsLastVisit] DATE NOT NULL 
);  
GO
INSERT INTO [Hospital].[patients](PatientsName, PatientsSurnameName, PatientsGender, PatientsAge, PatientsInsurance, PatientsLastVisit)
VALUES('Jhon', 'Brown', 'Male', 45, 'X', '27.OCT.2018');
INSERT INTO [Hospital].[patients](PatientsName, PatientsSurnameName, PatientsGender, PatientsAge, PatientsInsurance, PatientsLastVisit)
VALUES('Maria', 'Hunt', 'Female', 22, 'Z','27.AUG.2018');
INSERT INTO [Hospital].[patients](PatientsName, PatientsSurnameName, PatientsGender, PatientsAge, PatientsInsurance, PatientsLastVisit)
VALUES('Colin', 'Debrincat', 'Male', 35, 'Y','1.FEB.2011');
INSERT INTO [Hospital].[patients](PatientsName, PatientsSurnameName, PatientsGender, PatientsAge, PatientsInsurance, PatientsLastVisit)
VALUES('Stephanie', 'Zammit', 'Female', 27, 'Z','5.MAR.2017');
INSERT INTO [Hospital].[patients](PatientsName, PatientsSurnameName, PatientsGender, PatientsAge, PatientsInsurance, PatientsLastVisit)
VALUES('Joan', 'Attard', 'Female', 44, 'X','9.MAY.2020');

SELECT * FROM [Hospital].[patients];

