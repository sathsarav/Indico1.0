USE [Indico]
GO


DECLARE @Item AS int 
DECLARE @ItemAttrSub AS int
DECLARE @WItem AS int 
DECLARE @WItemAttr AS int 
DECLARE @Parent AS int

SET @Item = (SELECT [ID] FROM [dbo].[Item] WHERE [Name] = 'JACKET SET IN' AND [Parent] IS NULL)
SET @WItem = (SELECT [ID] FROM [dbo].[Item] WHERE [Name] = 'JACKET RAGLAN' AND [Parent] IS NULL)

SET @ItemAttrSub = (SELECT [ID] FROM [dbo].[ItemAttribute] WHERE [Name] = 'HOOD' AND [Parent] IS NULL AND [Item] = @Item)
SET @Parent = (SELECT [ID] FROM [dbo].[ItemAttribute] WHERE [Name] = 'HOOD' AND [Parent] IS NULL AND [Item] = @WItem)

SET @WItemAttr = (SELECT [ID] FROM [dbo].[ItemAttribute] WHERE [Name] = 'FOLD AWAY HOOD' AND [Parent] = @Parent  AND [Item] = @Item)

UPDATE [dbo].[ItemAttribute] SET [Parent] = @ItemAttrSub  WHERE [ID] = @WItemAttr


