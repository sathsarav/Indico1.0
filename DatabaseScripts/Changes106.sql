USE [Indico]
GO


ALTER TABLE [dbo].[Order]
DROP COLUMN [PhotoApprovalReq]
GO

--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**


ALTER TABLE [dbo].[OrderDetail]
ADD [PhotoApprovalReq] [bit] NULL
GO

--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**


UPDATE [dbo].[OrderDetail] SET [PhotoApprovalReq] = 0 

--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**


INSERT INTO [Indico].[dbo].[OrderDetailStatus]
           ([Name], [Description], [Company], [Priority]) VALUES ('Waiting Info', 'Factory Waiting Info', 2, 18)
GO

--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**

DECLARE @Page AS int
DECLARE @ParentPage AS int 
DECLARE @Parent AS int
DECLARE @MenuItem AS int
DECLARE @Role AS int 

SET @Page = (SELECT [ID] FROM [dbo].[Page] WHERE [Name] = '/ViewWeeklyCapacities.aspx')
SET @ParentPage = (SELECT [ID] FROM [dbo].[Page] WHERE [Name] = '/Home.aspx')
SET @Parent = (SELECT [ID] FROM [dbo].[MenuItem] WHERE [Page] = @ParentPage AND [Parent] IS NULL)
SET @MenuItem = (SELECT [ID] FROM [dbo].[MenuItem] WHERE [Page] = @Page AND [Parent] = @Parent)
SET @Role = (SELECT [ID] FROM [dbo].[Role] WHERE [Description] = 'Factory Coordinator')

INSERT INTO [Indico].[dbo].[MenuItemRole] ([MenuItem], [Role]) VALUES (@MenuItem, @Role)
GO

--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**

--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**

DECLARE @Page AS int
DECLARE @ParentPage AS int 
DECLARE @Parent AS int
DECLARE @MenuItem AS int
DECLARE @Role AS int 

SET @Page = (SELECT [ID] FROM [dbo].[Page] WHERE [Name] = '/PackingList.aspx')
SET @ParentPage = (SELECT [ID] FROM [dbo].[Page] WHERE [Name] = '/ViewOrders.aspx')
SET @Parent = (SELECT [ID] FROM [dbo].[MenuItem] WHERE [Page] = @ParentPage AND [Parent] IS NULL)
SET @MenuItem = (SELECT [ID] FROM [dbo].[MenuItem] WHERE [Page] = @Page AND [Parent] = @Parent)
SET @Role = (SELECT [ID] FROM [dbo].[Role] WHERE [Description] = 'Factory Coordinator')

INSERT INTO [Indico].[dbo].[MenuItemRole] ([MenuItem], [Role]) VALUES (@MenuItem, @Role)
GO
--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**

DECLARE @Page AS int
DECLARE @ParentPage AS int 
DECLARE @Parent AS int
DECLARE @MenuItem AS int
DECLARE @Role AS int 

SET @Page = (SELECT [ID] FROM [dbo].[Page] WHERE [Name] = '/ViewPackingLists.aspx')
SET @ParentPage = (SELECT [ID] FROM [dbo].[Page] WHERE [Name] = '/ViewOrders.aspx')
SET @Parent = (SELECT [ID] FROM [dbo].[MenuItem] WHERE [Page] = @ParentPage AND [Parent] IS NULL)
SET @MenuItem = (SELECT [ID] FROM [dbo].[MenuItem] WHERE [Page] = @Page AND [Parent] = @Parent)
SET @Role = (SELECT [ID] FROM [dbo].[Role] WHERE [Description] = 'Factory Coordinator')

INSERT INTO [Indico].[dbo].[MenuItemRole] ([MenuItem], [Role]) VALUES (@MenuItem, @Role)
GO

--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**
DECLARE @Page AS int
DECLARE @ParentPage AS int 
DECLARE @Parent AS int
DECLARE @MenuItem AS int
DECLARE @Role AS int 

SET @Page = (SELECT [ID] FROM [dbo].[Page] WHERE [Name] = '/ViewWeekDetails.aspx')
SET @ParentPage = (SELECT [ID] FROM [dbo].[Page] WHERE [Name] = '/Home.aspx')
SET @Parent = (SELECT [ID] FROM [dbo].[MenuItem] WHERE [Page] = @ParentPage AND [Parent] IS NULL)
SET @MenuItem = (SELECT [ID] FROM [dbo].[MenuItem] WHERE [Page] = @Page AND [Parent] = @Parent)
SET @Role = (SELECT [ID] FROM [dbo].[Role] WHERE [Description] = 'Factory Coordinator')

INSERT INTO [Indico].[dbo].[MenuItemRole] ([MenuItem], [Role]) VALUES (@MenuItem, @Role)
GO

--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**
DECLARE @Page AS int
DECLARE @ParentPage AS int 
DECLARE @Parent AS int
DECLARE @MenuItem AS int
DECLARE @Role AS int 

SET @Page = (SELECT [ID] FROM [dbo].[Page] WHERE [Name] = '/ViewSummaryDetails.aspx')
SET @ParentPage = (SELECT [ID] FROM [dbo].[Page] WHERE [Name] = '/Home.aspx')
SET @Parent = (SELECT [ID] FROM [dbo].[MenuItem] WHERE [Page] = @ParentPage AND [Parent] IS NULL)
SET @MenuItem = (SELECT [ID] FROM [dbo].[MenuItem] WHERE [Page] = @Page AND [Parent] = @Parent)
SET @Role = (SELECT [ID] FROM [dbo].[Role] WHERE [Description] = 'Factory Coordinator')

INSERT INTO [Indico].[dbo].[MenuItemRole] ([MenuItem], [Role]) VALUES (@MenuItem, @Role)
GO

--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**

UPDATE [dbo].[Order] SET [DespatchToExistingClient] = 50 WHERE [DespatchToExistingClient] IS NULL AND [Distributor] = 13
GO


UPDATE [dbo].[Order] SET [DespatchToExistingClient] = (SELECT [ID] FROM [dbo].[DistributorClientAddress] WHERE [CompanyName] = 'INDICO ADELAIDE') WHERE [DespatchToExistingClient] IS NULL
GO

--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**
/****** Object:  StoredProcedure [dbo].[SPC_GetWeeklyFirmOrders]    Script Date: 09/29/2014 12:07:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPC_GetWeeklyFirmOrders]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SPC_GetWeeklyFirmOrders]
GO

/****** Object:  StoredProcedure [dbo].[SPC_GetWeeklyFirmOrders]    Script Date: 09/29/2014 12:07:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/********* ALTER STORED PROCEDURE [SPC_GetWeeklyFirmOrders]*************/
CREATE PROCEDURE [dbo].[SPC_GetWeeklyFirmOrders] (	
	@P_WeekEndDate datetime2(7),
	@P_SearchText AS NVARCHAR(255) = '',
	@P_OrderStatus AS NVARCHAR(255) = '',
	@P_Sort AS int = 0, --0 CreatedDate,--1 VL, --2 Pattern Number, --3 Order Detail Type, --4  Order Detail Status, --5 Old Po No, --6 Coordinator, --7 Distributor, --8 Client, --9 Order Status
	@P_OrderBy AS bit = 1,  -- 0 ASC , -- 1 DESC
	@P_Set AS int = 0,
	@P_MaxRows AS int = 20,
	@P_RecCount int OUTPUT,
	@P_Coordinator AS NVARCHAR(255) = '',
	@P_Distributor AS NVARCHAR(255) = '',
	@P_Clients AS NVARCHAR(255) = ''
)
AS
BEGIN

