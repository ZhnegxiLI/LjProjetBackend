
/* 
* BEGIN: Add mobile version
* ZLI
* 16/12/2019 
*/
UPDATE [XYINFO]
SET Mobile_Version = '0.0.6'
/* 
* END: Add mobile version 
* ZLI
* 16/12/2019 
*/

/* 
* BEGIN: Add specific permission 
* ZLI
* 16/12/2019 
*/
IF NOT EXISTS (SELECT * FROM Mobile_Permission WHERE Code = 'OrderModule_financialValidation')
BEGIN
	INSERT INTO Mobile_Permission(Code,Label)
	VALUES ('OrderModule_financialValidation','订单财务审核')
END
GO

IF NOT EXISTS (SELECT * FROM Mobile_Permission WHERE Code = 'OrderModule_managerValidation')
BEGIN
	INSERT INTO Mobile_Permission(Code,Label)
	VALUES ('OrderModule_managerValidation','订单经理审核')
END
GO
/* 
* END: Add specific permission 
* ZLI
* 16/12/2019 
*/

/* 
* BEGIN: Add permission for specific users 
* ZLI
* 16/12/2019 
*/
DECLARE @UserId char(4) = (SELECT EMPN_PSL FROM PERSONEL WHERE NAME_PSL = '郝卫东')
DECLARE @PermissionId int = (SELECT Id FROM Mobile_Permission WHERE code = 'OrderModule_financialValidation') 

IF NOT EXISTS (SELECT * FROM Mobile_User_Permission WHERE UserId =@UserId and permissionId = @PermissionId)
BEGIN
	INSERT INTO Mobile_User_Permission (UserId,PermissionId)
	VALUES(@UserId,@PermissionId)
END

SET @PermissionId = (SELECT Id FROM Mobile_Permission WHERE code = 'OrderModule_managerValidation') 
IF NOT EXISTS (SELECT * FROM Mobile_User_Permission WHERE UserId = @UserId and permissionId = @PermissionId)
BEGIN 
	INSERT INTO Mobile_User_Permission (UserId,PermissionId)
	VALUES(@UserId,@PermissionId)
END

SET @PermissionId = (SELECT Id FROM Mobile_Permission WHERE code = 'OrderModule_financialValidation') 
SET @UserId  = (SELECT EMPN_PSL FROM PERSONEL WHERE NAME_PSL = '管理员')
IF NOT EXISTS (SELECT * FROM Mobile_User_Permission WHERE UserId =@UserId and permissionId = @PermissionId)
BEGIN
	INSERT INTO Mobile_User_Permission (UserId,PermissionId)
	VALUES(@UserId,@PermissionId)
END


SET @permissionId = (SELECT Id FROM Mobile_Permission WHERE code = 'OrderModule_managerValidation') 
IF NOT EXISTS (SELECT * FROM Mobile_User_Permission WHERE UserId =@UserId and permissionId = @PermissionId)
BEGIN
	INSERT INTO Mobile_User_Permission (UserId,PermissionId)
	VALUES(@UserId,@PermissionId)
END
GO
/* 
* END: Add permission for specific users 
* ZLI
* 16/12/2019 
*/

/* 
* BEGIN: Add specific permission review order permission
* ZLI
* 16/01/2019 
*/
IF NOT EXISTS (SELECT * FROM Mobile_Permission WHERE Code = 'OrderModule_reviewSalesOrder')
BEGIN
	INSERT INTO Mobile_Permission(Code,Label)
	VALUES ('OrderModule_reviewSalesOrder','观看销售订单')
END

IF NOT EXISTS (SELECT * FROM Mobile_Permission WHERE Code = 'OrderModule_reviewPurchaseOrder')
BEGIN
	INSERT INTO Mobile_Permission(Code,Label)
	VALUES ('OrderModule_reviewPurchaseOrder','观看采购订单')
END

GO

/* 
* END: BEGIN: Add specific permission review order permission
* ZLI
* 16/01/2019 
*/




/* 
* BEGIN: Add email for person
* ZLI
* 27/10/2020
*/
IF NOT EXISTS (SELECT * FROM [PERSONEL] WHERE Email_PSL IS NOT NULL)
BEGIN
UPDATE [PERSONEL]
SET Email_PSL = 'hwd@ljfz.net'
where NAME_PSL = N'郝卫东'


UPDATE [PERSONEL]
SET Email_PSL = 'fam@ljfz.net'
where NAME_PSL = N'范爱民'

UPDATE [PERSONEL]
SET Email_PSL = 'hcy@ljfz.net'
where NAME_PSL = N'阿燕'

UPDATE [PERSONEL]
SET Email_PSL = 'hwm@ljfz.net'
where NAME_PSL = N'韩卫民'

	
UPDATE [PERSONEL]
SET Email_PSL = 'lh@ljfz.net'
where NAME_PSL = N'李华'
END
GO

/* 
* END: BEGIN: Add email for person
* ZLI
* 27/10/2020
*/