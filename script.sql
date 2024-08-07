USE [master]
GO
/****** Object:  Database [WindowCalculator_v2n]    Script Date: 13.07.2024 17:55:03 ******/
CREATE DATABASE [WindowCalculator_v2n]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WindowCalculator_v2n', FILENAME = N'D:\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\WindowCalculator_v2n.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'WindowCalculator_v2n_log', FILENAME = N'D:\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\WindowCalculator_v2n_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [WindowCalculator_v2n] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WindowCalculator_v2n].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WindowCalculator_v2n] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WindowCalculator_v2n] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WindowCalculator_v2n] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WindowCalculator_v2n] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WindowCalculator_v2n] SET ARITHABORT OFF 
GO
ALTER DATABASE [WindowCalculator_v2n] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [WindowCalculator_v2n] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WindowCalculator_v2n] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WindowCalculator_v2n] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WindowCalculator_v2n] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WindowCalculator_v2n] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WindowCalculator_v2n] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WindowCalculator_v2n] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WindowCalculator_v2n] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WindowCalculator_v2n] SET  ENABLE_BROKER 
GO
ALTER DATABASE [WindowCalculator_v2n] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WindowCalculator_v2n] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WindowCalculator_v2n] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WindowCalculator_v2n] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WindowCalculator_v2n] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WindowCalculator_v2n] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [WindowCalculator_v2n] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WindowCalculator_v2n] SET RECOVERY FULL 
GO
ALTER DATABASE [WindowCalculator_v2n] SET  MULTI_USER 
GO
ALTER DATABASE [WindowCalculator_v2n] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WindowCalculator_v2n] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WindowCalculator_v2n] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WindowCalculator_v2n] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [WindowCalculator_v2n] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [WindowCalculator_v2n] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'WindowCalculator_v2n', N'ON'
GO
ALTER DATABASE [WindowCalculator_v2n] SET QUERY_STORE = ON
GO
ALTER DATABASE [WindowCalculator_v2n] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [WindowCalculator_v2n]
GO
/****** Object:  Table [dbo].[MaterialsTable]    Script Date: 13.07.2024 17:55:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MaterialsTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Category] [nvarchar](30) NOT NULL,
	[Name] [nvarchar](40) NOT NULL,
	[Color] [nvarchar](30) NOT NULL,
	[CostPerMeter] [int] NOT NULL,
	[Description] [nvarchar](60) NOT NULL,
 CONSTRAINT [PK__Materials_T__3236EC07934EC078] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsersTable]    Script Date: 13.07.2024 17:55:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsersTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](40) NULL,
	[Login] [nvarchar](40) NULL,
	[Password] [nvarchar](40) NULL,
	[Email] [nvarchar](max) NULL,
	[IsAdmin] [bit] NOT NULL,
 CONSTRAINT [PK__Users_T__3214EC07934EC078] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[MaterialsTable] ON 

INSERT [dbo].[MaterialsTable] ([Id], [Category], [Name], [Color], [CostPerMeter], [Description]) VALUES (1, N'Glass', N'Glass', N'Transparent', 30, N'Обычное стекло')
INSERT [dbo].[MaterialsTable] ([Id], [Category], [Name], [Color], [CostPerMeter], [Description]) VALUES (3, N'Frame', N'Plastic', N'Black', 25, N'Пластамасовая рамка белого цвета')
INSERT [dbo].[MaterialsTable] ([Id], [Category], [Name], [Color], [CostPerMeter], [Description]) VALUES (4, N'Frame', N'Tree', N'Brown', 10, N'Деревянная рамка')
INSERT [dbo].[MaterialsTable] ([Id], [Category], [Name], [Color], [CostPerMeter], [Description]) VALUES (5, N'Glass', N'Glass 2', N'Transparent', 60, N'Двойное стекло')
INSERT [dbo].[MaterialsTable] ([Id], [Category], [Name], [Color], [CostPerMeter], [Description]) VALUES (6, N'Glass', N'Dark glass', N'Black', 45, N'Затемненное стекло')
INSERT [dbo].[MaterialsTable] ([Id], [Category], [Name], [Color], [CostPerMeter], [Description]) VALUES (8, N'Glass', N'Dark glass 2', N'Black', 90, N'Двойное затемненное стекло')
INSERT [dbo].[MaterialsTable] ([Id], [Category], [Name], [Color], [CostPerMeter], [Description]) VALUES (9, N'Section', N'Plastic', N'White', 5, N'Белая пластиковая секция')
INSERT [dbo].[MaterialsTable] ([Id], [Category], [Name], [Color], [CostPerMeter], [Description]) VALUES (10, N'Section', N'Plastic', N'Black', 7, N'Черная пластиковая секция')
INSERT [dbo].[MaterialsTable] ([Id], [Category], [Name], [Color], [CostPerMeter], [Description]) VALUES (12, N'Section', N'Tree', N'Brown', 3, N'Деревянная секция')
INSERT [dbo].[MaterialsTable] ([Id], [Category], [Name], [Color], [CostPerMeter], [Description]) VALUES (13, N'Sill', N'Plastic', N'White', 10, N'Белый подоконник')
INSERT [dbo].[MaterialsTable] ([Id], [Category], [Name], [Color], [CostPerMeter], [Description]) VALUES (14, N'Sill', N'Plastic', N'Black', 20, N'Черный подоконник')
INSERT [dbo].[MaterialsTable] ([Id], [Category], [Name], [Color], [CostPerMeter], [Description]) VALUES (15, N'Sill', N'Tree', N'Brown', 30, N'Деревянный подоконник')
INSERT [dbo].[MaterialsTable] ([Id], [Category], [Name], [Color], [CostPerMeter], [Description]) VALUES (16, N'Section', N'Plastic', N'White', 10, N'Белая пластиковая открывающяяся секция')
INSERT [dbo].[MaterialsTable] ([Id], [Category], [Name], [Color], [CostPerMeter], [Description]) VALUES (17, N'Section', N'Plastic', N'Black', 14, N'Черная пластиковая открывающяяся секция')
INSERT [dbo].[MaterialsTable] ([Id], [Category], [Name], [Color], [CostPerMeter], [Description]) VALUES (18, N'Section', N'Tree', N'Brown', 6, N'Деревянная открывающяяся секция')
INSERT [dbo].[MaterialsTable] ([Id], [Category], [Name], [Color], [CostPerMeter], [Description]) VALUES (19, N'Furniture', N'Plastic', N'White', 3, N'Пластиковые белые ручки')
INSERT [dbo].[MaterialsTable] ([Id], [Category], [Name], [Color], [CostPerMeter], [Description]) VALUES (20, N'Furniture', N'Plastic', N'Black', 6, N'Пластиковые черные ручки')
INSERT [dbo].[MaterialsTable] ([Id], [Category], [Name], [Color], [CostPerMeter], [Description]) VALUES (21, N'Furniture', N'Steel', N'Metallic', 10, N'Металлические ручки')
INSERT [dbo].[MaterialsTable] ([Id], [Category], [Name], [Color], [CostPerMeter], [Description]) VALUES (22, N'Furniture', N'Steel', N'Metallic', 13, N'Metallic')
SET IDENTITY_INSERT [dbo].[MaterialsTable] OFF
GO
SET IDENTITY_INSERT [dbo].[UsersTable] ON 

INSERT [dbo].[UsersTable] ([Id], [FullName], [Login], [Password], [Email], [IsAdmin]) VALUES (1, N'Admin', N'Admin', N'0B2FFE4FAE90F11F26F4223C2FDC95BB', N'admin@gmail.com', 1)
INSERT [dbo].[UsersTable] ([Id], [FullName], [Login], [Password], [Email], [IsAdmin]) VALUES (2, N'Tom g', N'Qwerty', N'1111', N'xxxxx', 0)
INSERT [dbo].[UsersTable] ([Id], [FullName], [Login], [Password], [Email], [IsAdmin]) VALUES (1002, N'ffff', N'ffff', N'ffff', N'dd', 0)
SET IDENTITY_INSERT [dbo].[UsersTable] OFF
GO
USE [master]
GO
ALTER DATABASE [WindowCalculator_v2n] SET  READ_WRITE 
GO
