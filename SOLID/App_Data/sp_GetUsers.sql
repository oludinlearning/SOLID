CREATE PROCEDURE [dbo].[sp_GetUsers1]
@University nvarchar(50)= NameUniver,
@Facult nvarchar(50) = NameFacult,
@Spec nvarchar(60) = NameSpec,
@Group nvarchar(30) = NameGroup,
@Rating int = 1
AS
    SELECT * FROM View_1
	WHERE (NameUniver = @University) AND (NameFacult = @Facult) AND (NameSpec = @Spec) AND (NameGroup=@Group) AND (RatingUSE>@Rating) 
GO
