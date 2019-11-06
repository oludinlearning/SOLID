USE [University]
GO
/****** Object:  StoredProcedure [dbo].[sp_ViewStudentCond]    Script Date: 06.11.2019 21:26:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_ViewStudentCond]
@University nvarchar(50)= NameUniver,
@Facult nvarchar(50) = NameFacult,
@Spec nvarchar(60) = NameSpec,
@Group nvarchar(30) = NameGroup,
@Rating int = 1
AS
BEGIN
    SELECT Student.IdStudent, Student.NameStudent, Student.YearBirth, Student.RatingUSE, [Group].NameGroup, Spec.NameSpec, Facult.NameFacult, University.NameUniver
    FROM Student
	JOIN [Group] ON Student.IdGroup = [Group].IdGroup
	JOIN Spec ON [Group].IdSpec = Spec.IdSpec
	JOIN Facult ON Spec.IdFacult = Facult.IdFacult
	JOIN University ON Facult.IdUniver = University.IdUniver
	WHERE (University.NameUniver = @University) AND (Facult.NameFacult = @Facult) AND (Spec.NameSpec = @Spec) AND ([Group].NameGroup=@Group) AND (RatingUSE>@Rating)
	GROUP BY Student.IdStudent, Student.NameStudent, Student.YearBirth, Student.RatingUSE, [Group].NameGroup, Spec.NameSpec, Facult.NameFacult, University.NameUniver
END;