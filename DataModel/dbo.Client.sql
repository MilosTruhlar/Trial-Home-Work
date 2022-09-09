CREATE TABLE [dbo].[Client] (
    [ClientId]    INT          IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (90) NOT NULL,
    [Second name] VARCHAR (90) NOT NULL,
	[AccountId] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([ClientId] ASC),
	FOREIGN KEY (AccountId) REFERENCES Accounts(Account Id)
);

