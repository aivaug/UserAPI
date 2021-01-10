# UserAPI

Project created using .NET Core 5

----
#### Installation
- To get database ready, run commands below in your console
> `C:\fakePath\User>sqlcmd`  
> `1> CREATE DATABASE UserAPI_DB`  
> `2> GO`  
> `3> USE UserAPI_DB`  
> `4> GO`  
> `5> CREATE LOGIN UserAPI_Username WITH PASSWORD = 'UserAPI_Password';`  
> `6> CREATE USER UserAPI_Username FOR LOGIN UserAPI_Username`  
> `7> GO`  
> `8> EXEC sp_addrolemember N'db_datareader', N'UserAPI_Username'`  
> `9> EXEC sp_addrolemember N'db_datawriter', N'UserAPI_Username'`  
> `10> EXEC sp_addrolemember N'db_ddladmin', N'UserAPI_Username'`  
> `11> GO`  
  
   
- To prepare backend environment you have to write in console:
> `update-database`  

Database seed automatically creates some user sample data.