/*

No database-level extended properties were found or all existing extended properties are open in other windows

*/CREATE TABLE [dbo].[Cars]
(
	[Id] INT  NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [BrandId] INT NOT NULL, 
    [ColorId] INT NOT NULL, 
    [ModelYear] INT NOT NULL, 
    [DailyPrice] DECIMAL NOT NULL, 
    [Description] NCHAR(50) NOT NULL
	FOREIGN KEY (ColorId) REFERENCES Colors(ColorId),
	FOREIGN KEY (BrandId) REFERENCES Brands(BrandId)
)