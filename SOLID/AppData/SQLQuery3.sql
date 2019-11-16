USE [University]
GO


CREATE TABLE [dbo].[University](
	[IdUniver] [int] IDENTITY(1,1),
	[NameUniver] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO

ALTER TABLE University
ADD CONSTRAINT DF_University_NameUniver_Unique UNIQUE (NameUniver)
GO 

ALTER TABLE University
ADD CONSTRAINT PK_University_IdUniver PRIMARY KEY CLUSTERED (IdUniver)
GO 

CREATE TABLE [dbo].[Facult](
	[IdFacult] [int] IDENTITY(1,1),
	[NameFacult] [nvarchar](50) NOT NULL,
	[IdUniver] int NOT NULL
) ON [PRIMARY]

GO


ALTER TABLE Facult
ADD CONSTRAINT PK_University_IdFacult PRIMARY KEY CLUSTERED (IdFacult)
GO 

CREATE TABLE [dbo].[Spec](
	[IdSpec] [int] IDENTITY(1,1),
	[NameSpec] [nvarchar](60) NOT NULL,
	[IdFacult] int NOT NULL
) ON [PRIMARY]

GO


ALTER TABLE Spec
ADD CONSTRAINT PK_University_IdSpec PRIMARY KEY CLUSTERED (IdSpec)
GO 

CREATE TABLE [dbo].[Group](
	[IdGroup] [int] IDENTITY(1,1),
	[NameGroup] [nvarchar](30) NOT NULL,
	[IdSpec] int NOT NULL
) ON [PRIMARY]

GO


ALTER TABLE [Group]
ADD CONSTRAINT PK_University_IdGroup PRIMARY KEY CLUSTERED (IdGroup)
GO 

CREATE TABLE [dbo].[Student](
	[IdStudent] [int] IDENTITY(1,1),
	[NameStudent] [nvarchar](80) NOT NULL,
	[IdGroup] int NOT NULL
) ON [PRIMARY]

GO


ALTER TABLE Student
ADD CONSTRAINT PK_University_IdStudent PRIMARY KEY CLUSTERED (IdStudent)
GO 

CREATE TABLE [dbo].[Subject](
	[IdSubject] [int] NOT NULL,
	[NameSubject] [nvarchar](50) NOT NULL,
	[IdStudent] int NOT NULL,
	[Rating] int NULL
) ON [PRIMARY]

GO


ALTER TABLE [Subject]
ADD CONSTRAINT PK_University_IdSubject PRIMARY KEY CLUSTERED (IdSubject)
GO 