SET NOCOUNT ON
	DECLARE @Orders TABLE
	(
    OrderID int NOT NULL
	);
	DECLARE @StartOffset AS int;
	DECLARE @orderid AS int;
	SET @StartOffset = (@P_Set - 1) * @P_MaxRows;
	
	
	IF (ISNUMERIC(@P_SearchText) = 1 )
		BEGIN
			SET @orderid = CONVERT(int, @P_SearchText)		
		END
	ELSE
		BEGIN
			SET @orderid = 0
		END;
		
		/*WITH Orders AS
		(
		SELECT DISTINCT TOP (@P_Set * @P_MaxRows)
		CONVERT(int, ROW_NUMBER() OVER ( ORDER BY o.[ID] DESC))
		AS Number,
		 o.[ID]
			 FROM [Indico].[dbo].[OrderDetail] od
										JOIN [dbo].[Order] o
											ON od.[Order] = o.[ID]
										JOIN [dbo].[VisualLayout] vl
											ON od.[VisualLayout] = vl.[ID]
										JOIN [dbo].[Pattern] p 
											ON od.[Pattern] = p.[ID]
										JOIN [dbo].[FabricCode] fc
											ON od.[FabricCode] = fc.[ID]
										LEFT OUTER JOIN [dbo].[OrderDetailStatus] ods
											ON od.[Status] = ods.[ID]
										JOIN [dbo].[OrderType] ot
											ON od.[OrderType] = ot.[ID]
										JOIN [dbo].[Company] c
											ON c.[ID] = o.[Distributor]
										JOIN [dbo].[User] u
											ON c.[Coordinator] = u.[ID]
										JOIN [dbo].[Client] cl
											ON o.[Client] = cl.[ID]
										JOIN [dbo].[OrderStatus] os
											ON o.[Status] = os.[ID]
										JOIN [dbo].[User] urc
											ON o.[Creator] = urc.[ID]
										JOIN [dbo].[User] urm
											ON o.[Modifier] = urm.[ID] 
									WHERE (@P_SearchText = '' OR
										   o.[OldPONo] LIKE '%' + @P_SearchText + '%' OR
										   u.[GivenName]  LIKE '%' + @P_SearchText + '%' OR
										   u.[FamilyName] LIKE '%' + @P_SearchText + '%' OR
										   p.[Number] LIKE '%' + @P_SearchText + '%' OR 
										   p.[NickName] LIKE '%' + @P_SearchText + '%' OR
										   vl.[NamePrefix] LIKE '%' + @P_SearchText + '%' OR 
										   vl.[NameSuffix] LIKE '%' + @P_SearchText + '%' OR 
										   ods.[Name] LIKE '%' + @P_SearchText + '%' OR 
										   ot.[Name] LIKE '%' + @P_SearchText + '%' OR
										   c.[Name] LIKE '%' + @P_SearchText + '%' OR 
										   cl.[Name] LIKE '%' + @P_SearchText + '%' OR					
										   fc.[Code] LIKE '%' + @P_SearchText + '%' OR 
										   fc.[Name] LIKE '%' + @P_SearchText + '%'  OR
										   o.[ID] = @orderid )AND
										  (@P_OrderStatus = '' OR os.[Name] LIKE '%' + @P_OrderStatus + '%') AND
								          (o.[Reservation] IS NULL) AND
								          (od.[SheduledDate] > DATEADD(day, -7, @P_WeekEndDate) AND od.[SheduledDate] <= @P_WeekEndDate)AND
										  (@P_Coordinator = '' OR (u.[GivenName] + ' ' + u.[FamilyName]) LIKE '%' + @P_Coordinator + '%') AND
										  (@P_Distributor = '' OR c.[Name] LIKE '%' + @P_Distributor + '%')	AND
										  (@P_Clients = '' OR cl.[Name] LIKE '%' + @P_Clients + '%') AND
										  (od.[Status] IS NULL  OR od.[Status] IN ((SELECT [ID] FROM [dbo].[OrderDetailStatus]  WHERE [Name] = 'ODS Printed' OR [Name] = 'On Hold' OR [Name] = 'Cancelled')))
								      GROUP BY o.[ID]
		 )
	
	INSERT INTO @Orders ([OrderID]) 
	SELECT  ID FROM Orders WHERE Number > @StartOffset;	
	*/
													
	
	--WITH OrderDetails AS
	--	(
			SELECT 			
				   od.[ID] AS OrderDetail
				  ,ot.[Name] AS OrderType
				  ,vl.[NamePrefix] + ISNULL(CAST(vl.[NameSuffix] AS nvarchar(255)),'') AS VisualLayout
				  ,od.[VisualLayout] AS VisualLayoutID
				  ,od.[Pattern] AS PatternID
				  ,p.[Number] + ' - ' + p.[NickName] AS Pattern
				  ,od.[FabricCode] AS FabricID
				  ,fc.[Code] + ' - ' + fc.[Name] AS Fabric
				  ,od.[VisualLayoutNotes] AS VisualLayoutNotes      
				  ,od.[Order] AS 'Order'
				  ,ISNULL(od.[Label], 0) AS Label
				  ,ISNULL(ods.[Name], 'New') AS OrderDetailStatus
				  ,ISNULL(od.[Status], 0) AS OrderDetailStatusID
				  ,od.[ShipmentDate] AS ShipmentDate
				  ,od.[SheduledDate] AS SheduledDate      
				  ,od.[RequestedDate] AS RequestedDate
				  ,ISNULL((SELECT SUM(odq.[Qty]) FROM [dbo].[OrderDetailQty] odq WHERE odq.[OrderDetail] = od.[ID]),0) AS Quantity      
				  ,(SELECT DATEDIFF(day, od.[RequestedDate], od.[SheduledDate])) AS 'DateDiffrence'
				  ,ISNULL(o.[OldPONo], '') AS 'PurONo'
				  ,c.[Name] AS Distributor
				  ,u.[GivenName] + ' ' + u.[FamilyName] AS Coordinator
				  ,cl.[Name] AS Client
				  ,os.[Name] AS OrderStatus
				  ,o.[Status] AS OrderStatusID
				  ,urc.[GivenName] + ' ' + urc.[FamilyName] AS Creator
				  ,o.[Creator] AS CreatorID
				  ,o.[CreatedDate] AS CreatedDate
				  ,urm.[GivenName] + ' ' + urm.[FamilyName] AS Modifier
				  ,o.[ModifiedDate] AS ModifiedDate
				  ,ISNULL(pm.[Name], '') AS PaymentMethod
				  ,ISNULL(sm.[Name], '') AS ShipmentMethod
				  ,o.[IsWeeklyShipment]  AS WeeklyShiment
				  ,o.[IsCourierDelivery]  AS CourierDelivery
				  ,o.[IsAdelaideWareHouse] AS AdelaideWareHouse
				  ,o.[IsFollowingAddress] AS FollowingAddress
				  ,ISNULL(dca.[CompanyName] + ' ' + dca.[Address] + ' ' + dca.[Suburb] + ' ' + ISNULL(dca.[State], '') + ' ' + co.[ShortName] + ' ' + dca.[PostCode], '') AS ShippingAddress
				  ,ISNULL(dp.[Name], '') AS DestinationPort
				  ,ISNULL(vl.[ResolutionProfile], 0 ) AS ResolutionProfile
			 FROM [Indico].[dbo].[OrderDetail] od
				JOIN [dbo].[Order] o
					ON od.[Order] = o.[ID]
				JOIN [dbo].[VisualLayout] vl
					ON od.[VisualLayout] = vl.[ID]
				JOIN [dbo].[Pattern] p 
					ON od.[Pattern] = p.[ID]
				JOIN [dbo].[FabricCode] fc
					ON od.[FabricCode] = fc.[ID]
				LEFT OUTER JOIN [dbo].[OrderDetailStatus] ods
					ON od.[Status] = ods.[ID]
				JOIN [dbo].[OrderType] ot
					ON od.[OrderType] = ot.[ID]
				JOIN [dbo].[Company] c
					ON c.[ID] = o.[Distributor]
				JOIN [dbo].[User] u
					ON c.[Coordinator] = u.[ID]
				JOIN [dbo].[Client] cl
					ON o.[Client] = cl.[ID]
				JOIN [dbo].[OrderStatus] os
					ON o.[Status] = os.[ID]
				JOIN [dbo].[User] urc
					ON o.[Creator] = urc.[ID]
				JOIN [dbo].[User] urm
					ON o.[Modifier] = urm.[ID] 
				LEFT OUTER JOIN [dbo].[PaymentMethod] pm
					ON o.[PaymentMethod] = pm.[ID]
				LEFT OUTER JOIN [dbo].[ShipmentMode] sm
					ON o.[ShipmentMode] = sm.[ID]
				LEFT OUTER JOIN [dbo].[DistributorClientAddress] dca
					ON o.[DespatchToExistingClient] = dca.[ID]
				LEFT OUTER JOIN [dbo].[Country] co
					ON dca.[Country] = co.[ID]
				LEFT OUTER JOIN [dbo].[DestinationPort] dp
					ON dca.[Port] = dp.[ID]
			WHERE (@P_SearchText = '' OR
				   o.[OldPONo] LIKE '%' + @P_SearchText + '%' OR
				   u.[GivenName]  LIKE '%' + @P_SearchText + '%' OR
				   u.[FamilyName] LIKE '%' + @P_SearchText + '%' OR
				   p.[Number] LIKE '%' + @P_SearchText + '%' OR 
				   p.[NickName] LIKE '%' + @P_SearchText + '%' OR
				   vl.[NamePrefix] LIKE '%' + @P_SearchText + '%' OR 
				   vl.[NameSuffix] LIKE '%' + @P_SearchText + '%' OR 
				   ods.[Name] LIKE '%' + @P_SearchText + '%' OR 
				   ot.[Name] LIKE '%' + @P_SearchText + '%' OR
				   c.[Name] LIKE '%' + @P_SearchText + '%' OR 
				   cl.[Name] LIKE '%' + @P_SearchText + '%' OR					
				   fc.[Code] LIKE '%' + @P_SearchText + '%' OR 
				   fc.[Name] LIKE '%' + @P_SearchText + '%'  OR
				   o.[ID] = @orderid )AND
				  (@P_OrderStatus = '' OR os.[Name] LIKE '%' + @P_OrderStatus + '%') AND
		          (o.[Reservation] IS NULL) AND
		          (od.[SheduledDate] BETWEEN cast(DATEADD(wk, DATEDIFF(wk, 0, @P_WeekEndDate), 0) as DATE) AND DATEADD(day, 2, CONVERT (date, @P_WeekEndDate)))AND
				  (@P_Coordinator = '' OR (u.[GivenName] + ' ' + u.[FamilyName]) LIKE '%' + @P_Coordinator + '%') AND
				  (@P_Distributor = '' OR c.[Name] LIKE '%' + @P_Distributor + '%')	AND
				  (@P_Clients = '' OR cl.[Name] LIKE '%' + @P_Clients + '%') AND
				  (od.[Status] IS NULL  OR od.[Status] IN ((SELECT [ID] FROM [dbo].[OrderDetailStatus]  WHERE [Name] = 'ODS Printed' OR [Name] = 'On Hold' OR [Name] = 'Pre Shipped')))
							
	--	)
	--SELECT * FROM OrderDetails --WHERE ID > @StartOffset
	
	/*IF (@P_Set = 1)	
		BEGIN 
			SELECT  @P_RecCount = COUNT(ord.[ID]) 
			FROM (SELECT DISTINCT o.[ID] FROM [Indico].[dbo].[OrderDetail] od
														JOIN [dbo].[Order] o
															ON od.[Order] = o.[ID]
														JOIN [dbo].[VisualLayout] vl
															ON od.[VisualLayout] = vl.[ID]
														JOIN [dbo].[Pattern] p 
															ON od.[Pattern] = p.[ID]
														JOIN [dbo].[FabricCode] fc
															ON od.[FabricCode] = fc.[ID]
														LEFT OUTER JOIN [dbo].[OrderDetailStatus] ods
															ON od.[Status] = ods.[ID]
														JOIN [dbo].[OrderType] ot
															ON od.[OrderType] = ot.[ID]
														JOIN [dbo].[Company] c
															ON c.[ID] = o.[Distributor]
														JOIN [dbo].[User] u
															ON c.[Coordinator] = u.[ID]
														JOIN [dbo].[Client] cl
															ON o.[Client] = cl.[ID]
														JOIN [dbo].[OrderStatus] os
															ON o.[Status] = os.[ID]
														JOIN [dbo].[User] urc
															ON o.[Creator] = urc.[ID]
														JOIN [dbo].[User] urm
															ON o.[Modifier] = urm.[ID] 
													WHERE (@P_SearchText = '' OR
														   o.[OldPONo] LIKE '%' + @P_SearchText + '%' OR
														   u.[GivenName]  LIKE '%' + @P_SearchText + '%' OR
														   u.[FamilyName] LIKE '%' + @P_SearchText + '%' OR
														   p.[Number] LIKE '%' + @P_SearchText + '%' OR 
														   p.[NickName] LIKE '%' + @P_SearchText + '%' OR
														   vl.[NamePrefix] LIKE '%' + @P_SearchText + '%' OR 
														   vl.[NameSuffix] LIKE '%' + @P_SearchText + '%' OR 
														   ods.[Name] LIKE '%' + @P_SearchText + '%' OR 
														   ot.[Name] LIKE '%' + @P_SearchText + '%' OR
														   c.[Name] LIKE '%' + @P_SearchText + '%' OR 
														   cl.[Name] LIKE '%' + @P_SearchText + '%' OR					
														   fc.[Code] LIKE '%' + @P_SearchText + '%' OR 
														   fc.[Name] LIKE '%' + @P_SearchText + '%'  OR
														   o.[ID] = @orderid )AND
														  (@P_OrderStatus = '' OR os.[Name] LIKE '%' + @P_OrderStatus + '%') AND
												          (o.[Reservation] IS NULL) AND
												          (od.[SheduledDate] > DATEADD(day, -7, @P_WeekEndDate) AND od.[SheduledDate] <= @P_WeekEndDate)AND
														  (@P_Coordinator = '' OR (u.[GivenName] + ' ' + u.[FamilyName]) LIKE '%' + @P_Coordinator + '%') AND
														  (@P_Distributor = '' OR c.[Name] LIKE '%' + @P_Distributor + '%')	AND
														  (@P_Clients = '' OR cl.[Name] LIKE '%' + @P_Clients + '%') AND
														  (od.[Status] IS NULL  OR od.[Status] IN ((SELECT [ID] FROM [dbo].[OrderDetailStatus]  WHERE [Name] = 'ODS Printed' OR [Name] = 'On Hold' OR [Name] = 'Cancelled')))) ord
		END
	ELSE
		BEGIN*/
			SET @P_RecCount = 0
		--END	
		
END
GO
--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**


