USE [Indico]
GO

------------ Alter Order Detail column ------------------

ALTER TABLE [dbo].OrderDetail 
ADD [FactoryInstructions] nvarchar(255) NULL 

GO
--------------- Update JobName Country  ---------------

UPDATE [dbo].[JobName]
SET Country = 'Australia'
WHERE Country = '14'

GO

--------------------------------------------------------
			





