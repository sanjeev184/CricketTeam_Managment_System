CREATE PROCEDURE [dbo].[Update_CricketTeam]
@JerseyNumber int,
@JerseyName varchar(20),
@PlayerAge int,
@Average float

AS
begin
	Update [dbo].[CricketTeam] set  Jerseyname= @JerseyName,Playerage= @PlayerAge,Average= @Average
	where Jerseynumber=@JerseyNumber;
End
