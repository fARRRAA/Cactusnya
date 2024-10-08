USE [WPFKOURS1]
GO
/****** Object:  Table [dbo].[Collection]    Script Date: 20.09.2024 19:11:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Collection](
	[Id_Collection] [int] IDENTITY(113,1) NOT NULL,
	[Id_Vystavka] [int] NOT NULL,
	[Id_Kaktus] [int] NOT NULL,
 CONSTRAINT [PK_Collection] PRIMARY KEY CLUSTERED 
(
	[Id_Collection] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kaktus]    Script Date: 20.09.2024 19:11:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kaktus](
	[Id_kaktus] [int] IDENTITY(100,1) NOT NULL,
	[Id_Type] [int] NOT NULL,
	[Otkuda] [nvarchar](50) NOT NULL,
	[Age] [int] NOT NULL,
	[Price] [int] NOT NULL,
	[Uhod] [nvarchar](100) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Kaktus] PRIMARY KEY CLUSTERED 
(
	[Id_kaktus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Logins]    Script Date: 20.09.2024 19:11:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Logins](
	[Id_Login] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Id_User] [int] NOT NULL,
	[Role] [nvarchar](50) NULL,
 CONSTRAINT [PK_Logins] PRIMARY KEY CLUSTERED 
(
	[Id_Login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Type]    Script Date: 20.09.2024 19:11:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Type](
	[Id_Type] [int] IDENTITY(1000,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Type] PRIMARY KEY CLUSTERED 
(
	[Id_Type] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 20.09.2024 19:11:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id_User] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id_User] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vystavka]    Script Date: 20.09.2024 19:11:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vystavka](
	[Id_Vystavka] [int] IDENTITY(51,1) NOT NULL,
	[Date] [date] NOT NULL,
	[Mesto] [nvarchar](50) NULL,
 CONSTRAINT [PK_Vystavka] PRIMARY KEY CLUSTERED 
(
	[Id_Vystavka] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Collection] ON 

INSERT [dbo].[Collection] ([Id_Collection], [Id_Vystavka], [Id_Kaktus]) VALUES (1116, 51, 100)
INSERT [dbo].[Collection] ([Id_Collection], [Id_Vystavka], [Id_Kaktus]) VALUES (1117, 51, 101)
INSERT [dbo].[Collection] ([Id_Collection], [Id_Vystavka], [Id_Kaktus]) VALUES (1118, 51, 102)
INSERT [dbo].[Collection] ([Id_Collection], [Id_Vystavka], [Id_Kaktus]) VALUES (1119, 51, 103)
INSERT [dbo].[Collection] ([Id_Collection], [Id_Vystavka], [Id_Kaktus]) VALUES (1120, 52, 100)
INSERT [dbo].[Collection] ([Id_Collection], [Id_Vystavka], [Id_Kaktus]) VALUES (1121, 52, 101)
INSERT [dbo].[Collection] ([Id_Collection], [Id_Vystavka], [Id_Kaktus]) VALUES (1122, 51, 105)
INSERT [dbo].[Collection] ([Id_Collection], [Id_Vystavka], [Id_Kaktus]) VALUES (1123, 53, 100)
INSERT [dbo].[Collection] ([Id_Collection], [Id_Vystavka], [Id_Kaktus]) VALUES (1124, 53, 101)
INSERT [dbo].[Collection] ([Id_Collection], [Id_Vystavka], [Id_Kaktus]) VALUES (1125, 53, 102)
INSERT [dbo].[Collection] ([Id_Collection], [Id_Vystavka], [Id_Kaktus]) VALUES (2114, 53, 105)
SET IDENTITY_INSERT [dbo].[Collection] OFF
GO
SET IDENTITY_INSERT [dbo].[Kaktus] ON 

INSERT [dbo].[Kaktus] ([Id_kaktus], [Id_Type], [Otkuda], [Age], [Price], [Uhod], [Name]) VALUES (100, 1003, N'Казахстан', 12, 24000, N'алылвалывавыталвыавы', N'кактус 1')
INSERT [dbo].[Kaktus] ([Id_kaktus], [Id_Type], [Otkuda], [Age], [Price], [Uhod], [Name]) VALUES (101, 1000, N'мо ыщс', 231, 12311, N'ммыс', N'кактус 2')
INSERT [dbo].[Kaktus] ([Id_kaktus], [Id_Type], [Otkuda], [Age], [Price], [Uhod], [Name]) VALUES (102, 1001, N'аво фщ', 121, 21312, N'мауаа', N'кактус 3')
INSERT [dbo].[Kaktus] ([Id_kaktus], [Id_Type], [Otkuda], [Age], [Price], [Uhod], [Name]) VALUES (103, 1003, N'аыоатоыв', 32, 1231, N'асусу', N'кактус 4')
INSERT [dbo].[Kaktus] ([Id_kaktus], [Id_Type], [Otkuda], [Age], [Price], [Uhod], [Name]) VALUES (105, 1005, N'ашшут', 302, 1312, N'тсуга уш', N'кактус 5')
INSERT [dbo].[Kaktus] ([Id_kaktus], [Id_Type], [Otkuda], [Age], [Price], [Uhod], [Name]) VALUES (1102, 1003, N'втош', 21, 2121, N'тшывтц', N'кактус 8')
INSERT [dbo].[Kaktus] ([Id_kaktus], [Id_Type], [Otkuda], [Age], [Price], [Uhod], [Name]) VALUES (2106, 1002, N'ццвцф', 2321, 313, N'сыус', N'кактус 10')
INSERT [dbo].[Kaktus] ([Id_kaktus], [Id_Type], [Otkuda], [Age], [Price], [Uhod], [Name]) VALUES (3101, 1002, N'aada', 1212, 12, N'asdasd', N'rsddwwqeew')
SET IDENTITY_INSERT [dbo].[Kaktus] OFF
GO
SET IDENTITY_INSERT [dbo].[Logins] ON 

INSERT [dbo].[Logins] ([Id_Login], [Login], [Password], [Id_User], [Role]) VALUES (1, N'Login1', N'12345', 2, N'user')
INSERT [dbo].[Logins] ([Id_Login], [Login], [Password], [Id_User], [Role]) VALUES (2, N'fara', N'123123', 1, N'admin')
INSERT [dbo].[Logins] ([Id_Login], [Login], [Password], [Id_User], [Role]) VALUES (3, N'login2', N'321321', 3, N'user')
INSERT [dbo].[Logins] ([Id_Login], [Login], [Password], [Id_User], [Role]) VALUES (4, N'fara1', N'1231231', 4, N'user')
INSERT [dbo].[Logins] ([Id_Login], [Login], [Password], [Id_User], [Role]) VALUES (5, N'test', N'test123', 1004, N'user')
INSERT [dbo].[Logins] ([Id_Login], [Login], [Password], [Id_User], [Role]) VALUES (6, N'ildar', N'ildar', 2004, N'user')
INSERT [dbo].[Logins] ([Id_Login], [Login], [Password], [Id_User], [Role]) VALUES (7, N'admin', N'admin', 3004, N'admin')
SET IDENTITY_INSERT [dbo].[Logins] OFF
GO
SET IDENTITY_INSERT [dbo].[Type] ON 

INSERT [dbo].[Type] ([Id_Type], [Name]) VALUES (1000, N'Крутые')
INSERT [dbo].[Type] ([Id_Type], [Name]) VALUES (1001, N'Долгожительные')
INSERT [dbo].[Type] ([Id_Type], [Name]) VALUES (1002, N'Сухие')
INSERT [dbo].[Type] ([Id_Type], [Name]) VALUES (1003, N'Красные')
INSERT [dbo].[Type] ([Id_Type], [Name]) VALUES (1004, N'Кайфовые')
INSERT [dbo].[Type] ([Id_Type], [Name]) VALUES (1005, N'Сухоцветы')
SET IDENTITY_INSERT [dbo].[Type] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id_User], [Name]) VALUES (1, N'fara')
INSERT [dbo].[Users] ([Id_User], [Name]) VALUES (2, N'user1')
INSERT [dbo].[Users] ([Id_User], [Name]) VALUES (3, N'user2')
INSERT [dbo].[Users] ([Id_User], [Name]) VALUES (4, N'fara1')
INSERT [dbo].[Users] ([Id_User], [Name]) VALUES (1004, N'test')
INSERT [dbo].[Users] ([Id_User], [Name]) VALUES (2004, N'ildar')
INSERT [dbo].[Users] ([Id_User], [Name]) VALUES (3004, N'admin')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET IDENTITY_INSERT [dbo].[Vystavka] ON 

INSERT [dbo].[Vystavka] ([Id_Vystavka], [Date], [Mesto]) VALUES (51, CAST(N'2006-12-11' AS Date), N'галеева 3а')
INSERT [dbo].[Vystavka] ([Id_Vystavka], [Date], [Mesto]) VALUES (52, CAST(N'2024-09-06' AS Date), N'ершова 32Б')
INSERT [dbo].[Vystavka] ([Id_Vystavka], [Date], [Mesto]) VALUES (53, CAST(N'2023-10-13' AS Date), N'Мамадышка 32')
INSERT [dbo].[Vystavka] ([Id_Vystavka], [Date], [Mesto]) VALUES (1052, CAST(N'2024-09-04' AS Date), N'красная полялна 323')
SET IDENTITY_INSERT [dbo].[Vystavka] OFF
GO
ALTER TABLE [dbo].[Collection]  WITH CHECK ADD  CONSTRAINT [FK_Collection_Kaktus] FOREIGN KEY([Id_Kaktus])
REFERENCES [dbo].[Kaktus] ([Id_kaktus])
GO
ALTER TABLE [dbo].[Collection] CHECK CONSTRAINT [FK_Collection_Kaktus]
GO
ALTER TABLE [dbo].[Collection]  WITH CHECK ADD  CONSTRAINT [FK_Collection_Vystavka] FOREIGN KEY([Id_Vystavka])
REFERENCES [dbo].[Vystavka] ([Id_Vystavka])
GO
ALTER TABLE [dbo].[Collection] CHECK CONSTRAINT [FK_Collection_Vystavka]
GO
ALTER TABLE [dbo].[Kaktus]  WITH CHECK ADD  CONSTRAINT [FK_Kaktus_Type] FOREIGN KEY([Id_Type])
REFERENCES [dbo].[Type] ([Id_Type])
GO
ALTER TABLE [dbo].[Kaktus] CHECK CONSTRAINT [FK_Kaktus_Type]
GO
ALTER TABLE [dbo].[Logins]  WITH CHECK ADD  CONSTRAINT [FK_Logins_Users] FOREIGN KEY([Id_User])
REFERENCES [dbo].[Users] ([Id_User])
GO
ALTER TABLE [dbo].[Logins] CHECK CONSTRAINT [FK_Logins_Users]
GO
