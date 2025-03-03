USE [Tournament]
GO
/****** Object:  StoredProcedure [dbo].[spPrizes_GetByTournament]    Script Date: 17-10-2024 11:49:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spPrizes_GetByTournament]
	@TournamentId int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT p.* 
	FROM 
	dbo.Prizes p
	INNER JOIN
	dbo.TournamentPrizes t 
	ON p.Id = t.PrizeID
	WHERE t.TournamentID = @TournamentId;
END
GO
