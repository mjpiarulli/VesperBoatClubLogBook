-- access tables needed
-- members, fleet, log book, boat status log, boat type, boatings
-- notes: log book - edit mappings for dates to datetime2

-- Members
delete from Members
where [First Name] is null
	and [Middle Initial] is null
	and [Last Name] is null

Create Table Member (
	MemberId int not null identity(1, 1) primary key,
	FirstName varchar(50),
	MiddleInitial varchar(50),
	LastName varchar(50)
)

set identity_insert Member ON
go

Insert Into Member(MemberId, FirstName, MiddleInitial, LastName)
Select [Member Number], [First Name], [Middle Initial], [Last Name]
from Members

set identity_insert Member off
go

drop table Members

-- fleet
Create Table Boat (
	BoatId int not null identity primary key,
	Name varchar(50) not null,
	Make varchar(50),
	Size int not null default(0),
	[Type] varchar(50) not null,
	CurrentRigging varchar(50),
	RiggingAvailable varchar(50),
	UseRestrictions varchar(50),
	[Status] varchar(50),
	OwnedBy varchar(50)
)

set identity_insert Boat ON
go

Insert Into Boat(BoatId, Name, Make, Size, [Type], CurrentRigging, RiggingAvailable, UseRestrictions, [Status], OwnedBy)
Select [Boat No], IsNull([Boat Name], ''), Make, IsNull(Size, 0), [Type], [Currrent Rigging], [Rigging Available], [Use Restrictions], [Status], [Owned By]
from Fleet

set identity_insert Boat off
go

Drop table Fleet


Create Table LogBook(
	LogBookId int identity(1,1) primary key,
	[Date] datetime2 null,
	TimeOut datetime2 null,
	TimeIn datetime2 null,
	MilesRowed int null,
	Comment varchar(max),
	BoatName varchar(200), 
	BoatType varchar(50)
)

set identity_insert LogBook on
go

Insert Into LogBook(LogBookId, [Date], TimeOut, TimeIn, MilesRowed, Comment, BoatName, BoatType)
Select [Entry No], [Date], [Time out], [Time in], [Miles Rowed], Comment, BoatName, [Type]
From [Log Book]

set identity_insert LogBook off
go

drop table [Log Book]



Create Table BoatStatusLog (
	BoatStatusLogId int identity(1, 1) primary key,
	BoatName varchar(50),
	[Status] varchar(50),
	Comments varchar(max),
	RemovalOfServiceDate datetime,
	CommentOnReturn varchar(max),
	ReturnToServiceDate datetime null
)

Insert Into BoatStatusLog(BoatName, [Status], Comments, RemovalOfServiceDate, CommentOnReturn, ReturnToServiceDate)
Select [Boat Name], [Status], [Comments], [Date of Removal from Service], [Comment on Return], [Date of Return to Service]
From [Boat Status Log]

Drop Table [Boat Status Log]


Create Table BoatType(
	BoatTypeId int identity(1, 1) primary key,
	[Type] varchar(20) not null,
	Name varchar(50) not null,
	Seats int not null,
	StartCount int not null,
	HasCox bit not null
)

Insert Into BoatType([Type],Name,Seats, StartCount, HasCox)
Select [Type],[Name],[Seats],[Start Count],[Cox]
from [Boat Type]

Drop Table [Boat Type]

Create Table Boating(
	BoatingId int identity(1, 1) primary key,
	LogBookId int not null,
	MemberId int not null,
	Seat varchar(10),
	[Order] int not null
	FOREIGN KEY (LogBookId) REFERENCES LogBook(LogBookId),
	FOREIGN KEY (MemberId) REFERENCES Member(MemberId)
)

Insert Into Boating(LogBookId, MemberId, Seat, [Order])
Select [Log entry number], [Member number], [Seat], [Order]
From Boatings b
join LogBook lb
on b.[Log entry number] = lb.LogBookId
join Member m
on b.[Member number] = m.MemberId

Drop Table Boatings