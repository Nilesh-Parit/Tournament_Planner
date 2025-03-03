USE [Tournament]
GO
/****** Object:  StoredProcedure [dbo].[spTournaments_Insert]    Script Date: 17-10-2024 11:49:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTournaments_Insert]
	
	@TournamentName nvarchar(50),
	@EntryFee float,
	@id int = 0 output

AS
BEGIN
SET NOCOUNT ON;

	INSERT INTO dbo.Tournaments
	(TournamentName, EntryFee, Active)
	VALUES(@TournamentName, @EntryFee, 1); 

	SELECT @Id = SCOPE_IDENTITY();

END
GO
