USE [FamilyTree]
GO
/****** Object:  Table [dbo].[person]    Script Date: 2018/08/01 11:00:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[person](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NULL,
	[parent_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[person] ON 

GO
INSERT [dbo].[person] ([id], [name], [parent_id]) VALUES (1, N'Ayah', NULL)
GO
INSERT [dbo].[person] ([id], [name], [parent_id]) VALUES (2, N'Budi', 1)
GO
INSERT [dbo].[person] ([id], [name], [parent_id]) VALUES (3, N'Cahyo', 1)
GO
INSERT [dbo].[person] ([id], [name], [parent_id]) VALUES (4, N'Dadang', 1)
GO
INSERT [dbo].[person] ([id], [name], [parent_id]) VALUES (5, N'Arif bin Budi', 2)
GO
INSERT [dbo].[person] ([id], [name], [parent_id]) VALUES (6, N'Baba bin Budi', 2)
GO
INSERT [dbo].[person] ([id], [name], [parent_id]) VALUES (7, N'Adi bin Cahyo', 3)
GO
INSERT [dbo].[person] ([id], [name], [parent_id]) VALUES (8, N'Bani bin Cahyo', 3)
GO
INSERT [dbo].[person] ([id], [name], [parent_id]) VALUES (9, N'Aba bin Dadang', 4)
GO
INSERT [dbo].[person] ([id], [name], [parent_id]) VALUES (10, N'Banu bin Dadang', 4)
GO
INSERT [dbo].[person] ([id], [name], [parent_id]) VALUES (11, N'Caca bin Dadang', 4)
GO
INSERT [dbo].[person] ([id], [name], [parent_id]) VALUES (12, N'Amar bin Arif', 5)
GO
INSERT [dbo].[person] ([id], [name], [parent_id]) VALUES (13, N'Amir bin Arif', 5)
GO
INSERT [dbo].[person] ([id], [name], [parent_id]) VALUES (14, N'Edi bin Amir', 13)
GO
INSERT [dbo].[person] ([id], [name], [parent_id]) VALUES (15, N'Edo bin Amir', 13)
GO
INSERT [dbo].[person] ([id], [name], [parent_id]) VALUES (16, N'Alan bin Edo', 15)
GO
INSERT [dbo].[person] ([id], [name], [parent_id]) VALUES (17, N'Ali bin Edo', 15)
GO
INSERT [dbo].[person] ([id], [name], [parent_id]) VALUES (18, N'Jaja bin Ali', 17)
GO
INSERT [dbo].[person] ([id], [name], [parent_id]) VALUES (19, N'Jali bin Ali', 17)
GO
INSERT [dbo].[person] ([id], [name], [parent_id]) VALUES (20, N'Danu bin Jali', 19)
GO
INSERT [dbo].[person] ([id], [name], [parent_id]) VALUES (21, N'Dani bin Jali', 19)
GO
INSERT [dbo].[person] ([id], [name], [parent_id]) VALUES (22, N'Lalu bin Dani', 21)
GO
SET IDENTITY_INSERT [dbo].[person] OFF
GO
ALTER TABLE [dbo].[person]  WITH CHECK ADD  CONSTRAINT [FK_person_parent_id] FOREIGN KEY([parent_id])
REFERENCES [dbo].[person] ([id])
GO
ALTER TABLE [dbo].[person] CHECK CONSTRAINT [FK_person_parent_id]
GO
