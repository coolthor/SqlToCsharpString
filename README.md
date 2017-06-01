# SqlToCsharpString
將SQL Server Management Studio產生的insert/update等字串自動依序代換成{0} {1}的string，方便偷懶用。

例如其實可以很容易的從SSMS取到以下的字串：
***
   
UPDATE [dbo].[Doc]
   SET [DocNo] = <DocNo, nvarchar(50),>
      ,[DocDesc] = <DocDesc, nvarchar(250),>
      ,[DocName] = <DocName, nvarchar(100),>
      ,[DocUrl] = <DocUrl, nvarchar(max),>
      ,[DocGroupID] = <DocGroupID, nvarchar(50),>
      ,[SystemOperator] = <SystemOperator, nvarchar(50),>
      ,[CreateTimeStamp] = <CreateTimeStamp, nvarchar(30),>
      ,[Remark] = <Remark, nvarchar(max),>
 WHERE <搜尋條件,,>

***
經過程式轉換後可以得到
***
UPDATE [dbo].[Doc]
   SET [DocNo] = N'{0}'
      ,[DocDesc] = N'{1}'
      ,[DocName] = N'{2}'
      ,[DocUrl] = N'{3}'
      ,[DocGroupID] = N'{4}'
      ,[SystemOperator] = N'{5}'
      ,[CreateTimeStamp] = N'{6}'
      ,[Remark] = N'{7}'
 WHERE N'{8}'
***

不建議於公開網頁使用此轉換，珍惜生命，拒絕SQL Injection.
