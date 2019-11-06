USE [University]
GO
/****** Object:  StoredProcedure [dbo].[sp_ViewStudentCond2]    Script Date: 06.11.2019 21:51:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_ViewStudentCond2]
@University nvarchar(50)= NameUniver,
@Facult nvarchar(50) = NameFacult,
@Spec nvarchar(60) = NameSpec,
@Group nvarchar(30) = NameGroup,
@Rating int = 1
AS
BEGIN
    SELECT *
    FROM View_1
	WHERE (NameUniver = @University) AND (NameFacult = @Facult) AND (NameSpec = @Spec) AND (NameGroup=@Group) AND (RatingUSE>@Rating)
END;