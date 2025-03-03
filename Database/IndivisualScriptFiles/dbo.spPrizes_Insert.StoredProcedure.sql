USE [Tournament]
GO
/****** Object:  StoredProcedure [dbo].[spPrizes_Insert]    Script Date: 17-10-2024 11:49:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spPrizes_Insert]
	@PlaceNumber int,
	@PlaceName nvarchar(50),
	@PrizeAmount float,
	@PrizePercentage float,
	@id int = 0 output
AS
BEGIN
	
	SET NOCOUNT ON;
	
	INSERT INTO dbo.Prizes (PlaceNumber, PlaceName, PrizeAmount, PrizePercentage) 
	VALUES (@PlaceNumber, @PlaceName, @PrizeAmount, @PrizePercentage);

	SELECT @id = SCOPE_IDENTITY();

END
GO
