-- Insert statement for the Categories table
SET IDENTITY_INSERT [dbo].[Categories] ON
Insert into [Antiques].[dbo].[Categories]
			([CategoryID],
			[Category])
VALUES	(1, 'Under 18'),
		(2, '19-25'),
		(3, '26-29'),
		(4, '30-39'),
		(5, '40-49'),
		(6, '50-65'),
		(7, 'Above 65')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO

-- Insert table for the Customers table
SET IDENTITY_INSERT [dbo].[Customers] ON
Insert into [Antiques].[dbo].[Customers]
		([CustomerID],
		[CategoryID],
		[FirstName],
		[LastName],
		[Address],
		[Suburb],
		[State],
		[PostCode],
		[SendNewsletter])
		VALUES
		(1, 4, 'John', 'Smith', '1 Sunnydale St', 'Sunnydale', 'NSW', '2011', '0'),
		(2, 5, 'John', 'Smith', '72 Parramatta Rd' ,'Liechhardt', 'NSW', '2089', '0'),
		(3, 3, 'Mary', 'Jones', '15 Victoria Road', 'Ryde', 'NSW', '2013', '1'),
		(4, 6, 'Rick', 'Spanner', '6/4 Burns Bay Rd', 'Lane Cove', 'NSW', '2066', '1'),
		(5, 7, 'Tracy', 'Monahan', '23 Premier St', 'Kogarah', 'NSW', '2045', '0'),
		(6, 2, 'Sandra', 'Kindale', '7/36 Chiefly Ave', 'Surry Hills', 'NSW', '2030', '1'),
		(7, 5, 'Margaret', 'Wilson', '6 Fouveau St', 'Surry Hills', 'NSW', '2030', '1')
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO






-- Insert staement for the Sales table
SET IDENTITY_INSERT [dbo].[Sales] ON
Insert into [Antiques].[dbo].[Sales]
		([SaleID], [CustomerID], [SaleDate])
	VALUES
		(1, 1, '02-JUN-2016'),
		(2, 3, '02-JUN-2016'),
		(3, 4, '03-JUN-2016'),
		(4, 1, '04-JUN-2016'),
		(5, 5, '04-JUN-2016'),
		(6, 3, '06-JUN-2016'),
		(7, 2, '07-JUN-2016'),
		(8, 6, '07-JUN-2016'),
		(9, 7, '08-JUN-2016')
SET IDENTITY_INSERT [dbo].[Sales] OFF
GO

-- Insert statement for the Itemtypes table
SET IDENTITY_INSERT [dbo].[ItemTypes] ON
Insert Into [Antiques].[dbo].[ItemTypes]
		([TypeID], [Type])
VALUES	(1, 'Mens Jewellery'),
		(2, 'Mens Watch'),
		(3, 'Womens Jewellery'),
		(4, 'Womans Watch')
SET IDENTITY_INSERT [dbo].[ItemTypes] OFF
GO

-- Insert statement for the items table
SET IDENTITY_INSERT [dbo].[Items] ON
Insert Into [Antiques].[dbo].[Items]
		([ItemID], [TypeID], [ItemPrice], [ItemDescription], [ItemYear])
VALUES	(1, 1, 250, 'Gold Necklace', '1925'),
		(2, 3, 1250, 'Diamond Ring', '1898'),
		(3, 2, 560, 'Gold Watch', '1905'),
		(4, 3, 340, 'Gold Ring', '1889'),
		(5, 3, 275, 'Silver Necklace', '1876'),
		(6, 3, 245, 'Silver Bracelet', '1946'),
		(7, 3, 570, 'Gold Broach', '1901'),
		(8, 1, 375, 'Gold Bracelet', '1914'),
		(9, 3, 250, 'Gold Broach', '1949'),
		(10, 3, 2300, 'Diamond Ring', '1952'),
		(11, 3, 2500, 'Diamond Earrings', '1924'),
		(12, 3, 460, 'Pearl Earrings', '1936'),
		(13, 3, 550, 'Ruby Ring', '1915'),
		(14, 3, 780, 'Pearl Necklace', '1939'),
		(15, 1, 280, 'Gold Earnings', '1939'),
		(16, 4, 780, 'Silver Watch', '1936')
SET IDENTITY_INSERT [dbo].[Items] OFF
GO

-- Insert statement for the SalesItems table
Insert Into [Antiques].[dbo].[SalesItems]
	([SaleID], [ItemID])
VALUES	(1, 1),
		(1, 2),
		(2, 3),
		(3, 4),
		(3, 5),
		(3, 6),
		(4, 7),
		(5, 8),
		(5, 9),
		(6, 10),
		(6, 11),
		(7, 12),
		(7, 13),
		(8, 14),
		(9, 15),
		(9, 16)
GO



