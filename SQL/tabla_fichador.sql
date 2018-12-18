USE [ControlHoras]
GO

/****** Object:  Table [dbo].[Fichador]    Script Date: 16/08/2016 14:20:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Fichador](
	[IDUsuario] [int] NOT NULL,
	[HoraInicio] [datetime] NULL,
	[HoraFin] [datetime] NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Fichador] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Fichador]  WITH CHECK ADD  CONSTRAINT [FK_Fichador_Usuarios] FOREIGN KEY([IDUsuario])
REFERENCES [dbo].[Usuarios] ([Id])
GO

ALTER TABLE [dbo].[Fichador] CHECK CONSTRAINT [FK_Fichador_Usuarios]
GO

