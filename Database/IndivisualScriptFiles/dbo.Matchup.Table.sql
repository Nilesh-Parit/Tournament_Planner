USE [Tournament]
GO
/****** Object:  Table [dbo].[Matchup]    Script Date: 17-10-2024 11:49:41 ******/
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
