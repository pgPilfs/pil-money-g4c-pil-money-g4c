USE [APPO!]
GO
/****** Object:  Table [dbo].[ComprasMonedas]    Script Date: 11/08/2021 18:36:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ComprasMonedas](
	[nro_comp_compra] [int] NOT NULL,
	[nombre_cripto] [varchar](50) NOT NULL,
	[monto] [decimal](18, 0) NOT NULL,
	[fecha] [date] NOT NULL,
	[hora] [time](7) NOT NULL,
	[CVU_compra] [varchar](22) NOT NULL,
 CONSTRAINT [PK_ComprasCripto] PRIMARY KEY CLUSTERED 
(
	[nro_comp_compra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cuentas]    Script Date: 11/08/2021 18:36:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cuentas](
	[CVU] [varchar](22) NOT NULL,
	[alias] [varchar](50) NOT NULL,
	[id_tipo_cuenta] [int] NOT NULL,
	[saldo_actual] [decimal](18, 0) NOT NULL,
	[dni_usuario] [int] NOT NULL,
 CONSTRAINT [PK_Cuentas] PRIMARY KEY CLUSTERED 
(
	[CVU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IngresosDinero]    Script Date: 11/08/2021 18:36:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IngresosDinero](
	[id_deposito] [int] NOT NULL,
	[nombre_deposito] [varchar](50) NOT NULL,
	[CVU_deposito] [varchar](22) NOT NULL,
	[nro_tarjeta] [varchar](50) NULL,
	[fecha_venc] [date] NULL,
	[cod_seguridad] [int] NULL,
	[nombre_titular] [varchar](50) NULL,
 CONSTRAINT [PK_IngresosDinero] PRIMARY KEY CLUSTERED 
(
	[id_deposito] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inversiones]    Script Date: 11/08/2021 18:36:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inversiones](
	[id_inversion] [int] NOT NULL,
	[monto_inversion] [decimal](18, 0) NOT NULL,
	[fecha_inicio] [date] NOT NULL,
	[fecha_fin] [date] NOT NULL,
	[CVU_inversion] [varchar](22) NOT NULL,
 CONSTRAINT [PK_Inversiones] PRIMARY KEY CLUSTERED 
(
	[id_inversion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PagosServicio]    Script Date: 11/08/2021 18:36:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PagosServicio](
	[nro_comprobante] [int] NOT NULL,
	[id_servicio] [int] NOT NULL,
	[CVU_pago] [varchar](22) NOT NULL,
	[nro_factura] [int] NOT NULL,
	[nombre_factura] [varchar](50) NOT NULL,
	[monto] [decimal](18, 0) NOT NULL,
	[fecha] [date] NOT NULL,
	[hora] [time](7) NOT NULL,
 CONSTRAINT [PK_PagosServicio] PRIMARY KEY CLUSTERED 
(
	[nro_comprobante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RetirosDinero]    Script Date: 11/08/2021 18:36:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RetirosDinero](
	[id_retiro] [int] NOT NULL,
	[CVU_retiro] [varchar](22) NOT NULL,
	[monto] [decimal](18, 0) NOT NULL,
	[fecha] [date] NOT NULL,
	[hora] [time](7) NOT NULL,
 CONSTRAINT [PK_RetirosDinero] PRIMARY KEY CLUSTERED 
(
	[id_retiro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Servicios]    Script Date: 11/08/2021 18:36:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servicios](
	[id_servicio] [int] NOT NULL,
	[nombre_servicio] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Servicios] PRIMARY KEY CLUSTERED 
(
	[id_servicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TiposCuentas]    Script Date: 11/08/2021 18:36:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TiposCuentas](
	[id_tipo_cuenta] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TiposCuentas] PRIMARY KEY CLUSTERED 
(
	[id_tipo_cuenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transferencias]    Script Date: 11/08/2021 18:36:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transferencias](
	[nro_transferencia] [int] NOT NULL,
	[CVU_origen] [varchar](22) NOT NULL,
	[CVU_destino] [varchar](22) NOT NULL,
	[fecha] [date] NOT NULL,
	[hora] [time](7) NOT NULL,
	[monto] [decimal](18, 0) NOT NULL,
	[referencia] [varchar](50) NULL,
 CONSTRAINT [PK_Transferencias] PRIMARY KEY CLUSTERED 
(
	[nro_transferencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 11/08/2021 18:36:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[dni] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[foto_dni_frente] [varbinary](max) NULL,
	[foto_dni_dorso] [varbinary](max) NULL,
	[mail] [varchar](50) NOT NULL,
	[password] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VentasMonedas]    Script Date: 11/08/2021 18:36:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VentasMonedas](
	[nro_comp_ventas] [int] NOT NULL,
	[monto] [decimal](18, 0) NOT NULL,
	[fecha] [date] NOT NULL,
	[hora] [time](7) NOT NULL,
	[CVU_venta] [varchar](22) NOT NULL,
 CONSTRAINT [PK_VentasCripto] PRIMARY KEY CLUSTERED 
(
	[nro_comp_ventas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ComprasMonedas]  WITH CHECK ADD  CONSTRAINT [FK_ComprasMonedas_Cuentas] FOREIGN KEY([CVU_compra])
REFERENCES [dbo].[Cuentas] ([CVU])
GO
ALTER TABLE [dbo].[ComprasMonedas] CHECK CONSTRAINT [FK_ComprasMonedas_Cuentas]
GO
ALTER TABLE [dbo].[Cuentas]  WITH CHECK ADD  CONSTRAINT [FK_Cuentas_TipoCuentas] FOREIGN KEY([id_tipo_cuenta])
REFERENCES [dbo].[TiposCuentas] ([id_tipo_cuenta])
GO
ALTER TABLE [dbo].[Cuentas] CHECK CONSTRAINT [FK_Cuentas_TipoCuentas]
GO
ALTER TABLE [dbo].[Cuentas]  WITH CHECK ADD  CONSTRAINT [FK_Cuentas_Usuario] FOREIGN KEY([dni_usuario])
REFERENCES [dbo].[Usuarios] ([dni])
GO
ALTER TABLE [dbo].[Cuentas] CHECK CONSTRAINT [FK_Cuentas_Usuario]
GO
ALTER TABLE [dbo].[IngresosDinero]  WITH CHECK ADD  CONSTRAINT [FK_IngresosDinero_Cuentas] FOREIGN KEY([CVU_deposito])
REFERENCES [dbo].[Cuentas] ([CVU])
GO
ALTER TABLE [dbo].[IngresosDinero] CHECK CONSTRAINT [FK_IngresosDinero_Cuentas]
GO
ALTER TABLE [dbo].[Inversiones]  WITH CHECK ADD  CONSTRAINT [FK_Inversiones_Cuentas] FOREIGN KEY([CVU_inversion])
REFERENCES [dbo].[Cuentas] ([CVU])
GO
ALTER TABLE [dbo].[Inversiones] CHECK CONSTRAINT [FK_Inversiones_Cuentas]
GO
ALTER TABLE [dbo].[PagosServicio]  WITH CHECK ADD  CONSTRAINT [FK_PagosServicio_Cuentas] FOREIGN KEY([CVU_pago])
REFERENCES [dbo].[Cuentas] ([CVU])
GO
ALTER TABLE [dbo].[PagosServicio] CHECK CONSTRAINT [FK_PagosServicio_Cuentas]
GO
ALTER TABLE [dbo].[PagosServicio]  WITH CHECK ADD  CONSTRAINT [FK_PagosServicio_Servicios] FOREIGN KEY([id_servicio])
REFERENCES [dbo].[Servicios] ([id_servicio])
GO
ALTER TABLE [dbo].[PagosServicio] CHECK CONSTRAINT [FK_PagosServicio_Servicios]
GO
ALTER TABLE [dbo].[RetirosDinero]  WITH CHECK ADD  CONSTRAINT [FK_RetirosDinero_Cuentas] FOREIGN KEY([CVU_retiro])
REFERENCES [dbo].[Cuentas] ([CVU])
GO
ALTER TABLE [dbo].[RetirosDinero] CHECK CONSTRAINT [FK_RetirosDinero_Cuentas]
GO
ALTER TABLE [dbo].[Transferencias]  WITH CHECK ADD  CONSTRAINT [FK_Transferencias_Cuentas_Destino] FOREIGN KEY([CVU_destino])
REFERENCES [dbo].[Cuentas] ([CVU])
GO
ALTER TABLE [dbo].[Transferencias] CHECK CONSTRAINT [FK_Transferencias_Cuentas_Destino]
GO
ALTER TABLE [dbo].[Transferencias]  WITH CHECK ADD  CONSTRAINT [FK_Transferencias_Cuentas_Origen] FOREIGN KEY([CVU_origen])
REFERENCES [dbo].[Cuentas] ([CVU])
GO
ALTER TABLE [dbo].[Transferencias] CHECK CONSTRAINT [FK_Transferencias_Cuentas_Origen]
GO
ALTER TABLE [dbo].[VentasMonedas]  WITH CHECK ADD  CONSTRAINT [FK_VentasMonedas_Cuentas] FOREIGN KEY([CVU_venta])
REFERENCES [dbo].[Cuentas] ([CVU])
GO
ALTER TABLE [dbo].[VentasMonedas] CHECK CONSTRAINT [FK_VentasMonedas_Cuentas]
GO
