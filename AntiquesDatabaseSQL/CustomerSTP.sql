--This procedure creates a new customer
CREATE PROCEDURE sp_Customers_CreateCustomer
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

-- This procedure updates an existing customer
CREATE PROCEDURE sp_Customers_UpdateCustomer
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

--This procedure checks if a customerID is linked to any sales, ifnot, the customer row can be deleted
CREATE PROCEDURE sp_Customers_AllowCustomerDelete
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

-- This procedure deletes a customer row
CREATE PROCEDURE sp_Customers_DeleteCustomer
		@CustomerID INT
AS
BEGIN
	DELETE FROM Customers WHERE @CustomerID = CustomerID
END
GO

-- This precedure checks if a customer exists in the database
CREATE PROCEDURE sp_Customers_ExistsCustomer
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

-- This Procedure will display a customer's details, if 0 is entered, all customer details will be shown
CREATE PROCEDURE sp_Customers_GetCustomerDetails
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

