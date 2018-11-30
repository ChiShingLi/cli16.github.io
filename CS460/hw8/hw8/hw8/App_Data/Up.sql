
CREATE TABLE [dbo].[Sellers]
(
	[ID] INT IDENTITY (1,1) NOT NULL,
	[SellerName] NVARCHAR(300) NOT NULL,	
	CONSTRAINT [PK_dbo.Sellers] PRIMARY KEY CLUSTERED ([SellerName] ASC)
	);


CREATE TABLE [dbo].[Items]
(
	--ID start from 1001 and increment by 1
	[ID] INT IDENTITY (1001,1) NOT NULL,
	[Name] NVARCHAR(30) NOT NULL,
	[Description] NVARCHAR(200) NOT NULL,
    [Seller] NVARCHAR(300) NOT NULL,
	CONSTRAINT [PK_dbo.Items] PRIMARY KEY CLUSTERED ([ID] ASC)
	--CONSTRAINT [FK_dbo.Items] FOREIGN KEY ([Seller]) REFERENCES [dbo].[Sellers] ([SellerName])
	);

CREATE TABLE [dbo].[Buyers]
(
	[ID] INT IDENTITY (1,1) NOT NULL,
	[BuyerName] NVARCHAR(30) NOT NULL,	
	CONSTRAINT [PK_dbo.Buyers] PRIMARY KEY CLUSTERED ([BuyerName] ASC)
	);


CREATE TABLE [dbo].[Bids]
(
	[ID] INT IDENTITY(1,1) NOT NULL,
	[Item] INT NOT NULL,
	[Buyer] NVARCHAR(30) NOT NULL,
    [Price] INT NOT NULL,
	[Timestamp] DATETIME NULL,
	CONSTRAINT [PK_dbo.Bids] PRIMARY KEY CLUSTERED ([ID] ASC),

	--setup a foreign key to get buyer name from other table, aka('Buyer' is an foreign key of 'Name' in 'Buyers' Table.)
	CONSTRAINT [FK_dbo.Bids] FOREIGN KEY ([Item]) REFERENCES [dbo].[Items] ([ID]),
	CONSTRAINT [FK2_dbo.Bids] FOREIGN KEY ([Buyer]) REFERENCES [dbo].[Buyers] ([BuyerName])
	);





	INSERT INTO [dbo].[Sellers] (SellerName) VALUES
	('Gayle Hardy'),
	('Lyle Banks'),
	('Pearl Greene');
	
	INSERT INTO [dbo].[Buyers] (BuyerName) VALUES
	('Jane Stone'),
	('Tom McMasters'),
	('Otto Vanderwall');

	INSERT INTO [dbo].[Items] (Name, Description, Seller) VALUES
	('Abraham Lincoln Hammer'    ,'A bench mallet fashioned from a broken rail-splitting maul in 1829 and owned by Abraham Lincoln', 'Pearl Greene'),
	('Albert Einsteins Telescope','A brass telescope owned by Albert Einstein in Germany, circa 1927', 'Gayle Hardy'),
	('Bob Dylan Love Poems'      ,'Five versions of an original unpublished, handwritten, love poem by Bob Dylan', 'Lyle Banks');


	INSERT INTO [dbo].[Bids] (Item, Buyer, Price, Timestamp) VALUES
	--Buyer must have been delcared in the Buyers table before using it
	--there no 0 for the ID, thats why
	--(0,'Otto Vanderwall', 250000,'12/04/2017 09:04:22'),
	(1001,'Otto Vanderwall', 250000,'12/04/2017 09:04:22'),
	(1003, 'Jane Stone', 95000,'12/04/2017 08:44:03');



			
	GO