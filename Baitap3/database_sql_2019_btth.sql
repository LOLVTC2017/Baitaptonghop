USE [master]
GO
/****** Object:  Database [QLDG]    Script Date: 5/11/2022 8:31:34 PM ******/
CREATE DATABASE [QLDG]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLDG', FILENAME = N'D:\QLDG.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLDG_log', FILENAME = N'D:\QLDG_log.ldf' , SIZE = 2368KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QLDG] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLDG].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLDG] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLDG] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLDG] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLDG] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLDG] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLDG] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QLDG] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLDG] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLDG] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLDG] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLDG] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLDG] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLDG] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLDG] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLDG] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLDG] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLDG] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLDG] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLDG] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLDG] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLDG] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLDG] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLDG] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLDG] SET  MULTI_USER 
GO
ALTER DATABASE [QLDG] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLDG] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLDG] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLDG] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLDG] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLDG] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QLDG] SET QUERY_STORE = OFF
GO
USE [QLDG]
GO
/****** Object:  Table [dbo].[GIANGDAY]    Script Date: 5/11/2022 8:31:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIANGDAY](
	[MAGV] [nchar](10) NOT NULL,
	[MAMONHOC] [nchar](10) NOT NULL,
	[MALOP] [nchar](20) NOT NULL,
	[HOCKY] [int] NULL,
	[NAMHOC] [nchar](15) NULL,
	[SOTIET] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MAGV] ASC,
	[MAMONHOC] ASC,
	[MALOP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GIANGVIEN]    Script Date: 5/11/2022 8:31:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIANGVIEN](
	[MAGV] [nchar](10) NOT NULL,
	[HODEM] [nvarchar](50) NULL,
	[TENGV] [nvarchar](50) NULL,
	[NGAYSINH] [date] NULL,
	[HOCVI] [nvarchar](50) NULL,
	[DIACHI] [nvarchar](50) NULL,
	[DIENTHOAI] [nchar](10) NULL,
	[HSLUONG] [float] NULL,
	[SOGIOCHUAN] [nchar](10) NULL,
	[MAKHOA] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MAGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHOA]    Script Date: 5/11/2022 8:31:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHOA](
	[MAKHOA] [nchar](10) NOT NULL,
	[TENKHOA] [nvarchar](50) NULL,
	[DIENTHOAI] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MAKHOA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOP]    Script Date: 5/11/2022 8:31:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOP](
	[MALOP] [nchar](20) NOT NULL,
	[TENLOP] [nvarchar](50) NULL,
	[KHOA] [int] NULL,
	[HEDAOTAO] [nvarchar](50) NULL,
	[NAMNHAPHOC] [nchar](10) NULL,
	[SISO] [int] NULL,
	[MAKHOA] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MALOP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MONHOC]    Script Date: 5/11/2022 8:31:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MONHOC](
	[MAMONHOC] [nchar](10) NOT NULL,
	[TENMONHOC] [nvarchar](50) NULL,
	[SODVHT] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MAMONHOC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 5/11/2022 8:31:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[TENND] [nchar](50) NULL,
	[MATKHAU] [nchar](50) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[GIANGDAY] ([MAGV], [MAMONHOC], [MALOP], [HOCKY], [NAMHOC], [SOTIET]) VALUES (N'GV1       ', N'AD        ', N'CDLTK15CNTT         ', 2, N'2022           ', 200)
INSERT [dbo].[GIANGDAY] ([MAGV], [MAMONHOC], [MALOP], [HOCKY], [NAMHOC], [SOTIET]) VALUES (N'GV1       ', N'PY        ', N'CDLTK15CNTT         ', 2, N'2022           ', 120)
INSERT [dbo].[GIANGDAY] ([MAGV], [MAMONHOC], [MALOP], [HOCKY], [NAMHOC], [SOTIET]) VALUES (N'GV2       ', N'TH        ', N'TCK14NVNH           ', 1, N'2021           ', 80)
INSERT [dbo].[GIANGDAY] ([MAGV], [MAMONHOC], [MALOP], [HOCKY], [NAMHOC], [SOTIET]) VALUES (N'GV3       ', N'CT        ', N'CDK15KTCBMA         ', 2, N'2020           ', 70)
GO
INSERT [dbo].[GIANGVIEN] ([MAGV], [HODEM], [TENGV], [NGAYSINH], [HOCVI], [DIACHI], [DIENTHOAI], [HSLUONG], [SOGIOCHUAN], [MAKHOA]) VALUES (N'GV1       ', N'Lâm Bá', N'Lam Man', CAST(N'1985-06-14' AS Date), N'Đại Học', N'Quy Nhơn, Bình Định', N'0905119950', 2.440000057220459, N'300       ', N'CN        ')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HODEM], [TENGV], [NGAYSINH], [HOCVI], [DIACHI], [DIENTHOAI], [HSLUONG], [SOGIOCHUAN], [MAKHOA]) VALUES (N'GV2       ', N'Trần Thị', N'Tuyết Mai', CAST(N'1990-02-04' AS Date), N'Đại Học', N'Quy Nhơn, Bình Định', N'0968150247', 2.42, N'260       ', N'DL        ')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HODEM], [TENGV], [NGAYSINH], [HOCVI], [DIACHI], [DIENTHOAI], [HSLUONG], [SOGIOCHUAN], [MAKHOA]) VALUES (N'GV3       ', N'Nguyễn Ngọc', N'Minh', CAST(N'1983-10-18' AS Date), N'Đại Học', N'Quy Nhơn, Bình Định', N'0396277810', 2.4, N'275       ', N'CK        ')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HODEM], [TENGV], [NGAYSINH], [HOCVI], [DIACHI], [DIENTHOAI], [HSLUONG], [SOGIOCHUAN], [MAKHOA]) VALUES (N'GV4       ', N'Đào', N'Thanh Mây', CAST(N'2022-05-11' AS Date), N'Đại Học', NULL, N'0339190580', 2.45, N'260       ', N'CN        ')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HODEM], [TENGV], [NGAYSINH], [HOCVI], [DIACHI], [DIENTHOAI], [HSLUONG], [SOGIOCHUAN], [MAKHOA]) VALUES (N'GV6       ', N'Nguyễn Tành', N'Pú', CAST(N'2022-05-11' AS Date), N'Đại Hou', NULL, N'0126261200', 2.51, N'222       ', N'CK        ')
GO
INSERT [dbo].[KHOA] ([MAKHOA], [TENKHOA], [DIENTHOAI]) VALUES (N'CK        ', N'Cơ Khí - Máy Móc', N'0902937642')
INSERT [dbo].[KHOA] ([MAKHOA], [TENKHOA], [DIENTHOAI]) VALUES (N'CN        ', N'Điện Tử - Tin Học', N'0905036812')
INSERT [dbo].[KHOA] ([MAKHOA], [TENKHOA], [DIENTHOAI]) VALUES (N'DL        ', N'Du Lịch - Dịch Vụ', N'0969221754')
GO
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [KHOA], [HEDAOTAO], [NAMNHAPHOC], [SISO], [MAKHOA]) VALUES (N'CDK15KTCBMA         ', N'Cao Đẳng K15 Nghiệp Vụ Nhà Hàng', 15, N'Cao Đẳng', N'2021      ', 26, N'DL        ')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [KHOA], [HEDAOTAO], [NAMNHAPHOC], [SISO], [MAKHOA]) VALUES (N'CDLTK15CNTT         ', N'Cao Đẳng LT K15 Công Nghệ Thông Tin', 15, N'Cao Đẳng', N'2019      ', 15, N'CN        ')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [KHOA], [HEDAOTAO], [NAMNHAPHOC], [SISO], [MAKHOA]) VALUES (N'TCK14NVNH           ', N'Trung Cấp K14 Chế Tạo Thiết Bị Cơ Khí', 14, N'Trung Cấp', N'2020      ', 30, N'CK        ')
GO
INSERT [dbo].[MONHOC] ([MAMONHOC], [TENMONHOC], [SODVHT]) VALUES (N'AD        ', N'Lập trình ứng dụng Android', 30)
INSERT [dbo].[MONHOC] ([MAMONHOC], [TENMONHOC], [SODVHT]) VALUES (N'CT        ', N'Chính Trị', 16)
INSERT [dbo].[MONHOC] ([MAMONHOC], [TENMONHOC], [SODVHT]) VALUES (N'PY        ', N'Lập Trình Python', 20)
INSERT [dbo].[MONHOC] ([MAMONHOC], [TENMONHOC], [SODVHT]) VALUES (N'TH        ', N'Tin Học', 23)
GO
INSERT [dbo].[TAIKHOAN] ([TENND], [MATKHAU]) VALUES (N'AdminSC01                                         ', N'WeareVenom123                                     ')
GO
ALTER TABLE [dbo].[GIANGDAY]  WITH CHECK ADD FOREIGN KEY([MAGV])
REFERENCES [dbo].[GIANGVIEN] ([MAGV])
GO
ALTER TABLE [dbo].[GIANGDAY]  WITH CHECK ADD FOREIGN KEY([MALOP])
REFERENCES [dbo].[LOP] ([MALOP])
GO
ALTER TABLE [dbo].[GIANGDAY]  WITH CHECK ADD FOREIGN KEY([MAMONHOC])
REFERENCES [dbo].[MONHOC] ([MAMONHOC])
GO
ALTER TABLE [dbo].[LOP]  WITH CHECK ADD FOREIGN KEY([MAKHOA])
REFERENCES [dbo].[KHOA] ([MAKHOA])
GO
ALTER TABLE [dbo].[GIANGVIEN]  WITH CHECK ADD  CONSTRAINT [chk_phone] CHECK  (([DIENTHOAI] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[GIANGVIEN] CHECK CONSTRAINT [chk_phone]
GO
ALTER TABLE [dbo].[KHOA]  WITH CHECK ADD  CONSTRAINT [chk_phoEne] CHECK  (([DIENTHOAI] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[KHOA] CHECK CONSTRAINT [chk_phoEne]
GO
/****** Object:  StoredProcedure [dbo].[CapNhatThongTinGiangVien]    Script Date: 5/11/2022 8:31:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CapNhatThongTinGiangVien]
(@magv nvarchar (50),@hodem nvarchar(50),@tengv nvarchar(50),@ngaysinh date,@hocvi nvarchar(50)
,@dienthoai nchar(10),@hsl float,@sgc nchar(10))
as 
update GIANGVIEN 
set TENGV =@tengv,HODEM = @hodem,NGAYSINH =@ngaysinh,HOCVI=@hocvi,dienthoai=@dienthoai
,HSLUONG=@hsl,SOGIOCHUAN =@sgc
where MAGV =@magv
GO
/****** Object:  StoredProcedure [dbo].[GetThongKeHday]    Script Date: 5/11/2022 8:31:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetThongKeHday] (@magv nvarchar(10)) as
select MONHOC.MAMONHOC,TENMONHOC,lop.TENLOP,GIANGDAY.SOTIET from MONHOC
inner join GIANGDAY on MONHOC.MAMONHOC = GIANGDAY.MAMONHOC
inner join LOP on GIANGDAY.MALOP =LOP.MALOP
where MAGV = @magv
GO
/****** Object:  StoredProcedure [dbo].[LK_GIODAY]    Script Date: 5/11/2022 8:31:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LK_GIODAY] (@MAGV NCHAR(10))
AS SELECT GIANGDAY.MAMONHOC, TENMONHOC, TENLOP, SOTIET FROM GIANGDAY, LOP, MONHOC 
WHERE GIANGDAY.MALOP = LOP.MALOP AND MONHOC.MAMONHOC = GIANGDAY.MAMONHOC
AND MAGV = @MAGV
GO
/****** Object:  StoredProcedure [dbo].[LoadGiangVienBangMaKhoa]    Script Date: 5/11/2022 8:31:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LoadGiangVienBangMaKhoa](@MAKHOA nchar(10))as
select * from GIANGVIEN
inner join KHOA on GIANGVIEN.MAKHOA = KHOA.MAKHOA
where KHOA.MAKHOA = @MAKHOA
GO
/****** Object:  StoredProcedure [dbo].[LuuThongTinGiangVien]    Script Date: 5/11/2022 8:31:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LuuThongTinGiangVien]
(@magv nvarchar (50),@hodem nvarchar(50),@tengv nvarchar(50),@ngaysinh date,@hocvi nvarchar(50)
,@dienthoai nchar(10),@hsl float,@sgc nchar(10),@makhoa nchar(10))
as 
update GIANGVIEN 
set TENGV =@tengv,HODEM = @hodem,NGAYSINH =@ngaysinh,HOCVI=@hocvi,dienthoai=@dienthoai
,HSLUONG=@hsl,SOGIOCHUAN =@sgc,MAKHOA = @makhoa
where MAGV =@magv
GO
USE [master]
GO
ALTER DATABASE [QLDG] SET  READ_WRITE 
GO
