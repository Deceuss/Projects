USE [master]
GO
/****** Object:  Database [Antiques]    Script Date: 7/23/2019 9:47:51 PM ******/
CREATE DATABASE [Antiques]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Antiques', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Antiques.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Antiques_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Antiques_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Antiques] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Antiques].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Antiques] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Antiques] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Antiques] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Antiques] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Antiques] SET ARITHABORT OFF 
GO
ALTER DATABASE [Antiques] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Antiques] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Antiques] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Antiques] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Antiques] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Antiques] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Antiques] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Antiques] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Antiques] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Antiques] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Antiques] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Antiques] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Antiques] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Antiques] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Antiques] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Antiques] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Antiques] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Antiques] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Antiques] SET  MULTI_USER 
GO
ALTER DATABASE [Antiques] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Antiques] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Antiques] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Antiques] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Antiques] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Antiques]
GO
/****** Object:  User [Carlotta]    Script Date: 7/23/2019 9:47:51 PM ******/
CREATE USER [Carlotta] FOR LOGIN [Carlotta] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  DatabaseRole [Admin]    Script Date: 7/23/2019 9:47:51 PM ******/
CREATE ROLE [Admin]
GO
ALTER ROLE [Admin] ADD MEMBER [Carlotta]
GO
GRANT CONNECT TO [Carlotta] AS [dbo]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 7/23/2019 9:47:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[Category] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
GRANT DELETE ON [dbo].[Categories] TO [Admin] AS [dbo]
GO
GRANT INSERT ON [dbo].[Categories] TO [Admin] AS [dbo]
GO
GRANT SELECT ON [dbo].[Categories] TO [Admin] AS [dbo]
GO
GRANT UPDATE ON [dbo].[Categories] TO [Admin] AS [dbo]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 7/23/2019 9:47:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryID] [int] NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Address] [varchar](100) NOT NULL,
	[State] [varchar](3) NOT NULL,
	[PostCode] [int] NOT NULL,
	[SendNewsletter] [bit] NOT NULL,
	[Suburb] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
