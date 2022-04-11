CREATE TABLE PersonalDetails (
    ID int NOT NULL,
    LastName nvarchar(255) NOT NULL,
    FirstName nvarchar(255),
    Age int CHECK(Age>=18),
    PRIMARY KEY(ID)
);

CREATE TABLE LoginInfo (
    username nvarchar(255) NOT NULL,
    pasword nvarchar(255) NOT NULL,
    ID int NOT NULL,
    CONSTRAINT FK_LoginInfo FOREIGN KEY (ID)
    REFERENCES PersonalDetails(ID)
);

ALTER TABLE LoginInfo
ADD CreateDate datetime DEFAULT CURRENT_TIMESTAMP;