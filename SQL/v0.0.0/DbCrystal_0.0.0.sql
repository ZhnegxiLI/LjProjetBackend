SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
		DECLARE @userId NVARCHAR(4) = (SELECT CREA_PO FROM POMST)
		DECLARE @orderId NVARCHAR(50) = (SELECT PONB_PO FROM POMST)
		DECLARE @statusId NVARCHAR(4) = (SELECT STAT_PO FROM POMST)
		DECLARE @updateBy NVARCHAR(4) = (SELECT LEDT_PO FROM POMST)
		DECLARE @orderType NVARCHAR(4) = (SELECT TYPE_PO FROM POMST)
		DECLARE @url NVARCHAR(1000) = 'https://api.europetechs.com/SqlListener/UpdateOrderStatus/?userId='+ @userId +'&orderId='+@orderId+'&statusId='+@statusId +'&updateBy='+@updateBy + '&orderType='+@orderType
        EXEC P_GET_HttpRequestData @url
        END
GO
/***************************************************************
* END SCRIPT 
* COMMENT : 添加订单状态触发器
* Author: ZLI
* DATE : 29/12/2019 
*****************************************************************/