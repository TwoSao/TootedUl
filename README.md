Что бы начать работу нужно в smss создать бд toodeDB и в ней создать 2 таблицы
CREATE TABLE [dbo].[Kategooria] 
(
    [Id] INT IDENTITY(1, 1) NOT NULL,
    [Kategooria_nimetus] NVARCHAR(50) NOT NULL,
    [Kirjendus] TEXT NULL,
    CONSTRAINT [PK_Kategooria] PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Toodetabel] 
(
    [Id] INT IDENTITY(1, 1) NOT NULL,
    [Toodenimetus] NCHAR(50) NOT NULL,
    [Kogus] INT NOT NULL,
    [Hind] INT NOT NULL,
    [Pilt] TEXT NULL,
    [Kategooriad] INT NOT NULL,
    [Bpilt] VARBINARY(MAX) NULL,
    CONSTRAINT [PK_Toodetabel] PRIMARY KEY CLUSTERED ([Id] ASC)
);

подключение: (localdb)\MSSQLLocalDB
