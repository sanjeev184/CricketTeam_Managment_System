﻿Create Procedure [dbo].[InsertToCricketTeam]
@JerseyNumber int,
@JerseyName varchar(20),
@PlayerAge int,
@Average float

as
begin
SET IDENTITY_INSERT [dbo].[CricketTeam] ON;
Insert Into [dbo].[CricketTeam]([Jerseynumber],[Jerseyname],[Playerage],[Average]) 
values(@JerseyNumber,@JerseyName,@PlayerAge,@Average)
End
