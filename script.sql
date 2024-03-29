USE [LastOne]
GO
/****** Object:  Table [dbo].[SinhViens]    Script Date: 12/4/2019 6:49:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhViens](
	[MaSinhVien] [nvarchar](128) NOT NULL,
	[HoTen] [nvarchar](max) NULL,
	[NgaySinh] [datetime] NOT NULL,
	[GioiTinh] [int] NOT NULL,
	[chuyennganh] [int] NOT NULL,
	[cn1] [real] NOT NULL,
	[cn2] [real] NOT NULL,
 CONSTRAINT [PK_dbo.SinhViens] PRIMARY KEY CLUSTERED 
(
	[MaSinhVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[SinhViens] ([MaSinhVien], [HoTen], [NgaySinh], [GioiTinh], [chuyennganh], [cn1], [cn2]) VALUES (N'14T1060121', N'Nghi Tâm', CAST(N'1996-12-04 07:30:50.000' AS DateTime), 1, 1, 6, 8)
INSERT [dbo].[SinhViens] ([MaSinhVien], [HoTen], [NgaySinh], [GioiTinh], [chuyennganh], [cn1], [cn2]) VALUES (N'15T1020123', N'Hồ Quý Bảo', CAST(N'1998-03-12 07:08:45.000' AS DateTime), 0, 2, 6, 8)
INSERT [dbo].[SinhViens] ([MaSinhVien], [HoTen], [NgaySinh], [GioiTinh], [chuyennganh], [cn1], [cn2]) VALUES (N'15T10214124', N'sang', CAST(N'1997-12-04 09:02:50.000' AS DateTime), 1, 0, 5, 6)
INSERT [dbo].[SinhViens] ([MaSinhVien], [HoTen], [NgaySinh], [GioiTinh], [chuyennganh], [cn1], [cn2]) VALUES (N'16T1021031', N'Trương Thành Đô', CAST(N'1991-10-25 00:00:00.000' AS DateTime), 0, 0, 2, 10)
INSERT [dbo].[SinhViens] ([MaSinhVien], [HoTen], [NgaySinh], [GioiTinh], [chuyennganh], [cn1], [cn2]) VALUES (N'16t1021034', N'Nguyễn Hữu Đức', CAST(N'1998-02-11 00:00:00.000' AS DateTime), 1, 2, 5, 5)
INSERT [dbo].[SinhViens] ([MaSinhVien], [HoTen], [NgaySinh], [GioiTinh], [chuyennganh], [cn1], [cn2]) VALUES (N'16T1021041', N'Lê Hồng Tấn Sang ', CAST(N'1998-11-25 00:00:00.000' AS DateTime), 1, 1, 7, 3)
INSERT [dbo].[SinhViens] ([MaSinhVien], [HoTen], [NgaySinh], [GioiTinh], [chuyennganh], [cn1], [cn2]) VALUES (N'17T1023121', N'Ngọc Tâm', CAST(N'1999-02-02 07:23:59.000' AS DateTime), 1, 2, 3, 7)
INSERT [dbo].[SinhViens] ([MaSinhVien], [HoTen], [NgaySinh], [GioiTinh], [chuyennganh], [cn1], [cn2]) VALUES (N'17T1024121', N'Quý Bảo', CAST(N'1999-02-02 07:20:57.000' AS DateTime), 1, 1, 9, 9)
