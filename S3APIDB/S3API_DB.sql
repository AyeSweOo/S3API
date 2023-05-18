USE [S3API_DB]
GO
/****** Object:  Table [dbo].[PayloadData]    Script Date: 18-May-23 12:49:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PayloadData](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FullPowerMode] [bit] NULL,
	[ActivePowerControl] [bit] NULL,
	[FirmwareVersion] [int] NULL,
	[Temperature] [int] NULL,
	[Humidity] [int] NULL,
	[Occupancy] [int] NULL,
 CONSTRAINT [PK_PayloadData] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
