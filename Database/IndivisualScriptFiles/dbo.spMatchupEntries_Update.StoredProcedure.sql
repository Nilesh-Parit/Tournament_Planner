USE [Tournament]
GO
/****** Object:  StoredProcedure [dbo].[spMatchupEntries_Update]    Script Date: 17-10-2024 11:49:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spMatchupEntries_Update]
	@Id int,
	@TeamCompetingId int = null,
	@Score float = null
AS
BEGIN

	SET NOCOUNT ON;

	UPDATE dbo.MatchupEntries
	SET TeamCompetingID = @TeamCompetingId,
	Score = @Score
	WHERE Id = @Id;

END
GO
