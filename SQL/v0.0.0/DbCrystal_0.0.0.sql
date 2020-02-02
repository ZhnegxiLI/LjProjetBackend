SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/***************************************************************
* BEGIN SCRIPT 
* COMMENT : 添加手机端权限模块
* Author: ZLI
* DATE : 29/12/2019 
*****************************************************************/
IF  EXISTS (select * FROM sys.views where name = 'View_User') 
	BEGIN
	DROP VIEW [dbo].[View_User]
	END
GO
CREATE view [dbo].[View_User]
	as
	SELECT EMPN_PSL AS Id, NAME_PSL AS 'Name', PSWD_PSW as Password
	FROM dbo.PERSONEL p
	INNER JOIN dbo.PASSWRD pw ON p.EMPN_PSL = pw.EMPN_PSW
GO



IF NOT EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME='Mobile_Permission' AND XTYPE='U')
BEGIN
	CREATE TABLE [dbo].[Mobile_Permission](
		  Id INT NOT NULL IDENTITY  PRIMARY KEY,
		  Code NVARCHAR(100) NOT NULL,
		  Label NVARCHAR(100)
	)
END
GO

IF NOT EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME='Mobile_User_Permission' AND XTYPE='U')
BEGIN
	CREATE TABLE [dbo].[Mobile_User_Permission](
		  Id INT NOT NULL IDENTITY  PRIMARY KEY,
		  UserId CHAR(4) NOT NULL,
		  PermissionId INT NOT NULL
	)
END
GO

IF NOT EXISTS (SELECT *  FROM SYS.COLUMNS WHERE OBJECT_ID = OBJECT_ID('XYINFO') AND NAME = 'Mobile_Version')
BEGIN
  ALTER TABLE [XYINFO]
  ADD  Mobile_Version NVARCHAR(50)
END
GO
/***************************************************************
* END SCRIPT 
* COMMENT : 添加手机端权限模块
* Author: ZLI
* DATE : 29/12/2019 
*****************************************************************/

/***************************************************************
* BEGIN SCRIPT 
* COMMENT : 添加订单状态触发器
* Author: ZLI
* DATE : 29/12/2019 
*****************************************************************/
sp_configure 'show advanced options', 1;
GO
RECONFIGURE;
GO
sp_configure 'Ole Automation Procedures', 1;
GO
RECONFIGURE;
GO
EXEC sp_configure 'Ole Automation Procedures';
GO


IF EXISTS ( SELECT  *
            FROM  sys.objects
            WHERE object_id = OBJECT_ID(N'P_GET_HttpRequestData')
                    AND type IN ( N'P', N'PC' ) ) 
BEGIN
	DROP PROCEDURE P_GET_HttpRequestData
END
GO
/*

参数说明?

@URL=http请求地址

@status=状态代?

@returnText=返回?

@object=对象令牌

@errSrc=错误源编?

*/

CREATE PROCEDURE P_GET_HttpRequestData(
@URL varchar(500),
@status int=0 OUT,
@returnText varchar(2000)='' OUT
)AS
BEGIN
	DECLARE @object int,
	@errSrc int

	/*初始化对*/
	EXEC @status = SP_OACreate 'Msxml2.ServerXMLHTTP.3.0', @object OUT
	IF @status <> 0
	BEGIN
	 EXEC SP_OAGetErrorInfo @object, @errSrc OUT, @returnText OUT
	 RETURN
	END

	/*创建链接*/
	EXEC @status= SP_OAMethod @object,'open',NULL,'GET',@URL
	IF @status <> 0
	BEGIN
		 EXEC SP_OAGetErrorInfo @object, @errSrc OUT, @returnText OUT
		 RETURN
	END
	EXEC @status=SP_OAMethod @object,'setRequestHeader','Content-Type','application/x-www-form-urlencoded'

	/*发起请求*/

	EXEC @status= SP_OAMethod @object,'send',NULL 
	IF @status <> 0 
	BEGIN 
		 EXEC SP_OAGetErrorInfo @object, @errSrc OUT, @returnText OUT
		 RETURN
	END

	/*获取返回*/

	EXEC @status= SP_OAGetProperty @object,'responseText',@returnText OUT
	IF @status <> 0 
	BEGIN 
		 EXEC SP_OAGetErrorInfo @object, @errSrc OUT, @returnText OUT
		 RETURN
	END
END
GO



IF EXISTS (SELECT * FROM sys.objects WHERE [type] = 'TR' AND [name] = 'TR_UpdateOrderStatut')
	BEGIN 
		DROP TRIGGER TR_UpdateOrderStatut;
	END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER TR_UpdateOrderStatut
ON [dbo].[POMST]
 FOR UPDATE
AS
DECLARE @oldStatus CHAR(1), @newStatus CHAR(1);
    SELECT @oldStatus = STAT_PO FROM deleted;
	SELECT @newStatus = STAT_PO FROM inserted;
    IF @oldStatus != @newStatus
        BEGIN 
		DECLARE @orderId NVARCHAR(50) = (SELECT PONB_PO FROM inserted)
		DECLARE @userId NVARCHAR(10) = (SELECT CREA_PO FROM POMST WHERE PONB_PO = @orderId)
		DECLARE @oldStatusId NVARCHAR(4) = (SELECT STAT_PO FROM deleted)
		DECLARE @newStatusId NVARCHAR(4) = (SELECT STAT_PO FROM inserted)
		DECLARE @updateBy NVARCHAR(4) = (SELECT LEDT_PO FROM inserted)
		DECLARE @orderType NVARCHAR(4) = (SELECT TYPE_PO FROM inserted)
		DECLARE @url NVARCHAR(1000) = 'https://api.europetechs.com/api/SqlListener/UpdateOrderStatus/?userId='+ @userId +'&orderId='+@orderId++'&oldStatusId='+@oldStatusId+'&newStatusId='+@newStatusId +'&updateBy='+@updateBy + '&orderType='+@orderType
        EXEC  P_GET_HttpRequestData @url 
		END
