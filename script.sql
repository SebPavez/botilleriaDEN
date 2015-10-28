ALTER TABLE [Bebida] DROP CONSTRAINT [FK_Bebida_MarcaBebida]
GO
ALTER TABLE [Bebida] DROP CONSTRAINT [FK_Bebida_TipoBebida]
GO
ALTER TABLE [BodegaLocal] DROP CONSTRAINT [FK_BodegaLocal_Bebida]
GO
ALTER TABLE [detalle_venta] DROP CONSTRAINT [FK_detalle_venta_Bebida]
GO
ALTER TABLE [detalle_venta] DROP CONSTRAINT [FK_detalle_venta_Venta]
GO
ALTER TABLE [Venta] DROP CONSTRAINT [FK_Venta_Usuario]
GO
ALTER TABLE [BodegaLocal] DROP CONSTRAINT [FK_BodegaLocal_Bebida]
GO
DROP TABLE [BodegaLocal]
GO
ALTER TABLE [detalle_venta] DROP CONSTRAINT [FK_detalle_venta_Bebida]
GO
ALTER TABLE [detalle_venta] DROP CONSTRAINT [FK_detalle_venta_Venta]
GO
DROP TABLE [detalle_venta]
GO
ALTER TABLE [Bebida] DROP CONSTRAINT [FK_Bebida_MarcaBebida]
GO
ALTER TABLE [Bebida] DROP CONSTRAINT [FK_Bebida_TipoBebida]
GO
DROP TABLE [Bebida]
GO
ALTER TABLE [Venta] DROP CONSTRAINT [FK_Venta_Usuario]
GO
DROP TABLE [Venta]
GO
DROP TABLE [MarcaBebida]
GO
DROP TABLE [TipoBebida]
GO
DROP TABLE [Usuario]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [Usuario](
	[id_usuario] [int] NOT NULL,
	[nombre_usuario] [varchar](50) NOT NULL,
	[contrasenja_usuario] [varchar](50) NOT NULL,
	[esAdministrador] [bit] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [TipoBebida](
	[id_tipo] [int] NOT NULL,
	[tipo] [nchar](10) NOT NULL,
 CONSTRAINT [PK_TipoBebida] PRIMARY KEY CLUSTERED 
(
	[id_tipo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [MarcaBebida](
	[id_marca] [int] NOT NULL,
	[marca] [nchar](30) NOT NULL,
 CONSTRAINT [PK_MarcaBebida] PRIMARY KEY CLUSTERED 
(
	[id_marca] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Venta](
	[id_venta] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[total_precio] [numeric](7, 0) NOT NULL,
	[id_usuario_fk] [int] NOT NULL,
 CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED 
(
	[id_venta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [Bebida](
	[id_bebida] [int] NOT NULL,
	[nombre_producto] [char](15) NOT NULL,
	[precio] [int] NOT NULL,
	[tipo] [int] NOT NULL,
	[grados_alcohol] [numeric](2, 0) NOT NULL,
	[volumen_litros] [float] NOT NULL,
	[es_retornable] [bit] NOT NULL,
	[comentario] [nvarchar](100) NOT NULL,
	[marca] [int] NOT NULL,
 CONSTRAINT [PK_Bebida] PRIMARY KEY CLUSTERED 
(
	[id_bebida] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [detalle_venta](
	[cantidad] [int] NOT NULL,
	[id_bebida_fk] [int] NOT NULL,
	[id_venta_fk] [int] NOT NULL
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [BodegaLocal](
	[id_bodega] [int] NOT NULL,
	[producto_fk] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
 CONSTRAINT [PK_BodegaLocal] PRIMARY KEY CLUSTERED 
(
	[id_bodega] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [Bebida]  WITH CHECK ADD  CONSTRAINT [FK_Bebida_MarcaBebida] FOREIGN KEY([marca])
REFERENCES [MarcaBebida] ([id_marca])
GO
ALTER TABLE [Bebida] CHECK CONSTRAINT [FK_Bebida_MarcaBebida]
GO
ALTER TABLE [Bebida]  WITH CHECK ADD  CONSTRAINT [FK_Bebida_TipoBebida] FOREIGN KEY([tipo])
REFERENCES [TipoBebida] ([id_tipo])
GO
ALTER TABLE [Bebida] CHECK CONSTRAINT [FK_Bebida_TipoBebida]
GO
ALTER TABLE [BodegaLocal]  WITH CHECK ADD  CONSTRAINT [FK_BodegaLocal_Bebida] FOREIGN KEY([producto_fk])
REFERENCES [Bebida] ([id_bebida])
GO
ALTER TABLE [BodegaLocal] CHECK CONSTRAINT [FK_BodegaLocal_Bebida]
GO
ALTER TABLE [detalle_venta]  WITH CHECK ADD  CONSTRAINT [FK_detalle_venta_Bebida] FOREIGN KEY([id_bebida_fk])
REFERENCES [Bebida] ([id_bebida])
GO
ALTER TABLE [detalle_venta] CHECK CONSTRAINT [FK_detalle_venta_Bebida]
GO
ALTER TABLE [detalle_venta]  WITH CHECK ADD  CONSTRAINT [FK_detalle_venta_Venta] FOREIGN KEY([id_venta_fk])
REFERENCES [Venta] ([id_venta])
GO
ALTER TABLE [detalle_venta] CHECK CONSTRAINT [FK_detalle_venta_Venta]
GO
ALTER TABLE [Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Usuario] FOREIGN KEY([id_usuario_fk])
REFERENCES [Usuario] ([id_usuario])
GO
ALTER TABLE [Venta] CHECK CONSTRAINT [FK_Venta_Usuario]
GO
