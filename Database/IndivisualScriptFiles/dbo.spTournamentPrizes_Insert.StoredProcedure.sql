USE [Tournament]
GO
/****** Object:  StoredProcedure [dbo].[spTournamentPrizes_Insert]    Script Date: 17-10-2024 11:49:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTournamentPrizes_Insert]

	@TournamentID int,
	@PrizeID int,
	@Id int = 0 output

AS
BEGIN
SET NOCOUNT ON;

	INSERT INTO TournamentPrizes 
	(TournamentID, PrizeID)
	VALUES (@TournamentID, @PrizeID);

	SELECT @Id = SCOPE_IDENTITY();

END
GO
