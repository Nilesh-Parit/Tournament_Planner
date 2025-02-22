USE [Tournament]
GO
/****** Object:  StoredProcedure [dbo].[spMatchupEntries_Insert]    Script Date: 17-10-2024 11:49:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spMatchupEntries_Insert]
	@MatchupID int,
	@ParentMatchupID int,
	@TeamCompetingID int,
	@Id int = 0 OUTPUT
AS
BEGIN
	
	SET NOCOUNT ON;

	INSERT INTO
	dbo.MatchupEntries
	(MatchupID, ParentMatchupID, TeamCompetingID)
	VALUES
	(@MatchupID, @ParentMatchupID, @TeamCompetingID);
	
	SELECT @Id = SCOPE_IDENTITY();

END
GO
