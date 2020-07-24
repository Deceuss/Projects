
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Dyfan Batchelor
-- Create date: 28/07/2019
-- Description:	This Function Calculates the GST (Goods and Service Tax) of a product, given that the GST is 10% of the product's price
-- =============================================
CREATE FUNCTION fn_CalculateGST
(
	@ItemPrice money
)
RETURNS Money

AS
BEGIN
	
	DECLARE @GST money

	SET @GST =	@ItemPrice * 0.1
	RETURN @GST
	
END
GO


-- Creates a view displaying various sales information, including GST, which is calculated and displayed by passing the ItemID to the function 'fn_CalculateGST' written above
CREATE VIEW vw_SalesInformation
AS
SELECT dbo.Sales.SaleID, dbo.Sales.SaleDate, dbo.Customers.FirstName, dbo.Customers.LastName, dbo.Categories.Category, 
dbo.Items.ItemDescription, dbo.ItemTypes.Type, dbo.Items.ItemYear, dbo.Items.ItemPrice, dbo.fn_CalculateGST(Items.ItemPrice) AS GST, (dbo.Items.ItemPrice + dbo.fn_CalculateGST(Items.ItemPrice)) AS TotalSalePrice
FROM     dbo.Sales INNER JOIN
                  dbo.Categories INNER JOIN
                  dbo.Customers ON dbo.Categories.CategoryID = dbo.Customers.CategoryID ON dbo.Sales.CustomerID = dbo.Customers.CustomerID INNER JOIN
                  dbo.SalesItems ON dbo.Sales.SaleID = dbo.SalesItems.SaleID INNER JOIN
                  dbo.ItemTypes INNER JOIN
                  dbo.Items ON dbo.ItemTypes.TypeID = dbo.Items.TypeID ON dbo.SalesItems.ItemID = dbo.Items.ItemID