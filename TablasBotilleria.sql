CREATE TABLE [dbo].[Usuario](
	[id_usuario] [int] NOT NULL,
	[nombre_usuario] [varchar](50) NOT NULL,
	[contrasenja_usuario] [varchar](50) NOT NULL,
	[esAdministrador] [bit] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
)

CREATE TABLE [dbo].[Bebida](
	[id_producto] [int] NOT NULL,
	[nombre_producto] [char](15) NOT NULL,
	[precio] [int] NOT NULL,
	[tipo] [nchar](10) NOT NULL,
	[grados_alcohol] [numeric](2, 0) NOT NULL,
	[volumen_litros] [numeric](2, 0) NOT NULL,
 CONSTRAINT [PK_Bebida_1] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)

CREATE TABLE [dbo].[BodegaLocal](
	[id_bodega] [int] NOT NULL,
	[producto_fk] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
 CONSTRAINT [PK_BodegaLocal] PRIMARY KEY CLUSTERED 
(
	[id_bodega] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
)

CREATE TABLE [dbo].[Venta](
	[id_venta] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[total_precio] [numeric](7, 0) NOT NULL,
	[id_usuario_fk] [int] NOT NULL,
 CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED 
(
	[id_venta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
)

CREATE TABLE [dbo].[detalle_venta](
	[cantidad] [int] NOT NULL,
	[id_producto_fk] [int] NOT NULL,
	[id_venta_fk] [int] NOT NULL
)