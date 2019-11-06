USE University;
GO
CREATE PROCEDURE sp_ViewStudentCond
@University nvarchar(50)= NameUniver,
@Facult nvarchar(50) = NameFacult,
@Spec nvarchar(60) = NameSpec,
@Group nvarchar(30) = NameGroup,
@Rating int = 1
AS
BEGIN
    SELECT Student.IdStudent AS Id, Student.NameStudent AS NameStudent, Student.YearBirth AS YearB, Student.RatingUSE AS Rating, [Group].NameGroup AS NameGroup, Spec.NameSpec AS NameSpec, Facult.NameFacult AS NameFacult, University.NameUniver AS NameUniver
    FROM Student
	JOIN [Group] ON Student.IdGroup = [Group].IdGroup
	JOIN Spec ON [Group].IdSpec = Spec.IdSpec
	JOIN Facult ON Spec.IdFacult = Facult.IdFacult
	JOIN University ON Facult.IdUniver = University.IdUniver
	WHERE (University.NameUniver = @University) AND (Facult.NameFacult = @Facult) AND (Spec.NameSpec = @Spec) AND ([Group].NameGroup=@Group) AND (RatingUSE>@Rating)
	GROUP BY Student.IdStudent, Student.NameStudent, Student.YearBirth, Student.RatingUSE, [Group].NameGroup, Spec.NameSpec, Facult.NameFacult, University.NameUniver
END;