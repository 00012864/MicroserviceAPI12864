USE [Catalog]
GO

ALTER TABLE [dbo].[Products]  WITH CHECK ADD FOREIGN KEY([ProductCategoryId])
REFERENCES [dbo].[Categories] ([Id])
GO


