-- 2.1 This Query lists the customer's name and address details.
SELECT FirstName AS [Customers.FirstName], LastName AS [Customers.LastName], Address AS [Customers.Address], State AS [Customers.State], PostCode AS [Customers.PostCode]
FROM     Customers
GO

-- 2.2 This query lists custome's name, address and the category they belong too.
SELECT Categories.Category AS [Categories.Category], Customers.FirstName AS [Customers.FirstName], Customers.LastName AS [Customers.LastName], Customers.Address AS [Customers.Address], Customers.State AS [Customers.State], 
                  Customers.PostCode AS [Customers.PostCode]
FROM     Categories INNER JOIN
                  Customers ON Categories.CategoryID = Customers.CategoryID
GO

-- 2.3 This query lists the item's description, year made, price and item type. Listing in Ascending order on the 'description' column, then in descending order on the 'year made' column.
SELECT Items.ItemDescription AS [Items.ItemDescription], Items.ItemYear AS [Items.ItemYear], Items.ItemPrice AS [Items.ItemPrice], ItemTypes.Type AS [ItemTypes.Type]
FROM     Items INNER JOIN
                  ItemTypes ON Items.TypeID = ItemTypes.TypeID
ORDER BY [Items.ItemDescription] ASC, [Items.ItemYear] DESC
GO

-- 2.4 This query lists customer's name and address details for customers who want to receive the newsletter.
SELECT FirstName AS [Customers.FirstName], LastName AS [Customers.LastName], Address AS [Customers.Address], State AS [Customers.State], PostCode AS [Customers.State], SendNewsletter AS [Customers.SendNewsletter]
FROM     Customers
WHERE  (SendNewsletter = 1)
GO

-- 2.5 This query lists the item's description, year made, price and item type where the made is before and including 1940, and the item type is either womens jewellery or womens watch.
SELECT Items.ItemPrice AS [Items.ItemPrice], Items.ItemDescription AS [Items.ItemDescription], Items.ItemYear AS [Items.ItemYear], ItemTypes.Type AS [ItemTypes.Type]
FROM     Items INNER JOIN
                  ItemTypes ON Items.TypeID = ItemTypes.TypeID
WHERE  Items.ItemYear <= '1940' AND (ItemTypes.TypeID = 3 OR ItemTypes.TypeID = 4)
ORDER BY Items.ItemDescription ASC, Items.ItemYear DESC
GO

-- 2.6 This query lists customer's name, address details and the category they belong to, for cusomers who are under the age of 50 and have a last name containing the letter S.
SELECT Categories.Category AS [Categories.Category], Customers.FirstName AS [Customers.FirstName], Customers.LastName AS [Customers.LastName], Customers.Address AS [Customers.Address], Customers.State AS [Customers.State], 
                  Customers.PostCode AS [Customers.PostCode]
FROM     Categories INNER JOIN
                  Customers ON Categories.CategoryID = Customers.CategoryID
WHERE  Categories.CategoryID <= 5 AND Customers.LastName LIKE '%s%'
GO

-- 2.7 This query lists the customer's name, sale date, item sold and the price for the sales made between 03 Jun 2016 and 06 Jun 2016. Orded by sale date.
SELECT Customers.FirstName AS [Customers.FirstName], Customers.LastName AS [Customers.LastName], Sales.SaleDate AS [Sales.SaleDate], Items.ItemDescription AS [Items.ItemDescription], Items.ItemPrice AS [Items.ItemPrice]
FROM     Customers INNER JOIN
                  Sales ON Customers.CustomerID = Sales.CustomerID INNER JOIN
                  SalesItems ON Sales.SaleID = SalesItems.SaleID INNER JOIN
                  Items ON SalesItems.ItemID = Items.ItemID
WHERE (Sales.SaleDate >= CONVERT(DATETIME, '2016-06-03 00:00:00', 102) AND Sales.SaleDate <= CONVERT(DATETIME, '2016-06-06 00:00:00', 102)
GO

-- 2.8 This query lists the minimum, maximum and average sale price for all items.
SELECT MAX(Items.ItemPrice) AS [Items.MaximumPrice], MIN(Items.ItemPrice) AS [Items.MinimumPrice], ROUND(AVG(Items.ItemPrice), 2) AS [Items.AveragePrice]
FROM     Items
GO

-- 2.9 This query lists the sale number, sale date, customer's name and the total sale price. Ordered by sale number
SELECT Sales.SaleID AS [Sales.SaleID], Sales.SaleDate AS [Sales.SaleDate], Customers.FirstName + ' ' + Customers.LastName AS [Customers.CustomerName], SUM(Items.ItemPrice) AS [Items.TotalPrice]
FROM     Items INNER JOIN
                  SalesItems ON Items.ItemID = SalesItems.ItemID INNER JOIN
                  Sales ON SalesItems.SaleID = Sales.SaleID INNER JOIN
                  Customers ON Sales.CustomerID = Customers.CustomerID
GROUP BY Sales.SaleID, Sales.SaleDate, Customers.FirstName + ' ' + Customers.LastName
ORDER BY Sales.SaleID ASC
GO

-- 2.10 This query displays the number of sales made between 03 Jun 2016 and 06 Jun 2016
SELECT COUNT(SaleID) as [Sales.SaleCount]
FROM Sales
WHERE (Sales.SaleDate > '03/06/2016') AND (Sales.SaleDate < '06/06/2016')
GO

-- 2.11 This query displays the first letter of a customer's first name combined with the customer's last name with a space in between. Also, it displays the length of the combined first and last name of the customer with a space between the first and last name.
SELECT LEFT(Customers.FirstName, 1) + ' ' + Customers.LastName AS [Customers.InitialWithLastName], LEN(Customers.FirstName + ' ' + Customers.LastName) AS [Customers.NameLength]
FROM     Customers
GO

-- 2.12 This query displays the number of days between the earliest sale date and the latest sale date.
SELECT DATEDIFF(dd, MIN(Sales.SaleDate), MAX(Sales.SaleDate)) AS [Sales.DateDifference]
FROM Sales
GO