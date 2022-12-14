USE [master]
GO
/****** Object:  Database [BDWebCursos]    Script Date: 2/12/2021 11:50:30 ******/
CREATE DATABASE [BDWebCursos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BDWebCurso', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\BDWebCurso.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BDWebCurso_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\BDWebCurso_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [BDWebCursos] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BDWebCursos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BDWebCursos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BDWebCursos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BDWebCursos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BDWebCursos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BDWebCursos] SET ARITHABORT OFF 
GO
ALTER DATABASE [BDWebCursos] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BDWebCursos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BDWebCursos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BDWebCursos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BDWebCursos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BDWebCursos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BDWebCursos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BDWebCursos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BDWebCursos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BDWebCursos] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BDWebCursos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BDWebCursos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BDWebCursos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BDWebCursos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BDWebCursos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BDWebCursos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BDWebCursos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BDWebCursos] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BDWebCursos] SET  MULTI_USER 
GO
ALTER DATABASE [BDWebCursos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BDWebCursos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BDWebCursos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BDWebCursos] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BDWebCursos] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'BDWebCursos', N'ON'
GO
ALTER DATABASE [BDWebCursos] SET QUERY_STORE = OFF
GO
USE [BDWebCursos]
GO
/****** Object:  User [alumno]    Script Date: 2/12/2021 11:50:30 ******/
CREATE USER [alumno] FOR LOGIN [alumno] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Administradores]    Script Date: 2/12/2021 11:50:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Administradores](
	[IdAdministrador] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Administradores] PRIMARY KEY CLUSTERED 
(
	[IdAdministrador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contacto]    Script Date: 2/12/2021 11:50:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contacto](
	[IdContacto] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Email] [varchar](100) NULL,
	[Consulta] [text] NULL,
 CONSTRAINT [PK_Contacto] PRIMARY KEY CLUSTERED 
(
	[IdContacto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cursos]    Script Date: 2/12/2021 11:50:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cursos](
	[IdCurso] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
	[Descripcion] [text] NULL,
	[Imagen] [varchar](200) NULL,
	[UrlCurso] [varchar](250) NULL,
	[MeGusta] [int] NULL,
	[NoMeGusta] [int] NULL,
	[IdEspecialidad] [int] NULL,
	[Precio] [int] NULL,
	[ReunionZoom] [varchar](100) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Especialidades]    Script Date: 2/12/2021 11:50:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Especialidades](
	[IdEspecialidad] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
	[Materia] [varchar](50) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Administradores] ON 

INSERT [dbo].[Administradores] ([IdAdministrador], [Nombre], [Password]) VALUES (1, N'Jony', N'46483420')
INSERT [dbo].[Administradores] ([IdAdministrador], [Nombre], [Password]) VALUES (2, N'a', N'a')
SET IDENTITY_INSERT [dbo].[Administradores] OFF
GO
SET IDENTITY_INSERT [dbo].[Contacto] ON 

INSERT [dbo].[Contacto] ([IdContacto], [Nombre], [Email], [Consulta]) VALUES (1, N'a', N'a@a', N'a')
INSERT [dbo].[Contacto] ([IdContacto], [Nombre], [Email], [Consulta]) VALUES (9, N'jony', N'jony@gmail', N'quiero hacer una consulta')
SET IDENTITY_INSERT [dbo].[Contacto] OFF
GO
SET IDENTITY_INSERT [dbo].[Cursos] ON 

INSERT [dbo].[Cursos] ([IdCurso], [Nombre], [Descripcion], [Imagen], [UrlCurso], [MeGusta], [NoMeGusta], [IdEspecialidad], [Precio], [ReunionZoom]) VALUES (1, N'Curso de PHP para principiantes', N'El curso inicia con los fundamentos de PHP, en los cuales aprenderás y dominaras todas las estructuras del lenguaje de programación tales como variables, ciclos, condicionales, arreglos, funciones y programación orientada a objetos.', N'https://www.solucionex.com/sites/default/files/posts/imagen/php.jpg', N'<iframe width="560" height="315" src="https://www.youtube.com/embed/mX0z6wSWJtA" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>', 5, 2, 1, 10000, N'linkZoom1')
INSERT [dbo].[Cursos] ([IdCurso], [Nombre], [Descripcion], [Imagen], [UrlCurso], [MeGusta], [NoMeGusta], [IdEspecialidad], [Precio], [ReunionZoom]) VALUES (6, N'curso 1', N'un curso', N'https://www.colegiosenbuenosaires.com/wp-content/uploads/2021/01/Instituto-ORT_sede-Almagro-650x423.jpg', N'<iframe width="560" height="315" src="https://www.youtube.com/embed/wHn1_QVoXGM" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>', 0, 0, 1, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Cursos] OFF
GO
SET IDENTITY_INSERT [dbo].[Especialidades] ON 

INSERT [dbo].[Especialidades] ([IdEspecialidad], [Nombre], [Materia]) VALUES (1, N'Lenguajes', N'Programacion')
INSERT [dbo].[Especialidades] ([IdEspecialidad], [Nombre], [Materia]) VALUES (2, N'Programas Diseño', N'Imagen y Comunicacion')
INSERT [dbo].[Especialidades] ([IdEspecialidad], [Nombre], [Materia]) VALUES (3, N'Metodologías', N'Efsi')
INSERT [dbo].[Especialidades] ([IdEspecialidad], [Nombre], [Materia]) VALUES (4, N'Ingles', N'Ingles')
SET IDENTITY_INSERT [dbo].[Especialidades] OFF
GO
USE [master]
GO
ALTER DATABASE [BDWebCursos] SET  READ_WRITE 
GO
