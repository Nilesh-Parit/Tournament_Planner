USE [Tournament]
GO
/****** Object:  StoredProcedure [dbo].[spTeamMember_Insert]    Script Date: 17-10-2024 11:49:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTeamMember_Insert]
	@TeamID int,
	@PersonID int,
	@Id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO dbo.TeamMembers(TeamID,PersonID)VALUES(@TeamID,@PersonID);

	SELECT @Id = SCOPE_IDENTITY();

END
GO
