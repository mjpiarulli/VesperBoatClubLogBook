SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Boat](
	[BoatId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Make] [varchar](50) NULL,
	[Size] [int] NOT NULL,
	[Type] [varchar](50) NOT NULL,
	[CurrentRigging] [varchar](50) NULL,
	[RiggingAvailable] [varchar](50) NULL,
	[UseRestrictions] [varchar](50) NULL,
	[Status] [varchar](50) NULL,
	[OwnedBy] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[BoatId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Boating]    Script Date: 1/20/2019 7:48:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Boating](
	[BoatingId] [int] IDENTITY(1,1) NOT NULL,
	[LogBookId] [int] NOT NULL,
	[MemberId] [int] NOT NULL,
	[Seat] [varchar](10) NULL,
	[Order] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[BoatingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BoatStatus]    Script Date: 1/20/2019 7:48:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BoatStatus](
	[BoatStatusId] [int] IDENTITY(1,1) NOT NULL,
	[Status] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[BoatStatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BoatStatusLog]    Script Date: 1/20/2019 7:48:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BoatStatusLog](
	[BoatStatusLogId] [int] IDENTITY(1,1) NOT NULL,
	[BoatName] [varchar](50) NULL,
	[Status] [varchar](50) NULL,
	[Comments] [varchar](max) NULL,
	[RemovalOfServiceDate] [datetime] NULL,
	[CommentOnReturn] [varchar](max) NULL,
	[ReturnToServiceDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[BoatStatusLogId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BoatType]    Script Date: 1/20/2019 7:48:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BoatType](
	[BoatTypeId] [int] IDENTITY(1,1) NOT NULL,
	[Type] [varchar](20) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Seats] [int] NOT NULL,
	[StartCount] [int] NOT NULL,
	[HasCox] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[BoatTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LogBook]    Script Date: 1/20/2019 7:48:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LogBook](
	[LogBookId] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime2](7) NULL,
	[TimeOut] [datetime2](7) NULL,
	[TimeIn] [datetime2](7) NULL,
	[MilesRowed] [int] NULL,
	[Comment] [varchar](max) NULL,
	[BoatName] [varchar](200) NULL,
	[BoatType] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[LogBookId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Member]    Script Date: 1/20/2019 7:48:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Member](
	[MemberId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NULL,
	[MiddleInitial] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MemberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rigging]    Script Date: 1/20/2019 7:48:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rigging](
	[RiggingId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RiggingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UseRestriction]    Script Date: 1/20/2019 7:48:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UseRestriction](
	[UseRestrictionId] [int] IDENTITY(1,1) NOT NULL,
	[Restriction] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UseRestrictionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Boat] ADD  DEFAULT ((0)) FOR [Size]
GO
ALTER TABLE [dbo].[Boating]  WITH CHECK ADD FOREIGN KEY([MemberId])
REFERENCES [dbo].[Member] ([MemberId])
GO
ALTER TABLE [dbo].[Boating]  WITH CHECK ADD FOREIGN KEY([LogBookId])
REFERENCES [dbo].[LogBook] ([LogBookId])
GO
