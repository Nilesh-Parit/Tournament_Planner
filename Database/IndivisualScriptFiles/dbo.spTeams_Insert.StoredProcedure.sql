USE [Tournament]
GO
/****** Object:  StoredProcedure [dbo].[spTeams_Insert]    Script Date: 17-10-2024 11:49:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTeams_Insert]
	@TeamName nvarchar(50),
	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO dbo.Teams(TeamName)VALUES(@TeamName);

	SELECT @id = SCOPE_IDENTITY();

END
GO
