USE [Tournament]
GO
/****** Object:  StoredProcedure [dbo].[spMatchups_Insert]    Script Date: 17-10-2024 11:49:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spMatchups_Insert]
	@TournamentId int,
	@MatchupRound int,
	@Id int = 0 output
AS
BEGIN
	
	SET NOCOUNT ON;
	
	INSERT INTO dbo.Matchup(TournamentID,MatchupRound)
	VALUES (@TournamentId, @MatchupRound);

	SELECT @Id = SCOPE_IDENTITY();

END
GO
