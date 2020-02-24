USE [master]
GO
/****** Object:  Database [SistemaVenda]    Script Date: 24/02/2020 09:42:18 ******/
CREATE DATABASE [SistemaVenda]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SistemaVenda', FILENAME = N'C:\BDSistemaVendas\SistemaVenda.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SistemaVenda_log', FILENAME = N'C:\BDSistemaVendas\SistemaVenda_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
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
ALTER DATABASE [SistemaVenda] SET  DISABLE_BROKER 
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
ALTER DATABASE [SistemaVenda] SET QUERY_STORE = OFF
GO
USE [SistemaVenda]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 24/02/2020 09:42:19 ******/
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
/****** Object:  Table [dbo].[Cliente]    Script Date: 24/02/2020 09:42:19 ******/
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
	[cep] [varchar](20) NULL,
	[numeroEnde] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Colaborador]    Script Date: 24/02/2020 09:42:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Colaborador](
	[id_colaborador] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[cpf] [varchar](15) NOT NULL,
	[senha] [varbinary](100) NOT NULL,
	[telefone] [varchar](15) NULL,
	[celular] [varchar](15) NULL,
	[descricao] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_colaborador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Compra]    Script Date: 24/02/2020 09:42:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compra](
	[id_compra] [int] IDENTITY(1,1) NOT NULL,
	[dataCompra] [datetime] NULL,
	[nfiscal] [int] NULL,
	[total] [float] NULL,
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
/****** Object:  Table [dbo].[Endereco]    Script Date: 24/02/2020 09:42:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Endereco](
	[cep] [varchar](20) NOT NULL,
	[rua] [varchar](60) NOT NULL,
	[bairro] [varchar](60) NOT NULL,
	[cidade] [varchar](60) NULL,
	[uf] [varchar](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[cep] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fornecedor]    Script Date: 24/02/2020 09:42:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fornecedor](
	[id_fornecedor] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[cpfCNPJ] [varchar](30) NOT NULL,
	[telefone] [varchar](15) NULL,
	[celular] [varchar](15) NULL,
	[observacao] [varchar](100) NULL,
	[email] [varchar](30) NULL,
	[cep] [varchar](20) NULL,
	[numeroEnde] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_fornecedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItensCompra]    Script Date: 24/02/2020 09:42:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItensCompra](
	[id_itensCompra] [int] NOT NULL,
	[quantidade] [float] NULL,
	[valor] [float] NULL,
	[id_compra] [int] NOT NULL,
	[id_produto] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItensVenda]    Script Date: 24/02/2020 09:42:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItensVenda](
	[id_itensVenda] [int] NOT NULL,
	[quantidade] [float] NULL,
	[valor] [float] NULL,
	[id_venda] [int] NOT NULL,
	[id_produto] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ParcelasVenda]    Script Date: 24/02/2020 09:42:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ParcelasVenda](
	[id_parcelasVenda] [int] NOT NULL,
	[valor] [float] NULL,
	[dataPagto] [date] NULL,
	[dataVencimento] [date] NULL,
	[id_venda] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Produto]    Script Date: 24/02/2020 09:42:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produto](
	[id_produto] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[preco] [float] NOT NULL,
	[quantidade] [float] NOT NULL,
	[descricao] [varchar](50) NULL,
	[id_categoria] [int] NOT NULL,
	[id_fornecedor] [int] NOT NULL,
	[codigo_pro] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_produto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoPagamento]    Script Date: 24/02/2020 09:42:19 ******/
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
/****** Object:  Table [dbo].[Venda]    Script Date: 24/02/2020 09:42:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venda](
	[id_venda] [int] IDENTITY(1,1) NOT NULL,
	[dataVenda] [datetime] NULL,
	[nfiscal] [int] NULL,
	[total] [float] NULL,
	[nparcelas] [int] NULL,
	[vendaStatus] [varchar](30) NULL,
	[id_cliente] [int] NULL,
	[id_tipoPagamento] [int] NULL,
	[Avista] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_venda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cep_tbEndereco] FOREIGN KEY([cep])
REFERENCES [dbo].[Endereco] ([cep])
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [FK_Cep_tbEndereco]
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_idtipoPagamento_TipoPagamento] FOREIGN KEY([id_tipoPagamento])
REFERENCES [dbo].[TipoPagamento] ([id_tipoPagamento])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_idtipoPagamento_TipoPagamento]
GO
ALTER TABLE [dbo].[Fornecedor]  WITH CHECK ADD  CONSTRAINT [FK_CepF_tbEndereco] FOREIGN KEY([cep])
REFERENCES [dbo].[Endereco] ([cep])
GO
ALTER TABLE [dbo].[Fornecedor] CHECK CONSTRAINT [FK_CepF_tbEndereco]
GO
ALTER TABLE [dbo].[ItensCompra]  WITH CHECK ADD  CONSTRAINT [FK_IdCompraitenscompra_tbCompra] FOREIGN KEY([id_compra])
REFERENCES [dbo].[Compra] ([id_compra])
GO
ALTER TABLE [dbo].[ItensCompra] CHECK CONSTRAINT [FK_IdCompraitenscompra_tbCompra]
GO
ALTER TABLE [dbo].[ItensCompra]  WITH CHECK ADD  CONSTRAINT [FK_idProdutoIC_tbProduto] FOREIGN KEY([id_produto])
REFERENCES [dbo].[Produto] ([id_produto])
GO
ALTER TABLE [dbo].[ItensCompra] CHECK CONSTRAINT [FK_idProdutoIC_tbProduto]
GO
ALTER TABLE [dbo].[ItensVenda]  WITH CHECK ADD  CONSTRAINT [FK_idProdutoItensV_tbProduto] FOREIGN KEY([id_produto])
REFERENCES [dbo].[Produto] ([id_produto])
GO
ALTER TABLE [dbo].[ItensVenda] CHECK CONSTRAINT [FK_idProdutoItensV_tbProduto]
GO
ALTER TABLE [dbo].[ItensVenda]  WITH CHECK ADD  CONSTRAINT [FK_idVenda_tbVendaI] FOREIGN KEY([id_venda])
REFERENCES [dbo].[Venda] ([id_venda])
GO
ALTER TABLE [dbo].[ItensVenda] CHECK CONSTRAINT [FK_idVenda_tbVendaI]
GO
ALTER TABLE [dbo].[ParcelasVenda]  WITH CHECK ADD  CONSTRAINT [FK_idVenda_tbVenda] FOREIGN KEY([id_venda])
REFERENCES [dbo].[Venda] ([id_venda])
GO
ALTER TABLE [dbo].[ParcelasVenda] CHECK CONSTRAINT [FK_idVenda_tbVenda]
GO
ALTER TABLE [dbo].[Produto]  WITH CHECK ADD  CONSTRAINT [FK_Idcategoria_Categoria] FOREIGN KEY([id_categoria])
REFERENCES [dbo].[Categoria] ([id_categoria])
GO
ALTER TABLE [dbo].[Produto] CHECK CONSTRAINT [FK_Idcategoria_Categoria]
GO
ALTER TABLE [dbo].[Produto]  WITH CHECK ADD  CONSTRAINT [FK_idFornecedor_tbFornecedor] FOREIGN KEY([id_fornecedor])
REFERENCES [dbo].[Fornecedor] ([id_fornecedor])
GO
ALTER TABLE [dbo].[Produto] CHECK CONSTRAINT [FK_idFornecedor_tbFornecedor]
GO
ALTER TABLE [dbo].[Venda]  WITH CHECK ADD  CONSTRAINT [FK_IdCliente_tbCliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Cliente] ([id_cliente])
GO
ALTER TABLE [dbo].[Venda] CHECK CONSTRAINT [FK_IdCliente_tbCliente]
GO
ALTER TABLE [dbo].[Venda]  WITH CHECK ADD  CONSTRAINT [FK_idTipoPagamento_tbTipoPagamento] FOREIGN KEY([id_tipoPagamento])
REFERENCES [dbo].[TipoPagamento] ([id_tipoPagamento])
GO
ALTER TABLE [dbo].[Venda] CHECK CONSTRAINT [FK_idTipoPagamento_tbTipoPagamento]
GO
USE [master]
GO
ALTER DATABASE [SistemaVenda] SET  READ_WRITE 
GO
