USE [Tournament]
GO
/****** Object:  StoredProcedure [dbo].[spMatchupEntries_GetByMatchup]    Script Date: 17-10-2024 11:49:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spMatchupEntries_GetByMatchup]
	@MatchupId int
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT * FROM MatchupEntries
	WHERE MatchupID = @MatchupId;

END
GO
