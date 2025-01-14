SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Bodega]') AND type in (N'U'))
BEGIN
CREATE TABLE [Bodega](
	[id_bodega] [int] NOT NULL,
	[nombre_bodega] [nchar](20) NOT NULL,
	[direccion] [nchar](50) NOT NULL,
	[telefono] [int] NOT NULL,
	[correo_electronico] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Bodega] PRIMARY KEY CLUSTERED 
(
	[id_bodega] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Bodega]') AND type in (N'U'))
BEGIN
CREATE TABLE [Bodega](
	[id_bodega] [int] NOT NULL,
	[nombre_bodega] [nchar](20) NOT NULL,
	[direccion] [nchar](50) NOT NULL,
	[telefono] [int] NOT NULL,
	[correo_electronico] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Bodega] PRIMARY KEY CLUSTERED 
(
	[id_bodega] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