/****** Object:  StoredProcedure [dbo].[SPC_ProductionCapacities]    Script Date: 09/29/2014 12:08:58 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPC_ProductionCapacities]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SPC_ProductionCapacities]
GO

/****** Object:  StoredProcedure [dbo].[SPC_ProductionCapacities]    Script Date: 09/29/2014 12:08:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO









CREATE PROCEDURE [dbo].[SPC_ProductionCapacities] (	
	
	@P_WeekEndDate datetime2(7)
)
AS
BEGIN

	DECLARE @Capacities TABLE
	(
		Firms int,
		ResevationOrders int,
		Resevations int,
		Holds int,
		Less5Items int,
		Jackets int,
		Samples int
	)
	
	INSERT INTO @Capacities
	VALUES
	(
		-- Firm Orders
		(	SELECT  ISNULL(SUM(odq.Qty),0) AS Firms  
			FROM [Order] o
				JOIN OrderDetail od
					ON o.ID = od.[Order]  
				JOIN OrderDetailQty odq 
					ON od.ID = odq.OrderDetail 
						WHERE (od.[SheduledDate] BETWEEN cast(DATEADD(wk, DATEDIFF(wk, 0, @P_WeekEndDate), 0) as DATE) AND DATEADD(day, 2, CONVERT (date, @P_WeekEndDate)))
						AND (o.[Reservation] IS NULL)
						AND (od.[Status] IS NULL  OR od.[Status] IN ((SELECT [ID] FROM [dbo].[OrderDetailStatus]  WHERE [Name] = 'ODS Printed' OR [Name] = 'On Hold' OR [Name] = 'Pre Shipped')))),
		-- Resevation order quantities
		(	 (SELECT ISNULL(SUM (r.[Qty]), 0)      
					FROM [dbo].[Reservation] r
					WHERE (r.[ShipmentDate] BETWEEN CAST(DATEADD(wk, DATEDIFF(wk, 0, @P_WeekEndDate), 0) as DATE) AND DATEADD(day, 2, CONVERT (date, @P_WeekEndDate))))),
		-- Resevation quantities
		(	SELECT ISNULL(SUM(odq.Qty),0) 
							FROM [OrderDetail] od				
								JOIN OrderDetailQty odq 
									ON od.ID = odq.OrderDetail
								JOIN Reservation r
									ON od.Reservation = r.ID 
							WHERE (od.[SheduledDate] BETWEEN cast(DATEADD(wk, DATEDIFF(wk, 0, @P_WeekEndDate), 0) as DATE) AND DATEADD(day, 2, CONVERT (date, @P_WeekEndDate)))
							AND (od.[Status] IS NULL  OR od.[Status] IN ((SELECT [ID] FROM [dbo].[OrderDetailStatus]  WHERE [Name] = 'ODS Printed' OR [Name] = 'On Hold' OR [Name] = 'Pre Shipped')))),
		-- Hold
		(	SELECT ISNULL(SUM(odq.[Qty]), 0) AS Hold
			 FROM [dbo].[OrderDetailQty] odq 
				JOIN [dbo].[OrderDetail] od
					ON	odq.[OrderDetail] = od.[ID]
				JOIN [dbo].[Order] o
					ON od.[Order] = o.[ID]
			 WHERE ((o.[Status] = (SELECT os.[ID] FROM [dbo].[OrderStatus] os WHERE os.[Name] = 'Indiman Hold')) OR
					((o.[Status] = (SELECT os.[ID] FROM [dbo].[OrderStatus] os WHERE os.[Name] = 'Indico Hold')))) AND
				   (od.[SheduledDate] > DATEADD(day, -7, @P_WeekEndDate) AND od.[SheduledDate] <= @P_WeekEndDate) AND
				   (od.[Status] IS NULL  OR od.[Status] IN ((SELECT [ID] FROM [dbo].[OrderDetailStatus]  WHERE [Name] = 'ODS Printed' OR [Name] = 'On Hold' OR [Name] = 'Pre Shipped')))),
		-- Less5Items
		(SELECT ISNULL(SUM(odq.[Qty]), 0)  AS Less5Items				 
										FROM dbo.[Order] o
											JOIN [OrderDetail] od
												ON o.[ID] = od.[Order]
											JOIN [OrderDetailQty] odq
												ON od.[ID] = odq.[OrderDetail]
										WHERE o.ID IN (	 SELECT o.ID	
														 FROM dbo.[Order] o
															  JOIN OrderDetail od 
																   ON o.ID = od.[Order] 
															  JOIN OrderDetailQty odq
																   ON od.ID = odq.OrderDetail
														GROUP BY o.ID
														HAVING SUM(odq.Qty) <= 5
														UNION
														SELECT o.ID	
														FROM dbo.[Order] o
															  JOIN OrderDetail od 
																   ON o.ID = od.[Order] 
															  JOIN OrderDetailQty odq
																   ON od.ID = odq.OrderDetail
															  JOIN Reservation res 
																   ON o.Reservation = res.ID
														GROUP BY o.ID
														HAVING SUM(odq.Qty) <= 5)AND (od.[SheduledDate] BETWEEN cast(DATEADD(wk, DATEDIFF(wk, 0, @P_WeekEndDate), 0) as DATE) AND DATEADD(day, 2, CONVERT (date, @P_WeekEndDate)))
														AND (od.[Status] IS NULL  OR od.[Status] IN ((SELECT [ID] FROM [dbo].[OrderDetailStatus]  WHERE [Name] = 'ODS Printed' OR [Name] = 'On Hold' OR [Name] = 'Pre Shipped')))),

		-- JacketsOrders
		(SELECT ISNULL(SUM(odq.[Qty]), 0) AS Jackets 				  
										FROM [Order] o
											JOIN OrderDetail od
												ON o.ID = od.[Order]
											JOIN [OrderDetailQty] odq
												ON od.[ID] = odq.[OrderDetail]
											JOIN Pattern p
												ON p.ID = od.Pattern
											JOIN Item i
												ON i.ID = p.Item
										WHERE i.Name LIKE '%JACKET%' AND i.Parent IS NULL
											AND  (od.[SheduledDate] BETWEEN cast(DATEADD(wk, DATEDIFF(wk, 0, @P_WeekEndDate), 0) as DATE) AND DATEADD(day, 2, CONVERT (date, @P_WeekEndDate)))
											AND  (p.IsActive = 1)
											AND (od.[Status] IS NULL  OR od.[Status] IN ((SELECT [ID] FROM [dbo].[OrderDetailStatus]  WHERE [Name] = 'ODS Printed' OR [Name] = 'On Hold' OR [Name] = 'Pre Shipped')))),
						
		-- SampleOrders
		(SELECT ISNULL(SUM(odq.[Qty]), 0) AS Samples											 
							   FROM dbo.[Order] o
									JOIN OrderDetail od
										ON o.ID =od.[Order]
									JOIN [OrderDetailQty] odq
										ON od.[ID] = odq.[OrderDetail]
									LEFT OUTER JOIN  Reservation res
										ON o.Reservation=res.ID
							   WHERE od.OrderType IN( (SELECT [ID] FROM [Indico].[dbo].[OrderType] WHERE [Name] = 'SAMPLE' OR [Name]  = 'DEV SAMPLE'))
									AND (od.[SheduledDate] BETWEEN cast(DATEADD(wk, DATEDIFF(wk, 0, @P_WeekEndDate), 0) as DATE) AND DATEADD(day, 2, CONVERT (date, @P_WeekEndDate)))
									AND (od.[Status] IS NULL  OR od.[Status] IN ((SELECT [ID] FROM [dbo].[OrderDetailStatus]  WHERE [Name] = 'ODS Printed' OR [Name] = 'On Hold' OR [Name] = 'Pre Shipped'))))

	)
	
	SELECT * FROM @Capacities

END




GO


--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**
DECLARE @ID AS int
DECLARE @OrderDetail AS int
DECLARE ChangeStatusCursor CURSOR FAST_FORWARD FOR 
SELECT ino.[ID]      
      ,ino.[OrderDetail]      
  FROM [Indico].[dbo].[InvoiceOrder] ino
	JOIN [dbo].[Invoice] i
		ON ino.[Invoice] = i.[ID]
  WHERE [WeeklyProductionCapacity] = 91	
OPEN ChangeStatusCursor 
	FETCH NEXT FROM ChangeStatusCursor INTO @ID, @OrderDetail
	WHILE @@FETCH_STATUS = 0 
	BEGIN 
	
		DECLARE @Order AS int 
		
		SET @Order = (SELECT [Order] FROM [dbo].[OrderDetail] WHERE [ID] = @OrderDetail)
		
		UPDATE [dbo].[OrderDetail] SET [Status] = 17 WHERE [ID] = @OrderDetail
		
		UPDATE [dbo].[Order] SET [Status] = 19 WHERE [ID] = @Order
	
		FETCH NEXT FROM ChangeStatusCursor INTO @ID, @OrderDetail
	END 

CLOSE ChangeStatusCursor 
DEALLOCATE ChangeStatusCursor		
GO
--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**

/****** Object:  StoredProcedure [dbo].[SPC_GetWeeklyHoldOrders]    Script Date: 09/29/2014 13:12:13 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPC_GetWeeklyHoldOrders]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SPC_GetWeeklyHoldOrders]
GO

/****** Object:  StoredProcedure [dbo].[SPC_GetWeeklyHoldOrders]    Script Date: 09/29/2014 13:12:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO





CREATE PROCEDURE [dbo].[SPC_GetWeeklyHoldOrders] (	
	@P_WeekEndDate datetime2(7),
	@P_SearchText AS NVARCHAR(255) = '',
	@P_OrderStatus AS NVARCHAR(255) = '',
	--@P_Sort AS int = 0, --0 CreatedDate,--1 VL, --2 Pattern Number, --3 Order Detail Type, --4  Order Detail Status, --5 Old Po No, --6 Coordinator, --7 Distributor, --8 Client, --9 Order Status
	--@P_OrderBy AS bit = 1,  -- 0 ASC , -- 1 DESC
	--@P_Set AS int = 0,
	--@P_MaxRows AS int = 20,
	--@P_RecCount int OUTPUT,
	@P_Coordinator AS NVARCHAR(255) = '',
	@P_Distributor AS NVARCHAR(255) = '',
	@P_Clients AS NVARCHAR(255) = ''
)
AS
BEGIN

SET NOCOUNT ON
	DECLARE @Orders TABLE
	(
    OrderID int NOT NULL
	);
	--DECLARE @StartOffset AS int;
	--SET @StartOffset = (@P_Set - 1) * @P_MaxRows;
	
	DECLARE @orderid AS int;
	IF (ISNUMERIC(@P_SearchText) = 1 )
		BEGIN
			SET @orderid = CONVERT(int, @P_SearchText)		
		END
	ELSE
		BEGIN
			SET @orderid = 0
		END;
		
		/*WITH Orders AS
		(
			SELECT DISTINCT TOP (@P_Set * @P_MaxRows)
			CONVERT(int, ROW_NUMBER() OVER ( ORDER BY o.[ID] DESC))
			AS Number,
			o.[ID]	
			FROM [Indico].[dbo].[OrderDetail] od
				JOIN [dbo].[Order] o
					ON od.[Order] = o.[ID]
				JOIN [dbo].[VisualLayout] vl
					ON od.[VisualLayout] = vl.[ID]
				JOIN [dbo].[Pattern] p 
					ON od.[Pattern] = p.[ID]
				JOIN [dbo].[FabricCode] fc
					ON od.[FabricCode] = fc.[ID]
				LEFT OUTER JOIN [dbo].[OrderDetailStatus] ods
					ON od.[Status] = ods.[ID]
				JOIN [dbo].[OrderType] ot
					ON od.[OrderType] = ot.[ID]
				JOIN [dbo].[Company] c
					ON c.[ID] = o.[Distributor]
				JOIN [dbo].[User] u
					ON c.[Coordinator] = u.[ID]
				JOIN [dbo].[Client] cl
					ON o.[Client] = cl.[ID]
				JOIN [dbo].[OrderStatus] os
					ON o.[Status] = os.[ID]
				JOIN [dbo].[User] urc
					ON o.[Creator] = urc.[ID]
				JOIN [dbo].[User] urm
					ON o.[Modifier] = urm.[ID] 														
			WHERE (@P_SearchText = '' OR
				   o.[OldPONo] LIKE '%' + @P_SearchText + '%' OR
				   u.[GivenName]  LIKE '%' + @P_SearchText + '%' OR
				   u.[FamilyName] LIKE '%' + @P_SearchText + '%' OR
				   p.[Number] LIKE '%' + @P_SearchText + '%' OR 
				   p.[NickName] LIKE '%' + @P_SearchText + '%' OR
				   vl.[NamePrefix] LIKE '%' + @P_SearchText + '%' OR 
				   vl.[NameSuffix] LIKE '%' + @P_SearchText + '%' OR 
				   ods.[Name] LIKE '%' + @P_SearchText + '%' OR 
				   ot.[Name] LIKE '%' + @P_SearchText + '%' OR
				   c.[Name] LIKE '%' + @P_SearchText + '%' OR 
				   cl.[Name] LIKE '%' + @P_SearchText + '%' OR					
				   fc.[Code] LIKE '%' + @P_SearchText + '%' OR 
				   fc.[Name] LIKE '%' + @P_SearchText + '%'  OR
				   o.[ID] = @orderid)AND														   
		           (od.[OrderType] = (SELECT odt.[ID] FROM [Indico].[dbo].[OrderType] odt WHERE odt.[Name] = 'SAMPLE')) AND
				  (@P_OrderStatus = '' OR os.[Name] LIKE '%' + @P_OrderStatus + '%') AND
				  (od.[SheduledDate] > DATEADD(day, -7, @P_WeekEndDate) AND od.[SheduledDate] <= @P_WeekEndDate)AND
				  (@P_Coordinator = '' OR (u.[GivenName] + ' ' + u.[FamilyName]) LIKE '%' + @P_Coordinator + '%') AND
				  (@P_Distributor = '' OR c.[Name] LIKE '%' + @P_Distributor + '%')	AND
				  (@P_Clients = '' OR cl.[Name] LIKE '%' + @P_Clients + '%') AND
				  (od.[Status] IS NULL  OR od.[Status] IN ((SELECT [ID] FROM [dbo].[OrderDetailStatus]  WHERE [Name] = 'ODS Printed' OR [Name] = 'On Hold' OR [Name] = 'Cancelled')))											           
			GROUP BY o.[ID] 
		)
	INSERT INTO @Orders ([OrderID]) 
	SELECT  ID FROM Orders WHERE Number > @StartOffset;		
	*/
	--WITH OrderDetails AS
		--(
			SELECT 			
				   od.[ID] AS OrderDetail
				  ,ot.[Name] AS OrderType
				  ,vl.[NamePrefix] + ISNULL(CAST(vl.[NameSuffix] AS nvarchar(255)),'') AS VisualLayout
				  ,od.[VisualLayout] AS VisualLayoutID
				  ,od.[Pattern] AS PatternID
				  ,p.[Number] + ' - ' + p.[NickName] AS Pattern
				  ,od.[FabricCode] AS FabricID
				  ,fc.[Code] + ' - ' + fc.[Name] AS Fabric
				  ,od.[VisualLayoutNotes] AS VisualLayoutNotes      
				  ,od.[Order] AS 'Order'
				  ,ISNULL(od.[Label], 0) AS Label
				  ,ISNULL(ods.[Name], 'New') AS OrderDetailStatus
				  ,ISNULL(od.[Status], 0) AS OrderDetailStatusID
				  ,od.[ShipmentDate] AS ShipmentDate
				  ,od.[SheduledDate] AS SheduledDate      
				  ,od.[RequestedDate] AS RequestedDate
				  ,ISNULL((SELECT SUM(odq.[Qty]) FROM [dbo].[OrderDetailQty] odq WHERE odq.[OrderDetail] = od.[ID]),0) AS Quantity      
				  ,(SELECT DATEDIFF(day, od.[RequestedDate], od.[SheduledDate])) AS 'DateDiffrence'
				  ,ISNULL(o.[OldPONo], '') AS 'PurONo'
				  ,c.[Name] AS Distributor
				  ,u.[GivenName] + ' ' + u.[FamilyName] AS Coordinator
				  ,cl.[Name] AS Client
				  ,os.[Name] AS OrderStatus
				  ,o.[Status] AS OrderStatusID
				  ,urc.[GivenName] + ' ' + urc.[FamilyName] AS Creator
				  ,o.[Creator] AS CreatorID
				  ,o.[CreatedDate] AS CreatedDate
				  ,urm.[GivenName] + ' ' + urm.[FamilyName] AS Modifier
				  ,o.[ModifiedDate] AS ModifiedDate
				  ,ISNULL(pm.[Name], '') AS PaymentMethod
				  ,ISNULL(sm.[Name], '') AS ShipmentMethod
				  ,o.[IsWeeklyShipment]  AS WeeklyShiment
				  ,o.[IsCourierDelivery]  AS CourierDelivery
				  ,o.[IsAdelaideWareHouse] AS AdelaideWareHouse
				  ,o.[IsFollowingAddress] AS FollowingAddress
				  ,ISNULL(dca.[CompanyName] + ' ' + dca.[Address] + ' ' + dca.[Suburb] + ' ' + ISNULL(dca.[State], '') + ' ' + co.[ShortName] + ' ' + dca.[PostCode], '') AS ShippingAddress
				  ,ISNULL(dp.[Name], '') AS DestinationPort
				  ,ISNULL(vl.[ResolutionProfile], 0 ) AS ResolutionProfile
			  FROM [Indico].[dbo].[OrderDetail] od
				JOIN [dbo].[Order] o
					ON od.[Order] = o.[ID]
				JOIN [dbo].[VisualLayout] vl
					ON od.[VisualLayout] = vl.[ID]
				JOIN [dbo].[Pattern] p 
					ON od.[Pattern] = p.[ID]
				JOIN [dbo].[FabricCode] fc
					ON od.[FabricCode] = fc.[ID]
				LEFT OUTER JOIN [dbo].[OrderDetailStatus] ods
					ON od.[Status] = ods.[ID]
				JOIN [dbo].[OrderType] ot
					ON od.[OrderType] = ot.[ID]
				JOIN [dbo].[Company] c
					ON c.[ID] = o.[Distributor]
				JOIN [dbo].[User] u
					ON c.[Coordinator] = u.[ID]
				JOIN [dbo].[Client] cl
					ON o.[Client] = cl.[ID]
				JOIN [dbo].[OrderStatus] os
					ON o.[Status] = os.[ID]
				JOIN [dbo].[User] urc
					ON o.[Creator] = urc.[ID]
				JOIN [dbo].[User] urm
					ON o.[Modifier] = urm.[ID]
				LEFT OUTER JOIN [dbo].[PaymentMethod] pm
					ON o.[PaymentMethod] = pm.[ID]
				LEFT OUTER JOIN [dbo].[ShipmentMode] sm
					ON o.[ShipmentMode] = sm.[ID]
				LEFT OUTER JOIN [dbo].[DistributorClientAddress] dca
					ON o.[DespatchToExistingClient] = dca.[ID]
				LEFT OUTER JOIN [dbo].[Country] co
					ON dca.[Country] = co.[ID]
				LEFT OUTER JOIN [dbo].[DestinationPort] dp
					ON dca.[Port] = dp.[ID] 														
			WHERE (@P_SearchText = '' OR
				   o.[OldPONo] LIKE '%' + @P_SearchText + '%' OR
				   u.[GivenName]  LIKE '%' + @P_SearchText + '%' OR
				   u.[FamilyName] LIKE '%' + @P_SearchText + '%' OR
				   p.[Number] LIKE '%' + @P_SearchText + '%' OR 
				   p.[NickName] LIKE '%' + @P_SearchText + '%' OR
				   vl.[NamePrefix] LIKE '%' + @P_SearchText + '%' OR 
				   vl.[NameSuffix] LIKE '%' + @P_SearchText + '%' OR 
				   ods.[Name] LIKE '%' + @P_SearchText + '%' OR 
				   ot.[Name] LIKE '%' + @P_SearchText + '%' OR
				   c.[Name] LIKE '%' + @P_SearchText + '%' OR 
				   cl.[Name] LIKE '%' + @P_SearchText + '%' OR					
				   fc.[Code] LIKE '%' + @P_SearchText + '%' OR 
				   fc.[Name] LIKE '%' + @P_SearchText + '%'  OR
				   o.[ID] = @orderid)AND														   
		          ((o.[Status] = (SELECT os.[ID] FROM [dbo].[OrderStatus] os WHERE os.[Name] = 'Indiman Hold'))OR
		           (o.[Status] = (SELECT os.[ID] FROM [dbo].[OrderStatus] os WHERE os.[Name] = 'Indico Hold'))) AND
				  (@P_OrderStatus = '' OR os.[Name] LIKE '%' + @P_OrderStatus + '%') AND
				  (od.[SheduledDate] BETWEEN cast(DATEADD(wk, DATEDIFF(wk, 0, @P_WeekEndDate), 0) as DATE) AND DATEADD(day, 2, CONVERT (date, @P_WeekEndDate)))AND
				  (@P_Coordinator = '' OR (u.[GivenName] + ' ' + u.[FamilyName]) LIKE '%' + @P_Coordinator + '%') AND
				  (@P_Distributor = '' OR c.[Name] LIKE '%' + @P_Distributor + '%')	AND
				  (@P_Clients = '' OR cl.[Name] LIKE '%' + @P_Clients + '%') AND
				  (od.[Status] IS NULL  OR od.[Status] IN ((SELECT [ID] FROM [dbo].[OrderDetailStatus]  WHERE [Name] = 'ODS Printed' OR [Name] = 'On Hold' OR [Name] = 'Pre Shipped')))										
		--)
	/*SELECT * FROM OrderDetails-- WHERE ID > @StartOffset
	
	IF (@P_Set = 1)	
		BEGIN 
			SELECT  @P_RecCount = COUNT(ord.[ID]) 
			FROM (SELECT DISTINCT o.[ID] FROM [Indico].[dbo].[OrderDetail] od
														JOIN [dbo].[Order] o
															ON od.[Order] = o.[ID]
														JOIN [dbo].[VisualLayout] vl
															ON od.[VisualLayout] = vl.[ID]
														JOIN [dbo].[Pattern] p 
															ON od.[Pattern] = p.[ID]
														JOIN [dbo].[FabricCode] fc
															ON od.[FabricCode] = fc.[ID]
														LEFT OUTER JOIN [dbo].[OrderDetailStatus] ods
															ON od.[Status] = ods.[ID]
														JOIN [dbo].[OrderType] ot
															ON od.[OrderType] = ot.[ID]
														JOIN [dbo].[Company] c
															ON c.[ID] = o.[Distributor]
														JOIN [dbo].[User] u
															ON c.[Coordinator] = u.[ID]
														JOIN [dbo].[Client] cl
															ON o.[Client] = cl.[ID]
														JOIN [dbo].[OrderStatus] os
															ON o.[Status] = os.[ID]
														JOIN [dbo].[User] urc
															ON o.[Creator] = urc.[ID]
														JOIN [dbo].[User] urm
															ON o.[Modifier] = urm.[ID] 														
													WHERE (@P_SearchText = '' OR
														   o.[OldPONo] LIKE '%' + @P_SearchText + '%' OR
														   u.[GivenName]  LIKE '%' + @P_SearchText + '%' OR
														   u.[FamilyName] LIKE '%' + @P_SearchText + '%' OR
														   p.[Number] LIKE '%' + @P_SearchText + '%' OR 
														   p.[NickName] LIKE '%' + @P_SearchText + '%' OR
														   vl.[NamePrefix] LIKE '%' + @P_SearchText + '%' OR 
														   vl.[NameSuffix] LIKE '%' + @P_SearchText + '%' OR 
														   ods.[Name] LIKE '%' + @P_SearchText + '%' OR 
														   ot.[Name] LIKE '%' + @P_SearchText + '%' OR
														   c.[Name] LIKE '%' + @P_SearchText + '%' OR 
														   cl.[Name] LIKE '%' + @P_SearchText + '%' OR					
														   fc.[Code] LIKE '%' + @P_SearchText + '%' OR 
														   fc.[Name] LIKE '%' + @P_SearchText + '%'  OR
														   o.[ID] = @orderid )AND														   
												           (od.[OrderType] = (SELECT odt.[ID] FROM [Indico].[dbo].[OrderType] odt WHERE odt.[Name] = 'SAMPLE')) AND
														   (@P_OrderStatus = '' OR os.[Name] LIKE '%' + @P_OrderStatus + '%') AND
														   (od.[SheduledDate] > DATEADD(day, -7, @P_WeekEndDate) AND od.[SheduledDate] <= @P_WeekEndDate)AND
														   (@P_Coordinator = '' OR (u.[GivenName] + ' ' + u.[FamilyName]) LIKE '%' + @P_Coordinator + '%') AND
														   (@P_Distributor = '' OR c.[Name] LIKE '%' + @P_Distributor + '%')	AND
														   (@P_Clients = '' OR cl.[Name] LIKE '%' + @P_Clients + '%') AND
														   (od.[Status] IS NULL  OR od.[Status] IN ((SELECT [ID] FROM [dbo].[OrderDetailStatus]  WHERE [Name] = 'ODS Printed' OR [Name] = 'On Hold' OR [Name] = 'Cancelled')))) ord
		END
	ELSE
		BEGIN*/
			--SET @P_RecCount = 0
		--END			

