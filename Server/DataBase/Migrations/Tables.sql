--CREATE TABLE [User](
--	[ID]			INT NOT NULL IDENTITY  PRIMARY KEY,
--	[Login]			VARCHAR(64) NOT NULL,
--	[PassHash]		CHAR(64)	NOT NULL,
--	[CryptoSalt]	VARCHAR(10) NOT NULL,
--	[Email]			VARCHAR(64)	NOT NULL,
--	[Name]			NVARCHAR(64) NOT NULL,
--	[Surname]		NVARCHAR(64) NOT NULL,
--	[DOB]			DATETIME NOT NULL,
--	[Subscribers]	INT NOT NULL DEFAULT 0,
--	[RecoveryCode]	VARCHAR(4) NULL
--);

CREATE TABLE [CountryCode](
	[ID]			INT NOT NULL IDENTITY PRIMARY KEY,
	[Country]		NVARCHAR(48) NOT NULL UNIQUE,
	[InternCode]	SMALLINT NOT NULL
);

--CREATE TABLE [Message](
--	[ID]			INT NOT NULL IDENTITY PRIMARY KEY,
--	[SenderID]		INT NOT NULL, -- Связь с таблицей User
--	[SenderName]	NVARCHAR(64) NOT NULL,
--	[ReceiverID]	INT NOT NULL, -- Связь с таблицей User
--	[DateTime]		DATETIME NOT NULL DEFAULT GETDATE(),
--	[Text]			NVARCHAR(MAX), -- !!!
--);

--CREATE TABLE [Conversation](
--	[ID]			INT NOT NULL IDENTITY PRIMARY KEY,
--	[Name]			NVARCHAR(64) NOT NULL UNIQUE,
--	[UserCount]		INT	NOT NULL DEFAULT 0,
--	[CreateDate]	DATETIME NOT NULL DEFAULT GETDATE(),
--);

--CREATE TABLE [CategoryProd](
--	[ID]			INT NOT NULL IDENTITY PRIMARY KEY,
--	[Name]			NVARCHAR(64) NOT NULL UNIQUE,
--);

---- Создать подкатегории товаров

--CREATE TABLE [Product](
--	[ID]			INT NOT NULL IDENTITY PRIMARY KEY,
--	[UserCreateID]	INT NOT NULL, -- Связь с таблицей User
--	[Name]			NVARCHAR(128) NOT NULL,
--	[CategoryID]	INT NOT NULL, -- Связь с таблицей CategoryProd
--	[Description]	NVARCHAR(MAX),
--	[Price]			MONEY NOT NULL,
--	[DatePost]		DATETIME NOT NULL DEFAULT GETDATE()
--);
