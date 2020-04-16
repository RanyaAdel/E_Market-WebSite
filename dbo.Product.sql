CREATE TABLE [dbo].[Product] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [name]        NVARCHAR (50)  NULL,
    [description] NVARCHAR (MAX) NULL,
    [image]       NVARCHAR (MAX) NOT NULL,
    [price]       INT            NULL,
    [cid]         INT            NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([cid]) REFERENCES [dbo].[Category] ([cid])
);

