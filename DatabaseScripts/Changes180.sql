USE [Indico]
GO

--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**

DELETE FROM [dbo].[Client]
WHERE ID = 15298

DELETE FROM [dbo].[Client]
WHERE ID = 15299

GO
--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**

UPDATE [dbo].[Order]
SET Client = 10833
WHERE Client = 13572

DELETE FROM [dbo].[JobName]
WHERE ID = 13572

DELETE FROM [dbo].[Client]
WHERE ID = 11190
GO
--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**
