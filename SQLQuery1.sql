USE [school2]
GO
/****** Object:  Table [dbo].[user_details]    Script Date: 16/04/2016 15:41:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_details](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nchar](30) NULL,
	[password] [nchar](30) NULL,
	[usertype] [nchar](10) NULL,
 CONSTRAINT [PK_user_details] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[user_details] ON
INSERT [dbo].[user_details] ([id], [username], [password], [usertype]) VALUES (1, N'Admin                         ', N'admin                         ', N'Admin     ')
INSERT [dbo].[user_details] ([id], [username], [password], [usertype]) VALUES (2, N'Teacher                       ', N'teacher                       ', N'Teacher   ')
INSERT [dbo].[user_details] ([id], [username], [password], [usertype]) VALUES (3, N'Faculty                       ', N'faculty                       ', N'Teacher   ')
INSERT [dbo].[user_details] ([id], [username], [password], [usertype]) VALUES (4, N'Principal                     ', N'principal                     ', N'Admin     ')
SET IDENTITY_INSERT [dbo].[user_details] OFF
/****** Object:  Table [dbo].[student]    Script Date: 16/04/2016 15:41:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[student](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[studname] [nvarchar](50) NULL,
	[rollno] [int] NULL,
	[fathername] [nvarchar](50) NULL,
	[mothername] [nvarchar](50) NULL,
	[dob] [nvarchar](20) NULL,
	[gender] [nchar](10) NULL,
	[class] [nvarchar](15) NULL,
	[contact] [nvarchar](15) NULL,
	[hno] [nvarchar](50) NULL,
	[city] [nvarchar](50) NULL,
	[address1] [nvarchar](50) NULL,
	[address2] [nvarchar](50) NULL,
	[state] [nvarchar](50) NULL,
	[pincode] [nvarchar](50) NULL,
 CONSTRAINT [PK_student] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[student] ON
INSERT [dbo].[student] ([id], [studname], [rollno], [fathername], [mothername], [dob], [gender], [class], [contact], [hno], [city], [address1], [address2], [state], [pincode]) VALUES (1, N'Name12', 12, N'Father12', N'Mother12', N'12/DECEMBER/1990', N'Male      ', N'10th Class', N'1234567890', N'12', N'mirpur', N'lane1', N'lane2', N'dhaka', N'121212')
SET IDENTITY_INSERT [dbo].[student] OFF
/****** Object:  Table [dbo].[admission]    Script Date: 16/04/2016 15:41:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[admission](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[admissionid] [nchar](5) NULL,
	[admissiondate] [nchar](15) NULL,
	[name] [nvarchar](50) NULL,
	[fathername] [nvarchar](50) NULL,
	[mothername] [nvarchar](50) NULL,
	[dob] [nvarchar](50) NULL,
	[gender] [nchar](10) NULL,
	[address] [nvarchar](200) NULL,
	[admission_for] [nchar](15) NULL,
	[previous_schoolname] [nvarchar](300) NULL,
 CONSTRAINT [PK_admission] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[admission] ON
INSERT [dbo].[admission] ([id], [admissionid], [admissiondate], [name], [fathername], [mothername], [dob], [gender], [address], [admission_for], [previous_schoolname]) VALUES (1, N'001  ', N'15-04-2016     ', N'badhon', N'zaman', N'farzana', N'27/MARCH/1991', N'Male      ', N'anandonagor,
jalakabad,
dhaka', N'10th Class     ', N'mhschool')
INSERT [dbo].[admission] ([id], [admissionid], [admissiondate], [name], [fathername], [mothername], [dob], [gender], [address], [admission_for], [previous_schoolname]) VALUES (2, N'002  ', N'14-04-16       ', N'shuvo', N'Srinaryana', N'sridevi', N'3/MARCH/1992', N'Female    ', N'Takurgou', N'2nd Class      ', N'sk Public School')
SET IDENTITY_INSERT [dbo].[admission] OFF
