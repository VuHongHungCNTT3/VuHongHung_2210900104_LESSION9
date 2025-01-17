USE [TRUONGANHQUAN_2210900058_LESSION9]
GO
/****** Object:  Table [dbo].[TaqKhoa]    Script Date: 6/26/2024 09:29:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaqKhoa](
	[TaqMakhoa] [nchar](10) NOT NULL,
	[TaqTenkhoa] [nvarchar](50) NULL,
	[TaqTrangThai] [bit] NULL,
 CONSTRAINT [PK_TaqKhoa] PRIMARY KEY CLUSTERED 
(
	[TaqMakhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaqSinhvien]    Script Date: 6/26/2024 09:29:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaqSinhvien](
	[TaqMaSV] [nvarchar](50) NOT NULL,
	[TaqHoSV] [nvarchar](50) NULL,
	[TaqTenSV] [nvarchar](50) NULL,
	[TaqNgaySinh] [date] NULL,
	[TaqPhai] [bit] NULL,
	[TaqPhone] [nchar](10) NULL,
	[TaqEmail] [nvarchar](50) NULL,
	[TaqMakhoa] [nchar](10) NULL,
 CONSTRAINT [PK_TaqSinhvien] PRIMARY KEY CLUSTERED 
(
	[TaqMaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[TaqKhoa] ([TaqMakhoa], [TaqTenkhoa], [TaqTrangThai]) VALUES (N'k22cnt3   ', NULL, NULL)
GO
INSERT [dbo].[TaqSinhvien] ([TaqMaSV], [TaqHoSV], [TaqTenSV], [TaqNgaySinh], [TaqPhai], [TaqPhone], [TaqEmail], [TaqMakhoa]) VALUES (N'2210900058', N'Truong', N'Anh Quan', CAST(N'2004-03-09' AS Date), 1, N'0869271802', N'Truonganhquan1111@gmail.com', NULL)
GO
