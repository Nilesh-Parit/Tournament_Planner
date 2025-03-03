USE [Tournament]
GO
/****** Object:  StoredProcedure [dbo].[spTeamMembers_GetByTeam]    Script Date: 17-10-2024 11:49:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTeamMembers_GetByTeam]
	@TeamId int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT p.* FROM dbo.TeamMembers m INNER JOIN dbo.People p ON m.PersonID = p.Id WHERE m.TeamID = @TeamId;
END
GO
