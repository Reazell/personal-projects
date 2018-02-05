USE BazaDanych;
GO
CREATE SCHEMA Person;
GO
	CREATE TABLE "Address"
		(AddressID int Primary KEY NOT NULL,
		AddressLine1 NVARCHAR(60) NOT NULL,
		AddressLine2 NVARCHAR(60),
		City NVARCHAR(30) NOT NULL,
		StateProvinceID int NOT NULL,
		PostalCode NVARCHAR(15) NOT NULL);

GO
CREATE SCHEMA Production;
GO
	CREATE TABLE Product
		(ProductID int PRIMARY KEY NOT NULL,
		Name NVARCHAR(50) NOT NULL,
		ProductNumber NVARCHAR(25) NOT NULL,
		Color NVARCHAR(15),
		SafetyStockLevel SMALLINT NOT NULL,
		ReorderPoint SMALLINT NOT NULL,
		StandardCost MONEY NOT NULL,
		ListPrice MONEY NOT NULL,
		Size NVARCHAR (5),
		SizeUnitMeasureCode NCHAR (3),
		WeightUnitMeasureCode NCHAR (3),
		"Weight" DECIMAL (8,2));

GO
CREATE SCHEMA Sales;
GO
	CREATE TABLE Customer
		(CustomerID INT PRIMARY KEY NOT NULL,
		PersonID INT,
		StoreID INT,
		TerritoryID INT,
		AccountNumber VARCHAR (10) NOT NULL);

	CREATE TABLE SalesPerson
		(BusinessEntityID INT PRIMARY KEY NOT NULL,
		TerritoryID INT,
		SalesQuota MONEY,
		Bonus MONEY NOT NULL,
		CommissionPct SMALLMONEY NOT NULL);

	CREATE TABLE SalesTerritory
		(TerritoryID INT PRIMARY KEY NOT NULL,
		Name NVARCHAR (50) NOT NULL,
		CountryRegionCode NVARCHAR (3) NOT NULL,
		"Group" NVARCHAR (50) NOT NULL);

	CREATE TABLE SalesOrderDetail
		(SalesOrderDetailID INT PRIMARY KEY NOT NULL,
		SalesOrderID INT NOT NULL,
		OrderQty SMALLINT NOT NULL,
		ProductID INT NOT NULL,
		UnitPrice MONEY NOT NULL,
		UnitPriceDiscount MONEY NOT NULL);

	CREATE TABLE SalesOrderHeader
		(SalesOrderID INT PRIMARY KEY NOT NULL,
		SalesOrderNumber NVARCHAR (25) NOT NULL,
		OrderDate DATE,
		DueDate DATE,
		ShipDate DATE,
		CustomerID INT,
		SalesPersonID INT,
		TerritoryID INT,
		BillToAddressID INT,
		ShipToAddressID INT,
		CurrencyRateID INT,
		SubTotal MONEY NOT NULL,
		TextAmt MONEY NOT NULL,
		Freight MONEY NOT NULL,
		TotalDue MONEY NOT NULL);


	CREATE TABLE CurrencyRate
		(CurrencyRateID INT PRIMARY KEY NOT NULL,
		CurrencyRadeDate DATETIME NOT NULL,
		FromCurrencyCode NCHAR (3) NOT NULL,
		ToCurrencyCode NCHAR (3) NOT NULL,
		AverageRate MONEY NOT NULL,
		EndOfDayRate MONEY NOT NULL);


	--SalesOrderDetail FK--
GO
	ALTER TABLE Sales.SalesOrderDetail
	ADD FOREIGN KEY (SalesOrderID)
	REFERENCES Sales.SalesOrderHeader(SalesOrderID);
GO
	ALTER TABLE Sales.SalesOrderDetail
	ADD FOREIGN KEY (ProductID)
	REFERENCES Production.Product(ProductID);
	
	--SalesOrderHeader FK--
GO
	ALTER TABLE Sales.SalesOrderHeader
	ADD FOREIGN KEY (CustomerID)
	REFERENCES Sales.Customer(CustomerID);
GO
	ALTER TABLE Sales.SalesOrderHeader
	ADD FOREIGN KEY (SalesPersonID)
	REFERENCES Sales.SalesPerson(BusinessEntityID);
GO
	ALTER TABLE Sales.SalesOrderHeader
	ADD FOREIGN KEY (TerritoryID)
	REFERENCES Sales.SalesTerritory(TerritoryID);
GO
	ALTER TABLE Sales.SalesOrderHeader
	ADD FOREIGN KEY (BillToAddressID)
	REFERENCES Person."Address"(AddressID);
GO
	ALTER TABLE Sales.SalesOrderHeader
	ADD FOREIGN KEY (ShipToAddressID)
	REFERENCES Person."Address"(AddressID);
GO
	ALTER TABLE Sales.SalesOrderHeader
	ADD FOREIGN KEY (CurrencyRateID)
	REFERENCES Sales.CurrencyRate (CurrencyRateID);



SELECT * from SalesOrderDetail;
DROP SCHEMA Person;
DROP SCHEMA Production;
DROP SCHEMA Sales;
DROP TABLE "Address";
DROP TABLE Product;
DROP TABLE Customer;
DROP TABLE SalesPerson;
DROP TABLE SalesTerritory;
DROP TABLE SalesOrderDetail;
DROP TABLE SalesOrderHeader;
DROP TABLE CurrencyRate;