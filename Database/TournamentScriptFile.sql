USE [Tournament]
GO
/****** Object:  Table [dbo].[Matchup]    Script Date: 17-10-2024 11:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Matchup](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[WinnerID] [int] NULL,
	[MatchupRound] [int] NULL,
	[TournamentID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MatchupEntries]    Script Date: 17-10-2024 11:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MatchupEntries](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MatchupID] [int] NOT NULL,
	[ParentMatchupID] [int] NULL,
	[TeamCompetingID] [int] NULL,
	[Score] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[People]    Script Date: 17-10-2024 11:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[People](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastNAme] [nvarchar](50) NULL,
	[EmailAddress] [nvarchar](50) NULL,
	[Cellphone] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prizes]    Script Date: 17-10-2024 11:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prizes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PlaceNumber] [int] NULL,
	[PlaceName] [nvarchar](50) NULL,
	[PrizeAmount] [float] NULL,
	[PrizePercentage] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TeamMembers]    Script Date: 17-10-2024 11:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TeamMembers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TeamID] [int] NULL,
	[PersonID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teams]    Script Date: 17-10-2024 11:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teams](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TeamName] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TournamentEntries]    Script Date: 17-10-2024 11:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TournamentEntries](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TournamentID] [int] NULL,
	[TeamID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TournamentPrizes]    Script Date: 17-10-2024 11:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TournamentPrizes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TournamentID] [int] NULL,
	[PrizeID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tournaments]    Script Date: 17-10-2024 11:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tournaments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TournamentName] [nvarchar](50) NULL,
	[EntryFee] [float] NULL,
	[Active] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Matchup]  WITH CHECK ADD  CONSTRAINT [FK_Matchup_Teams] FOREIGN KEY([WinnerID])
REFERENCES [dbo].[Teams] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Matchup] CHECK CONSTRAINT [FK_Matchup_Teams]
GO
ALTER TABLE [dbo].[Matchup]  WITH CHECK ADD  CONSTRAINT [FK_Matchup_Tournaments] FOREIGN KEY([TournamentID])
REFERENCES [dbo].[Tournaments] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Matchup] CHECK CONSTRAINT [FK_Matchup_Tournaments]
GO
ALTER TABLE [dbo].[MatchupEntries]  WITH CHECK ADD  CONSTRAINT [FK_MatchupEntries_Matchup] FOREIGN KEY([MatchupID])
REFERENCES [dbo].[Matchup] ([Id])
GO
ALTER TABLE [dbo].[MatchupEntries] CHECK CONSTRAINT [FK_MatchupEntries_Matchup]
GO
ALTER TABLE [dbo].[MatchupEntries]  WITH CHECK ADD  CONSTRAINT [FK_MatchupEntries_ParentMatchup] FOREIGN KEY([ParentMatchupID])
REFERENCES [dbo].[Matchup] ([Id])
GO
ALTER TABLE [dbo].[MatchupEntries] CHECK CONSTRAINT [FK_MatchupEntries_ParentMatchup]
GO
ALTER TABLE [dbo].[MatchupEntries]  WITH CHECK ADD  CONSTRAINT [FK_MatchupEntries_Teams] FOREIGN KEY([TeamCompetingID])
REFERENCES [dbo].[Teams] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MatchupEntries] CHECK CONSTRAINT [FK_MatchupEntries_Teams]
GO
ALTER TABLE [dbo].[TeamMembers]  WITH CHECK ADD  CONSTRAINT [FK_TeamMembers_People] FOREIGN KEY([PersonID])
REFERENCES [dbo].[People] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TeamMembers] CHECK CONSTRAINT [FK_TeamMembers_People]
GO
ALTER TABLE [dbo].[TeamMembers]  WITH CHECK ADD  CONSTRAINT [FK_TeamMembers_Teams] FOREIGN KEY([TeamID])
REFERENCES [dbo].[Teams] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TeamMembers] CHECK CONSTRAINT [FK_TeamMembers_Teams]
GO
ALTER TABLE [dbo].[TournamentEntries]  WITH CHECK ADD  CONSTRAINT [FK_TournamentEntries_Teams] FOREIGN KEY([TeamID])
REFERENCES [dbo].[Teams] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TournamentEntries] CHECK CONSTRAINT [FK_TournamentEntries_Teams]
GO
ALTER TABLE [dbo].[TournamentEntries]  WITH CHECK ADD  CONSTRAINT [FK_TournamentEntries_Tournaments] FOREIGN KEY([TournamentID])
REFERENCES [dbo].[Tournaments] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TournamentEntries] CHECK CONSTRAINT [FK_TournamentEntries_Tournaments]
GO
ALTER TABLE [dbo].[TournamentPrizes]  WITH CHECK ADD  CONSTRAINT [FK_TournamentPrizes_Prizes] FOREIGN KEY([PrizeID])
REFERENCES [dbo].[Prizes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TournamentPrizes] CHECK CONSTRAINT [FK_TournamentPrizes_Prizes]
GO
ALTER TABLE [dbo].[TournamentPrizes]  WITH CHECK ADD  CONSTRAINT [FK_TournamentPrizes_Tournaments] FOREIGN KEY([TournamentID])
REFERENCES [dbo].[Tournaments] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TournamentPrizes] CHECK CONSTRAINT [FK_TournamentPrizes_Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spMatchupEntries_GetByMatchup]    Script Date: 17-10-2024 11:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spMatchupEntries_GetByMatchup]
	@MatchupId int
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT * FROM MatchupEntries
	WHERE MatchupID = @MatchupId;

END
GO
/****** Object:  StoredProcedure [dbo].[spMatchupEntries_Insert]    Script Date: 17-10-2024 11:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spMatchupEntries_Insert]
	@MatchupID int,
	@ParentMatchupID int,
	@TeamCompetingID int,
	@Id int = 0 OUTPUT
AS
BEGIN
	
	SET NOCOUNT ON;

	INSERT INTO
	dbo.MatchupEntries
	(MatchupID, ParentMatchupID, TeamCompetingID)
	VALUES
	(@MatchupID, @ParentMatchupID, @TeamCompetingID);
	
	SELECT @Id = SCOPE_IDENTITY();

END
GO
/****** Object:  StoredProcedure [dbo].[spMatchupEntries_Update]    Script Date: 17-10-2024 11:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spMatchupEntries_Update]
	@Id int,
	@TeamCompetingId int = null,
	@Score float = null
AS
BEGIN

	SET NOCOUNT ON;

	UPDATE dbo.MatchupEntries
	SET TeamCompetingID = @TeamCompetingId,
	Score = @Score
	WHERE Id = @Id;

END
GO
/****** Object:  StoredProcedure [dbo].[spMatchups_GetByTournament]    Script Date: 17-10-2024 11:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spMatchups_GetByTournament]
	@TournamentId int
AS
BEGIN
	
	SET NOCOUNT ON;
	
	SELECT m.*
	FROM 
	dbo.Matchup m
	WHERE
	m.TournamentID = @TournamentId 
	ORDER BY 
	MatchupRound;

END
GO
/****** Object:  StoredProcedure [dbo].[spMatchups_Insert]    Script Date: 17-10-2024 11:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spMatchups_Insert]
	@TournamentId int,
	@MatchupRound int,
	@Id int = 0 output
AS
BEGIN
	
	SET NOCOUNT ON;
	
	INSERT INTO dbo.Matchup(TournamentID,MatchupRound)
	VALUES (@TournamentId, @MatchupRound);

	SELECT @Id = SCOPE_IDENTITY();

END
GO
/****** Object:  StoredProcedure [dbo].[spMatchups_Update]    Script Date: 17-10-2024 11:20:48 ******/
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
/****** Object:  StoredProcedure [dbo].[spPeople_GetAll]    Script Date: 17-10-2024 11:20:48 ******/
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
/****** Object:  StoredProcedure [dbo].[spPerson_Insert]    Script Date: 17-10-2024 11:20:48 ******/
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
/****** Object:  StoredProcedure [dbo].[spPrizes_GetByTournament]    Script Date: 17-10-2024 11:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spPrizes_GetByTournament]
	@TournamentId int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT p.* 
	FROM 
	dbo.Prizes p
	INNER JOIN
	dbo.TournamentPrizes t 
	ON p.Id = t.PrizeID
	WHERE t.TournamentID = @TournamentId;
END
GO
/****** Object:  StoredProcedure [dbo].[spPrizes_Insert]    Script Date: 17-10-2024 11:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spPrizes_Insert]
	@PlaceNumber int,
	@PlaceName nvarchar(50),
	@PrizeAmount float,
	@PrizePercentage float,
	@id int = 0 output
AS
BEGIN
	
	SET NOCOUNT ON;
	
	INSERT INTO dbo.Prizes (PlaceNumber, PlaceName, PrizeAmount, PrizePercentage) 
	VALUES (@PlaceNumber, @PlaceName, @PrizeAmount, @PrizePercentage);

	SELECT @id = SCOPE_IDENTITY();

END
GO
/****** Object:  StoredProcedure [dbo].[spTeam_GetAll]    Script Date: 17-10-2024 11:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTeam_GetAll]

AS
BEGIN
	SET NOCOUNT ON 
	SELECT * FROM dbo.Teams;
END
GO
/****** Object:  StoredProcedure [dbo].[spTeam_GetByTournament]    Script Date: 17-10-2024 11:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTeam_GetByTournament]
	@TournamentId int
AS
BEGIN 

	SET NOCOUNT ON;

	SELECT t.*
	FROM
	dbo.Teams t
	INNER JOIN
	dbo.TournamentEntries e
	ON t.Id = e.TeamID
	WHERE
	e.TournamentID = @TournamentId;

END
GO
/****** Object:  StoredProcedure [dbo].[spTeamMember_Insert]    Script Date: 17-10-2024 11:20:48 ******/
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
/****** Object:  StoredProcedure [dbo].[spTeamMembers_GetByTeam]    Script Date: 17-10-2024 11:20:48 ******/
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
/****** Object:  StoredProcedure [dbo].[spTeams_Insert]    Script Date: 17-10-2024 11:20:48 ******/
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
/****** Object:  StoredProcedure [dbo].[spTournament_Complete]    Script Date: 17-10-2024 11:20:48 ******/
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
/****** Object:  StoredProcedure [dbo].[spTournament_GetAll]    Script Date: 17-10-2024 11:20:48 ******/
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
/****** Object:  StoredProcedure [dbo].[spTournamentEntries_Insert]    Script Date: 17-10-2024 11:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTournamentEntries_Insert]
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
/****** Object:  StoredProcedure [dbo].[spTournamentPrizes_Insert]    Script Date: 17-10-2024 11:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTournamentPrizes_Insert]

	@TournamentID int,
	@PrizeID int,
	@Id int = 0 output

AS
BEGIN
SET NOCOUNT ON;

	INSERT INTO TournamentPrizes 
	(TournamentID, PrizeID)
	VALUES (@TournamentID, @PrizeID);

	SELECT @Id = SCOPE_IDENTITY();

END
GO
/****** Object:  StoredProcedure [dbo].[spTournaments_Insert]    Script Date: 17-10-2024 11:20:48 ******/
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
/****** Object:  StoredProcedure [dbo].[TournamentEntries_Insert]    Script Date: 17-10-2024 11:20:48 ******/
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