GO
/***************************************************************
* END SCRIPT 
* COMMENT : 添加订单状态触发器
* Author: ZLI
* DATE : 29/12/2019 
*****************************************************************/



/***************************************************************
* START SCRIPT 
* COMMENT : 添加更新poview ps
* Author: ZLI
* DATE : 29/12/2019 
*****************************************************************/
IF EXISTS ( SELECT  *
            FROM    sys.objects
            WHERE   object_id = OBJECT_ID(N'Ps_InsertOrUpdate_Poveiw')
                    AND type IN ( N'P', N'PC' ) ) 
BEGIN
	DROP PROCEDURE Ps_InsertOrUpdate_Poveiw
END
GO
CREATE PROCEDURE Ps_InsertOrUpdate_Poveiw  @orderId NVARCHAR(50), @userId NVARCHAR(50)
AS   
	DECLARE @orderType NVARCHAR(10) = (SELECT TOP 1 TYPE_PO FROM POMST WHERE PONB_PO=@orderId)
	DECLARE @copyToPoview BIT = (SELECT TOP 1 CTOV_PO FROM POMST WHERE PONB_PO=@orderId)
	IF @copyToPoview = 1
		BEGIN
		IF object_id('tempdb..#result') is not null
		BEGIN
			DROP TABLE #result
		END
		CREATE TABLE #result(
			PLNT_PP NVARCHAR(50) NULL,  
			DATE_PO DATETIME NULL,
			DESC_PP NVARCHAR(50) NULL,
			TQTY_PP DECIMAL(18,2) NULL,
			UNIT_PP NVARCHAR(50) NULL,
			TCPY_PO NVARCHAR(50) NULL,
			PONB_PO NVARCHAR(50),
			PRIC_PP DECIMAL(18,2) NULL,
			TNAM_PO NVARCHAR(50) NULL,
			TTEL_PO NVARCHAR(50) NULL,
			REMK_PP NVARCHAR(100) NULL,
			CMPL_POV BIT DEFAULT 0,
			LDAT_POV DATETIME DEFAULT GETDATE(),
			LEDT_POV NVARCHAR(50) NULL
		)
		INSERT INTO #result(PLNT_PP,DATE_PO,DESC_PP,TQTY_PP,UNIT_PP,TCPY_PO,PONB_PO,PRIC_PP,TNAM_PO,TTEL_PO,REMK_PP)
		SELECT PLNT_PO, DATE_PO, DESC_PP, TQTY_PP, UNIT_PP, TCPY_PO, PONB_PO, PRIC_PP,TNAM_PO,TTEL_PO,REMK_PP 
		FROM POMST PO
		INNER JOIN POPART PP ON PO.PONB_PO = PP.PONB_PP
		WHERE PO.PONB_PO = @orderId
		UPDATE #result SET LEDT_POV = @userId
		IF @orderType='O'
		BEGIN
			-- INSERT THE DATA 
			INSERT INTO POVIEW(PLNT_POV,DATE_POV,DESC_POV,ORDQ_POV,UNIT_POV,NAME_POV,TELN_POV,REMK_POV,CMPL_POV,LDAT_POV,LEDT_POV,  CSTM_POV,CPON_POV,OPRC_POV)
			SELECT PLNT_PP,DATE_PO,DESC_PP,TQTY_PP,UNIT_PP,TNAM_PO,TTEL_PO,REMK_PP, CMPL_POV, LDAT_POV, LEDT_POV,TCPY_PO,PONB_PO,PRIC_PP
			FROM #result
		END
		IF @orderType = 'I'
		BEGIN
			-- INSERT THE DATA 
			INSERT INTO POVIEW(PLNT_POV,DATE_POV,DESC_POV,ORDQ_POV,UNIT_POV,NAME_POV,TELN_POV,REMK_POV,CMPL_POV,LDAT_POV,LEDT_POV,  VEND_POV,VPON_POV,IPRC_POV)
			SELECT PLNT_PP,DATE_PO,DESC_PP,TQTY_PP,UNIT_PP,TNAM_PO,TTEL_PO,REMK_PP, CMPL_POV, LDAT_POV, LEDT_POV,TCPY_PO,PONB_PO,PRIC_PP
			FROM #result
		END
	END
GO 
/***************************************************************
* END SCRIPT 
* COMMENT : 添加更新poview ps
* Author: ZLI
* DATE : 29/12/2019 
*****************************************************************/

/***************************************************************
* BEGIN SCRIPT 
* COMMENT : 添加Mobile_PushMessage,用于发推送
* Author: ZLI
* DATE : 02/02/2019 
*****************************************************************/
IF NOT EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME='Mobile_PushMessage' AND XTYPE='U')
BEGIN
CREATE TABLE [dbo].[Mobile_PushMessage](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] NVARCHAR(4) NULL,
	[Title] NVARCHAR(500),
	[Body] NVARCHAR(MAX),
	[UserGroup] NVARCHAR(100) NULL,
	[IsSend] BIT
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/***************************************************************
* END SCRIPT 
* COMMENT : 添加Mobile_PushMessage,用于发推送
* Author: ZLI
* DATE : 02/02/2019 
*****************************************************************/



