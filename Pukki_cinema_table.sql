CREATE TABLE GENRES(
Genre_ID	int 		IDENTITY(1,1) PRIMARY KEY,
Description	varchar(20)
);

CREATE TABLE FILMS(
Film_ID		int		IDENTITY(1,1) PRIMARY KEY,
Title		varchar(100),
Film_Cost	money,
Selling_Price	smallmoney,
Length		int,
Age_Restriction int,
Genre_ID	int	FOREIGN KEY REFERENCES GENRE(Genre_ID)
);


CREATE TABLE THEATRES(
Theatre_ID	int		IDENTITY(1,1) PRIMARY KEY,
Capacity	int
);

CREATE trigger LimitTable
on THEATRES
after insert
as
    declare @tableCount int
    select @tableCount= Count(*)
    from THEATRES

    if @tableCount > 3
    begin
        rollback
    end
go

CREATE TABLE USERS(
User_ID		int		IDENTITY(1,1) PRIMARY KEY,
Username	varchar(20),
Password	varchar(20),
IsAdmin		bit
);

CREATE TABLE TIME_ALLOCATIONS(
Time_ID		int 		IDENTITY(1,1) PRIMARY KEY,
Time		time
);

CREATE TABLE SCHEDULES(
Schedule_ID	int 		IDENTITY(1,1) PRIMARY KEY,
Film_ID		int	FOREIGN KEY REFERENCES FILM(Film_ID),
Theatre_ID	int	FOREIGN KEY REFERENCES THEATRE(Theatre_ID),
Time_ID		int 	FOREIGN KEY REFERENCES TIME_ALLOCATION(Time_ID),
Film_Date	date,
Ticket_Counter	int
);

