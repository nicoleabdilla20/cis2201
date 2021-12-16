CREATE SCHEMA [Hospital]  
    AUTHORIZATION [dbo];  
GO  
PRINT N'Creating Public.patients...';  
GO  
CREATE TABLE [Hospital].[staff] (  
    [StaffID]   INT  IDENTITY NOT NULL,  
    [StaffName] NVARCHAR (40) NOT NULL,  
    [StaffSurnameName] NVARCHAR (40) NOT NULL,
    [StaffGender] NVARCHAR (40) NOT NULL,  
    [StaffEmail] NVARCHAR (40) NOT NULL,
    [StaffPhoneNumber] NVARCHAR (40) NOT NULL,
    [StaffRole] NVARCHAR (40) NOT NULL,
    [StaffHours] NVARCHAR (40) NOT NULL,
    [StaffPay] NVARCHAR (40) NOT NULL
);  

GO
INSERT INTO [Hospital].[staff](StaffName, StaffSurnameName, StaffGender, StaffEmail, StaffPhoneNumber, StaffRole, StaffHours, StaffPay)
VALUES('Ronald', 'Abela', 'Male', 'ronald_abela@gmail.com', '79465623', 'Doctor', '200', '15615');
INSERT INTO [Hospital].[staff](StaffName, StaffSurnameName, StaffGender, StaffEmail, StaffPhoneNumber, StaffRole, StaffHours, StaffPay)
VALUES('Elizabeth', 'Smith', 'Female', 'eliSmith20@gmail.com', '77162349', 'Nurse', '150', '1450');
INSERT INTO [Hospital].[staff](StaffName, StaffSurnameName, StaffGender, StaffEmail, StaffPhoneNumber, StaffRole, StaffHours, StaffPay)
VALUES('George', 'Williams', 'Male', 'george_williams@gmail.com', '99118831', 'Therapist', '50', '6500');
INSERT INTO [Hospital].[staff](StaffName, StaffSurnameName, StaffGender, StaffEmail, StaffPhoneNumber, StaffRole, StaffHours, StaffPay)
VALUES('David', 'Brown', 'Male', 'brownDavid@gmail.com', '79798612', 'Physicians', '90', '4685');
INSERT INTO [Hospital].[staff](StaffName, StaffSurnameName, StaffGender, StaffEmail, StaffPhoneNumber, StaffRole, StaffHours, StaffPay)
VALUES('John', 'Oliver', 'Male', 'john_oliver_78@gmail.com', '79021036', 'Specialists', '110', '12000');
INSERT INTO [Hospital].[staff](StaffName, StaffSurnameName, StaffGender, StaffEmail, StaffPhoneNumber, StaffRole, StaffHours, StaffPay)
VALUES('Leo', 'Zammit', 'Male', 'leo_zammit@gmail.com', '79460666', 'Interpreters', '40', '905');
INSERT INTO [Hospital].[staff](StaffName, StaffSurnameName, StaffGender, StaffEmail, StaffPhoneNumber, StaffRole, StaffHours, StaffPay)
VALUES('Thomas', 'Smith', 'Male', 'smithThomas88@gmail.com', '99992354', 'Pharmacists', '200', '10025');
INSERT INTO [Hospital].[staff](StaffName, StaffSurnameName, StaffGender, StaffEmail, StaffPhoneNumber, StaffRole, StaffHours, StaffPay)
VALUES('Christina', 'Mizzi', 'Female', 'chriMizzi87@gmail.com', '77614639', 'Social Worker', '50', '998');

SELECT * FROM [Hospital].[staff];