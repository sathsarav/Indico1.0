USE [Indico]
GO


/****** Object:  StoredProcedure [dbo].[SPC_GetWeeklyAddressDetails]    Script Date: 09/23/2015 16:58:45 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPC_GetWeeklyAddressDetails]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SPC_GetWeeklyAddressDetails]
GO

/****** Object:  StoredProcedure [dbo].[SPC_GetWeeklyAddressDetails]    Script Date: 09/23/2015 16:58:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPC_GetWeeklyAddressDetails] (	
@P_WeekEndDate datetime2(7),
@P_CompanyName NVARCHAR(255) = '',
@P_ShipmentMode int = 0 
)	
AS 
BEGIN
	
		SELECT	   od.[ID] AS OrderDetail
				  ,ot.[Name] AS OrderType
				  ,vl.[NamePrefix] + ISNULL(CAST(vl.[NameSuffix] AS nvarchar(255)),'') AS VisualLayout
				  ,od.[VisualLayout] AS VisualLayoutID
				  ,od.[Pattern] AS PatternID
				  ,p.[Number] + ' - ' + p.[NickName] AS Pattern
				  ,od.[FabricCode] AS FabricID
				  --,fc.[Code] + ' - ' + fc.[Name] AS Fabric
				  ,fc.[Code] AS FabricCode
				  ,fc.[Name] AS FabricName
				  ,fc.[Material] AS FabricMaterial				  
				  ,od.[VisualLayoutNotes] AS VisualLayoutNotes      
				  ,od.[Order] AS 'Order'
				  ,ISNULL(od.[Label], 0) AS Label
				  ,ISNULL(ods.[Name], 'New') AS OrderDetailStatus
				  ,ISNULL(od.[Status], 0) AS OrderDetailStatusID
				  ,od.[ShipmentDate] AS ShipmentDate
				  ,od.[SheduledDate] AS SheduledDate      
				  ,od.[RequestedDate] AS RequestedDate
				  ,ISNULL((SELECT SUM(odq.[Qty]) FROM [dbo].[OrderDetailQty] odq WHERE odq.[OrderDetail] = od.[ID]),0) AS Quantity       
				  ,ISNULL(o.[OldPONo], '') AS 'PurONo'
				  ,c.[Name] AS Distributor
				  ,u.[GivenName] + ' ' + u.[FamilyName] AS Coordinator
				  ,cl.[Name] AS Client
				  ,os.[Name] AS OrderStatus
				  ,o.[Status] AS OrderStatusID				  
				  ,ISNULL(o.[ShipmentMode], 0) AS ShimentModeID
				  ,ISNULL(shm.[Name], 'AIR') AS ShipmentMode
				  ,ISNULL(dca.[CompanyName], '') AS 'CompanyName'
				  ,ISNULL(dca.[Address],'') AS 'Address'
				  ,ISNULL(dca.[Suburb],'')  AS 'Suberb' 
				  ,ISNULL(dca.[State],'') AS 'State'
				  ,ISNULL(dca.[PostCode],'')  AS 'PostCode'				 
				  ,ISNULL(coun.[ShortName],'') AS 'Country'
				  ,ISNULL(dca.[ContactName],'') + ' ' + ISNULL(dca.[ContactPhone],'') AS 'ContactDetails'
				  ,o.[IsWeeklyShipment] AS 'IsWeeklyShipment'
				  ,o.[IsAdelaideWareHouse] AS 'IsAdelaideWareHouse'
				  ,ISNULL(od.[DespatchTo], 0) AS 'ShipTo'
				  ,ISNULL(CAST((SELECT CASE
										WHEN (p.[SubItem] IS NULL)
											THEN  	('')
										ELSE (CAST((SELECT TOP 1 hsc.[Code] FROM [dbo].[HSCode] hsc WHERE hsc.[ItemSubCategory] = p.[SubItem] AND hsc.[Gender] = p.[Gender]) AS nvarchar(64)))
								END) AS nvarchar (64)), '') AS 'HSCode'
			  FROM [Indico].[dbo].[OrderDetail] od				
				LEFT OUTER JOIN [dbo].[VisualLayout] vl
					ON od.[VisualLayout] = vl.[ID]
				LEFT OUTER JOIN [dbo].[Pattern] p 
					ON od.[Pattern] = p.[ID]
				LEFT OUTER JOIN [dbo].[FabricCode] fc
					ON od.[FabricCode] = fc.[ID]
				LEFT OUTER JOIN [dbo].[OrderDetailStatus] ods
					ON od.[Status] = ods.[ID]
				LEFT OUTER JOIN [dbo].[OrderType] ot
					ON od.[OrderType] = ot.[ID]
				INNER JOIN [dbo].[Order] o
					ON od.[Order] = o.[ID]	
				LEFT OUTER JOIN [dbo].[Company] c
					ON c.[ID] = o.[Distributor]
				LEFT OUTER JOIN [dbo].[User] u
					ON c.[Coordinator] = u.[ID]
				LEFT OUTER JOIN [dbo].[Client] cl
					ON o.[Client] = cl.[ID]
				LEFT OUTER JOIN [dbo].[OrderStatus] os
					ON o.[Status] = os.[ID]				
				LEFT OUTER JOIN [dbo].[ShipmentMode] shm
					ON o.[ShipmentMode] = shm.[ID] 
				LEFT OUTER JOIN [dbo].[DistributorClientAddress] dca
					ON od.[DespatchTo] = dca.[ID]
				LEFT OUTER JOIN [dbo].[Country] coun
					ON dca.[Country] = coun.[ID]
			WHERE (od.[SheduledDate] BETWEEN cast(DATEADD(wk, DATEDIFF(wk, 0, @P_WeekEndDate), 0) as DATE) AND DATEADD(day, 2, CONVERT (date, @P_WeekEndDate))) AND
				  (@P_CompanyName = '' OR dca.[CompanyName] = @P_CompanyName ) AND
				  (@P_ShipmentMode = 0 OR shm.[ID] = @P_ShipmentMode)
			ORDER BY cl.[Name]

	END 

GO


