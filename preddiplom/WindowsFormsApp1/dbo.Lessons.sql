CREATE TABLE [dbo].[Lessons] (
    [Id]        INT        IDENTITY (1, 0) NOT NULL,
    [ФИО]       NCHAR (50) NULL,
    [Пара]      INT        NULL,
    [Аудитория] NCHAR (5)  NULL,
    [Дата]      DATETIME   NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

