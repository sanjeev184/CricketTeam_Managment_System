CREATE PROCEDURE [dbo].[Update_CricketTeam]
@JerseyNumber int,
@JerseyName varchar,
@PlayerAge int,
@Average decimal

AS
begin
	Update [dbo].[CricketTeam] set  Jerseyname= @JerseyName,Playerage= @PlayerAge,Average= @Average
	where Jerseynumber=@JerseyNumber;
End
