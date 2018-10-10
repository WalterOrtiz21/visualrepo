USE [RRHH]
GO
/****** Object:  Table [dbo].[Asistencias]    Script Date: 9/10/2018 19:06:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Asistencias](
	[CodAsistencia] [int] IDENTITY(1,1) NOT NULL,
	[FechaHora] [datetime] NOT NULL,
	[CodEmpleado] [int] NOT NULL,
 CONSTRAINT [PK_Asistencias] PRIMARY KEY CLUSTERED 
(
	[CodAsistencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 9/10/2018 19:06:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empleados](
	[CodEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[NroDocumento] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[Direccion] [varchar](50) NOT NULL,
	[Telefono] [varchar](50) NOT NULL,
	[CodHorario] [int] NOT NULL,
	[Salario] [money] NOT NULL,
	[Activo] [char](1) NOT NULL,
 CONSTRAINT [PK_dbo.Empleadoes] PRIMARY KEY CLUSTERED 
(
	[CodEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Horarios]    Script Date: 9/10/2018 19:06:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Horarios](
	[CodHorario] [int] IDENTITY(1,1) NOT NULL,
	[EntradaLunes] [varchar](20) NULL,
	[SalidaLunes] [varchar](20) NULL,
	[EntradaMartes] [varchar](20) NULL,
	[SalidaMartes] [varchar](20) NULL,
	[EntradaMiercoles] [varchar](50) NULL,
	[SalidaMiercoles] [varchar](50) NULL,
	[EntradaJueves] [varchar](50) NULL,
	[SalidaJueves] [varchar](50) NULL,
	[EntradaViernes] [varchar](50) NULL,
	[SalidaViernes] [varchar](50) NULL,
	[EntradaSabado] [varchar](50) NULL,
	[SalidaSabado] [varchar](50) NULL,
 CONSTRAINT [PK_Horarios] PRIMARY KEY CLUSTERED 
(
	[CodHorario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TiposOperaciones]    Script Date: 9/10/2018 19:06:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TiposOperaciones](
	[TipoOperacionID] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[Acrivo] [char](1) NOT NULL,
 CONSTRAINT [PK_TiposOperaciones] PRIMARY KEY CLUSTERED 
(
	[TipoOperacionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Transacciones]    Script Date: 9/10/2018 19:06:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Transacciones](
	[CodTransaccion] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [date] NOT NULL,
	[CodEmpleado] [int] NOT NULL,
	[CodUsuario] [int] NOT NULL,
	[CodTipoOperacion] [int] NOT NULL,
	[Monto] [money] NOT NULL,
	[Anulada] [char](1) NOT NULL,
 CONSTRAINT [PK_Transacciones] PRIMARY KEY CLUSTERED 
(
	[CodTransaccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 9/10/2018 19:06:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[CodUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Login] [varchar](50) NOT NULL,
	[Contraseña] [varchar](50) NOT NULL,
	[Activo] [char](1) NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[CodUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Asistencias] ON 

INSERT [dbo].[Asistencias] ([CodAsistencia], [FechaHora], [CodEmpleado]) VALUES (3, CAST(0x0000A97300846D90 AS DateTime), 2)
SET IDENTITY_INSERT [dbo].[Asistencias] OFF
SET IDENTITY_INSERT [dbo].[Empleados] ON 

INSERT [dbo].[Empleados] ([CodEmpleado], [NroDocumento], [Nombre], [FechaNacimiento], [Direccion], [Telefono], [CodHorario], [Salario], [Activo]) VALUES (2, N'5252965', N'Cecilia Barrios', CAST(0x36190B00 AS Date), N'Las Perlas 542', N'021-854-965', 1, 5500000.0000, N'S')
INSERT [dbo].[Empleados] ([CodEmpleado], [NroDocumento], [Nombre], [FechaNacimiento], [Direccion], [Telefono], [CodHorario], [Salario], [Activo]) VALUES (3, N'80000', N'Juan Sosa', CAST(0x1B0F0B00 AS Date), N'Montevideo 854', N'099255554', 2, 3600000.0000, N'S')
SET IDENTITY_INSERT [dbo].[Empleados] OFF
SET IDENTITY_INSERT [dbo].[Horarios] ON 

INSERT [dbo].[Horarios] ([CodHorario], [EntradaLunes], [SalidaLunes], [EntradaMartes], [SalidaMartes], [EntradaMiercoles], [SalidaMiercoles], [EntradaJueves], [SalidaJueves], [EntradaViernes], [SalidaViernes], [EntradaSabado], [SalidaSabado]) VALUES (1, N'07:00', N'17:00', N'08:00', N'18:00', N'08:00', N'18:00', N'07:00', N'17:00', N'07:00', N'17:00', N'08:00', N'12:00')
INSERT [dbo].[Horarios] ([CodHorario], [EntradaLunes], [SalidaLunes], [EntradaMartes], [SalidaMartes], [EntradaMiercoles], [SalidaMiercoles], [EntradaJueves], [SalidaJueves], [EntradaViernes], [SalidaViernes], [EntradaSabado], [SalidaSabado]) VALUES (2, N'08:00', N'19:00', N'08:00', N'18:00', N'09:00', N'20:00', N'07:00', N'17:00', N'07:00', N'17:00', N'08:00', N'12:00')
SET IDENTITY_INSERT [dbo].[Horarios] OFF
SET IDENTITY_INSERT [dbo].[TiposOperaciones] ON 

INSERT [dbo].[TiposOperaciones] ([TipoOperacionID], [Descripcion], [Acrivo]) VALUES (1, N'Honorario Base', N'S')
INSERT [dbo].[TiposOperaciones] ([TipoOperacionID], [Descripcion], [Acrivo]) VALUES (2, N'Honorario Adicional', N'S')
INSERT [dbo].[TiposOperaciones] ([TipoOperacionID], [Descripcion], [Acrivo]) VALUES (3, N'Anticipo', N'S')
INSERT [dbo].[TiposOperaciones] ([TipoOperacionID], [Descripcion], [Acrivo]) VALUES (4, N'Prestamo', N'S')
INSERT [dbo].[TiposOperaciones] ([TipoOperacionID], [Descripcion], [Acrivo]) VALUES (5, N'Otros Creditos', N'S')
SET IDENTITY_INSERT [dbo].[TiposOperaciones] OFF
SET IDENTITY_INSERT [dbo].[Transacciones] ON 

INSERT [dbo].[Transacciones] ([CodTransaccion], [Fecha], [CodEmpleado], [CodUsuario], [CodTipoOperacion], [Monto], [Anulada]) VALUES (1, CAST(0xCE3E0B00 AS Date), 2, 1, 1, 5500000.0000, N'N')
SET IDENTITY_INSERT [dbo].[Transacciones] OFF
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([CodUsuario], [Nombre], [Login], [Contraseña], [Activo]) VALUES (1, N'Juan Perez', N'jperez', N'juan', N'S')
INSERT [dbo].[Usuarios] ([CodUsuario], [Nombre], [Login], [Contraseña], [Activo]) VALUES (2, N'Administrador', N'admin', N'123', N'S')
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
ALTER TABLE [dbo].[Asistencias]  WITH CHECK ADD  CONSTRAINT [FK_Asistencias_Empleados] FOREIGN KEY([CodEmpleado])
REFERENCES [dbo].[Empleados] ([CodEmpleado])
GO
ALTER TABLE [dbo].[Asistencias] CHECK CONSTRAINT [FK_Asistencias_Empleados]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Horarios] FOREIGN KEY([CodHorario])
REFERENCES [dbo].[Horarios] ([CodHorario])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_Horarios]
GO
ALTER TABLE [dbo].[Transacciones]  WITH CHECK ADD  CONSTRAINT [FK_Transacciones_Empleados] FOREIGN KEY([CodEmpleado])
REFERENCES [dbo].[Empleados] ([CodEmpleado])
GO
ALTER TABLE [dbo].[Transacciones] CHECK CONSTRAINT [FK_Transacciones_Empleados]
GO
ALTER TABLE [dbo].[Transacciones]  WITH CHECK ADD  CONSTRAINT [FK_Transacciones_TiposOperaciones] FOREIGN KEY([CodTipoOperacion])
REFERENCES [dbo].[TiposOperaciones] ([TipoOperacionID])
GO
ALTER TABLE [dbo].[Transacciones] CHECK CONSTRAINT [FK_Transacciones_TiposOperaciones]
GO
ALTER TABLE [dbo].[Transacciones]  WITH CHECK ADD  CONSTRAINT [FK_Transacciones_Usuarios] FOREIGN KEY([CodUsuario])
REFERENCES [dbo].[Usuarios] ([CodUsuario])
GO
ALTER TABLE [dbo].[Transacciones] CHECK CONSTRAINT [FK_Transacciones_Usuarios]
GO
