USE [Indico]
GO

ALTER TABLE [dbo].[VisualLayout] ADD [Where] [nvarchar] (128) NULL 

GO 

ALTER TABLE [dbo].[OrderDetail] ADD [PromoCode] [nvarchar] (32) NULL 

GO 