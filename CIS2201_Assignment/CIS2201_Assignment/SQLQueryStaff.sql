CREATE SCHEMA [Hospital]  
    AUTHORIZATION [dbo];  
GO  
PRINT N'Creating Public.patients...';  
GO  
CREATE TABLE [Hospital].[staff] (  
    [StaffID]   VARCHAR(40) NOT NULL,  
    [StaffName] NVARCHAR (40) NOT NULL,  
    [StaffSurnameName] NVARCHAR (40) NOT NULL,
    [StaffGender] NVARCHAR (40) NOT NULL,  
    [StaffEmail] NVARCHAR (40) NOT NULL,
    [StaffPhoneNumber] NVARCHAR (40) NOT NULL,
    [StaffRole] NVARCHAR (40) NOT NULL,
    [StaffHours] NVARCHAR (40) NOT NULL
);  

GO
INSERT INTO [Hospital].[staff](StaffID, StaffName, StaffSurnameName, StaffGender, StaffEmail, StaffPhoneNumber, StaffRole, StaffHours)
VALUES('33456G', 'Ronald', 'Abela', 'Male', 'ronald_abela@gmail.com', '79465623', 'Doctor', '200');
INSERT INTO [Hospital].[staff](StaffID, StaffName, StaffSurnameName, StaffGender, StaffEmail, StaffPhoneNumber, StaffRole, StaffHours)
VALUES('77786H', 'Elizabeth', 'Smith', 'Female', 'eliSmith20@gmail.com', '77162349', 'Nurse', '150');
INSERT INTO [Hospital].[staff](StaffID, StaffName, StaffSurnameName, StaffGender, StaffEmail, StaffPhoneNumber, StaffRole, StaffHours)
VALUES('55546M', 'George', 'Williams', 'Male', 'george_williams@gmail.com', '99118831', 'Therapist', '50');
INSERT INTO [Hospital].[staff](StaffID, StaffName, StaffSurnameName, StaffGender, StaffEmail, StaffPhoneNumber, StaffRole, StaffHours)
VALUES('44567G', 'David', 'Brown', 'Male', 'brownDavid@gmail.com', '79798612', 'Physicians', '90');
INSERT INTO [Hospital].[staff](StaffID, StaffName, StaffSurnameName, StaffGender, StaffEmail, StaffPhoneNumber, StaffRole, StaffHours)
VALUES('88765H', 'John', 'Oliver', 'Male', 'john_oliver_78@gmail.com', '79021036', 'Specialists', '110');
INSERT INTO [Hospital].[staff](StaffID, StaffName, StaffSurnameName, StaffGender, StaffEmail, StaffPhoneNumber, StaffRole, StaffHours)
VALUES('99654H', 'Leo', 'Zammit', 'Male', 'leo_zammit@gmail.com', '79460666', 'Interpreters', '40');
INSERT INTO [Hospital].[staff](StaffID, StaffName, StaffSurnameName, StaffGender, StaffEmail, StaffPhoneNumber, StaffRole, StaffHours)
VALUES('99876M', 'Thomas', 'Smith', 'Male', 'smithThomas88@gmail.com', '99992354', 'Pharmacists', '200');
INSERT INTO [Hospital].[staff](StaffID, StaffName, StaffSurnameName, StaffGender, StaffEmail, StaffPhoneNumber, StaffRole, StaffHours)
VALUES('11234G', 'Christina', 'Mizzi', 'Female', 'chriMizzi87@gmail.com', '77614639', 'Social Worker', '50');
INSERT INTO [Hospital].[staff](StaffID, StaffName, StaffSurnameName, StaffGender, StaffEmail, StaffPhoneNumber, StaffRole, StaffHours)
VALUES('00965G', 'Maria', 'Grech', 'Female', 'mgrech22@gmail.com', '76543289', 'Doctor', '50');

SELECT * FROM [Hospital].[staff];
