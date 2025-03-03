USE [Tournament]
GO
/****** Object:  StoredProcedure [dbo].[spMatchups_GetByTournament]    Script Date: 17-10-2024 11:49:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spMatchups_GetByTournament]
	@TournamentId int
AS
BEGIN
	
	SET NOCOUNT ON;
	
	SELECT m.*
	FROM 
	dbo.Matchup m
	WHERE
	m.TournamentID = @TournamentId 
	ORDER BY 
	MatchupRound;

END
GO
