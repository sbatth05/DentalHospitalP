USE [master]
GO
/****** Object:  Database [DentalHospital]    Script Date: 9/22/2020 3:43:49 AM ******/
CREATE DATABASE [DentalHospital]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DentalHospital_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\DentalHospital.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DentalHospital_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\DentalHospital.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DentalHospital] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DentalHospital].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DentalHospital] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DentalHospital] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DentalHospital] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DentalHospital] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DentalHospital] SET ARITHABORT OFF 
GO
ALTER DATABASE [DentalHospital] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DentalHospital] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DentalHospital] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DentalHospital] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DentalHospital] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DentalHospital] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DentalHospital] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DentalHospital] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DentalHospital] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DentalHospital] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DentalHospital] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DentalHospital] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DentalHospital] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DentalHospital] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DentalHospital] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DentalHospital] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DentalHospital] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DentalHospital] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DentalHospital] SET  MULTI_USER 
GO
ALTER DATABASE [DentalHospital] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DentalHospital] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DentalHospital] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DentalHospital] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DentalHospital] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DentalHospital] SET QUERY_STORE = OFF
GO
USE [DentalHospital]
GO
/****** Object:  Table [dbo].[Appointment_Table]    Script Date: 9/22/2020 3:43:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointment_Table](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[Contact] [varchar](50) NULL,
	[Appointment] [varchar](50) NULL,
 CONSTRAINT [PK_Appointment_Table] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contact_Table]    Script Date: 9/22/2020 3:43:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contact_Table](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Contact] [varchar](50) NULL,
	[Message] [varchar](50) NULL,
 CONSTRAINT [PK_Contact_Table] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctor_Table]    Script Date: 9/22/2020 3:43:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctor_Table](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[Contact] [varchar](50) NULL,
	[Specialist] [varchar](50) NULL,
 CONSTRAINT [PK_Doctor_Table] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patient_Details]    Script Date: 9/22/2020 3:43:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient_Details](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[Contact] [varchar](50) NULL,
	[Disease] [varchar](50) NULL,
 CONSTRAINT [PK_Patient_Details] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Table_Admin]    Script Date: 9/22/2020 3:43:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table_Admin](
	[id] [int] NOT NULL,
	[Name] [varchar](50) NULL,
	[UserPassword] [varchar](50) NULL,
 CONSTRAINT [PK_Table_Admin] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Contact_Table] ON 

INSERT [dbo].[Contact_Table] ([id], [Name], [Contact], [Message]) VALUES (1, N'Harpreet Singh', N'9876347407', N'testing')
SET IDENTITY_INSERT [dbo].[Contact_Table] OFF
SET IDENTITY_INSERT [dbo].[Doctor_Table] ON 

INSERT [dbo].[Doctor_Table] ([id], [Name], [Address], [Contact], [Specialist]) VALUES (1, N'UTTAM SINGH', N'aukland', N'6448445', N'gums')
SET IDENTITY_INSERT [dbo].[Doctor_Table] OFF
SET IDENTITY_INSERT [dbo].[Patient_Details] ON 

INSERT [dbo].[Patient_Details] ([id], [Name], [Address], [Contact], [Disease]) VALUES (1, N'UTTAM SINGH', N'auckland', N'6469848', N'gums prob')
SET IDENTITY_INSERT [dbo].[Patient_Details] OFF
INSERT [dbo].[Table_Admin] ([id], [Name], [UserPassword]) VALUES (1, N'doctor', N'doctor')
USE [master]
GO
ALTER DATABASE [DentalHospital] SET  READ_WRITE 
GO
