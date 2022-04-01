CREATE TABLE [dbo].[konsertlar]
(
	[Id] INT NOT NULL PRIMARY KEY identity(1, 1),
	[Nomi] VARCHAR(60) NOT NULL,
	[BiletlarSoni] int not null DEFAULT 0,
	[SotilganBiletlar] varchar(MAX) not null,
	[BiletNarxi] decimal NOT NULL DEFAULT 0,
	[BushBiletlar] varchar(MAX) not null
	 
)
