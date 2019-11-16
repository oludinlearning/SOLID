USE University;
GO
CREATE PROCEDURE sp_viewStudent AS
BEGIN
    SELECT Student.IdStudent, Student.NameStudent, Student.YearBirth, Student.RatingUSE, [Group].NameGroup, Spec.NameSpec, Facult.NameFacult, University.NameUniver
    FROM Student
	JOIN [Group] ON Student.IdGroup = [Group].IdGroup
	JOIN Spec ON [Group].IdSpec = Spec.IdSpec
	JOIN Facult ON Spec.IdFacult = Facult.IdFacult
	JOIN University ON Facult.IdUniver = University.IdUniver
END;