--**-**-**--**-**-**--**-**-**--**-**-**--**-**-**--**-**-**--**-**-**--**-**-**--**-**-**--**-**-**--**-**-**--**-**-**--**-**-**--**-**-**
/****** Object:  View [dbo].[ReturnDistributorDetailsView]    Script Date: 11/18/2013 09:59:48 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[ReturnDistributorDetailsView]'))
DROP VIEW [dbo].[ReturnDistributorDetailsView]
GO

/****** Object:  View [dbo].[ReturnDistributorDetailsView]    Script Date: 11/18/2013 09:59:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE VIEW [dbo].[ReturnDistributorDetailsView]
AS
	SELECT 
		0 AS Distributor,
		'' AS 'Type',
		CONVERT(bit,0)AS IsDistributor,		
		'' AS Name,		
		'' AS Number,
		'' AS Address1,
		'' AS Address2,
		'' AS City,
		'' AS 'State',
		'' AS PostCode,
		'' AS Country,
		'' AS Phone1,
		'' AS Phone2,
		'' AS Fax,
		'' AS NickName,
		'' AS PrimaryCoordinator,
		'' AS 'Owner',
		'' AS 'Creator',
		GETDATE() AS CreatedDate,
		'' AS Modifier,
		GETDATE() AS ModifiedDate,
		'' AS SecondaryCoordinator,
		CONVERT(bit,0)AS IsActive,
		CONVERT(bit,0)AS IsDelete,
		CONVERT(bit,0)AS Clients,		
		CONVERT(bit,0)AS DistributorLabels,
		CONVERT(bit,0)AS DistributorPriceLevelCosts,
		CONVERT(bit,0)AS DistributorPriceMarkups,
		CONVERT(bit,0)AS DespatchTo,
		CONVERT(bit,0)AS 'Order',
		CONVERT(bit,0)AS ShipTo	

GO


--**-**-**--**-**-**--**-**-**--**-**-**--**-**-**--**-**-**--**-**-**--**-**-**--**-**-**--**-**-**--**-**-**--**-**-**--**-**-**--**-**-**
/****** Object:  StoredProcedure [dbo].[SPC_ViewDistributorsDetails]    Script Date: 11/18/2013 10:00:21 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPC_ViewDistributorsDetails]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SPC_ViewDistributorsDetails]
GO

/****** Object:  StoredProcedure [dbo].[SPC_ViewDistributorsDetails]    Script Date: 11/18/2013 10:00:21 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SPC_ViewDistributorsDetails]
(
	@P_SearchText AS NVARCHAR(255) = '',
	@P_MaxRows AS int = 20,
	@P_Set AS int = 0,
	@P_Sort AS int = 0, --0 Name, --1 NickName, --2 PrimaryCoordinator, --3 SecondaryCoordinator
	@P_OrderBy AS bit = 0,  -- 0 ASC , -- 1 DESC
	@P_RecCount int OUTPUT,
	@P_PCoordinator AS NVARCHAR(255) = '',
	@P_SCoordinator AS NVARCHAR(255) = ''
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @StartOffset int;
	SET @StartOffset = (@P_Set - 1) * @P_MaxRows;
 -- Get Distributor Details	
	WITH Distributors AS
	(
			SELECT 
				DISTINCT TOP (@P_Set * @P_MaxRows)
				CONVERT(int, ROW_NUMBER() OVER (
				ORDER BY 
					CASE 
						WHEN (@p_Sort = 0 AND @p_OrderBy = 0) THEN d.[Name]
					END ASC,
					CASE						
						WHEN (@p_Sort = 0 AND @p_OrderBy = 1) THEN d.[Name]
					END DESC,
					CASE 
						WHEN (@p_Sort = 1 AND @p_OrderBy = 0) THEN d.[NickName]
					END ASC,
					CASE						
						WHEN (@p_Sort = 1 AND @p_OrderBy = 1) THEN d.[NickName]
					END DESC,
					CASE 
						WHEN (@p_Sort = 2 AND @p_OrderBy = 0) THEN u.[GivenName]
					END ASC,
					CASE						
						WHEN (@p_Sort = 2 AND @p_OrderBy = 1) THEN u.[GivenName]
					END DESC,	
					CASE 
						WHEN (@p_Sort = 3 AND @p_OrderBy = 0) THEN sc.[GivenName]
					END ASC,
					CASE						
						WHEN (@p_Sort = 3 AND @p_OrderBy = 1) THEN sc.[GivenName]
					END DESC		
					)) AS ID,
					d.[ID] AS Distributor,
					t.[Name] AS 'Type',
					d.[IsDistributor] AS IsDistributor,
					d.[Name] AS Name,					
					ISNULL(d.[Number],'') AS Number,
					ISNULL(d.[Address1], '') AS Address1,
					ISNULL(d.[Address2], '') AS Address2,
					ISNULL(d.[City], '') AS City,
					ISNULL(d.[State], '') AS 'State',
					ISNULL(d.[Postcode], '') AS Postcode,
					c.[ShortName] AS Country,
					ISNULL(d.[Phone1], '') AS Phone1,
					ISNULL(d.[Phone2], '') AS Phone2,
					ISNULL(d.[Fax], '') AS Fax,
					ISNULL(d.[NickName], '') AS NickName,
					ISNULL(u.[GivenName] +' '+ u.[FamilyName], 'No Coordinator') AS PrimaryCoordinator,
					ISNULL(ow.[GivenName] + ' ' + ow.[FamilyName], '') AS 'Owner',
					cr.[GivenName] + ' ' + cr.[FamilyName] AS 'Creator',
					cm.[GivenName] + ' ' + cm.[FamilyName] AS 'Modifier',
					d.[ModifiedDate] AS ModifiedDate, 
					d.[CreatedDate] AS CreatedDate,
					ISNULL(sc.[GivenName] +' '+ sc.[FamilyName], 'No Secondary Coordinator' ) AS SecondaryCoordinator,
					d.[IsActive] AS IsActive,
					d.[IsDelete] AS IsDelete,
				    CONVERT(bit, (SELECT CASE WHEN (EXISTS(SELECT TOP 1 (cl.[Distributor]) FROM [dbo].[Client] cl WHERE cl.[Distributor] = d.[ID])) THEN 1 ELSE 0 END)) AS Clients,
				    CONVERT(bit, (SELECT CASE WHEN (EXISTS(SELECT TOP 1 (dl.[Distributor]) FROM [dbo].[DistributorLabel] dl WHERE dl.[Distributor] = d.[ID])) THEN 1 ELSE 0 END)) AS DistributorLabels,
				    CONVERT(bit, (SELECT CASE WHEN (EXISTS(SELECT TOP 1 (dplc.[ID]) FROM [dbo].[DistributorPriceLevelCost] dplc WHERE dplc.[Distributor] = d.[ID])) THEN 1 ELSE 0 END)) AS DistributorPriceLevelCosts,
				    CONVERT(bit, (SELECT CASE WHEN (EXISTS(SELECT TOP 1 (dpm.[Distributor]) FROM [dbo].[DistributorPriceMarkup] dpm WHERE dpm.[Distributor] = d.[ID])) THEN 1 ELSE 0 END)) AS DistributorPriceMarkups,
				    CONVERT(bit, (SELECT CASE WHEN (EXISTS(SELECT TOP 1 (od.[DespatchTo]) FROM [dbo].[Order] od WHERE od.[DespatchTo] = d.[ID])) THEN 1 ELSE 0 END)) AS DespatchTo,
				    CONVERT(bit, (SELECT CASE WHEN (EXISTS(SELECT TOP 1 (o.[Distributor]) FROM [dbo].[Order] o WHERE o.[Distributor] = d.[ID])) THEN 1 ELSE 0 END)) AS 'Order',
				    CONVERT(bit, (SELECT CASE WHEN (EXISTS(SELECT TOP 1 (os.[ShipTo]) FROM [dbo].[Order] os WHERE os.[ShipTo] = d.[ID])) THEN 1 ELSE 0 END)) AS ShipTo			
			FROM [dbo].[Company] d
			LEFT OUTER JOIN [dbo].[User] u
				ON d.[Coordinator] = u.[ID]
			LEFT OUTER JOIN [dbo].[User] sc
				ON d.[SecondaryCoordinator] = sc.[ID]
			JOIN [dbo].[Country] c
				ON d.[Country] = c.[ID]
			JOIN [dbo].[CompanyType] t
				ON d.[Type] = t.[ID]
			LEFT OUTER JOIN [dbo].[User] ow
				ON d.[Owner] = ow.[ID]
			JOIN [dbo].[User] cr
				ON d.[Creator] = cr.[ID]
			JOIN [dbo].[User] cm
				ON d.[Modifier] = cm.[ID]			
			WHERE (d.[IsDistributor] = 1 AND
				   d.[IsActive] = 1 AND 
				   d.[IsDelete] = 0 AND (
				   @P_SearchText = '' OR
				   d.[Name] LIKE '%' + @P_SearchText + '%' OR
				   d.[NickName] LIKE '%' + @P_SearchText + '%' OR
				   (u.[GivenName] + ' ' + u.[FamilyName]) LIKE + '%' + @P_SearchText + '%' OR
				   (sc.[GivenName] + ' ' + sc.[FamilyName]) LIKE + '%' + @P_SearchText + '%'))
				   AND (@P_PCoordinator = '' OR (u.[GivenName] + ' ' + u.[FamilyName]) LIKE + '%' + @P_PCoordinator + '%' )
				   AND (@P_SCoordinator = '' OR (sc.[GivenName] + ' ' + sc.[FamilyName]) LIKE + '%' + @P_SCoordinator + '%')
				   
	)
	SELECT * FROM Distributors WHERE ID > @StartOffset
	
	---- Send the total
	IF @P_Set = 1
	BEGIN	
		SELECT @P_RecCount = COUNT (di.ID)
		FROM (
	SELECT 	d.[ID] AS ID						
			FROM [dbo].[Company] d
			LEFT OUTER JOIN [dbo].[User] u
				ON d.[Coordinator] = u.[ID]
			LEFT OUTER JOIN [dbo].[User] sc
				ON d.[SecondaryCoordinator] = sc.[ID]
			JOIN [dbo].[Country] c
				ON d.[Country] = c.[ID]
			JOIN [dbo].[CompanyType] t
				ON d.[Type] = t.[ID]
			LEFT OUTER JOIN [dbo].[User] ow
				ON d.[Owner] = ow.[ID]
			JOIN [dbo].[User] cr
				ON d.[Creator] = cr.[ID]
			JOIN [dbo].[User] cm
				ON d.[Modifier] = cm.[ID]			
			WHERE (d.[IsDistributor] = 1 AND
				   d.[IsActive] = 1 AND 
				   d.[IsDelete] = 0 AND (
				   @P_SearchText = '' OR
				   d.[Name] LIKE '%' + @P_SearchText + '%' OR
				   d.[NickName] LIKE '%' + @P_SearchText + '%' OR
				   (u.[GivenName] + ' ' + u.[FamilyName]) LIKE + '%' + @P_SearchText + '%' OR
				   (sc.[GivenName] + ' ' + sc.[FamilyName]) LIKE + '%' + @P_SearchText + '%'))
				    AND (@P_PCoordinator = '' OR (u.[GivenName] + ' ' + u.[FamilyName]) LIKE + '%' + @P_PCoordinator + '%' )
				    AND (@P_SCoordinator = '' OR (sc.[GivenName] + ' ' + sc.[FamilyName]) LIKE + '%' + @P_SCoordinator + '%')
				  )di
	END
	ELSE
	BEGIN
		SET @P_RecCount = 0
	END
	
END


GO


