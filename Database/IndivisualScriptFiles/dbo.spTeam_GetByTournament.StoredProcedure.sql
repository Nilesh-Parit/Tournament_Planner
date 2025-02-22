USE [Tournament]
GO
/****** Object:  StoredProcedure [dbo].[spTeam_GetByTournament]    Script Date: 17-10-2024 11:49:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTeam_GetByTournament]
	@TournamentId int
AS
BEGIN 

	SET NOCOUNT ON;

	SELECT t.*
	FROM
	dbo.Teams t
	INNER JOIN
	dbo.TournamentEntries e
	ON t.Id = e.TeamID
	WHERE
	e.TournamentID = @TournamentId;

END
GO
