USE [master]
GO
/****** Object:  Database [SistemaVenda]    Script Date: 05/10/2019 18:13:34 ******/
CREATE DATABASE [SistemaVenda]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SistemaVenda', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\SistemaVenda.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SistemaVenda_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\SistemaVenda_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [SistemaVenda] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SistemaVenda].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SistemaVenda] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SistemaVenda] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SistemaVenda] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SistemaVenda] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SistemaVenda] SET ARITHABORT OFF 
GO
ALTER DATABASE [SistemaVenda] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SistemaVenda] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SistemaVenda] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SistemaVenda] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SistemaVenda] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SistemaVenda] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SistemaVenda] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SistemaVenda] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SistemaVenda] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SistemaVenda] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SistemaVenda] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SistemaVenda] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SistemaVenda] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SistemaVenda] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SistemaVenda] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SistemaVenda] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SistemaVenda] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SistemaVenda] SET RECOVERY FULL 
GO
ALTER DATABASE [SistemaVenda] SET  MULTI_USER 
GO
ALTER DATABASE [SistemaVenda] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SistemaVenda] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SistemaVenda] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SistemaVenda] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SistemaVenda] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'SistemaVenda', N'ON'
GO
ALTER DATABASE [SistemaVenda] SET QUERY_STORE = OFF
GO
USE [SistemaVenda]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 05/10/2019 18:13:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[id_categoria] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](30) NOT NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[id_categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 05/10/2019 18:13:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[cpf] [varchar](20) NOT NULL,
	[telefone] [varchar](20) NULL,
	[celular] [varchar](20) NULL,
	[email] [varchar](50) NULL,
	[observacao] [varchar](100) NULL,
	[id_endereco] [int] NULL,
	[numeroEnde] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Colaborador]    Script Date: 05/10/2019 18:13:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Colaborador](
	[id_colaborador] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[cpf] [varchar](15) NOT NULL,
	[senha] [varchar](50) NOT NULL,
	[telefone] [varchar](15) NULL,
	[celular] [varchar](15) NULL,
	[descricao] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_colaborador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Compra]    Script Date: 05/10/2019 18:13:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compra](
	[id_compra] [int] IDENTITY(1,1) NOT NULL,
	[dataCompra] [datetime] NULL,
	[nfiscal] [int] NULL,
	[total] [money] NULL,
	[nparcelas] [int] NULL,
	[compraStatus] [varchar](30) NULL,
	[id_fornecedor] [int] NULL,
	[id_tipoPagamento] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_compra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Endereco]    Script Date: 05/10/2019 18:13:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Endereco](
	[id_endereco] [int] IDENTITY(1,1) NOT NULL,
	[cep] [varchar](20) NULL,
	[rua] [varchar](50) NOT NULL,
	[bairro] [varchar](50) NOT NULL,
	[cidade] [varchar](50) NULL,
	[uf] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_endereco] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fornecedor]    Script Date: 05/10/2019 18:13:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fornecedor](
	[id_fornecedor] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[cpfCNPJ] [varchar](30) NOT NULL,
	[telefone] [varchar](15) NULL,
	[email] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_fornecedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItensCompra]    Script Date: 05/10/2019 18:13:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItensCompra](
	[id_itensCompra] [int] NOT NULL,
	[quantidade] [float] NULL,
	[valor] [money] NULL,
	[id_compra] [int] NOT NULL,
	[id_produto] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItensVenda]    Script Date: 05/10/2019 18:13:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItensVenda](
	[id_itensVenda] [int] NOT NULL,
	[quantidade] [float] NULL,
	[valor] [money] NULL,
	[id_venda] [int] NOT NULL,
	[id_produto] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_itensVenda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Produto]    Script Date: 05/10/2019 18:13:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produto](
	[id_produto] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[preco] [decimal](25, 2) NOT NULL,
	[quantidade] [decimal](25, 2) NOT NULL,
	[descricao] [varchar](50) NULL,
	[id_categoria] [int] NOT NULL,
	[id_fornecedor] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_produto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoPagamento]    Script Date: 05/10/2019 18:13:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoPagamento](
	[id_tipoPagamento] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_tipoPagamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_IdEndereco_Endereco] FOREIGN KEY([id_endereco])
REFERENCES [dbo].[Endereco] ([id_endereco])
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [FK_IdEndereco_Endereco]
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_idFornecedor_tbFornecedor] FOREIGN KEY([id_fornecedor])
REFERENCES [dbo].[Fornecedor] ([id_fornecedor])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_idFornecedor_tbFornecedor]
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_idtipoPagamento_TipoPagamento] FOREIGN KEY([id_tipoPagamento])
REFERENCES [dbo].[TipoPagamento] ([id_tipoPagamento])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_idtipoPagamento_TipoPagamento]
GO
ALTER TABLE [dbo].[ItensCompra]  WITH CHECK ADD  CONSTRAINT [FK_IdCompra_TbCompra] FOREIGN KEY([id_compra])
REFERENCES [dbo].[Compra] ([id_compra])
GO
ALTER TABLE [dbo].[ItensCompra] CHECK CONSTRAINT [FK_IdCompra_TbCompra]
GO
ALTER TABLE [dbo].[ItensCompra]  WITH CHECK ADD  CONSTRAINT [FK_idProduto_tbProduto] FOREIGN KEY([id_produto])
REFERENCES [dbo].[Produto] ([id_produto])
GO
ALTER TABLE [dbo].[ItensCompra] CHECK CONSTRAINT [FK_idProduto_tbProduto]
GO
ALTER TABLE [dbo].[Produto]  WITH CHECK ADD  CONSTRAINT [FK_Idcategoria_Categoria] FOREIGN KEY([id_categoria])
REFERENCES [dbo].[Categoria] ([id_categoria])
GO
ALTER TABLE [dbo].[Produto] CHECK CONSTRAINT [FK_Idcategoria_Categoria]
GO
ALTER TABLE [dbo].[Produto]  WITH CHECK ADD  CONSTRAINT [FK_IdFornecedor_Fornecedor] FOREIGN KEY([id_fornecedor])
REFERENCES [dbo].[Fornecedor] ([id_fornecedor])
GO
ALTER TABLE [dbo].[Produto] CHECK CONSTRAINT [FK_IdFornecedor_Fornecedor]
GO
/****** Object:  StoredProcedure [dbo].[sp_Login]    Script Date: 05/10/2019 18:13:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_Login]
(
@nome varchar(30),
@senha varchar(30),
@msg varchar (100) output
)
as 
begin
if(not exists(select * from Colaborador where @nome = nome and @senha = senha ))
set
@msg = 'Dados Incorretos'
else
begin
set
@msg = 'Bem vindo: ' + @nome
end
end
GO
USE [master]
GO
ALTER DATABASE [SistemaVenda] SET  READ_WRITE 
GO
