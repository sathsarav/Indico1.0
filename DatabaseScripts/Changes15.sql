UPDATE [Indico].[dbo].[VisualLayout]
   SET [Coordinator] = 9
 WHERE [Coordinator] = 22
GO

DELETE FROM [Indico].[dbo].[User]
      WHERE ID = 22
GO

