USE [TeacherDocs]
GO
/****** Object:  Table [dbo].[Class]    Script Date: 2023/3/7 12:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Class](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Class] [nvarchar](50) NULL,
	[Grade] [nvarchar](50) NULL,
	[InsertDate] [datetime] NULL,
 CONSTRAINT [PK_Class] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LabReport]    Script Date: 2023/3/7 12:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LabReport](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[TeacherId] [int] NULL,
	[TeacherName] [nvarchar](50) NULL,
	[Content] [nvarchar](max) NULL,
	[SubjectId] [int] NULL,
	[SubjectName] [nvarchar](50) NULL,
	[LabDate] [datetime] NULL,
	[InsertDate] [datetime] NULL,
	[StudentId] [int] NULL,
	[StudentName] [nvarchar](50) NULL,
 CONSTRAINT [PK_LabReport] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Material]    Script Date: 2023/3/7 12:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Material](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[SubjectId] [int] NULL,
	[SubjectName] [nvarchar](50) NULL,
	[Source] [nvarchar](50) NULL,
	[AuthorId] [int] NULL,
	[AuthorName] [nvarchar](50) NULL,
	[Content] [nvarchar](max) NULL,
	[InsertDate] [datetime] NULL,
 CONSTRAINT [PK_Material] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaperTest]    Script Date: 2023/3/7 12:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaperTest](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[SubjectId] [int] NULL,
	[SubjectName] [nvarchar](50) NULL,
	[TeacherId] [int] NULL,
	[TeacherName] [nvarchar](50) NULL,
	[ClassId] [int] NULL,
	[ClassName] [nvarchar](50) NULL,
	[Count] [int] NULL,
	[SumScore] [int] NULL,
	[TestTime] [datetime] NULL,
	[InsertDate] [datetime] NULL,
 CONSTRAINT [PK_PaperTest] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Score]    Script Date: 2023/3/7 12:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Score](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StudentId] [int] NULL,
	[StudentName] [nvarchar](50) NULL,
	[SubjectId] [int] NULL,
	[SubjectName] [nvarchar](50) NULL,
	[TestId] [int] NULL,
	[TestName] [nvarchar](50) NULL,
	[ScoreValue] [float] NULL,
	[InsertDate] [datetime] NULL,
 CONSTRAINT [PK_Score] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 2023/3/7 12:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Number] [nvarchar](50) NULL,
	[Name] [nvarchar](50) NOT NULL,
	[ClassId] [int] NULL,
	[ClassName] [nvarchar](50) NULL,
	[Telephone] [nvarchar](50) NULL,
	[Address] [nvarchar](150) NULL,
	[Email] [nvarchar](50) NULL,
	[Sex] [nvarchar](50) NULL,
	[InsertDate] [datetime] NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentWork]    Script Date: 2023/3/7 12:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentWork](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[WorkDate] [datetime] NULL,
	[Address] [nvarchar](50) NULL,
	[Student] [int] NULL,
	[StudentName] [nvarchar](50) NULL,
	[Content] [nvarchar](max) NULL,
	[InsertDate] [datetime] NULL,
 CONSTRAINT [PK_StudentWork] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudyCalender]    Script Date: 2023/3/7 12:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudyCalender](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TearcherName] [nvarchar](50) NULL,
	[TearcherId] [int] NULL,
	[Monday] [nvarchar](max) NULL,
	[Tuesday] [nvarchar](max) NULL,
	[Wednesday] [nvarchar](max) NULL,
	[Thursday] [nvarchar](max) NULL,
	[Friday] [nvarchar](max) NULL,
	[Saturday] [nvarchar](max) NULL,
	[Sunday] [nvarchar](max) NULL,
	[InsertDate] [datetime] NULL,
 CONSTRAINT [PK_StudyCalender] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subject]    Script Date: 2023/3/7 12:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subject](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Code] [nvarchar](50) NULL,
	[Info] [nvarchar](max) NULL,
	[TeacherName] [nvarchar](50) NULL,
	[TeacherId] [int] NULL,
	[Score] [int] NULL,
	[Date] [datetime] NULL,
	[CurrentStudent] [int] NULL,
	[Capacity] [int] NULL,
	[InsertDate] [datetime] NULL,
 CONSTRAINT [PK_Subject] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SubjectDesign]    Script Date: 2023/3/7 12:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubjectDesign](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[TeacherId] [int] NULL,
	[TeacherName] [nvarchar](50) NULL,
	[Content] [nvarchar](max) NULL,
	[SubjectId] [int] NULL,
	[SubjectName] [nvarchar](max) NULL,
	[DesignDate] [datetime] NULL,
	[InsertDate] [datetime] NULL,
 CONSTRAINT [PK_SubjectDesign] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 2023/3/7 12:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Number] [nvarchar](50) NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NULL,
	[Role] [int] NULL,
	[Telephone] [nvarchar](50) NULL,
	[Addresss] [nvarchar](250) NULL,
	[Email] [nvarchar](50) NULL,
	[JobTitle] [nvarchar](50) NULL,
	[Sex] [nvarchar](50) NULL,
	[InsertData] [datetime] NULL,
 CONSTRAINT [PK_dbo.Teacher] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TeachPlan]    Script Date: 2023/3/7 12:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TeachPlan](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[TeacherId] [int] NULL,
	[TeacherName] [nvarchar](50) NULL,
	[Content] [nvarchar](max) NULL,
	[SubjectId] [int] NULL,
	[SubjectName] [nvarchar](50) NULL,
	[InsertDate] [datetime] NULL,
 CONSTRAINT [PK_TeachPlan] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Test]    Script Date: 2023/3/7 12:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Test](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[InsertDate] [datetime] NULL,
 CONSTRAINT [PK_Test] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Class] ADD  CONSTRAINT [DF_Class_InsertDate]  DEFAULT (getdate()) FOR [InsertDate]
GO
ALTER TABLE [dbo].[LabReport] ADD  CONSTRAINT [DF_LabReport_LabDate]  DEFAULT (getdate()) FOR [LabDate]
GO
ALTER TABLE [dbo].[LabReport] ADD  CONSTRAINT [DF_LabReport_InsertDate]  DEFAULT (getdate()) FOR [InsertDate]
GO
ALTER TABLE [dbo].[Material] ADD  CONSTRAINT [DF_Material_InsertDate]  DEFAULT (getdate()) FOR [InsertDate]
GO
ALTER TABLE [dbo].[PaperTest] ADD  CONSTRAINT [DF_PaperTest_TestTime]  DEFAULT (getdate()) FOR [TestTime]
GO
ALTER TABLE [dbo].[PaperTest] ADD  CONSTRAINT [DF_PaperTest_InsertDate]  DEFAULT (getdate()) FOR [InsertDate]
GO
ALTER TABLE [dbo].[Score] ADD  CONSTRAINT [DF_Score_InsertDate]  DEFAULT (getdate()) FOR [InsertDate]
GO
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_InsertDate]  DEFAULT (getdate()) FOR [InsertDate]
GO
ALTER TABLE [dbo].[StudentWork] ADD  CONSTRAINT [DF_StudentWork_StudentName]  DEFAULT (getdate()) FOR [StudentName]
GO
ALTER TABLE [dbo].[StudentWork] ADD  CONSTRAINT [DF_StudentWork_InsertDate]  DEFAULT (getdate()) FOR [InsertDate]
GO
ALTER TABLE [dbo].[Subject] ADD  CONSTRAINT [DF_Subject_InsertDate]  DEFAULT (getdate()) FOR [InsertDate]
GO
ALTER TABLE [dbo].[SubjectDesign] ADD  CONSTRAINT [DF_SubjectDesign_DesignDate]  DEFAULT (getdate()) FOR [DesignDate]
GO
ALTER TABLE [dbo].[SubjectDesign] ADD  CONSTRAINT [DF_SubjectDesign_InsertDate]  DEFAULT (getdate()) FOR [InsertDate]
GO
ALTER TABLE [dbo].[TeachPlan] ADD  CONSTRAINT [DF_TeachPlan_InsertDate]  DEFAULT (getdate()) FOR [InsertDate]
GO
ALTER TABLE [dbo].[Test] ADD  CONSTRAINT [DF_Test_InsertDate]  DEFAULT (getdate()) FOR [InsertDate]
GO
