USE [master]
GO
/****** Object:  Database [Tournament]    Script Date: 17-10-2024 11:49:41 ******/
CREATE DATABASE [Tournament]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Tournament', FILENAME = N'C:\Users\nilesh.parit\Tournament.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Tournament_log', FILENAME = N'C:\Users\nilesh.parit\Tournament_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Tournament] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Tournament].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Tournament] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Tournament] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Tournament] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Tournament] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Tournament] SET ARITHABORT OFF 
GO
ALTER DATABASE [Tournament] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Tournament] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Tournament] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Tournament] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Tournament] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Tournament] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Tournament] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Tournament] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Tournament] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Tournament] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Tournament] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Tournament] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Tournament] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Tournament] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Tournament] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Tournament] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Tournament] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Tournament] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Tournament] SET  MULTI_USER 
GO
ALTER DATABASE [Tournament] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Tournament] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Tournament] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Tournament] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Tournament] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Tournament] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Tournament', N'ON'
GO
ALTER DATABASE [Tournament] SET QUERY_STORE = OFF
GO
ALTER DATABASE [Tournament] SET  READ_WRITE 
GO
