CREATE TABLE [dbo].[Infoes]
(
	[ID] INT IDENTITY (1,1) NOT NULL,
	[RequestDate] DATETIME NULL,
	[WordSearched] NVARCHAR(MAX) NOT NULL,
    [IpAddress] NVARCHAR(MAX) NOT NULL,
	[BrowserAgent] NVARCHAR(MAX) NOT NULL,
	CONSTRAINT [PK_dbo.Infoes] PRIMARY KEY CLUSTERED ([ID] ASC)
	);
		
--		INSERT INTO [dbo].[Infoes] (DateCreated, WordSearched, IpAddress, BrowserAgent) VALUES
--			('2018-11-13 10:11:33','walk','198.1.1.1', 'Firefox')
			GO