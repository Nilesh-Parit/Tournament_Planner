USE [Tournament]
GO
/****** Object:  Table [dbo].[TournamentPrizes]    Script Date: 17-10-2024 11:49:41 ******/
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