GRANT DELETE ON [dbo].[Customers] TO [Admin] AS [dbo]
GO
GRANT INSERT ON [dbo].[Customers] TO [Admin] AS [dbo]
GO
GRANT SELECT ON [dbo].[Customers] TO [Admin] AS [dbo]
GO
GRANT UPDATE ON [dbo].[Customers] TO [Admin] AS [dbo]
GO
/****** Object:  Table [dbo].[Items]    Script Date: 7/23/2019 9:47:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Items](
	[ItemID] [int] IDENTITY(1,1) NOT NULL,
	[TypeID] [int] NOT NULL,
	[ItemPrice] [money] NOT NULL,
	[ItemDescription] [varchar](100) NOT NULL,
	[ItemYear] [varchar](4) NOT NULL,
 CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
GRANT DELETE ON [dbo].[Items] TO [Admin] AS [dbo]
GO
GRANT INSERT ON [dbo].[Items] TO [Admin] AS [dbo]
GO
GRANT SELECT ON [dbo].[Items] TO [Admin] AS [dbo]
GO
GRANT UPDATE ON [dbo].[Items] TO [Admin] AS [dbo]
GO
/****** Object:  Table [dbo].[ItemTypes]    Script Date: 7/23/2019 9:47:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ItemTypes](
	[TypeID] [int] IDENTITY(1,1) NOT NULL,
	[Type] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ItemTypes] PRIMARY KEY CLUSTERED 
(
	[TypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
GRANT DELETE ON [dbo].[ItemTypes] TO [Admin] AS [dbo]
GO
GRANT INSERT ON [dbo].[ItemTypes] TO [Admin] AS [dbo]
GO
GRANT SELECT ON [dbo].[ItemTypes] TO [Admin] AS [dbo]
GO
GRANT UPDATE ON [dbo].[ItemTypes] TO [Admin] AS [dbo]
GO
/****** Object:  Table [dbo].[Sales]    Script Date: 7/23/2019 9:47:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sales](
	[SaleID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[SaleDate] [date] NOT NULL,
 CONSTRAINT [PK_Sales] PRIMARY KEY CLUSTERED 
(
	[SaleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
GRANT DELETE ON [dbo].[Sales] TO [Admin] AS [dbo]
GO
GRANT INSERT ON [dbo].[Sales] TO [Admin] AS [dbo]
GO
GRANT SELECT ON [dbo].[Sales] TO [Admin] AS [dbo]
GO
GRANT UPDATE ON [dbo].[Sales] TO [Admin] AS [dbo]
GO
/****** Object:  Table [dbo].[SalesItems]    Script Date: 7/23/2019 9:47:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesItems](
	[SaleID] [int] NOT NULL,
	[ItemID] [int] NOT NULL
) ON [PRIMARY]

GO
GRANT DELETE ON [dbo].[SalesItems] TO [Admin] AS [dbo]
GO
GRANT INSERT ON [dbo].[SalesItems] TO [Admin] AS [dbo]
GO
GRANT SELECT ON [dbo].[SalesItems] TO [Admin] AS [dbo]
GO
GRANT UPDATE ON [dbo].[SalesItems] TO [Admin] AS [dbo]
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Customers_Categories] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([CategoryID])
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_Customers_Categories]
GO
ALTER TABLE [dbo].[Items]  WITH CHECK ADD  CONSTRAINT [FK_Items_ItemTypes] FOREIGN KEY([TypeID])
REFERENCES [dbo].[ItemTypes] ([TypeID])
GO
ALTER TABLE [dbo].[Items] CHECK CONSTRAINT [FK_Items_ItemTypes]
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Customers] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
GO
ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [FK_Sales_Customers]
GO
ALTER TABLE [dbo].[SalesItems]  WITH CHECK ADD  CONSTRAINT [FK_SalesItems_Items] FOREIGN KEY([ItemID])
REFERENCES [dbo].[Items] ([ItemID])
GO
ALTER TABLE [dbo].[SalesItems] CHECK CONSTRAINT [FK_SalesItems_Items]
GO
ALTER TABLE [dbo].[SalesItems]  WITH CHECK ADD  CONSTRAINT [FK_SalesItems_Sales] FOREIGN KEY([SaleID])
REFERENCES [dbo].[Sales] ([SaleID])
GO
ALTER TABLE [dbo].[SalesItems] CHECK CONSTRAINT [FK_SalesItems_Sales]
GO
/****** Object:  StoredProcedure [dbo].[sp_Customers_AllowCustomerDelete]    Script Date: 7/23/2019 9:47:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--This procedure checks if a customerID is linked to any sales, ifnot, the customer row can be deleted
CREATE PROCEDURE [dbo].[sp_Customers_AllowCustomerDelete]
		@CustomerID INT,
		@RecordCount INT OUTPUT
AS
BEGIN
	DECLARE @tmpRecordCount INT

	SELECT @RecordCount = 0

	SELECT @tmpRecordCount = COUNT(*) FROM Sales WHERE CustomerID = @CustomerID
	IF @tmpRecordCount > 0
		SELECT @RecordCount = 1
END

GO
/****** Object:  StoredProcedure [dbo].[sp_Customers_CreateCustomer]    Script Date: 7/23/2019 9:47:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--This procedure creates a new customer
CREATE PROCEDURE [dbo].[sp_Customers_CreateCustomer]
	@CategoryID int,
	@FirstName varchar(50),
	@LastName varchar(50),
	@Address varchar(100),
	@Suburb varchar(100),
	@State varchar(3),
	@Postcode int,
	@SendNewsletter bit,
	@NewCustomerID INT OUTPUT
AS
BEGIN
	INSERT INTO Customers
		(CategoryID,
		FirstName,
		LastName,
		Address,
		Suburb,
		State,
		PostCode,
		SendNewsletter)
	VALUES
		(@CategoryID,
		@FirstName,
		@LastName,
		@Address,
		@Suburb,
		@State,
		@Postcode,
		@SendNewsletter)

	SELECT @NewCustomerID = @@IDENTITY

END

GO
/****** Object:  StoredProcedure [dbo].[sp_Customers_DeleteCustomer]    Script Date: 7/23/2019 9:47:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- This procedure deletes a customer row
CREATE PROCEDURE [dbo].[sp_Customers_DeleteCustomer]
		@CustomerID INT
AS
BEGIN
	DELETE FROM Customers WHERE @CustomerID = CustomerID
END

GO
/****** Object:  StoredProcedure [dbo].[sp_Customers_ExistsCustomer]    Script Date: 7/23/2019 9:47:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- This precedure checks if a customer exists in the database
CREATE PROCEDURE [dbo].[sp_Customers_ExistsCustomer]
	@FirstName varchar(50),
	@LastName varchar(50),
	@Address varchar(100),
	@Suburb varchar(100),
	@State varchar(3),
	@Postcode int,
	@RecordCount INT OUTPUT
AS
BEGIN
	SELECT @RecordCount = COUNT(*)
	FROM Customers
	WHERE FirstName = @FirstName
      AND LastName = @LastName
      AND Address = @Address
      AND Suburb = @Suburb
      AND State = @State
      AND Postcode = @Postcode

END

GO
/****** Object:  StoredProcedure [dbo].[sp_Customers_GetCustomerDetails]    Script Date: 7/23/2019 9:47:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- This Procedure will display a customer's details, if 0 is entered, all customer details will be shown
CREATE PROCEDURE [dbo].[sp_Customers_GetCustomerDetails]
		@CustomerID INT
AS
BEGIN
	IF @CustomerID = 0
		BEGIN
			SELECT * FROM Customers
			ORDER by FirstName, LastName
		END
	ELSE
		BEGIN
			SELECT * FROM Customers WHERE CustomerID = @CustomerID
		END
END

GO
/****** Object:  StoredProcedure [dbo].[sp_Customers_UpdateCustomer]    Script Date: 7/23/2019 9:47:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- This procedure updates an existing customer
CREATE PROCEDURE [dbo].[sp_Customers_UpdateCustomer]
		@CustomerID INT,
		@CategoryID int,
		@FirstName varchar(50),
		@LastName varchar(50),
		@Address varchar(100),
		@Suburb varchar(100),
		@State varchar(3),
		@Postcode int,
		@SendNewsletter bit
AS
BEGIN
	UPDATE Customers
	SET CategoryID = @CategoryID,
		FirstName = @FirstName,
		LastName = @LastName,
		Address = @Address,
		Suburb = @Suburb,
		State = @State,
		PostCode = @Postcode,
		SendNewsletter = @SendNewsletter
	WHERE CustomerID = @CustomerID
END

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'The Primary Key which is an Identity Key. Is a foreign key to table Customers' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Categories', @level2type=N'COLUMN',@level2name=N'CategoryID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Age bracket in which Customers will reside' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Categories', @level2type=N'COLUMN',@level2name=N'Category'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Primary Key For the Customers table, is a unique identifier for customers' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'CustomerID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign key for the related category to which the customer belongs too' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'CategoryID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Cusomter''s first name' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'FirstName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Customer''s last name' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'LastName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Cusotmer''s home address' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'Address'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'The state in which the Customer lives' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'State'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Cusotmer''s Post code' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'PostCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Whether or not the customer has chosen to receive the newsletter 1 = YES, 0 = NO' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'SendNewsletter'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Unique identifier for Items that are for sale' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Items', @level2type=N'COLUMN',@level2name=N'ItemID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Describes the type of each item' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Items', @level2type=N'COLUMN',@level2name=N'TypeID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'The price of the item' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Items', @level2type=N'COLUMN',@level2name=N'ItemPrice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Physical description of the item' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Items', @level2type=N'COLUMN',@level2name=N'ItemDescription'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'The year in which the item was made' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Items', @level2type=N'COLUMN',@level2name=N'ItemYear'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Unique identifier for each type of item' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ItemTypes', @level2type=N'COLUMN',@level2name=N'TypeID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Describes the type of jewellry and gender it was intended for' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ItemTypes', @level2type=N'COLUMN',@level2name=N'Type'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Primary identifier for sales' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sales', @level2type=N'COLUMN',@level2name=N'SaleID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign identity key linking the sale to a customer' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sales', @level2type=N'COLUMN',@level2name=N'CustomerID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Date of the sale' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sales', @level2type=N'COLUMN',@level2name=N'SaleDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key linking to the sales table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SalesItems', @level2type=N'COLUMN',@level2name=N'SaleID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key linking to the sales table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SalesItems', @level2type=N'COLUMN',@level2name=N'ItemID'
GO
USE [master]
GO
ALTER DATABASE [Antiques] SET  READ_WRITE 
GO
