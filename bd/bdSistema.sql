USE [master]
GO
/****** Object:  Database [SistemaVenda]    Script Date: 16/09/2019 20:07:32 ******/
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
/****** Object:  Table [dbo].[Categoria]    Script Date: 16/09/2019 20:07:32 ******/
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
/****** Object:  Table [dbo].[Cliente]    Script Date: 16/09/2019 20:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[cpf] [varchar](20) NOT NULL,
	[telefone] [int] NULL,
	[email] [varchar](50) NULL,
	[observacao] [varchar](100) NULL,
	[id_endereco] [int] NULL,
	[numeroEnde] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Colaborador]    Script Date: 16/09/2019 20:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Colaborador](
	[id_colaborador] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[cpf] [varchar](15) NOT NULL,
	[senha] [varchar](50) NULL,
	[descricao] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_colaborador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Endereco]    Script Date: 16/09/2019 20:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Endereco](
	[id_endereco] [int] IDENTITY(1,1) NOT NULL,
	[cep] [int] NOT NULL,
	[rua] [varchar](50) NOT NULL,
	[bairro] [varchar](50) NOT NULL,
	[cidade] [varchar](50) NOT NULL,
	[uf] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_endereco] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Produto]    Script Date: 16/09/2019 20:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produto](
	[id_produto] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[preco] [decimal](25, 2) NOT NULL,
	[descricao] [varchar](50) NULL,
	[id_categoria] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_produto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_Endereco] FOREIGN KEY([id_endereco])
REFERENCES [dbo].[Endereco] ([id_endereco])
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [FK_Cliente_Endereco]
GO
ALTER TABLE [dbo].[Produto]  WITH CHECK ADD  CONSTRAINT [FK_Produto_Categoria1] FOREIGN KEY([id_categoria])
REFERENCES [dbo].[Categoria] ([id_categoria])
GO
ALTER TABLE [dbo].[Produto] CHECK CONSTRAINT [FK_Produto_Categoria1]
GO
/****** Object:  StoredProcedure [dbo].[sp_alterarCategoria]    Script Date: 16/09/2019 20:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_alterarCategoria]
(
@id_categoria int,
@nome VARCHAR(30),
@mensagem VARCHAR(100) output
)
as
begin
--VERIFICAR SE JA EXISTE CPF CADASTRO
IF(EXISTS(SELECT * FROM Categoria WHERE nome  = @nome))
SET @mensagem='Este nome de categoria: ' +@nome + ' já está registrado!'
ELSE
Begin
UPDATE Categoria set nome = @nome
	WHERE id_categoria = @id_categoria
SET @mensagem='Dados alterados com sucesso!'
end
end
GO
/****** Object:  StoredProcedure [dbo].[sp_alterarCliente]    Script Date: 16/09/2019 20:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_alterarCliente]
(
@id_cliente int,
@nome varchar (50) , 
@cpf varchar(20) ,
@telefone int,
@email varchar (50) ,
@observacao varchar (100),
@id_endereco int,
@numeroEnde int,
@mensagem varchar(100) output
)
as
Begin
UPDATE Cliente set 
nome = @nome, 
cpf = @cpf,
telefone = @telefone,
email= @email ,
observacao = @observacao,
id_endereco = @id_endereco,
numeroEnde = @numeroEnde
WHERE id_cliente = @id_cliente
SET @mensagem='Dados alterados com sucesso!'
end
GO
/****** Object:  StoredProcedure [dbo].[sp_alterarColaborador]    Script Date: 16/09/2019 20:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_alterarColaborador]
(
@id_colaborador int,
@nome VARCHAR(50),
@senha VARCHAR(50),
@cpf varchar(15),
@descricao varchar(50),
@mensagem VARCHAR(100) output
)
as
begin
UPDATE Colaborador set 
nome = @nome,
senha = @senha,
cpf = @cpf,
descricao = @descricao
WHERE id_colaborador = @id_colaborador
SET @mensagem='Dados alterados com sucesso!'
end
GO
/****** Object:  StoredProcedure [dbo].[sp_alterarEndereco]    Script Date: 16/09/2019 20:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_alterarEndereco]
(
@id_endereco int,
@cep int , 
@rua varchar(50) ,
@bairro varchar (50) ,
@cidade varchar (50) ,
@uf varchar (10),
@mensagem varchar(100) output
)
as
begin
--VERIFICAR SE JA EXISTE CPF CADASTRO
IF(EXISTS(SELECT * FROM Endereco WHERE cep  = @cep))
SET @mensagem='Este numero de cep: ' +@cep + ' já está registrado!'
ELSE
Begin
UPDATE Endereco set 
cep = @cep,
rua = @rua ,
bairro = @bairro ,
cidade = @cidade ,
uf = @uf
WHERE id_endereco = @id_endereco
SET @mensagem='Dados alterados com sucesso!'
end
end
GO
/****** Object:  StoredProcedure [dbo].[sp_alterarProduto]    Script Date: 16/09/2019 20:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCedure [dbo].[sp_alterarProduto]
(
@id_produto int,
@nome varchar(50),
@preco decimal(25,2),
@descricao varchar(50),
@id_categoria int,
@mensagem varchar(100) output
)
as
begin
--VERIFICAR SE JA EXISTE CPF CADASTRO
IF(EXISTS(SELECT * FROM Produto WHERE nome  = @nome))
SET @mensagem='Este Nome de Produto: ' +@nome + ' já está registrado!'
ELSE
Begin
UPDATE Produto set 
nome = @nome,
preco = @preco,
descricao = @descricao,
id_categoria = @id_categoria
WHERE id_produto = @id_produto
SET @mensagem='Dados alterados com sucesso!'
end
end
GO
/****** Object:  StoredProcedure [dbo].[sp_excluirCategoria]    Script Date: 16/09/2019 20:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_excluirCategoria]
(
@id_categoria int,
@mensagem varchar(100) output
)
as
begin
delete Categoria where id_categoria = @id_categoria
SET @mensagem='Categoria excluida!'
end	
GO
/****** Object:  StoredProcedure [dbo].[sp_excluirCliente]    Script Date: 16/09/2019 20:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_excluirCliente]
(
@id_cliente int,
@mensagem varchar(100) output
)
as
begin
delete Cliente where id_cliente = @id_cliente
SET @mensagem='Cliente excluido!'
end	
GO
/****** Object:  StoredProcedure [dbo].[sp_excluirColaborador]    Script Date: 16/09/2019 20:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_excluirColaborador]
(
@id_colaborador int,
@mensagem varchar(100) output
)
as
begin
delete Colaborador where id_colaborador = @id_colaborador
SET @mensagem='Colaborador excluido!'
end	
GO
/****** Object:  StoredProcedure [dbo].[sp_excluirEndereco]    Script Date: 16/09/2019 20:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_excluirEndereco]
(
@id_endereco int,
@mensagem varchar(100) output
)
as
begin
delete Endereco where id_endereco = @id_endereco
SET @mensagem='Endereco excluido!'
end	
GO
/****** Object:  StoredProcedure [dbo].[sp_excluirProduto]    Script Date: 16/09/2019 20:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_excluirProduto]
(
@id_produto int,
@mensagem varchar(100) output
)
as
begin
delete Produto where id_produto = @id_produto
SET @mensagem='Produto excluido!'
end	
GO
/****** Object:  StoredProcedure [dbo].[sp_Login]    Script Date: 16/09/2019 20:07:33 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_salvarCategoria]    Script Date: 16/09/2019 20:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--CRIAR OS PROCEDIMENTOS	
CREATE PROCEDURE [dbo].[sp_salvarCategoria]
(
@nome varchar(30),
@mensagem varchar(50) output
)
AS
BEGIN 
--VERIFICAR SE JA EXISTE CPF CADASTRO
IF(EXISTS(SELECT * FROM Categoria WHERE nome  = @nome))
SET @mensagem='Este nome de categoria: ' +@nome + ' já está registrado!'
ELSE
Begin
INSERT INTO Categoria VALUES(@nome)
SET @mensagem='Categoria cadastrada com sucesso!'
end
end
GO
/****** Object:  StoredProcedure [dbo].[sp_salvarCliente]    Script Date: 16/09/2019 20:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_salvarCliente]
(
@nome varchar (50), 
@cpf varchar(20),
@telefone int ,
@email varchar (50),
@observacao varchar (100),
@id_endereco int ,
@numeroEnde int,
@mensagem varchar(100) output
)
AS
BEGIN 
--VERIFICAR SE JA EXISTE Cliente cadastrado
IF(EXISTS(SELECT * FROM Cliente WHERE cpf  = @cpf))
SET @mensagem='Este cpf de Cliente: ' +@cpf + ' já está registrado!'
ELSE
Begin
INSERT INTO Cliente VALUES(@nome, @cpf, @telefone, @email, @observacao, @id_endereco, @numeroEnde)
SET @mensagem='Cliente cadastrado com sucesso!'
end
end
GO
/****** Object:  StoredProcedure [dbo].[sp_salvarColaborador]    Script Date: 16/09/2019 20:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_salvarColaborador]
(
@nome varchar(50),
@cpf varchar(15),
@senha varchar(50),
@descricao varchar (50),
@mensagem varchar(100) output
)
AS
BEGIN 
--VERIFICAR SE JA EXISTE CPF CADASTRO
IF(EXISTS(SELECT * FROM Colaborador WHERE cpf  = @cpf))
SET @mensagem='Este CPF de Colaborador: ' +@cpf + ' já está registrado!'
ELSE
Begin
INSERT INTO Colaborador VALUES(@nome, @cpf, @senha, @descricao)
SET @mensagem='Colaborador cadastrado com sucesso!'
end
end
GO
/****** Object:  StoredProcedure [dbo].[sp_salvarEndereco]    Script Date: 16/09/2019 20:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_salvarEndereco]
(
@cep int , 
@rua varchar(50) ,
@bairro varchar (50) ,
@cidade varchar (50) ,
@uf varchar (10),
@mensagem varchar(100) output
)
AS
BEGIN 
--VERIFICAR SE JA EXISTE CEP cadastrado
IF(EXISTS(SELECT * FROM Endereco WHERE cep  = @cep))
SET @mensagem='Este número de CEP: ' +@cep + ' já está registrado!'
ELSE
Begin
INSERT INTO Endereco VALUES(@cep, @rua, @bairro, @cidade, @uf)
SET @mensagem='Endereço cadastrado com sucesso!'
end
end
GO
/****** Object:  StoredProcedure [dbo].[sp_salvarProduto]    Script Date: 16/09/2019 20:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_salvarProduto]
(
@nome varchar(50),
@preco decimal(25,2),
@descricao varchar(50),
@id_categoria int,
@mensagem varchar(100) output
)
AS
BEGIN 
--VERIFICAR SE JA EXISTE CPF CADASTRO
IF(EXISTS(SELECT * FROM Produto WHERE nome  = @nome))
SET @mensagem='Este Nome de Produto: ' +@nome + ' já está registrado!'
ELSE
Begin
INSERT INTO Produto VALUES(@nome, @preco, @descricao, @id_categoria)
SET @mensagem='Produto cadastrado com sucesso!'
end
end
GO
USE [master]
GO
ALTER DATABASE [SistemaVenda] SET  READ_WRITE 
GO
