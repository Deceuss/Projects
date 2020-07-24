
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Dyfan Batchelor>
-- Description:	<Description,,Calculates GST>
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
