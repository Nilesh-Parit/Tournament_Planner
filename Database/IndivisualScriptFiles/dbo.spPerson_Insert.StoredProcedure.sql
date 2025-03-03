USE [Tournament]
GO
/****** Object:  StoredProcedure [dbo].[spPerson_Insert]    Script Date: 17-10-2024 11:49:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spPerson_Insert]
	@FirstName nvarchar(50),
	@LastName nvarchar(100),
	@EmailAddress nvarchar(100),
	@Cellphone nvarchar(100),
	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO dbo.People (FirstName, LastNAme, EmailAddress, Cellphone)
	VALUES (@FirstName, @LastName, @EmailAddress, @Cellphone);

	select @id = SCOPE_IDENTITY();

END
GO
