USE [Indico]
GO

ALTER TABLE dbo.[Order] ADD [IsGSTExcluded] bit NOT NULL CONSTRAINT [DF_Order_IsGSTExcluded] DEFAULT(0)
GO