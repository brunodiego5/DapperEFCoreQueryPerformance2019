CREATE TABLE Sport (ID int NOT NULL PRIMARY KEY, Name varchar(200));
CREATE TABLE Team (ID int NOT NULL PRIMARY KEY, Name varchar(200), FoundingDate datetime2, SportID int NOT NULL FOREIGN KEY REFERENCES Sport(ID));
CREATE TABLE Player (ID int NOT NULL PRIMARY KEY, FirstName varchar(200), LastName varchar(200), DateOfBirth datetime2, TeamID int FOREIGN KEY REFERENCES Team(ID));