USE [Tournament]
GO
/****** Object:  StoredProcedure [dbo].[TournamentEntries_Insert]    Script Date: 17-10-2024 11:49:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TournamentEntries_Insert]
	@TournamentID int,
	@TeamID int,
	@Id int = 0 output
AS
BEGIN

	SET NOCOUNT ON;
	
	INSERT INTO TournamentEntries 
	(TournamentID, TeamID)
	VALUES (@TournamentID, @TeamID);

	SELECT @Id = SCOPE_IDENTITY();
	
END
GO
