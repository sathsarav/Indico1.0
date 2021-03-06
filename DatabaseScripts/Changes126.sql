USE [Indico]
GO

-- Deleting SizeChart records on pattern = 314 ------
DELETE FROM [dbo].[SizeChart]
WHERE Pattern = 314 AND Size NOT IN (
									SELECT ID FROM [dbo].[Size]
									WHERE [SizeSet] = 5
									)
													