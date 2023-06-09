USE [S3API_DB]
GO
/****** Object:  Table [dbo].[PayloadData1]    Script Date: 18-May-23 3:28:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PayloadData1](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fullPowerMode] [bit] NULL,
	[activePowerControl] [bit] NULL,
	[firmwareVersion] [int] NULL,
	[temperature] [int] NULL,
	[humidity] [int] NULL,
 CONSTRAINT [PK_PayloadData] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PayloadData2]    Script Date: 18-May-23 3:28:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PayloadData2](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[version] [int] NULL,
	[messageType] [nvarchar](50) NULL,
	[firmwareVersion] [int] NULL,
	[occupancy] [bit] NULL,
	[stateChanged] [int] NULL,
 CONSTRAINT [PK_PayloadData2] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
