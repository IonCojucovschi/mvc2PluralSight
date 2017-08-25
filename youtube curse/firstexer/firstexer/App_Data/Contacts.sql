CREATE TABLE [dbo].[Table]
(
	[ContactId] INT NOT NULL PRIMARY KEY identity(1,1),
	[LastName] nvarchar(50) NOT NULL ,
	[FristName] nvarchar(50) NOT NULL,
	[Email] nvarchar(50) NOT NULL,
)