END



GO

--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**

/****** Object:  StoredProcedure [dbo].[SPC_GetWeeklyJacketOrders]    Script Date: 09/29/2014 13:15:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPC_GetWeeklyJacketOrders]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SPC_GetWeeklyJacketOrders]
GO


/****** Object:  StoredProcedure [dbo].[SPC_GetWeeklyJacketOrders]    Script Date: 09/29/2014 13:15:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




/********* ALTER STORED PROCEDURE [SPC_GetWeeklyJacketOrders]*************/

CREATE PROCEDURE [dbo].[SPC_GetWeeklyJacketOrders] (	
	@P_WeekEndDate datetime2(7),
	@P_SearchText AS NVARCHAR(255) = '',
	@P_OrderStatus AS NVARCHAR(255) = '',
	@P_Sort AS int = 0, --0 CreatedDate,--1 VL, --2 Pattern Number, --3 Order Detail Type, --4  Order Detail Status, --5 Old Po No, --6 Coordinator, --7 Distributor, --8 Client, --9 Order Status
	@P_OrderBy AS bit = 1,  -- 0 ASC , -- 1 DESC
	@P_Set AS int = 0,
	@P_MaxRows AS int = 20,
	@P_RecCount int OUTPUT,
	@P_Coordinator AS NVARCHAR(255) = '',
	@P_Distributor AS NVARCHAR(255) = '',
	@P_Clients AS NVARCHAR(255) = ''
)
AS
BEGIN


	SET NOCOUNT ON
	DECLARE @Orders TABLE
	(
    OrderID int NOT NULL
	);
	DECLARE @StartOffset AS int;
	SET @StartOffset = (@P_Set - 1) * @P_MaxRows;
	
	DECLARE @orderid AS int;
	IF (ISNUMERIC(@P_SearchText) = 1 )
		BEGIN
			SET @orderid = CONVERT(int, @P_SearchText)		
		END
	ELSE
		BEGIN
			SET @orderid = 0
		END;
		
		/*WITH Orders AS
		(
		SELECT DISTINCT TOP (@P_Set * @P_MaxRows)
		CONVERT(int, ROW_NUMBER() OVER ( ORDER BY o.[ID] DESC))
		AS Number,
		 o.[ID]
		 FROM [Indico].[dbo].[OrderDetail] od
						JOIN [dbo].[Order] o
							ON od.[Order] = o.[ID]
						JOIN [dbo].[VisualLayout] vl
							ON od.[VisualLayout] = vl.[ID]
						JOIN [dbo].[Pattern] p 
							ON od.[Pattern] = p.[ID]
						JOIN [dbo].[FabricCode] fc
							ON od.[FabricCode] = fc.[ID]
						LEFT OUTER JOIN [dbo].[OrderDetailStatus] ods
							ON od.[Status] = ods.[ID]
						JOIN [dbo].[OrderType] ot
							ON od.[OrderType] = ot.[ID]
						JOIN [dbo].[Company] c
							ON c.[ID] = o.[Distributor]
						JOIN [dbo].[User] u
							ON c.[Coordinator] = u.[ID]
						JOIN [dbo].[Client] cl
							ON o.[Client] = cl.[ID]
						JOIN [dbo].[OrderStatus] os
							ON o.[Status] = os.[ID]
						JOIN [dbo].[User] urc
							ON o.[Creator] = urc.[ID]
						JOIN [dbo].[User] urm
							ON o.[Modifier] = urm.[ID] 
					WHERE (@P_SearchText = '' OR
						   o.[OldPONo] LIKE '%' + @P_SearchText + '%' OR
						   u.[GivenName]  LIKE '%' + @P_SearchText + '%' OR
						   u.[FamilyName] LIKE '%' + @P_SearchText + '%' OR
						   p.[Number] LIKE '%' + @P_SearchText + '%' OR 
						   p.[NickName] LIKE '%' + @P_SearchText + '%' OR
						   vl.[NamePrefix] LIKE '%' + @P_SearchText + '%' OR 
						   vl.[NameSuffix] LIKE '%' + @P_SearchText + '%' OR 
						   ods.[Name] LIKE '%' + @P_SearchText + '%' OR 
						   ot.[Name] LIKE '%' + @P_SearchText + '%' OR
						   c.[Name] LIKE '%' + @P_SearchText + '%' OR 
						   cl.[Name] LIKE '%' + @P_SearchText + '%' OR					
						   fc.[Code] LIKE '%' + @P_SearchText + '%' OR 
						   fc.[Name] LIKE '%' + @P_SearchText + '%'  OR
						   o.[ID] = @orderid )AND
						  (@P_OrderStatus = '' OR os.[Name] LIKE '%' + @P_OrderStatus + '%') AND
						  (p.[Item] = (SELECT i.[ID] FROM [Indico].[dbo].[Item] i WHERE i.[Name] = 'JACKET' AND i.[Parent] IS NULL)) AND
						  (od.[SheduledDate] > DATEADD(day, -7, @P_WeekEndDate) AND od.[SheduledDate] <= @P_WeekEndDate)AND
						  (@P_Coordinator = '' OR (u.[GivenName] + ' ' + u.[FamilyName]) LIKE '%' + @P_Coordinator + '%') AND
						  (@P_Distributor = '' OR c.[Name] LIKE '%' + @P_Distributor + '%')	AND
						  (@P_Clients = '' OR cl.[Name] LIKE '%' + @P_Clients + '%') AND
						  (od.[Status] IS NULL  OR od.[Status] IN ((SELECT [ID] FROM [dbo].[OrderDetailStatus]  WHERE [Name] = 'ODS Printed' OR [Name] = 'On Hold' OR [Name] = 'Cancelled')))
					GROUP BY  o.[ID]
		 )
	
		INSERT INTO @Orders ([OrderID]) 
		SELECT  ID FROM Orders WHERE Number > @StartOffset;	
	*/
	---WITH OrderDetails AS
		--(
			SELECT 			
				   od.[ID] AS OrderDetail
				  ,ot.[Name] AS OrderType
				  ,vl.[NamePrefix] + ISNULL(CAST(vl.[NameSuffix] AS nvarchar(255)),'') AS VisualLayout
				  ,od.[VisualLayout] AS VisualLayoutID
				  ,od.[Pattern] AS PatternID
				  ,p.[Number] + ' - ' + p.[NickName] AS Pattern
				  ,od.[FabricCode] AS FabricID
				  ,fc.[Code] + ' - ' + fc.[Name] AS Fabric
				  ,od.[VisualLayoutNotes] AS VisualLayoutNotes      
				  ,od.[Order] AS 'Order'
				  ,ISNULL(od.[Label], 0) AS Label
				  ,ISNULL(ods.[Name], 'New') AS OrderDetailStatus
				  ,ISNULL(od.[Status], 0) AS OrderDetailStatusID
				  ,od.[ShipmentDate] AS ShipmentDate
				  ,od.[SheduledDate] AS SheduledDate      
				  ,od.[RequestedDate] AS RequestedDate
				  ,ISNULL((SELECT SUM(odq.[Qty]) FROM [dbo].[OrderDetailQty] odq WHERE odq.[OrderDetail] = od.[ID]),0) AS Quantity      
				  ,(SELECT DATEDIFF(day, od.[RequestedDate], od.[SheduledDate])) AS 'DateDiffrence'
				  ,ISNULL(o.[OldPONo], '') AS 'PurONo'
				  ,c.[Name] AS Distributor
				  ,u.[GivenName] + ' ' + u.[FamilyName] AS Coordinator
				  ,o.[Creator] AS CreatorID
				  ,cl.[Name] AS Client
				  ,os.[Name] AS OrderStatus
				  ,o.[Status] AS OrderStatusID
				  ,urc.[GivenName] + ' ' + urc.[FamilyName] AS Creator
				  ,o.[CreatedDate] AS CreatedDate
				  ,urm.[GivenName] + ' ' + urm.[FamilyName] AS Modifier
				  ,o.[ModifiedDate] AS ModifiedDate
				  ,ISNULL(pm.[Name], '') AS PaymentMethod
				  ,ISNULL(sm.[Name], '') AS ShipmentMethod
				  ,o.[IsWeeklyShipment]  AS WeeklyShiment
				  ,o.[IsCourierDelivery]  AS CourierDelivery
				  ,o.[IsAdelaideWareHouse] AS AdelaideWareHouse
				  ,o.[IsFollowingAddress] AS FollowingAddress
				  ,ISNULL(dca.[CompanyName] + ' ' + dca.[Address] + ' ' + dca.[Suburb] + ' ' + ISNULL(dca.[State], '') + ' ' + co.[ShortName] + ' ' + dca.[PostCode], '') AS ShippingAddress
				  ,ISNULL(dp.[Name], '') AS DestinationPort
				  ,ISNULL(vl.[ResolutionProfile], 0 ) AS ResolutionProfile
			  FROM [Indico].[dbo].[OrderDetail] od
						JOIN [dbo].[Order] o
							ON od.[Order] = o.[ID]
						JOIN [dbo].[VisualLayout] vl
							ON od.[VisualLayout] = vl.[ID]
						JOIN [dbo].[Pattern] p 
							ON od.[Pattern] = p.[ID]
						JOIN [dbo].[FabricCode] fc
							ON od.[FabricCode] = fc.[ID]
						LEFT OUTER JOIN [dbo].[OrderDetailStatus] ods
							ON od.[Status] = ods.[ID]
						JOIN [dbo].[OrderType] ot
							ON od.[OrderType] = ot.[ID]
						JOIN [dbo].[Company] c
							ON c.[ID] = o.[Distributor]
						JOIN [dbo].[User] u
							ON c.[Coordinator] = u.[ID]
						JOIN [dbo].[Client] cl
							ON o.[Client] = cl.[ID]
						JOIN [dbo].[OrderStatus] os
							ON o.[Status] = os.[ID]
						JOIN [dbo].[User] urc
							ON o.[Creator] = urc.[ID]
						JOIN [dbo].[User] urm
							ON o.[Modifier] = urm.[ID]
						LEFT OUTER JOIN [dbo].[PaymentMethod] pm
							ON o.[PaymentMethod] = pm.[ID]
						LEFT OUTER JOIN [dbo].[ShipmentMode] sm
							ON o.[ShipmentMode] = sm.[ID]
						LEFT OUTER JOIN [dbo].[DistributorClientAddress] dca
							ON o.[DespatchToExistingClient] = dca.[ID]
						LEFT OUTER JOIN [dbo].[Country] co
							ON dca.[Country] = co.[ID]
						LEFT OUTER JOIN [dbo].[DestinationPort] dp
							ON dca.[Port] = dp.[ID]
				WHERE (@P_SearchText = '' OR
					   o.[OldPONo] LIKE '%' + @P_SearchText + '%' OR
					   u.[GivenName]  LIKE '%' + @P_SearchText + '%' OR
					   u.[FamilyName] LIKE '%' + @P_SearchText + '%' OR
					   p.[Number] LIKE '%' + @P_SearchText + '%' OR 
					   p.[NickName] LIKE '%' + @P_SearchText + '%' OR
					   vl.[NamePrefix] LIKE '%' + @P_SearchText + '%' OR 
					   vl.[NameSuffix] LIKE '%' + @P_SearchText + '%' OR 
					   ods.[Name] LIKE '%' + @P_SearchText + '%' OR 
					   ot.[Name] LIKE '%' + @P_SearchText + '%' OR
					   c.[Name] LIKE '%' + @P_SearchText + '%' OR 
					   cl.[Name] LIKE '%' + @P_SearchText + '%' OR					
					   fc.[Code] LIKE '%' + @P_SearchText + '%' OR 
					   fc.[Name] LIKE '%' + @P_SearchText + '%'  OR
					   o.[ID] = @orderid )AND
					  (@P_OrderStatus = '' OR os.[Name] LIKE '%' + @P_OrderStatus + '%') AND
					  (p.[Item] IN((SELECT i.[ID] FROM [Indico].[dbo].[Item] i WHERE i.[Name] LIKE '%JACKET%' AND i.[Parent] IS NULL))) AND
					  (od.[SheduledDate] BETWEEN cast(DATEADD(wk, DATEDIFF(wk, 0, @P_WeekEndDate), 0) as DATE) AND DATEADD(day, 2, CONVERT (date, @P_WeekEndDate)))AND
					  (@P_Coordinator = '' OR (u.[GivenName] + ' ' + u.[FamilyName]) LIKE '%' + @P_Coordinator + '%') AND
					  (@P_Distributor = '' OR c.[Name] LIKE '%' + @P_Distributor + '%')	AND
					  (@P_Clients = '' OR cl.[Name] LIKE '%' + @P_Clients + '%') AND				  
					  (od.[Status] IS NULL  OR od.[Status] IN ((SELECT [ID] FROM [dbo].[OrderDetailStatus]  WHERE [Name] = 'ODS Printed' OR [Name] = 'On Hold' OR [Name] = 'Pre Shipped')))	
							
							
			/*WHERE  o.[ID] IN (SELECT [OrderID] FROM @Orders) AND
				   (@orderid = 0 OR o.[ID] = @orderid) AND
				   (p.[Item] = (SELECT i.[ID] FROM [Indico].[dbo].[Item] i WHERE i.[Name] = 'JACKET' AND i.[Parent] IS NULL)) AND
				   (od.[Status] IS NULL  OR od.[Status] IN ((SELECT [ID] FROM [dbo].[OrderDetailStatus]  WHERE [Name] = 'ODS Printed' OR [Name] = 'On Hold' OR [Name] = 'Cancelled')))*/
	--	)
	/*SELECT * FROM OrderDetails --WHERE ID > @StartOffset
	
	IF (@P_Set = 1)	
		BEGIN 
			SELECT  @P_RecCount = COUNT(ord.[ID]) 
			FROM (SELECT DISTINCT o.[ID]  FROM [Indico].[dbo].[OrderDetail] od
														JOIN [dbo].[Order] o
															ON od.[Order] = o.[ID]
														JOIN [dbo].[VisualLayout] vl
															ON od.[VisualLayout] = vl.[ID]
														JOIN [dbo].[Pattern] p 
															ON od.[Pattern] = p.[ID]
														JOIN [dbo].[FabricCode] fc
															ON od.[FabricCode] = fc.[ID]
														LEFT OUTER JOIN [dbo].[OrderDetailStatus] ods
															ON od.[Status] = ods.[ID]
														JOIN [dbo].[OrderType] ot
															ON od.[OrderType] = ot.[ID]
														JOIN [dbo].[Company] c
															ON c.[ID] = o.[Distributor]
														JOIN [dbo].[User] u
															ON c.[Coordinator] = u.[ID]
														JOIN [dbo].[Client] cl
															ON o.[Client] = cl.[ID]
														JOIN [dbo].[OrderStatus] os
															ON o.[Status] = os.[ID]
														JOIN [dbo].[User] urc
															ON o.[Creator] = urc.[ID]
														JOIN [dbo].[User] urm
															ON o.[Modifier] = urm.[ID] 
													WHERE (@P_SearchText = '' OR
														   o.[OldPONo] LIKE '%' + @P_SearchText + '%' OR
														   u.[GivenName]  LIKE '%' + @P_SearchText + '%' OR
														   u.[FamilyName] LIKE '%' + @P_SearchText + '%' OR
														   p.[Number] LIKE '%' + @P_SearchText + '%' OR 
														   p.[NickName] LIKE '%' + @P_SearchText + '%' OR
														   vl.[NamePrefix] LIKE '%' + @P_SearchText + '%' OR 
														   vl.[NameSuffix] LIKE '%' + @P_SearchText + '%' OR 
														   ods.[Name] LIKE '%' + @P_SearchText + '%' OR 
														   ot.[Name] LIKE '%' + @P_SearchText + '%' OR
														   c.[Name] LIKE '%' + @P_SearchText + '%' OR 
														   cl.[Name] LIKE '%' + @P_SearchText + '%' OR					
														   fc.[Code] LIKE '%' + @P_SearchText + '%' OR 
														   fc.[Name] LIKE '%' + @P_SearchText + '%'  OR
														   o.[ID] = @orderid )AND
														  (@P_OrderStatus = '' OR os.[Name] LIKE '%' + @P_OrderStatus + '%') AND
														  (p.[Item] = (SELECT i.[ID] FROM [Indico].[dbo].[Item] i WHERE i.[Name] = 'JACKET' AND i.[Parent] IS NULL)) AND
														  (od.[SheduledDate] > DATEADD(day, -7, @P_WeekEndDate) AND od.[SheduledDate] <= @P_WeekEndDate)AND
														  (@P_Coordinator = '' OR (u.[GivenName] + ' ' + u.[FamilyName]) LIKE '%' + @P_Coordinator + '%') AND
														  (@P_Distributor = '' OR c.[Name] LIKE '%' + @P_Distributor + '%')	AND
														  (@P_Clients = '' OR cl.[Name] LIKE '%' + @P_Clients + '%') AND
														  (od.[Status] IS NULL  OR od.[Status] IN ((SELECT [ID] FROM [dbo].[OrderDetailStatus]  WHERE [Name] = 'ODS Printed' OR [Name] = 'On Hold' OR [Name] = 'Cancelled'))))ord
		END
	ELSE
		BEGIN*/
			SET @P_RecCount = 0
		--END					
