CREATE VIEW [dbo].[v_User_Log]
	AS SELECT U.Id, U.Name, L.Operation, L.IP, L.Browser, L.Created
	FROM [dbo].[User] as U inner join [dbo].UserLog as L 
	on U.Id = L.UserId