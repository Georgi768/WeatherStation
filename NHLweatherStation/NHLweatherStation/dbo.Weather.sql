CREATE TABLE [dbo].[Weather] (
    [Id]               INT            IDENTITY (1, 1) NOT NULL,
    [location]         NVARCHAR (MAX) NULL,
    [Temperature]      DECIMAL     NULL,
    [date]             VARCHAR(50)   NULL,
    [unitsTemperature] NCHAR (10)     NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