END 






GO



--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**

/****** Object:  StoredProcedure [dbo].[SPC_GetWeeklyLessFiveItemOrders]    Script Date: 09/29/2014 13:17:32 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPC_GetWeeklyLessFiveItemOrders]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SPC_GetWeeklyLessFiveItemOrders]
GO

/****** Object:  StoredProcedure [dbo].[SPC_GetWeeklyLessFiveItemOrders]    Script Date: 09/29/2014 13:17:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[SPC_GetWeeklyLessFiveItemOrders] (		
	@P_WeekEndDate datetime2(7),
	@P_SearchText AS NVARCHAR(255) = '',
	@P_OrderStatus AS NVARCHAR(255) = '',
	@P_Sort AS int = 0, --0 CreatedDate,--1 VL, --2 Pattern Number, --3 Order Detail Type, --4  Order Detail Status, --5 Old Po No, --6 Coordinator, --7 Distributor, --8 Client, --9 Order Status
	@P_OrderBy AS bit = 1,  -- 0 ASC , -- 1 DESC
	@P_Set AS int = 0,
	@P_MaxRows AS int = 20,
	@P_RecCount int OUTPUT,
	@P_Coordinator AS NVARCHAR(255) = '',
	@P_Distributor AS NVARCHAR(255) = '',
	@P_Clients AS NVARCHAR(255) = ''
)
AS
BEGIN

SET NOCOUNT ON
	DECLARE @Orders TABLE
	(
    OrderID int NOT NULL
	);
	DECLARE @StartOffset AS int;
	SET @StartOffset = (@P_Set - 1) * @P_MaxRows;
	
	DECLARE @orderid AS int;
	IF (ISNUMERIC(@P_SearchText) = 1 )
		BEGIN
			SET @orderid = CONVERT(int, @P_SearchText)		
		END
	ELSE
		BEGIN
			SET @orderid = 0
		END;
		
		/*WITH Orders AS
		(
		SELECT DISTINCT TOP (@P_Set * @P_MaxRows)
		CONVERT(int, ROW_NUMBER() OVER ( ORDER BY o.[ID] DESC))
		AS Number,
		o.[ID]	
			FROM [Indico].[dbo].[OrderDetail] od
							JOIN [dbo].[Order] o
								ON od.[Order] = o.[ID]
							JOIN [dbo].[VisualLayout] vl
								ON od.[VisualLayout] = vl.[ID]
							JOIN [dbo].[Pattern] p 
								ON od.[Pattern] = p.[ID]
							JOIN [dbo].[FabricCode] fc
								ON od.[FabricCode] = fc.[ID]
							LEFT OUTER JOIN [dbo].[OrderDetailStatus] ods
								ON od.[Status] = ods.[ID]
							JOIN [dbo].[OrderType] ot
								ON od.[OrderType] = ot.[ID]
							JOIN [dbo].[Company] c
								ON c.[ID] = o.[Distributor]
							JOIN [dbo].[User] u
								ON c.[Coordinator] = u.[ID]
							JOIN [dbo].[Client] cl
								ON o.[Client] = cl.[ID]
							JOIN [dbo].[OrderStatus] os
								ON o.[Status] = os.[ID]
							JOIN [dbo].[User] urc
								ON o.[Creator] = urc.[ID]
							JOIN [dbo].[User] urm
								ON o.[Modifier] = urm.[ID] 
						WHERE (@P_SearchText = '' OR
							   o.[OldPONo] LIKE '%' + @P_SearchText + '%' OR
							   u.[GivenName]  LIKE '%' + @P_SearchText + '%' OR
							   u.[FamilyName] LIKE '%' + @P_SearchText + '%' OR
							   p.[Number] LIKE '%' + @P_SearchText + '%' OR 
							   p.[NickName] LIKE '%' + @P_SearchText + '%' OR
							   vl.[NamePrefix] LIKE '%' + @P_SearchText + '%' OR 
							   vl.[NameSuffix] LIKE '%' + @P_SearchText + '%' OR 
							   ods.[Name] LIKE '%' + @P_SearchText + '%' OR 
							   ot.[Name] LIKE '%' + @P_SearchText + '%' OR
							   c.[Name] LIKE '%' + @P_SearchText + '%' OR 
							   cl.[Name] LIKE '%' + @P_SearchText + '%' OR					
							   fc.[Code] LIKE '%' + @P_SearchText + '%' OR 
							   fc.[Name] LIKE '%' + @P_SearchText + '%'  OR
							   o.[ID] = @orderid )AND
							  (@P_OrderStatus = '' OR os.[Name] LIKE '%' + @P_OrderStatus + '%') AND
								o.[ID] IN (SELECT o.ID
											 FROM dbo.[Order] o
												  JOIN OrderDetail od 
													   ON o.ID = od.[Order] 
												  JOIN OrderDetailQty odq
													   ON od.ID = odq.OrderDetail
											GROUP BY o.ID
											HAVING SUM(odq.Qty) <= 5						
											UNION					
											SELECT o.ID	
											FROM dbo.[Order] o
												  JOIN OrderDetail od 
													   ON o.ID = od.[Order] 
												  JOIN OrderDetailQty odq
													   ON od.ID = odq.OrderDetail
												  JOIN Reservation res 
													   ON o.Reservation = res.ID
											GROUP BY o.ID
											HAVING SUM(odq.Qty) <= 5) AND
							(od.[SheduledDate] > DATEADD(day, -7, @P_WeekEndDate) AND od.[SheduledDate] <= @P_WeekEndDate)AND
							(@P_Coordinator = '' OR (u.[GivenName] + ' ' + u.[FamilyName]) LIKE '%' + @P_Coordinator + '%') AND
							(@P_Distributor = '' OR c.[Name] LIKE '%' + @P_Distributor + '%')	AND
							(@P_Clients = '' OR cl.[Name] LIKE '%' + @P_Clients + '%') AND
							(od.[Status] IS NULL  OR od.[Status] IN ((SELECT [ID] FROM [dbo].[OrderDetailStatus]  WHERE [Name] = 'ODS Printed' OR [Name] = 'On Hold' OR [Name] = 'Cancelled')))
						GROUP BY  o.[ID]
			)
			
		INSERT INTO @Orders ([OrderID]) 
		SELECT  ID FROM Orders WHERE Number > @StartOffset;	
	*/
	
	--WITH OrderDetails AS
	--	(
			SELECT 				
				   od.[ID] AS OrderDetail
				  ,ot.[Name] AS OrderType
				  ,vl.[NamePrefix] + ISNULL(CAST(vl.[NameSuffix] AS nvarchar(255)),'') AS VisualLayout
				  ,od.[VisualLayout] AS VisualLayoutID
				  ,od.[Pattern] AS PatternID
				  ,p.[Number] + ' - ' + p.[NickName] AS Pattern
				  ,od.[FabricCode] AS FabricID
				  ,fc.[Code] + ' - ' + fc.[Name] AS Fabric
				  ,od.[VisualLayoutNotes] AS VisualLayoutNotes      
				  ,od.[Order] AS 'Order'
				  ,ISNULL(od.[Label], 0) AS Label
				  ,ISNULL(ods.[Name], 'New') AS OrderDetailStatus
				  ,ISNULL(od.[Status], 0) AS OrderDetailStatusID
				  ,od.[ShipmentDate] AS ShipmentDate
				  ,od.[SheduledDate] AS SheduledDate      
				  ,od.[RequestedDate] AS RequestedDate
				  ,ISNULL((SELECT SUM(odq.[Qty]) FROM [dbo].[OrderDetailQty] odq WHERE odq.[OrderDetail] = od.[ID]),0) AS Quantity      
				  ,(SELECT DATEDIFF(day, od.[RequestedDate], od.[SheduledDate])) AS 'DateDiffrence'
				  ,ISNULL(o.[OldPONo], '') AS 'PurONo'
				  ,c.[Name] AS Distributor
				  ,u.[GivenName] + ' ' + u.[FamilyName] AS Coordinator
				  ,cl.[Name] AS Client
				  ,os.[Name] AS OrderStatus
				  ,o.[Status] AS OrderStatusID
				  ,urc.[GivenName] + ' ' + urc.[FamilyName] AS Creator
				  ,o.[Creator] AS CreatorID
				  ,o.[CreatedDate] AS CreatedDate
				  ,urm.[GivenName] + ' ' + urm.[FamilyName] AS Modifier
				  ,o.[ModifiedDate] AS ModifiedDate
				  ,ISNULL(pm.[Name], '') AS PaymentMethod
				  ,ISNULL(sm.[Name], '') AS ShipmentMethod
				  ,o.[IsWeeklyShipment]  AS WeeklyShiment
				  ,o.[IsCourierDelivery]  AS CourierDelivery
				  ,o.[IsAdelaideWareHouse] AS AdelaideWareHouse
				  ,o.[IsFollowingAddress] AS FollowingAddress
				  ,ISNULL(dca.[CompanyName] + ' ' + dca.[Address] + ' ' + dca.[Suburb] + ' ' + ISNULL(dca.[State], '') + ' ' + co.[ShortName] + ' ' + dca.[PostCode], '') AS ShippingAddress
				  ,ISNULL(dp.[Name], '') AS DestinationPort
				  ,ISNULL(vl.[ResolutionProfile], 0 ) AS ResolutionProfile
			 		FROM [Indico].[dbo].[OrderDetail] od
							JOIN [dbo].[Order] o
								ON od.[Order] = o.[ID]
							JOIN [dbo].[VisualLayout] vl
								ON od.[VisualLayout] = vl.[ID]
							JOIN [dbo].[Pattern] p 
								ON od.[Pattern] = p.[ID]
							JOIN [dbo].[FabricCode] fc
								ON od.[FabricCode] = fc.[ID]
							LEFT OUTER JOIN [dbo].[OrderDetailStatus] ods
								ON od.[Status] = ods.[ID]
							JOIN [dbo].[OrderType] ot
								ON od.[OrderType] = ot.[ID]
							JOIN [dbo].[Company] c
								ON c.[ID] = o.[Distributor]
							JOIN [dbo].[User] u
								ON c.[Coordinator] = u.[ID]
							JOIN [dbo].[Client] cl
								ON o.[Client] = cl.[ID]
							JOIN [dbo].[OrderStatus] os
								ON o.[Status] = os.[ID]
							JOIN [dbo].[User] urc
								ON o.[Creator] = urc.[ID]
							JOIN [dbo].[User] urm
								ON o.[Modifier] = urm.[ID]
							LEFT OUTER JOIN [dbo].[PaymentMethod] pm
								ON o.[PaymentMethod] = pm.[ID]
							LEFT OUTER JOIN [dbo].[ShipmentMode] sm
								ON o.[ShipmentMode] = sm.[ID]
							LEFT OUTER JOIN [dbo].[DistributorClientAddress] dca
								ON o.[DespatchToExistingClient] = dca.[ID]
							LEFT OUTER JOIN [dbo].[Country] co
								ON dca.[Country] = co.[ID]
							LEFT OUTER JOIN [dbo].[DestinationPort] dp
								ON dca.[Port] = dp.[ID]
						WHERE (@P_SearchText = '' OR
							   o.[OldPONo] LIKE '%' + @P_SearchText + '%' OR
							   u.[GivenName]  LIKE '%' + @P_SearchText + '%' OR
							   u.[FamilyName] LIKE '%' + @P_SearchText + '%' OR
							   p.[Number] LIKE '%' + @P_SearchText + '%' OR 
							   p.[NickName] LIKE '%' + @P_SearchText + '%' OR
							   vl.[NamePrefix] LIKE '%' + @P_SearchText + '%' OR 
							   vl.[NameSuffix] LIKE '%' + @P_SearchText + '%' OR 
							   ods.[Name] LIKE '%' + @P_SearchText + '%' OR 
							   ot.[Name] LIKE '%' + @P_SearchText + '%' OR
							   c.[Name] LIKE '%' + @P_SearchText + '%' OR 
							   cl.[Name] LIKE '%' + @P_SearchText + '%' OR					
							   fc.[Code] LIKE '%' + @P_SearchText + '%' OR 
							   fc.[Name] LIKE '%' + @P_SearchText + '%'  OR
							   o.[ID] = @orderid )AND
							  (@P_OrderStatus = '' OR os.[Name] LIKE '%' + @P_OrderStatus + '%') AND
								o.[ID] IN (SELECT o.ID
											 FROM dbo.[Order] o
												  JOIN OrderDetail od 
													   ON o.ID = od.[Order] 
												  JOIN OrderDetailQty odq
													   ON od.ID = odq.OrderDetail
											GROUP BY o.ID
											HAVING SUM(odq.Qty) <= 5						
											UNION					
											SELECT o.ID	
											FROM dbo.[Order] o
												  JOIN OrderDetail od 
													   ON o.ID = od.[Order] 
												  JOIN OrderDetailQty odq
													   ON od.ID = odq.OrderDetail
												  JOIN Reservation res 
													   ON o.Reservation = res.ID
											GROUP BY o.ID
											HAVING SUM(odq.Qty) <= 5) AND
							(od.[SheduledDate] BETWEEN cast(DATEADD(wk, DATEDIFF(wk, 0, @P_WeekEndDate), 0) as DATE) AND DATEADD(day, 2, CONVERT (date, @P_WeekEndDate)))AND
							(@P_Coordinator = '' OR (u.[GivenName] + ' ' + u.[FamilyName]) LIKE '%' + @P_Coordinator + '%') AND
							(@P_Distributor = '' OR c.[Name] LIKE '%' + @P_Distributor + '%')	AND
							(@P_Clients = '' OR cl.[Name] LIKE '%' + @P_Clients + '%') AND
							(od.[Status] IS NULL  OR od.[Status] IN ((SELECT [ID] FROM [dbo].[OrderDetailStatus]  WHERE [Name] = 'ODS Printed' OR [Name] = 'On Hold' OR [Name] = 'Pre Shipped')))
	--SELECT * FROM OrderDetails --WHERE ID > @StartOffset
	
	/*IF (@P_Set = 1)	
		BEGIN 
			SELECT  @P_RecCount = COUNT(ord.[ID]) 
			FROM (SELECT DISTINCT o.[ID] FROM [Indico].[dbo].[OrderDetail] od
														JOIN [dbo].[Order] o
															ON od.[Order] = o.[ID]
														JOIN [dbo].[VisualLayout] vl
															ON od.[VisualLayout] = vl.[ID]
														JOIN [dbo].[Pattern] p 
															ON od.[Pattern] = p.[ID]
														JOIN [dbo].[FabricCode] fc
															ON od.[FabricCode] = fc.[ID]
														LEFT OUTER JOIN [dbo].[OrderDetailStatus] ods
															ON od.[Status] = ods.[ID]
														JOIN [dbo].[OrderType] ot
															ON od.[OrderType] = ot.[ID]
														JOIN [dbo].[Company] c
															ON c.[ID] = o.[Distributor]
														JOIN [dbo].[User] u
															ON c.[Coordinator] = u.[ID]
														JOIN [dbo].[Client] cl
															ON o.[Client] = cl.[ID]
														JOIN [dbo].[OrderStatus] os
															ON o.[Status] = os.[ID]
														JOIN [dbo].[User] urc
															ON o.[Creator] = urc.[ID]
														JOIN [dbo].[User] urm
															ON o.[Modifier] = urm.[ID] 
													WHERE (@P_SearchText = '' OR
														   o.[OldPONo] LIKE '%' + @P_SearchText + '%' OR
														   u.[GivenName]  LIKE '%' + @P_SearchText + '%' OR
														   u.[FamilyName] LIKE '%' + @P_SearchText + '%' OR
														   p.[Number] LIKE '%' + @P_SearchText + '%' OR 
														   p.[NickName] LIKE '%' + @P_SearchText + '%' OR
														   vl.[NamePrefix] LIKE '%' + @P_SearchText + '%' OR 
														   vl.[NameSuffix] LIKE '%' + @P_SearchText + '%' OR 
														   ods.[Name] LIKE '%' + @P_SearchText + '%' OR 
														   ot.[Name] LIKE '%' + @P_SearchText + '%' OR
														   c.[Name] LIKE '%' + @P_SearchText + '%' OR 
														   cl.[Name] LIKE '%' + @P_SearchText + '%' OR					
														   fc.[Code] LIKE '%' + @P_SearchText + '%' OR 
														   fc.[Name] LIKE '%' + @P_SearchText + '%'  OR
														   o.[ID] = @orderid )AND
														  (@P_OrderStatus = '' OR os.[Name] LIKE '%' + @P_OrderStatus + '%') AND
														  (od.[SheduledDate] > DATEADD(day, -7, @P_WeekEndDate) AND od.[SheduledDate] <= @P_WeekEndDate) AND
															o.[ID] IN (SELECT o.ID
																		 FROM dbo.[Order] o
																			  JOIN OrderDetail od 
																				   ON o.ID = od.[Order] 
																			  JOIN OrderDetailQty odq
																				   ON od.ID = odq.OrderDetail
																		GROUP BY o.ID
																		HAVING SUM(odq.Qty) <= 5						
																		UNION					
																		SELECT o.ID	
																		FROM dbo.[Order] o
																			  JOIN OrderDetail od 
																				   ON o.ID = od.[Order] 
																			  JOIN OrderDetailQty odq
																				   ON od.ID = odq.OrderDetail
																			  JOIN Reservation res 
																				   ON o.Reservation = res.ID
																		GROUP BY o.ID
																		HAVING SUM(odq.Qty) <= 5)AND
														(@P_Coordinator = '' OR (u.[GivenName] + ' ' + u.[FamilyName]) LIKE '%' + @P_Coordinator + '%') AND
														(@P_Distributor = '' OR c.[Name] LIKE '%' + @P_Distributor + '%')	AND
														(@P_Clients = '' OR cl.[Name] LIKE '%' + @P_Clients + '%') AND
														(od.[Status] IS NULL  OR od.[Status] IN ((SELECT [ID] FROM [dbo].[OrderDetailStatus]  WHERE [Name] = 'ODS Printed' OR [Name] = 'On Hold' OR [Name] = 'Cancelled')))) ord
		END
	ELSE
		BEGIN*/
			SET @P_RecCount = 0
		--END	
END





GO

--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**
/****** Object:  StoredProcedure [dbo].[SPC_GetWeeklyReservationOrders]    Script Date: 09/29/2014 13:18:35 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPC_GetWeeklyReservationOrders]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SPC_GetWeeklyReservationOrders]
GO

/****** Object:  StoredProcedure [dbo].[SPC_GetWeeklyReservationOrders]    Script Date: 09/29/2014 13:18:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPC_GetWeeklyReservationOrders] (		
	@P_WeekEndDate datetime2(7),
	@P_SearchText AS NVARCHAR(255) = '',
	@P_OrderStatus AS NVARCHAR(255) = '',
	@P_Sort AS int = 0, --0 CreatedDate,--1 VL, --2 Pattern Number, --3 Order Detail Type, --4  Order Detail Status, --5 Old Po No, --6 Coordinator, --7 Distributor, --8 Client, --9 Order Status
	@P_OrderBy AS bit = 1,  -- 0 ASC , -- 1 DESC
	@P_Set AS int = 0,
	@P_MaxRows AS int = 20,
	@P_RecCount int OUTPUT,
	@P_Coordinator AS NVARCHAR(255) = '',
	@P_Distributor AS NVARCHAR(255) = '',
	@P_Clients AS NVARCHAR(255) = ''
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Orders TABLE
	(
    OrderID int NOT NULL
	);
	DECLARE @StartOffset AS int;
	SET @StartOffset = (@P_Set - 1) * @P_MaxRows;
	
	DECLARE @orderid AS int;
	IF (ISNUMERIC(@P_SearchText) = 1 )
		BEGIN
			SET @orderid = CONVERT(int, @P_SearchText)		
		END
	ELSE
		BEGIN
			SET @orderid = 0
		END;
		
		/*WITH Orders AS
		(
			SELECT DISTINCT TOP (@P_Set * @P_MaxRows)
			CONVERT(int, ROW_NUMBER() OVER ( ORDER BY o.[ID] DESC))
			AS Number,
			o.[ID]	
			 FROM [Indico].[dbo].[OrderDetail] od
										JOIN [dbo].[Order] o
											ON od.[Order] = o.[ID]
										JOIN [dbo].[VisualLayout] vl
											ON od.[VisualLayout] = vl.[ID]
										JOIN [dbo].[Pattern] p 
											ON od.[Pattern] = p.[ID]
										JOIN [dbo].[FabricCode] fc
											ON od.[FabricCode] = fc.[ID]
										LEFT OUTER JOIN [dbo].[OrderDetailStatus] ods
											ON od.[Status] = ods.[ID]
										JOIN [dbo].[OrderType] ot
											ON od.[OrderType] = ot.[ID]
										JOIN [dbo].[Company] c
											ON c.[ID] = o.[Distributor]
										JOIN [dbo].[User] u
											ON c.[Coordinator] = u.[ID]
										JOIN [dbo].[Client] cl
											ON o.[Client] = cl.[ID]
										JOIN [dbo].[OrderStatus] os
											ON o.[Status] = os.[ID]
										JOIN [dbo].[User] urc
											ON o.[Creator] = urc.[ID]
										JOIN [dbo].[User] urm
											ON o.[Modifier] = urm.[ID] 
										JOIN [dbo].[Reservation] res
											ON o.[Reservation] = res.[ID] 
									WHERE (@P_SearchText = '' OR
										   o.[OldPONo] LIKE '%' + @P_SearchText + '%' OR
										   u.[GivenName]  LIKE '%' + @P_SearchText + '%' OR
										   u.[FamilyName] LIKE '%' + @P_SearchText + '%' OR
										   p.[Number] LIKE '%' + @P_SearchText + '%' OR 
										   p.[NickName] LIKE '%' + @P_SearchText + '%' OR
										   vl.[NamePrefix] LIKE '%' + @P_SearchText + '%' OR 
										   vl.[NameSuffix] LIKE '%' + @P_SearchText + '%' OR 
										   ods.[Name] LIKE '%' + @P_SearchText + '%' OR 
										   ot.[Name] LIKE '%' + @P_SearchText + '%' OR
										   c.[Name] LIKE '%' + @P_SearchText + '%' OR 
										   cl.[Name] LIKE '%' + @P_SearchText + '%' OR					
										   fc.[Code] LIKE '%' + @P_SearchText + '%' OR 
										   fc.[Name] LIKE '%' + @P_SearchText + '%'  OR
										   o.[ID] = @orderid )AND
										  (@P_OrderStatus = '' OR os.[Name] LIKE '%' + @P_OrderStatus + '%') AND
										  (od.[SheduledDate] > DATEADD(day, -7, @P_WeekEndDate) AND od.[SheduledDate] <= @P_WeekEndDate)AND
										  (@P_Coordinator = '' OR (u.[GivenName] + ' ' + u.[FamilyName]) LIKE '%' + @P_Coordinator + '%') AND
										  (@P_Distributor = '' OR c.[Name] LIKE '%' + @P_Distributor + '%')	AND
										  (@P_Clients = '' OR cl.[Name] LIKE '%' + @P_Clients + '%') AND
										  (od.[Status] IS NULL  OR od.[Status] IN ((SELECT [ID] FROM [dbo].[OrderDetailStatus]  WHERE [Name] = 'ODS Printed' OR [Name] = 'On Hold' OR [Name] = 'Cancelled')))
										  
									GROUP BY o.[ID]
			)
	
		INSERT INTO @Orders ([OrderID]) 
		SELECT  ID FROM Orders WHERE Number > @StartOffset;	
	*/
	--WITH OrderDetails AS
	--	(
			SELECT 			
				   od.[ID] AS OrderDetail
				  ,ot.[Name] AS OrderType
				  ,vl.[NamePrefix] + ISNULL(CAST(vl.[NameSuffix] AS nvarchar(255)),'') AS VisualLayout
				  ,od.[VisualLayout] AS VisualLayoutID
				  ,od.[Pattern] AS PatternID
				  ,p.[Number] + ' - ' + p.[NickName] AS Pattern
				  ,od.[FabricCode] AS FabricID
				  ,fc.[Code] + ' - ' + fc.[Name] AS Fabric
				  ,od.[VisualLayoutNotes] AS VisualLayoutNotes      
				  ,od.[Order] AS 'Order'
				  ,ISNULL(od.[Label], 0) AS Label
				  ,ISNULL(ods.[Name], 'New') AS OrderDetailStatus
				  ,ISNULL(od.[Status], 0) AS OrderDetailStatusID
				  ,od.[ShipmentDate] AS ShipmentDate
				  ,od.[SheduledDate] AS SheduledDate      
				  ,od.[RequestedDate] AS RequestedDate
				  ,ISNULL((SELECT SUM(odq.[Qty]) FROM [dbo].[OrderDetailQty] odq WHERE odq.[OrderDetail] = od.[ID]),0) AS Quantity      
				  ,(SELECT DATEDIFF(day, od.[RequestedDate], od.[SheduledDate])) AS 'DateDiffrence'
				  ,ISNULL(o.[OldPONo], '') AS 'PurONo'
				  ,c.[Name] AS Distributor
				  ,u.[GivenName] + ' ' + u.[FamilyName] AS Coordinator
				  ,cl.[Name] AS Client
				  ,os.[Name] AS OrderStatus
				  ,o.[Status] AS OrderStatusID
				  ,urc.[GivenName] + ' ' + urc.[FamilyName] AS Creator
				  ,o.[Creator] AS CreatorID
				  ,o.[CreatedDate] AS CreatedDate
				  ,urm.[GivenName] + ' ' + urm.[FamilyName] AS Modifier
				  ,o.[ModifiedDate] AS ModifiedDate
				  ,ISNULL(pm.[Name], '') AS PaymentMethod
				  ,ISNULL(sm.[Name], '') AS ShipmentMethod
				  ,o.[IsWeeklyShipment]  AS WeeklyShiment
				  ,o.[IsCourierDelivery]  AS CourierDelivery
				  ,o.[IsAdelaideWareHouse] AS AdelaideWareHouse
				  ,o.[IsFollowingAddress] AS FollowingAddress
				  ,ISNULL(dca.[CompanyName] + ' ' + dca.[Address] + ' ' + dca.[Suburb] + ' ' + ISNULL(dca.[State], '') + ' ' + co.[ShortName] + ' ' + dca.[PostCode], '') AS ShippingAddress
				  ,ISNULL(dp.[Name], '') AS DestinationPort
				  ,ISNULL(vl.[ResolutionProfile], 0 ) AS ResolutionProfile
			  FROM [Indico].[dbo].[OrderDetail] od
					JOIN [dbo].[Order] o
						ON od.[Order] = o.[ID]
					JOIN [dbo].[VisualLayout] vl
						ON od.[VisualLayout] = vl.[ID]
					JOIN [dbo].[Pattern] p 
						ON od.[Pattern] = p.[ID]
					JOIN [dbo].[FabricCode] fc
						ON od.[FabricCode] = fc.[ID]
					LEFT OUTER JOIN [dbo].[OrderDetailStatus] ods
						ON od.[Status] = ods.[ID]
					JOIN [dbo].[OrderType] ot
						ON od.[OrderType] = ot.[ID]
					JOIN [dbo].[Company] c
						ON c.[ID] = o.[Distributor]
					JOIN [dbo].[User] u
						ON c.[Coordinator] = u.[ID]
					JOIN [dbo].[Client] cl
						ON o.[Client] = cl.[ID]
					JOIN [dbo].[OrderStatus] os
						ON o.[Status] = os.[ID]
					JOIN [dbo].[User] urc
						ON o.[Creator] = urc.[ID]
					JOIN [dbo].[User] urm
						ON o.[Modifier] = urm.[ID] 
					JOIN [dbo].[Reservation] res
						ON od.[Reservation] = res.[ID]
					LEFT OUTER JOIN [dbo].[PaymentMethod] pm
						ON o.[PaymentMethod] = pm.[ID]
					LEFT OUTER JOIN [dbo].[ShipmentMode] sm
						ON o.[ShipmentMode] = sm.[ID]
					LEFT OUTER JOIN [dbo].[DistributorClientAddress] dca
						ON o.[DespatchToExistingClient] = dca.[ID]
					LEFT OUTER JOIN [dbo].[Country] co
						ON dca.[Country] = co.[ID]
					LEFT OUTER JOIN [dbo].[DestinationPort] dp
						ON dca.[Port] = dp.[ID] 
				WHERE (@P_SearchText = '' OR
					   o.[OldPONo] LIKE '%' + @P_SearchText + '%' OR
					   u.[GivenName]  LIKE '%' + @P_SearchText + '%' OR
					   u.[FamilyName] LIKE '%' + @P_SearchText + '%' OR
					   p.[Number] LIKE '%' + @P_SearchText + '%' OR 
					   p.[NickName] LIKE '%' + @P_SearchText + '%' OR
					   vl.[NamePrefix] LIKE '%' + @P_SearchText + '%' OR 
					   vl.[NameSuffix] LIKE '%' + @P_SearchText + '%' OR 
					   ods.[Name] LIKE '%' + @P_SearchText + '%' OR 
					   ot.[Name] LIKE '%' + @P_SearchText + '%' OR
					   c.[Name] LIKE '%' + @P_SearchText + '%' OR 
					   cl.[Name] LIKE '%' + @P_SearchText + '%' OR					
					   fc.[Code] LIKE '%' + @P_SearchText + '%' OR 
					   fc.[Name] LIKE '%' + @P_SearchText + '%'  OR
					   o.[ID] = @orderid )AND
					  (@P_OrderStatus = '' OR os.[Name] LIKE '%' + @P_OrderStatus + '%') AND
					  (od.[SheduledDate] BETWEEN cast(DATEADD(wk, DATEDIFF(wk, 0, @P_WeekEndDate), 0) as DATE) AND DATEADD(day, 2, CONVERT (date, @P_WeekEndDate)))AND
					  (@P_Coordinator = '' OR (u.[GivenName] + ' ' + u.[FamilyName]) LIKE '%' + @P_Coordinator + '%') AND
					  (@P_Distributor = '' OR c.[Name] LIKE '%' + @P_Distributor + '%')	AND
					  (@P_Clients = '' OR cl.[Name] LIKE '%' + @P_Clients + '%') AND
					  (od.[Status] IS NULL  OR od.[Status] IN ((SELECT [ID] FROM [dbo].[OrderDetailStatus]  WHERE [Name] = 'ODS Printed' OR [Name] = 'On Hold' OR [Name] = 'Pre Shipped')))
										  
		
	--	)
	--SELECT * FROM OrderDetails --WHERE ID > @StartOffset
	
	/*IF (@P_Set = 1)	
		BEGIN 
			SELECT  @P_RecCount = COUNT(ord.[ID]) 
			FROM (SELECT DISTINCT o.[ID] FROM [Indico].[dbo].[OrderDetail] od
														JOIN [dbo].[Order] o
															ON od.[Order] = o.[ID]
														JOIN [dbo].[VisualLayout] vl
															ON od.[VisualLayout] = vl.[ID]
														JOIN [dbo].[Pattern] p 
															ON od.[Pattern] = p.[ID]
														JOIN [dbo].[FabricCode] fc
															ON od.[FabricCode] = fc.[ID]
														LEFT OUTER JOIN [dbo].[OrderDetailStatus] ods
															ON od.[Status] = ods.[ID]
														JOIN [dbo].[OrderType] ot
															ON od.[OrderType] = ot.[ID]
														JOIN [dbo].[Company] c
															ON c.[ID] = o.[Distributor]
														JOIN [dbo].[User] u
															ON c.[Coordinator] = u.[ID]
														JOIN [dbo].[Client] cl
															ON o.[Client] = cl.[ID]
														JOIN [dbo].[OrderStatus] os
															ON o.[Status] = os.[ID]
														JOIN [dbo].[User] urc
															ON o.[Creator] = urc.[ID]
														JOIN [dbo].[User] urm
															ON o.[Modifier] = urm.[ID] 
														JOIN [dbo].[Reservation] res
															ON o.[Reservation] = res.[ID] 
													WHERE (@P_SearchText = '' OR
														   o.[OldPONo] LIKE '%' + @P_SearchText + '%' OR
														   u.[GivenName]  LIKE '%' + @P_SearchText + '%' OR
														   u.[FamilyName] LIKE '%' + @P_SearchText + '%' OR
														   p.[Number] LIKE '%' + @P_SearchText + '%' OR 
														   p.[NickName] LIKE '%' + @P_SearchText + '%' OR
														   vl.[NamePrefix] LIKE '%' + @P_SearchText + '%' OR 
														   vl.[NameSuffix] LIKE '%' + @P_SearchText + '%' OR 
														   ods.[Name] LIKE '%' + @P_SearchText + '%' OR 
														   ot.[Name] LIKE '%' + @P_SearchText + '%' OR
														   c.[Name] LIKE '%' + @P_SearchText + '%' OR 
														   cl.[Name] LIKE '%' + @P_SearchText + '%' OR					
														   fc.[Code] LIKE '%' + @P_SearchText + '%' OR 
														   fc.[Name] LIKE '%' + @P_SearchText + '%'  OR
														   o.[ID] = @orderid )AND
														  (@P_OrderStatus = '' OR os.[Name] LIKE '%' + @P_OrderStatus + '%') AND
												          (od.[SheduledDate] > DATEADD(day, -7, @P_WeekEndDate) AND od.[SheduledDate] <= @P_WeekEndDate)AND
														  (@P_Coordinator = '' OR (u.[GivenName] + ' ' + u.[FamilyName]) LIKE '%' + @P_Coordinator + '%') AND
										                  (@P_Distributor = '' OR c.[Name] LIKE '%' + @P_Distributor + '%')	AND
														  (@P_Clients = '' OR cl.[Name] LIKE '%' + @P_Clients + '%') AND
														  (od.[Status] IS NULL  OR od.[Status] IN ((SELECT [ID] FROM [dbo].[OrderDetailStatus]  WHERE [Name] = 'ODS Printed' OR [Name] = 'On Hold' OR [Name] = 'Cancelled')))) ord
		END
	ELSE
		BEGIN*/
			SET @P_RecCount = 0
		--END	
END

GO

--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**--***--**

/****** Object:  StoredProcedure [dbo].[SPC_GetWeeklySampleOrders]    Script Date: 09/29/2014 13:19:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPC_GetWeeklySampleOrders]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SPC_GetWeeklySampleOrders]
GO


/****** Object:  StoredProcedure [dbo].[SPC_GetWeeklySampleOrders]    Script Date: 09/29/2014 13:19:47 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[SPC_GetWeeklySampleOrders] (	
	@P_WeekEndDate datetime2(7),
	@P_SearchText AS NVARCHAR(255) = '',
	@P_OrderStatus AS NVARCHAR(255) = '',
	@P_Sort AS int = 0, --0 CreatedDate,--1 VL, --2 Pattern Number, --3 Order Detail Type, --4  Order Detail Status, --5 Old Po No, --6 Coordinator, --7 Distributor, --8 Client, --9 Order Status
	@P_OrderBy AS bit = 1,  -- 0 ASC , -- 1 DESC
	@P_Set AS int = 0,
	@P_MaxRows AS int = 20,
	@P_RecCount int OUTPUT,
	@P_Coordinator AS NVARCHAR(255) = '',
	@P_Distributor AS NVARCHAR(255) = '',
	@P_Clients AS NVARCHAR(255) = ''
)
AS
BEGIN

SET NOCOUNT ON
	DECLARE @Orders TABLE
	(
    OrderID int NOT NULL
	);
	DECLARE @StartOffset AS int;
	SET @StartOffset = (@P_Set - 1) * @P_MaxRows;
	
	DECLARE @orderid AS int;
	IF (ISNUMERIC(@P_SearchText) = 1 )
		BEGIN
			SET @orderid = CONVERT(int, @P_SearchText)		
		END
	ELSE
		BEGIN
			SET @orderid = 0
		END;
		
		/*WITH Orders AS
		(
			SELECT DISTINCT TOP (@P_Set * @P_MaxRows)
			CONVERT(int, ROW_NUMBER() OVER ( ORDER BY o.[ID] DESC))
			AS Number,
			o.[ID]	
			FROM [Indico].[dbo].[OrderDetail] od
				JOIN [dbo].[Order] o
					ON od.[Order] = o.[ID]
				JOIN [dbo].[VisualLayout] vl
					ON od.[VisualLayout] = vl.[ID]
				JOIN [dbo].[Pattern] p 
					ON od.[Pattern] = p.[ID]
				JOIN [dbo].[FabricCode] fc
					ON od.[FabricCode] = fc.[ID]
				LEFT OUTER JOIN [dbo].[OrderDetailStatus] ods
					ON od.[Status] = ods.[ID]
				JOIN [dbo].[OrderType] ot
					ON od.[OrderType] = ot.[ID]
				JOIN [dbo].[Company] c
					ON c.[ID] = o.[Distributor]
				JOIN [dbo].[User] u
					ON c.[Coordinator] = u.[ID]
				JOIN [dbo].[Client] cl
					ON o.[Client] = cl.[ID]
				JOIN [dbo].[OrderStatus] os
					ON o.[Status] = os.[ID]
				JOIN [dbo].[User] urc
					ON o.[Creator] = urc.[ID]
				JOIN [dbo].[User] urm
					ON o.[Modifier] = urm.[ID] 														
			WHERE (@P_SearchText = '' OR
				   o.[OldPONo] LIKE '%' + @P_SearchText + '%' OR
				   u.[GivenName]  LIKE '%' + @P_SearchText + '%' OR
				   u.[FamilyName] LIKE '%' + @P_SearchText + '%' OR
				   p.[Number] LIKE '%' + @P_SearchText + '%' OR 
				   p.[NickName] LIKE '%' + @P_SearchText + '%' OR
				   vl.[NamePrefix] LIKE '%' + @P_SearchText + '%' OR 
				   vl.[NameSuffix] LIKE '%' + @P_SearchText + '%' OR 
				   ods.[Name] LIKE '%' + @P_SearchText + '%' OR 
				   ot.[Name] LIKE '%' + @P_SearchText + '%' OR
				   c.[Name] LIKE '%' + @P_SearchText + '%' OR 
				   cl.[Name] LIKE '%' + @P_SearchText + '%' OR					
				   fc.[Code] LIKE '%' + @P_SearchText + '%' OR 
				   fc.[Name] LIKE '%' + @P_SearchText + '%'  OR
				   o.[ID] = @orderid)AND														   
		           (od.[OrderType] = (SELECT odt.[ID] FROM [Indico].[dbo].[OrderType] odt WHERE odt.[Name] = 'SAMPLE')) AND
				  (@P_OrderStatus = '' OR os.[Name] LIKE '%' + @P_OrderStatus + '%') AND
				  (od.[SheduledDate] > DATEADD(day, -7, @P_WeekEndDate) AND od.[SheduledDate] <= @P_WeekEndDate)AND
				  (@P_Coordinator = '' OR (u.[GivenName] + ' ' + u.[FamilyName]) LIKE '%' + @P_Coordinator + '%') AND
				  (@P_Distributor = '' OR c.[Name] LIKE '%' + @P_Distributor + '%')	AND
				  (@P_Clients = '' OR cl.[Name] LIKE '%' + @P_Clients + '%') AND
				  (od.[Status] IS NULL  OR od.[Status] IN ((SELECT [ID] FROM [dbo].[OrderDetailStatus]  WHERE [Name] = 'ODS Printed' OR [Name] = 'On Hold' OR [Name] = 'Cancelled')))											           
			GROUP BY o.[ID] 
		)
	INSERT INTO @Orders ([OrderID]) 
	SELECT  ID FROM Orders WHERE Number > @StartOffset;		
	*/
	--WITH OrderDetails AS
		--(
			SELECT 			
				   od.[ID] AS OrderDetail
				  ,ot.[Name] AS OrderType
				  ,vl.[NamePrefix] + ISNULL(CAST(vl.[NameSuffix] AS nvarchar(255)),'') AS VisualLayout
				  ,od.[VisualLayout] AS VisualLayoutID
				  ,od.[Pattern] AS PatternID
				  ,p.[Number] + ' - ' + p.[NickName] AS Pattern
				  ,od.[FabricCode] AS FabricID
				  ,fc.[Code] + ' - ' + fc.[Name] AS Fabric
				  ,od.[VisualLayoutNotes] AS VisualLayoutNotes      
				  ,od.[Order] AS 'Order'
				  ,ISNULL(od.[Label], 0) AS Label
				  ,ISNULL(ods.[Name], 'New') AS OrderDetailStatus
				  ,ISNULL(od.[Status], 0) AS OrderDetailStatusID
				  ,od.[ShipmentDate] AS ShipmentDate
				  ,od.[SheduledDate] AS SheduledDate      
				  ,od.[RequestedDate] AS RequestedDate
				  ,ISNULL((SELECT SUM(odq.[Qty]) FROM [dbo].[OrderDetailQty] odq WHERE odq.[OrderDetail] = od.[ID]),0) AS Quantity      
				  ,(SELECT DATEDIFF(day, od.[RequestedDate], od.[SheduledDate])) AS 'DateDiffrence'
				  ,ISNULL(o.[OldPONo], '') AS 'PurONo'
				  ,c.[Name] AS Distributor
				  ,u.[GivenName] + ' ' + u.[FamilyName] AS Coordinator
				  ,cl.[Name] AS Client
				  ,os.[Name] AS OrderStatus
				  ,o.[Status] AS OrderStatusID
				  ,urc.[GivenName] + ' ' + urc.[FamilyName] AS Creator
				  ,o.[Creator] AS CreatorID
				  ,o.[CreatedDate] AS CreatedDate
				  ,urm.[GivenName] + ' ' + urm.[FamilyName] AS Modifier
				  ,o.[ModifiedDate] AS ModifiedDate
				  ,ISNULL(pm.[Name], '') AS PaymentMethod
				  ,ISNULL(sm.[Name], '') AS ShipmentMethod
				  ,o.[IsWeeklyShipment]  AS WeeklyShiment
				  ,o.[IsCourierDelivery]  AS CourierDelivery
				  ,o.[IsAdelaideWareHouse] AS AdelaideWareHouse
				  ,o.[IsFollowingAddress] AS FollowingAddress
				  ,ISNULL(dca.[CompanyName] + ' ' + dca.[Address] + ' ' + dca.[Suburb] + ' ' + ISNULL(dca.[State], '') + ' ' + co.[ShortName] + ' ' + dca.[PostCode], '') AS ShippingAddress
				  ,ISNULL(dp.[Name], '') AS DestinationPort
				  ,ISNULL(vl.[ResolutionProfile], 0 ) AS ResolutionProfile
			  FROM [Indico].[dbo].[OrderDetail] od
				JOIN [dbo].[Order] o
					ON od.[Order] = o.[ID]
				JOIN [dbo].[VisualLayout] vl
					ON od.[VisualLayout] = vl.[ID]
				JOIN [dbo].[Pattern] p 
					ON od.[Pattern] = p.[ID]
				JOIN [dbo].[FabricCode] fc
					ON od.[FabricCode] = fc.[ID]
				LEFT OUTER JOIN [dbo].[OrderDetailStatus] ods
					ON od.[Status] = ods.[ID]
				JOIN [dbo].[OrderType] ot
					ON od.[OrderType] = ot.[ID]
				JOIN [dbo].[Company] c
					ON c.[ID] = o.[Distributor]
				JOIN [dbo].[User] u
					ON c.[Coordinator] = u.[ID]
				JOIN [dbo].[Client] cl
					ON o.[Client] = cl.[ID]
				JOIN [dbo].[OrderStatus] os
					ON o.[Status] = os.[ID]
				JOIN [dbo].[User] urc
					ON o.[Creator] = urc.[ID]
				JOIN [dbo].[User] urm
					ON o.[Modifier] = urm.[ID] 
				LEFT OUTER JOIN [dbo].[PaymentMethod] pm
					ON o.[PaymentMethod] = pm.[ID]
				LEFT OUTER JOIN [dbo].[ShipmentMode] sm
					ON o.[ShipmentMode] = sm.[ID]
				LEFT OUTER JOIN [dbo].[DistributorClientAddress] dca
					ON o.[DespatchToExistingClient] = dca.[ID]
				LEFT OUTER JOIN [dbo].[Country] co
					ON dca.[Country] = co.[ID]
				LEFT OUTER JOIN [dbo].[DestinationPort] dp
					ON dca.[Port] = dp.[ID] 														
			WHERE (@P_SearchText = '' OR
				   o.[OldPONo] LIKE '%' + @P_SearchText + '%' OR
				   u.[GivenName]  LIKE '%' + @P_SearchText + '%' OR
				   u.[FamilyName] LIKE '%' + @P_SearchText + '%' OR
				   p.[Number] LIKE '%' + @P_SearchText + '%' OR 
				   p.[NickName] LIKE '%' + @P_SearchText + '%' OR
				   vl.[NamePrefix] LIKE '%' + @P_SearchText + '%' OR 
				   vl.[NameSuffix] LIKE '%' + @P_SearchText + '%' OR 
				   ods.[Name] LIKE '%' + @P_SearchText + '%' OR 
				   ot.[Name] LIKE '%' + @P_SearchText + '%' OR
				   c.[Name] LIKE '%' + @P_SearchText + '%' OR 
				   cl.[Name] LIKE '%' + @P_SearchText + '%' OR					
				   fc.[Code] LIKE '%' + @P_SearchText + '%' OR 
				   fc.[Name] LIKE '%' + @P_SearchText + '%'  OR
				   o.[ID] = @orderid)AND														   
		           (od.[OrderType] IN ((SELECT odt.[ID] FROM [Indico].[dbo].[OrderType] odt WHERE odt.[Name] = 'SAMPLE' OR odt.[Name] = 'DEV SAMPLE'))) AND
				  (@P_OrderStatus = '' OR os.[Name] LIKE '%' + @P_OrderStatus + '%') AND
				  (od.[SheduledDate] BETWEEN cast(DATEADD(wk, DATEDIFF(wk, 0, @P_WeekEndDate), 0) as DATE) AND DATEADD(day, 2, CONVERT (date, @P_WeekEndDate)))AND
				  (@P_Coordinator = '' OR (u.[GivenName] + ' ' + u.[FamilyName]) LIKE '%' + @P_Coordinator + '%') AND
				  (@P_Distributor = '' OR c.[Name] LIKE '%' + @P_Distributor + '%')	AND
				  (@P_Clients = '' OR cl.[Name] LIKE '%' + @P_Clients + '%') AND
				  (od.[Status] IS NULL  OR od.[Status] IN ((SELECT [ID] FROM [dbo].[OrderDetailStatus]  WHERE [Name] = 'ODS Printed' OR [Name] = 'On Hold' OR [Name] = 'Pre Shipped')))										
		--)
	/*SELECT * FROM OrderDetails-- WHERE ID > @StartOffset
	
	IF (@P_Set = 1)	
		BEGIN 
			SELECT  @P_RecCount = COUNT(ord.[ID]) 
			FROM (SELECT DISTINCT o.[ID] FROM [Indico].[dbo].[OrderDetail] od
														JOIN [dbo].[Order] o
															ON od.[Order] = o.[ID]
														JOIN [dbo].[VisualLayout] vl
															ON od.[VisualLayout] = vl.[ID]
														JOIN [dbo].[Pattern] p 
															ON od.[Pattern] = p.[ID]
														JOIN [dbo].[FabricCode] fc
															ON od.[FabricCode] = fc.[ID]
														LEFT OUTER JOIN [dbo].[OrderDetailStatus] ods
															ON od.[Status] = ods.[ID]
														JOIN [dbo].[OrderType] ot
															ON od.[OrderType] = ot.[ID]
														JOIN [dbo].[Company] c
															ON c.[ID] = o.[Distributor]
														JOIN [dbo].[User] u
															ON c.[Coordinator] = u.[ID]
														JOIN [dbo].[Client] cl
															ON o.[Client] = cl.[ID]
														JOIN [dbo].[OrderStatus] os
															ON o.[Status] = os.[ID]
														JOIN [dbo].[User] urc
															ON o.[Creator] = urc.[ID]
														JOIN [dbo].[User] urm
															ON o.[Modifier] = urm.[ID] 														
													WHERE (@P_SearchText = '' OR
														   o.[OldPONo] LIKE '%' + @P_SearchText + '%' OR
														   u.[GivenName]  LIKE '%' + @P_SearchText + '%' OR
														   u.[FamilyName] LIKE '%' + @P_SearchText + '%' OR
														   p.[Number] LIKE '%' + @P_SearchText + '%' OR 
														   p.[NickName] LIKE '%' + @P_SearchText + '%' OR
														   vl.[NamePrefix] LIKE '%' + @P_SearchText + '%' OR 
														   vl.[NameSuffix] LIKE '%' + @P_SearchText + '%' OR 
														   ods.[Name] LIKE '%' + @P_SearchText + '%' OR 
														   ot.[Name] LIKE '%' + @P_SearchText + '%' OR
														   c.[Name] LIKE '%' + @P_SearchText + '%' OR 
														   cl.[Name] LIKE '%' + @P_SearchText + '%' OR					
														   fc.[Code] LIKE '%' + @P_SearchText + '%' OR 
														   fc.[Name] LIKE '%' + @P_SearchText + '%'  OR
														   o.[ID] = @orderid )AND														   
												           (od.[OrderType] = (SELECT odt.[ID] FROM [Indico].[dbo].[OrderType] odt WHERE odt.[Name] = 'SAMPLE')) AND
														   (@P_OrderStatus = '' OR os.[Name] LIKE '%' + @P_OrderStatus + '%') AND
														   (od.[SheduledDate] > DATEADD(day, -7, @P_WeekEndDate) AND od.[SheduledDate] <= @P_WeekEndDate)AND
														   (@P_Coordinator = '' OR (u.[GivenName] + ' ' + u.[FamilyName]) LIKE '%' + @P_Coordinator + '%') AND
														   (@P_Distributor = '' OR c.[Name] LIKE '%' + @P_Distributor + '%')	AND
														   (@P_Clients = '' OR cl.[Name] LIKE '%' + @P_Clients + '%') AND
														   (od.[Status] IS NULL  OR od.[Status] IN ((SELECT [ID] FROM [dbo].[OrderDetailStatus]  WHERE [Name] = 'ODS Printed' OR [Name] = 'On Hold' OR [Name] = 'Cancelled')))) ord
		END
	ELSE
		BEGIN*/
			SET @P_RecCount = 0
		--END			

END



GO





