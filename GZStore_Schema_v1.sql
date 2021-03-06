-- GameZone v1 Schema

--CREATE SCHEMA GStore;

-- TABLES
CREATE TABLE [GStore].[Customer](
	[CustomerID] INT IDENTITY NOT NULL, 
	[FirstName] NVARCHAR(100) NOT NULL, 
	[LastName] NVARCHAR(100) NOT NULL, 
	[Email] NVARCHAR(100) UNIQUE NOT NULL, 
	[Password] NVARCHAR(50) UNIQUE NOT NULL,
	[Admin] BIT NOT NULL
	CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ([CustomerID])
);

CREATE TABLE [GStore].[Product](
	[ProductID] INT IDENTITY NOT NULL,
	[Type] NVARCHAR(100),
    [Name] NVARCHAR(100) NOT NULL, 
    [Price] NUMERIC (10,2) NOT NULL 
    CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED ([ProductID])
);

CREATE TABLE [GStore].[Store](
	[StoreID] INT IDENTITY NOT NULL, 
	[StoreAddress] NVARCHAR(100) NOT NULL
	CONSTRAINT [PK_Store] PRIMARY KEY CLUSTERED ([StoreID])
);

CREATE TABLE [GStore].[Order](
	[OrderID] INT IDENTITY NOT NULL, 
	[CustomerID] INT NOT NULL, 
	[StoreID] INT NOT NULL, 
	[OrderDate] DATETIME NOT NULL,
	[OrderTotal] NUMERIC (10,2) NOT NULL
	CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED ([OrderID])
);

CREATE TABLE [GStore].[OrderLine](
	[OrderLineID] INT IDENTITY NOT NULL, 
	[OrderID] INT NOT NULL, 
	[ProductID] INT NOT NULL, 
	[Quantity] INT NOT NULL, 
	[TotalPrice] NUMERIC (10,2) NOT NULL
	CONSTRAINT [PK_OrderLine] PRIMARY KEY CLUSTERED ([OrderLineID])
);

CREATE TABLE [GStore].[Inventory](
	[InventoryID] INT NOT NULL, 
	[StoreID] INT NOT NULL, 
	[ProductID] INT NOT NULL, 
	[ProductQuantity] INT NOT NULL
	CONSTRAINT [PK_Inventory] PRIMARY KEY CLUSTERED ([InventoryID])
);

-- FOREIGN KEYS
ALTER TABLE [GStore].[Order] ADD
	CONSTRAINT [FK_CustomerId] FOREIGN KEY ([CustomerID]) REFERENCES [GStore].[Customer] ([CustomerID]) ON DELETE CASCADE ON UPDATE NO ACTION;
GO
ALTER TABLE [GStore].[Order] ADD
	CONSTRAINT [FK_StoreId] FOREIGN KEY	([StoreID]) REFERENCES [GStore].[Store] ([StoreID]) ON DELETE CASCADE ON UPDATE NO ACTION;
GO

ALTER TABLE [GStore].[OrderLine] ADD
	CONSTRAINT [FK_OrderId] FOREIGN KEY ([OrderID]) REFERENCES [GStore].[Order] ([OrderID]) ON DELETE CASCADE ON UPDATE NO ACTION;
GO
ALTER TABLE [GStore].[OrderLine] ADD
	CONSTRAINT [FK_ProductId] FOREIGN KEY ([ProductID]) REFERENCES [GStore].[Product] ([ProductID]) ON DELETE CASCADE ON UPDATE NO ACTION;
GO

ALTER TABLE [GStore].[Inventory] ADD
	CONSTRAINT [FK_InventoryStoreId] FOREIGN KEY ([StoreID]) REFERENCES [GStore].[Store] ([StoreID]) ON DELETE CASCADE ON UPDATE NO ACTION;
GO
ALTER TABLE [GStore].[Inventory] ADD
	CONSTRAINT [FK_InventoryProductId] FOREIGN KEY ([ProductID]) REFERENCES [GStore].[Product] ([ProductID]) ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- INSERT
--PRODUCTS
INSERT INTO [GStore].[Product] VALUES (N'Game Title', N'Super Mario Odyssey', 49.99);
INSERT INTO [GStore].[Product] VALUES (N'Game Title', N'Mario Kart 8 Deluxe', 49.99);
INSERT INTO [GStore].[Product] VALUES (N'Game Title', N'Persona 5 Royal', 59.99);
INSERT INTO [GStore].[Product] VALUES (N'Game Title', N'Marvel Spider-Man: Miles Morales, PS5', 49.99);
INSERT INTO [GStore].[Product] VALUES (N'Game Title', N'Resident Evil Village, Xbox Series X', 69.99);
INSERT INTO [GStore].[Product] VALUES (N'Console', N'Nintendo Switch Neon Blue and Neon Red', 299.99);
INSERT INTO [GStore].[Product] VALUES (N'Console', N'PlayStation 5', 499.99);
INSERT INTO [GStore].[Product] VALUES (N'Console', N'Xbox Series X', 499.99);
INSERT INTO [GStore].[Product] VALUES (N'Membership', N'Xbox Game Pass 3 Month Ultimate Membership', 49.99);
INSERT INTO [GStore].[Product] VALUES (N'Membership', N'PlayStation Plus 3 Month Membership', 24.99);
GO

-- DROP TABLE
--DROP TABLE [GStore].[OrderLine];
--DROP TABLE [GStore].[Order];
--DROP TABLE [GStore].[Customer];
--DROP TABLE [GStore].[Inventory];
--DROP TABLE [GStore].[Store];
--DROP TABLE [GStore].[Product];