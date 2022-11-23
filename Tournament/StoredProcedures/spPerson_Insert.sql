CREATE PROCEDURE [dbo].[spPerson_Insert]
	@FirstName nvarchar(100),
	@LastName nvarchar(100),
	@Email nvarchar(100),
	@Phone nvarchar(20),
	@Id int=0 Output

AS
Begin
	INSERT INTO dbo.Person(FirstName,LastName,Email,Phone)
	VALUES (@FirstName,@LastName,@Email,@Phone)
	select @Id=SCOPE_IDENTITY();
End
Go
