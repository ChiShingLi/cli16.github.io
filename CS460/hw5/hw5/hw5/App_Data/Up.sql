CREATE TABLE [dbo].[Renters] (
    [Id]               INT            IDENTITY (1, 1) NOT NULL,
    [FirstName]        NVARCHAR (MAX) NOT NULL,
    [LastName]         NVARCHAR (MAX) NOT NULL,
    [Phone]            NVARCHAR (MAX) NOT NULL,
    [ApartmentName]    NVARCHAR (MAX) NOT NULL,
    [UnitNumber]       INT NOT NULL,
    [CommentBox]       NVARCHAR (MAX) NOT NULL,
    [AgreementChecked] BIT            NOT NULL,
    [CurrentTime] DATETIME NOT NULL, 
    CONSTRAINT [PK_dbo.Renters] PRIMARY KEY CLUSTERED ([Id] ASC)
);

	INSERT INTO [dbo].[Renters] (FirstName, LastName, Phone, ApartmentName, UnitNumber, CommentBox, AgreementChecked, CurrentTime) VALUES
		('Bob','Jackson','321-123-3212', 'Block 2 St.', 11, 'Broken window', 1, '2018-10-01 10:11:33'),
		('Mary','Joeson','321-233-3433', 'Block 3 St.', 22, 'Broken door', 1, '2018-10-03 10:22:33'),
		('Jack','Balling','321-233-2233', 'Block 4 St.', 12, 'Broken closet', 1, '2018-10-05 08:22:33'),
		('Rain','Smithson','111-333-2233', 'Block 1 St.', 1, 'Leaky pipe', 1, '2018-10-01 02:26:42'),
		('Tommy','Raining','444-555-2222', 'Block 8 St.', 3, 'Power Outage', 0, '2018-06-01 11:37:45')
		GO
