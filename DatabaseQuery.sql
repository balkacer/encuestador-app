use master
go

drop database if exists EncuestadorApp
go

create database EncuestadorApp
go

use EncuestadorApp
go

create table [User]
(
	[Id] int primary key identity(1,1),
	[Name] varchar(50) not null,
	[LastName] varchar(50) not null,
	[Password] varchar(50) not null,
	[Username] varchar(50) unique not null
)
go

create table [Quiz]
(
	[Id] int primary key identity(1,1),
	[Name] varchar(50) not null,
	[UserId] int foreign key references [User]([Id]) not null
)
go

create table [QuizQuestion]
(
	[Id] int primary key identity(1,1),
	[Question] varchar(100) not null,
	[QuizId] int foreign key references [Quiz]([Id]) not null,
	constraint UQ_Quiz_Question unique ([QuizId], [Question])
)
go

create table [Respondent]
(
	[Id] int primary key identity(1,1),
	[Name] varchar(50) not null,
	[QuizId] int foreign key references [Quiz]([Id]) not null
)
go

create table [QuestionResponse]
(
	[Id] int primary key identity(1,1),
	[Response] varchar(150) not null,
	[RespondentId] int foreign key references [Respondent]([Id]) not null,
	[QuizQuestionId] int foreign key references [QuizQuestion]([Id]) not null
)
go