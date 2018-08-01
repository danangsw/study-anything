-- The Nested Set Model
USE [FamilyTree]
GO
/****** Object:  Table [dbo].[personNested]    Script Date: 2018/08/01 14:57:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[personNested](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[l_container] [int] NOT NULL,
	[r_container] [int] NOT NULL,
 CONSTRAINT [PK_personNested] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[personNested] ON 

GO
INSERT [dbo].[personNested] ([id], [name], [l_container], [r_container]) VALUES (1, N'Ayah', 1, 42)
GO
INSERT [dbo].[personNested] ([id], [name], [l_container], [r_container]) VALUES (2, N'Budi', 2, 27)
GO
INSERT [dbo].[personNested] ([id], [name], [l_container], [r_container]) VALUES (3, N'Cahyo', 29, 33)
GO
INSERT [dbo].[personNested] ([id], [name], [l_container], [r_container]) VALUES (4, N'Dadang', 34, 41)
GO
INSERT [dbo].[personNested] ([id], [name], [l_container], [r_container]) VALUES (5, N'Arif bin Budi', 3, 26)
GO
INSERT [dbo].[personNested] ([id], [name], [l_container], [r_container]) VALUES (6, N'Baba bin Budi', 27, 28)
GO
INSERT [dbo].[personNested] ([id], [name], [l_container], [r_container]) VALUES (7, N'Adi bin Cahyo', 30, 31)
GO
INSERT [dbo].[personNested] ([id], [name], [l_container], [r_container]) VALUES (8, N'Bani bin Cahyo', 32, 33)
GO
INSERT [dbo].[personNested] ([id], [name], [l_container], [r_container]) VALUES (9, N'Aba bin Dadang', 35, 36)
GO
INSERT [dbo].[personNested] ([id], [name], [l_container], [r_container]) VALUES (10, N'Banu bin Dadang', 37, 38)
GO
INSERT [dbo].[personNested] ([id], [name], [l_container], [r_container]) VALUES (11, N'Caca bin Dadang', 39, 40)
GO
INSERT [dbo].[personNested] ([id], [name], [l_container], [r_container]) VALUES (12, N'Amar bin Arif', 4, 5)
GO
INSERT [dbo].[personNested] ([id], [name], [l_container], [r_container]) VALUES (13, N'Amir bin Arif', 6, 25)
GO
INSERT [dbo].[personNested] ([id], [name], [l_container], [r_container]) VALUES (14, N'Edi bin Amir', 7, 8)
GO
INSERT [dbo].[personNested] ([id], [name], [l_container], [r_container]) VALUES (15, N'Edo bin Amir', 9, 24)
GO
INSERT [dbo].[personNested] ([id], [name], [l_container], [r_container]) VALUES (16, N'Alan bin Edo', 10, 11)
GO
INSERT [dbo].[personNested] ([id], [name], [l_container], [r_container]) VALUES (17, N'Ali bin Edo', 12, 23)
GO
INSERT [dbo].[personNested] ([id], [name], [l_container], [r_container]) VALUES (18, N'Jaja bin Ali', 13, 14)
GO
INSERT [dbo].[personNested] ([id], [name], [l_container], [r_container]) VALUES (19, N'Jali bin Ali', 15, 22)
GO
INSERT [dbo].[personNested] ([id], [name], [l_container], [r_container]) VALUES (20, N'Danu bin Jali', 16, 17)
GO
INSERT [dbo].[personNested] ([id], [name], [l_container], [r_container]) VALUES (21, N'Dani bin Jali', 18, 21)
GO
INSERT [dbo].[personNested] ([id], [name], [l_container], [r_container]) VALUES (22, N'Lalu bin Dani', 19, 20)
GO
SET IDENTITY_INSERT [dbo].[personNested] OFF
GO

