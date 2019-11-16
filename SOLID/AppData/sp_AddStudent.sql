CREATE PROCEDURE [dbo].[sp_AddStudent]
    @nameStudent nvarchar(80),
    @yearBirth date,
	@idGroup int,
	@ratingUSE int

AS
    INSERT INTO Student(NameStudent, YearBirth,IdGroup,RatingUSE)
    VALUES (@nameStudent, @yearBirth, @idGroup, @ratingUSE)
  
    SELECT SCOPE_IDENTITY()
GO