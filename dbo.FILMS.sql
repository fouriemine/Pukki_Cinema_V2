CREATE TABLE [dbo].[FILMS] (
    [Film_ID]         INT           IDENTITY (1, 1) NOT NULL,
    [Title]           VARCHAR (100) NULL,
    [Film_Cost]       MONEY         NULL,
    [Selling_Price]   SMALLMONEY    NULL,
    [Length]          INT           NULL,
    [Age_Restriction] INT           NULL,
    [Genre_ID]        INT           NULL,
	[Status]		  bit			Null,
    PRIMARY KEY CLUSTERED ([Film_ID] ASC),
    FOREIGN KEY ([Genre_ID]) REFERENCES [dbo].[GENRES] ([Genre_ID])
);

