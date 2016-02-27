USE eCommerce_db
GO
ALTER TABLE dbo.PRODUCT
ALTER COLUMN productID NVARCHAR(50) NOT NULL
GO

-- DROP CONSTRAINTS
USE eCommerce_db
GO
ALTER TABLE dbo.PRODUCT
DROP CONSTRAINT PK_product
GO

-- SET PRIMARY KEY
USE eCommerce_db
GO
ALTER TABLE dbo.product
ADD PRIMARY KEY (productID)
GO

-- ALTER INVOICE PRODUCTID 
USE eCommerce_db
GO
ALTER TABLE dbo.INVOICE
ALTER COLUMN productID NVARCHAR(50) NOT NULL
GO

--Add userID as foriegn key in userDetails Table
--USE eCommerce_db
--GO
--ALTER TABLE dbo.userDetails
--ADD COLUMN userID
--GO
--example: ALTER TABLE dbo.doc_exa ADD column_b VARCHAR(20) NULL, column_c INT NULL ;
USE eCommerce_db
GO
SELECT * FROM dbo.userDetails
GO

--*********************************************

--How to deal with two tables that are inter-related with foriegn keys to each other
USE eCommerce_db
GO
SELECT * FROM dbo.userDetails
GO

USE eCommerce_db
GO
INSERT INTO dbo.userDetails (lastName, firstName, address, mobile,emailAddress) VALUES ('lastname3','firstname3','address3','98765458','lastname3.firstname3@gmail.com')
GO

USE eCommerce_db
GO
UPDATE dbo.userDetails SET userID='userid3' WHERE lastName='lastname3'
GO

--*********************************************

/****** Script for login database table  ******/
USE eCommerce_db
GO
SELECT * FROM dbo.login
GO

USE eCommerce_db
GO
INSERT INTO dbo.login (userID,pwd,role,lastName) VALUES ('userid3','pwd3','role3','lastname3')
GO

--*********************************************