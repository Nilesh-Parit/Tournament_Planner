USE [Tournament]
GO
/****** Object:  StoredProcedure [dbo].[spTournament_GetAll]    Script Date: 17-10-2024 11:49:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTournament_GetAll]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM dbo.Tournaments WHERE Active = 1;
END
GO
