IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'CryptoPricesDb')
BEGIN
    CREATE DATABASE CryptoPricesDb;
END
GO

USE CryptoPricesDb;
GO

CREATE TABLE Prices (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Time DATETIME,
    Price DECIMAL(18, 2),
    IdofCrypto NVARCHAR(50)
);
GO