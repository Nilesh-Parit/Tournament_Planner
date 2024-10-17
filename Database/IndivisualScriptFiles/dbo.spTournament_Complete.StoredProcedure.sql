USE [Tournament]
GO
/****** Object:  StoredProcedure [dbo].[spTournament_Complete]    Script Date: 17-10-2024 11:49:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTournament_Complete]
	@Id int
AS
BEGIN
	
	SET NOCOUNT ON;

	UPDATE dbo.Tournaments
	SET Active = 0
	WHERE Id = @Id;

END
GO
