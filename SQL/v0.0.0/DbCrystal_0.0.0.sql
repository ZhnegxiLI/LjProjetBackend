USE [ERPDATA2]
GO


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
	

