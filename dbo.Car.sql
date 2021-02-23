CREATE TABLE [dbo].[Cars] (
    [CarId]      INT        IDENTITY (1, 1) NOT NULL,
    [BrandId]    INT        NOT NULL,
    [ColorId]    INT        NOT NULL,
    [ModelYear]  NCHAR (10) NOT NULL,
    [DailyPrice] FLOAT (53) NOT NULL,
    [Description] NCHAR (50) NOT NULL,
    CONSTRAINT [PK_Table] PRIMARY KEY CLUSTERED ([CarId] ASC)
);

