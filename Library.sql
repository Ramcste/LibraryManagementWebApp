
USE [Library]
GO
/****** Object:  Table [dbo].[Book]    Script Date: 19-06-2015 11:30:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Book](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](150) NOT NULL,
	[Author] [varchar](50) NOT NULL,
	[Publisher] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Borrow_Return]    Script Date: 19-06-2015 11:30:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Borrow_Return](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Member_Id] [int] NOT NULL,
	[Book_Id] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Borrow] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Member]    Script Date: 19-06-2015 11:30:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Member](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Number] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Member] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Book] ON 

INSERT [dbo].[Book] ([Id], [Title], [Author], [Publisher]) VALUES (1, N'Data Communication', N'Rakibul Hasan Roni', N'Khan')
INSERT [dbo].[Book] ([Id], [Title], [Author], [Publisher]) VALUES (2, N'C #', N'Herbert Schedilt', N'PHI')
SET IDENTITY_INSERT [dbo].[Book] OFF
SET IDENTITY_INSERT [dbo].[Borrow_Return] ON 

INSERT [dbo].[Borrow_Return] ([Id], [Member_Id], [Book_Id]) VALUES (8, 102, N'2         ')
INSERT [dbo].[Borrow_Return] ([Id], [Member_Id], [Book_Id]) VALUES (10, 103, N'2         ')
INSERT [dbo].[Borrow_Return] ([Id], [Member_Id], [Book_Id]) VALUES (1003, 100, N'2         ')
INSERT [dbo].[Borrow_Return] ([Id], [Member_Id], [Book_Id]) VALUES (1004, 104, N'2         ')
SET IDENTITY_INSERT [dbo].[Borrow_Return] OFF
SET IDENTITY_INSERT [dbo].[Member] ON 

INSERT [dbo].[Member] ([Id], [Number], [Name]) VALUES (1, 100, N'Rambabu Kushwaha')
INSERT [dbo].[Member] ([Id], [Number], [Name]) VALUES (2, 101, N'Suresh Kumar')
INSERT [dbo].[Member] ([Id], [Number], [Name]) VALUES (3, 103, N'munir Mahamud')
INSERT [dbo].[Member] ([Id], [Number], [Name]) VALUES (1002, 104, N'Mizan')
INSERT [dbo].[Member] ([Id], [Number], [Name]) VALUES (1003, 105, N'Mahmud')
SET IDENTITY_INSERT [dbo].[Member] OFF
USE [master]
GO
ALTER DATABASE [Library] SET  READ_WRITE 
GO
