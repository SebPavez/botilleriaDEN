ALTER TABLE [dbo].[BodegaLocal]  WITH CHECK ADD  CONSTRAINT [FK_BodegaLocal_Bebida] FOREIGN KEY([producto_fk])
REFERENCES [dbo].[Bebida] ([id_producto])
GO
ALTER TABLE [dbo].[BodegaLocal] CHECK CONSTRAINT [FK_BodegaLocal_Bebida]
GO
ALTER TABLE [dbo].[detalle_venta]  WITH CHECK ADD  CONSTRAINT [FK_detalle_venta_Bebida] FOREIGN KEY([id_producto_fk])
REFERENCES [dbo].[Bebida] ([id_producto])
GO
ALTER TABLE [dbo].[detalle_venta] CHECK CONSTRAINT [FK_detalle_venta_Bebida]
GO
ALTER TABLE [dbo].[detalle_venta]  WITH CHECK ADD  CONSTRAINT [FK_detalle_venta_Venta1] FOREIGN KEY([id_venta_fk])
REFERENCES [dbo].[Venta] ([id_venta])
GO
ALTER TABLE [dbo].[detalle_venta] CHECK CONSTRAINT [FK_detalle_venta_Venta1]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Usuario] FOREIGN KEY([id_usuario_fk])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Usuario]
GO