USE [master]
GO
/****** Object:  Database [Hopital-cs]    Script Date: 08/12/2023 14:02:55 ******/
CREATE DATABASE [Hopital-cs]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Hopital-cs', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\Hopital-cs.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Hopital-cs_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\Hopital-cs_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Hopital-cs] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Hopital-cs].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Hopital-cs] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Hopital-cs] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Hopital-cs] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Hopital-cs] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Hopital-cs] SET ARITHABORT OFF 
GO
ALTER DATABASE [Hopital-cs] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Hopital-cs] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Hopital-cs] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Hopital-cs] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Hopital-cs] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Hopital-cs] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Hopital-cs] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Hopital-cs] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Hopital-cs] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Hopital-cs] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Hopital-cs] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Hopital-cs] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Hopital-cs] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Hopital-cs] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Hopital-cs] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Hopital-cs] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Hopital-cs] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Hopital-cs] SET RECOVERY FULL 
GO
ALTER DATABASE [Hopital-cs] SET  MULTI_USER 
GO
ALTER DATABASE [Hopital-cs] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Hopital-cs] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Hopital-cs] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Hopital-cs] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Hopital-cs] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Hopital-cs', N'ON'
GO
ALTER DATABASE [Hopital-cs] SET QUERY_STORE = OFF
GO
USE [Hopital-cs]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [Hopital-cs]
GO
/****** Object:  Table [dbo].[Authentification]    Script Date: 08/12/2023 14:02:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Authentification](
	[login] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NULL,
	[nom] [nvarchar](50) NULL,
	[métier] [int] NULL,
 CONSTRAINT [PK_Authentification] PRIMARY KEY CLUSTERED 
(
	[login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[patients]    Script Date: 08/12/2023 14:02:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[patients](
	[id] [int] NOT NULL,
	[nom] [nvarchar](50) NULL,
	[prenom] [nvarchar](50) NULL,
	[age] [int] NULL,
	[adresse] [nvarchar](50) NULL,
	[telephone] [nvarchar](50) NULL,
 CONSTRAINT [PK_patients] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Visites]    Script Date: 08/12/2023 14:02:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Visites](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idpatient] [int] NULL,
	[date] [nvarchar](50) NULL,
	[médecin] [nvarchar](50) NULL,
	[num-salle] [int] NULL,
	[tarif] [int] NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [Hopital-cs] SET  READ_WRITE 
GO
