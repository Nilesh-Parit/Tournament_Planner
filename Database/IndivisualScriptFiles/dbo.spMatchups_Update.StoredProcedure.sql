USE [Tournament]
GO
/****** Object:  StoredProcedure [dbo].[spMatchups_Update]    Script Date: 17-10-2024 11:49:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spMatchups_Update]
	@Id int,
	@WinnerId int
AS
BEGIN

	SET NOCOUNT ON;

	UPDATE dbo.Matchup
	SET WinnerID = @WinnerId
	WHERE Id = @Id;

END
GO
