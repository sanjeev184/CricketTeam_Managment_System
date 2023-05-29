CREATE PROCEDURE [dbo].[DeletePlayer]
@Id int

AS
Begin
	Delete from [dbo].[CricketTeam] 
	where [Jerseynumber]=@Id;
End

