USE [Tournament]
GO
/****** Object:  StoredProcedure [dbo].[spPeople_GetAll]    Script Date: 17-10-2024 11:49:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spPeople_GetAll]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * from dbo.People;
END
GO
