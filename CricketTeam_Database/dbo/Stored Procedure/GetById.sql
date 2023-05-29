CREATE PROCEDURE [dbo].[GetById]
	@Id int
AS
BEGIN
	SELECT
	[Jerseyname],[Playerage],[Playerage],[Average]
	FROM [dbo].[CricketTeam]
	WHERE [Jerseynumber] = @Id
END