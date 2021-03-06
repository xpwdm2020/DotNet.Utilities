USE [DB]
GO
/****** Object:  Table [dbo].[SysSample]    Script Date: 12/25/2014 12:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SysSample](
	[Id] [varchar](50) NOT NULL,
	[Name] [varchar](50) NULL,
	[Age] [int] NULL,
	[Bir] [datetime] NULL,
	[Photo] [varchar](50) NULL,
	[Note] [text] NULL,
	[CreateTime] [datetime] NULL,
 CONSTRAINT [PK__SysSampl__3214EC075AEE82B9] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Person]    Script Date: 12/25/2014 12:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[PName] [nvarchar](50) NOT NULL,
	[PAge] [smallint] NOT NULL,
	[PAddress] [nvarchar](50) NULL
) ON [PRIMARY]
GO
