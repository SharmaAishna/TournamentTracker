CREATE TABLE [dbo].[Prizes]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	PlaceNumber INT NOT NULL,
	PlaceName VARCHAR(50) NOT NULL,
	PrizeAmount Decimal, 
    [PrizePercentage] DECIMAL,
)