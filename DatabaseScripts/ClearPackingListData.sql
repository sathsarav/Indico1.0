
USE [Indico]
GO

--**--**--**--Clear all records on Packing List--**--**--**--**--**--**--**

DELETE FROM [Indico].[dbo].[PackingListCartonItem]      
DELETE FROM [Indico].[dbo].[PackingListSizeQty]     
DELETE FROM [Indico].[dbo].[PackingList]