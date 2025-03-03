USE [Tournament]
GO
/****** Object:  Table [dbo].[Prizes]    Script Date: 17-10-2024 11:49:41 ******/
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
