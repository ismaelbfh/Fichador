USE [ControlHoras]
GO

/****** Object:  Table [dbo].[Tareas]    Script Date: 16/08/2016 14:21:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Tareas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IDUsuario] [int] NOT NULL,
	[HoraInicioTarea] [datetime] NOT NULL,
	[HoraFinTarea] [datetime] NULL,
	[duracion] [int] NOT NULL,
	[nombreTarea] [varchar](20) NOT NULL,
	[descripcionTarea] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Tareas]  WITH CHECK ADD  CONSTRAINT [FK_Tareas] FOREIGN KEY([IDUsuario])
REFERENCES [dbo].[Usuarios] ([Id])
GO

ALTER TABLE [dbo].[Tareas] CHECK CONSTRAINT [FK_Tareas]
GO

