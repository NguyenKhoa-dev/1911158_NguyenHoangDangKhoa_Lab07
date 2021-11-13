--CREATE DATABASE RestaurantManagement
USE [RestaurantManagement]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 6/4/2020 9:31:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[AccountName] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](200) NOT NULL,
	[FullName] [nvarchar](1000) NOT NULL,
	[Email] [nvarchar](1000) NULL,
	[Tell] [nvarchar](200) NULL,
	[DateCreated] [smalldatetime] NULL,
 CONSTRAINT [PK_Account_1] PRIMARY KEY CLUSTERED 
(
	[AccountName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillDetails]    Script Date: 6/4/2020 9:31:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillDetails](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceID] [int] NOT NULL,
	[FoodID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_InvoiceInfo] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bills]    Script Date: 6/4/2020 9:31:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bills](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](1000) NOT NULL,
	[TableID] [int] NOT NULL,
	[Amount] [int] NOT NULL,
	[Discount] [float] NULL,
	[Tax] [float] NULL,
	[Status] [bit] NOT NULL,
	[CheckoutDate] [smalldatetime] NULL,
	[Account] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 6/4/2020 9:31:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](1000) NOT NULL,
	[Type] [int] NOT NULL,
 CONSTRAINT [PK_FoodCategory] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Food]    Script Date: 6/4/2020 9:31:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Food](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](1000) NOT NULL,
	[Unit] [nvarchar](100) NOT NULL,
	[FoodCategoryID] [int] NOT NULL,
	[Price] [int] NOT NULL,
	[Notes] [nvarchar](3000) NULL,
 CONSTRAINT [PK_FoodStuffs] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 6/4/2020 9:31:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](1000) NOT NULL,
	[Path] [nvarchar](3000) NULL,
	[Notes] [nvarchar](3000) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoleAccount]    Script Date: 6/4/2020 9:31:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoleAccount](
	[RoleID] [int] NOT NULL,
	[AccountName] [nvarchar](100) NOT NULL,
	[Actived] [bit] NOT NULL,
	[Notes] [nvarchar](3000) NULL,
 CONSTRAINT [PK_RoleAccount] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC,
	[AccountName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Table]    Script Date: 6/4/2020 9:31:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](1000) NULL,
	[Status] [int] NOT NULL,
	[Capacity] [int] NULL,
 CONSTRAINT [PK_Table] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([AccountName], [Password], [FullName], [Email], [Tell], [DateCreated]) VALUES (N'lgcong', N'legiacong', N'Lê Gia Công', N'conglg@dlu.edu.vn', NULL, NULL)
INSERT [dbo].[Account] ([AccountName], [Password], [FullName], [Email], [Tell], [DateCreated]) VALUES (N'pttnga', N'phanthithanhnga', N'Phan Thị Thanh Nga', N'ngaptt@dlu.edu.vn', NULL, CAST(N'2020-06-04T00:00:00' AS SmallDateTime))
INSERT [dbo].[Account] ([AccountName], [Password], [FullName], [Email], [Tell], [DateCreated]) VALUES (N'tdquy', N'thaiduyquy', N'Thái Duy Quý', N'quytd@dlu.edu.vn', NULL, NULL)
INSERT [dbo].[Account] ([AccountName], [Password], [FullName], [Email], [Tell], [DateCreated]) VALUES (N'ttplinh', N'tranthiphuonglinh', N'Trần Thị Phương Linh', N'linhttp@dlu.edu.vn', NULL, NULL)
SET IDENTITY_INSERT [dbo].[BillDetails] ON 

INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (1, 1, 3, 2)
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (2, 1, 4, 1)
SET IDENTITY_INSERT [dbo].[BillDetails] OFF
SET IDENTITY_INSERT [dbo].[Bills] ON 

INSERT [dbo].[Bills] ([ID], [Name], [TableID], [Amount], [Discount], [Tax], [Status], [CheckoutDate], [Account]) VALUES (1, N'Hóa đơn thanh toán', 5, 150000, 0.05, 0, 1, NULL, N'tdquy')
SET IDENTITY_INSERT [dbo].[Bills] OFF
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (1, N'Khai vị', 1)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (2, N'Hải sản', 1)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (3, N'Gà', 1)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (4, N'Cơm', 1)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (5, N'Thịt', 1)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (6, N'Rau', 1)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (8, N'Canh', 1)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (9, N'Lẩu', 1)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (10, N'Bia', 0)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (11, N'Nước ngọt', 0)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (12, N'Cà phê', 0)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (13, N'Trà đá', 0)
SET IDENTITY_INSERT [dbo].[Category] OFF
SET IDENTITY_INSERT [dbo].[Food] ON 

INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (1, N'Rau muống xào tỏi', N'Đĩa', 6, 20000, NULL)
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (2, N'Cơm chiên Dương châu', N'Đĩa nhỏ', 4, 35000, N'3 người ăn')
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (3, N'Cơm chiên Dương châu', N'Đĩa lớn', 4, 40000, N'4 người ăn')
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (4, N'Ếch thui rơm', N'Đĩa', 2, 70000, NULL)
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (5, N'Sò lông nướng mỡ hành', N'Đĩa', 2, 80000, NULL)
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (6, N'Càng cua hấp', N'Đĩa', 2, 100000, NULL)
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (7, N'Canh cải', N'Tô', 8, 20000, NULL)
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (8, N'Gà nướng muối ớt', N'Con', 3, 180000, NULL)
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (9, N'Bia 333', N'Chai', 10, 12000, NULL)
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (10, N'Bia Heniken', N'Chai', 10, 20000, NULL)
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (11, N'Súp cua', N'Tô', 1, 15000, NULL)
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (12, N'Thịt kho', N'Đĩa', 5, 25000, N'Theo thời giá')
SET IDENTITY_INSERT [dbo].[Food] OFF
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([ID], [RoleName], [Path], [Notes]) VALUES (1, N'Adminstrator', NULL, NULL)
INSERT [dbo].[Role] ([ID], [RoleName], [Path], [Notes]) VALUES (2, N'Kế toán', NULL, NULL)
INSERT [dbo].[Role] ([ID], [RoleName], [Path], [Notes]) VALUES (3, N'Nhân viên thanh toán', NULL, NULL)
INSERT [dbo].[Role] ([ID], [RoleName], [Path], [Notes]) VALUES (4, N'Nhân viên phục vụ', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Role] OFF
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (1, N'lgcong', 1, NULL)
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (1, N'pttnga', 1, NULL)
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (1, N'tdquy', 1, NULL)
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (1, N'ttplinh', 1, NULL)
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (3, N'lgcong', 0, NULL)
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (3, N'pttnga', 0, NULL)
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (3, N'tdquy', 1, NULL)
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (3, N'ttplinh', 1, NULL)
SET IDENTITY_INSERT [dbo].[Table] ON 

INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1, N'01', 0, 4)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (2, N'02', 0, 4)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (4, N'03', 0, 4)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (5, N'04', 0, 6)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (6, N'05', 0, 8)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (8, N'06', 0, 8)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1002, N'07', 0, 8)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1003, N'08', 0, 12)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1004, N'09', 0, 12)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1005, N'10', 0, 15)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1006, N'VIP.1', 0, 20)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1007, N'VIP.2', 0, 20)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1008, N'VIP.3', 0, 10)
SET IDENTITY_INSERT [dbo].[Table] OFF
ALTER TABLE [dbo].[BillDetails] ADD  CONSTRAINT [DF_InvoiceDetails_Amount]  DEFAULT ((0)) FOR [Quantity]
GO
ALTER TABLE [dbo].[Food] ADD  CONSTRAINT [DF_Food_Price]  DEFAULT ((0)) FOR [Price]
GO
ALTER TABLE [dbo].[BillDetails]  WITH CHECK ADD  CONSTRAINT [FK_InvoiceInfo_FoodStuffs] FOREIGN KEY([FoodID])
REFERENCES [dbo].[Food] ([ID])
GO
ALTER TABLE [dbo].[BillDetails] CHECK CONSTRAINT [FK_InvoiceInfo_FoodStuffs]
GO
ALTER TABLE [dbo].[BillDetails]  WITH CHECK ADD  CONSTRAINT [FK_InvoiceInfo_Invoice] FOREIGN KEY([InvoiceID])
REFERENCES [dbo].[Bills] ([ID])
GO
ALTER TABLE [dbo].[BillDetails] CHECK CONSTRAINT [FK_InvoiceInfo_Invoice]
GO
ALTER TABLE [dbo].[Bills]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_Table] FOREIGN KEY([TableID])
REFERENCES [dbo].[Table] ([ID])
GO
ALTER TABLE [dbo].[Bills] CHECK CONSTRAINT [FK_Invoice_Table]
GO
ALTER TABLE [dbo].[Food]  WITH CHECK ADD  CONSTRAINT [FK_FoodStuffs_FoodCategory] FOREIGN KEY([FoodCategoryID])
REFERENCES [dbo].[Category] ([ID])
GO
ALTER TABLE [dbo].[Food] CHECK CONSTRAINT [FK_FoodStuffs_FoodCategory]
GO
ALTER TABLE [dbo].[RoleAccount]  WITH CHECK ADD  CONSTRAINT [FK_RoleAccount_Account] FOREIGN KEY([AccountName])
REFERENCES [dbo].[Account] ([AccountName])
GO
ALTER TABLE [dbo].[RoleAccount] CHECK CONSTRAINT [FK_RoleAccount_Account]
GO
ALTER TABLE [dbo].[RoleAccount]  WITH CHECK ADD  CONSTRAINT [FK_RoleAccount_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([ID])
GO
ALTER TABLE [dbo].[RoleAccount] CHECK CONSTRAINT [FK_RoleAccount_Role]
GO

CREATE PROCEDURE InsertFood
@ID int output,
@Name nvarchar(3000), 
@Unit nvarchar(3000), 
@FoodCategoryID int, 
@Price int,  
@Notes nvarchar(3000)
AS
	INSERT INTO Food (Name, Unit, FoodCategoryID, Price,  Notes)
	VALUES ( @Name, @Unit, @FoodCategoryID, @Price,  @Notes)

	SELECT @ID = SCOPE_IDENTITY()
go

CREATE PROCEDURE Food_Update
(
	@ID INT,
	@Name NVARCHAR(1000),
	@Unit NVARCHAR(100),
	@FoodCategoryID INT,
	@Price INT,
	@Notes NVARCHAR(3000)
)
As
Begin
	Update dbo.[Food]
	Set[Name] = @Name, 
	[Unit] = @Unit, 
	[FoodCategoryID] = @FoodCategoryID,
	[Price] = @Price,
	[Notes] = @Notes
	Where ID = @ID
End
go

CREATE PROCEDURE Food_Delete
(
	@ID INT
)
As
Begin
	Delete from dbo.[Food]
	Where ID = @ID
End
go

CREATE PROCEDURE Category_Insert
(
	@ID INT OUTPUT,
	@Name NVARCHAR(1000),
	@Type INT
)
As
Begin
	IF (not exists (Select Name from dbo.Category where Name = @Name))
		begin
			INSERT INTO Category (Name, [Type]) VALUES (@Name, @Type)
			SELECT @ID = SCOPE_IDENTITY()
		end		
End
go

CREATE PROCEDURE Bills_Insert
(
	@ID int output,
	@Name NVARCHAR(1000),
	@TableID INT,
	@Amount INT,
	@Discount FLOAT,
	@Tax FLOAT,
	@Status BIT,
	@CheckoutDate SMALLDATETIME,
	@Account NVARCHAR(100)
)
As
Begin
	INSERT INTO dbo.[Bills] (Name, TableID, Amount, Discount, Tax, [Status], CheckoutDate, Account) 
	VALUES (@Name, @TableID, @Amount, @Discount, @Tax, @Status, @CheckoutDate, @Account)
	SELECT @ID = SCOPE_IDENTITY()
End
go

CREATE PROCEDURE Bills_Update
(
	@ID INT,
	@Name NVARCHAR(1000),
	@TableID INT,
	@Amount INT,
	@Discount FLOAT,
	@Tax FLOAT,
	@Status BIT,
	@CheckoutDate SMALLDATETIME,
	@Account NVARCHAR(100)
)
As
Begin
	Update dbo.[Bills]
	Set[Name] = @Name, 
	[TableID] = @TableID, 
	[Amount] = @Amount,
	[Discount] = @Discount,
	[Tax] = @Tax,
	[Status] = @Status,
	[CheckoutDate] = @CheckoutDate,
	[Account] = @Account
	Where ID = @ID
End
go

CREATE PROCEDURE Account_Insert
(
	@AccountName NVARCHAR(100),
	@Password NVARCHAR(200),
	@FullName NVARCHAR(1000),
	@Email NVARCHAR(1000),
	@Tell NVARCHAR(200),
	@DateCreated SMALLDATETIME
)
As
Begin
	INSERT INTO dbo.[Account] (AccountName, [Password], FullName, Email, Tell, DateCreated) 
	VALUES (@AccountName, @Password, @FullName, @Email, @Tell, @DateCreated)
End
go

CREATE PROCEDURE RoleAccount_Insert
(
	@RoleID int,
	@AccountName nvarchar(100),
	@Actived bit,
	@Notes nvarchar(3000)
)
As
Begin
	If (not exists(select RoleID, AccountName from [RoleAccount] where AccountName = @AccountName and RoleID = @RoleID))
		INSERT INTO dbo.[RoleAccount] (RoleID, AccountName, Actived, Notes) 
		VALUES (@RoleID, @AccountName, @Actived, @Notes)
End
go

CREATE PROCEDURE Role_Insert
(
	@ID int OUTPUT,
	@RoleName NVARCHAR(1000),
	@Path NVARCHAR(3000),
	@Notes NVARCHAR(3000)
)
As
Begin
	If (not exists(select RoleName from [Role] where RoleName = @RoleName))
		begin
			INSERT INTO dbo.[Role] (RoleName, Path, Notes) 
			VALUES (@RoleName, @Path, @Notes)
			SELECT @ID = SCOPE_IDENTITY()
		end		
End
go

CREATE PROCEDURE Role_Update
(
	@ID INT,
	@RoleName NVARCHAR(1000),
	@Path NVARCHAR(3000),
	@Notes NVARCHAR(3000)
)
As
Begin
	Update dbo.[Role]
	Set[RoleName] = @RoleName,
	[Path] = @Path, 
	[Notes] = @Notes
	Where ID = @ID
End
go

CREATE PROCEDURE Account_Update
(
	@AccountName NVARCHAR(100),
	@Password NVARCHAR(200),
	@FullName NVARCHAR(1000),
	@Email NVARCHAR(1000),
	@Tell NVARCHAR(200)
)
As
Begin
	Update dbo.[Account]
	Set[Password] = @Password,
	[FullName] = @FullName, 
	[Email] = @Email,
	[Tell] = @Tell
	Where AccountName = @AccountName
End
go

CREATE PROCEDURE Password_Reset
(
	@AccountName NVARCHAR(100),
	@Password NVARCHAR(200)
)
As
Begin
	Update dbo.[Account]
	Set[Password] = @Password
	Where AccountName = @AccountName
End
go

CREATE PROCEDURE Account_Delete
(
	@AccountName nvarchar(100),
	@Actived bit
)
As
Begin
	Update dbo.[RoleAccount]
	Set[Actived] = @Actived
	Where AccountName = @AccountName
End
go

CREATE PROCEDURE Table_Insert
(
	@ID int OUTPUT,
	@Name NVARCHAR(1000),
	@Status INT,
	@Capacity INT
)
As
Begin
	IF (not exists (Select Name from dbo.[Table] where Name = @Name))
		begin
			INSERT INTO dbo.[Table] (Name, [Status], Capacity) VALUES (@Name, @Status, @Capacity)
			SELECT @ID = SCOPE_IDENTITY()
		end
End
go

CREATE PROCEDURE Table_Update
(
	@ID INT,
	@Name NVARCHAR(1000),
	@Status INT,
	@Capacity INT
)
As
Begin
	Update dbo.[Table]
	Set[Name] = @Name, [Status] = @Status, [Capacity] = @Capacity
	Where ID = @ID
End
go

CREATE PROCEDURE Table_Delete
(
	@ID INT
)
As
Begin
	Delete from dbo.[Table]
	Where ID = @ID
End

EXEC Bills_Update 1, N'Hóa đơn thanh toán', 5, 150000, 0.05, 0, 1, '10/23/2021', N'tdquy'

--EXEC Bills_Insert 0, N'Hóa đơn thanh toán', 4, 200000, 0.05, 0, 1, '02/08/2021', N'lgcong'
--EXEC Bills_Insert 0, N'Hóa đơn thanh toán VIP', 1006, 500000, 0.05, 0, 1, '10/26/2021', N'ttplinh'

--EXEC InsertFood 0, N'Súp vi cá', N'Tô', 1, 80000, N'' 
--select * from Bills

--select * from Bills
--where CheckoutDate > '10/20/2021' AND CheckoutDate < '10/26/2021'

--select * from RoleAccount

--EXEC Account_Insert N'nhdkhoa', N'nguyenkhoa', N'Nguyễn Hoàng Đăng Khoa', N'1911158@dlu.edu.vn', N'0917934079', '10/28/2021'
--Delete From Account Where AccountName = N'nhdkhoa'
--select * from Account

--SELECT A.AccountName, Password, FullName, Email, Tell, RoleName 
--FROM Account A, [Role] B, RoleAccount C 
--WHERE A.AccountName = C.AccountName AND B.ID = C.RoleID AND A.AccountName = + N'nhdkhoa'

--SELECT A.AccountName, FullName, Email, Tell
--FROM Account A, [Role] B, RoleAccount C
--WHERE A.AccountName = C.AccountName AND B.ID = C.RoleID AND RoleName = N'Adminstrator'

--select RoleName
--from Role A, RoleAccount B
--where A.ID = B.RoleID and AccountName = N'lgcong'

--EXEC Account_Delete N'nhdkhoa', 1

--select * from [Table]

--select A.ID, A.Name, TableID, Amount, Discount, Tax, A.[Status], CheckoutDate, Account 
--from Bills A, [Table] B
--where A.TableID = B.ID and A.[Status] = 0 and B.[Status] = 1 and B.ID = 5

--SELECT CheckoutDate FROM Bills WHERE TableID = 5

--SELECT A.ID, C.Name, Quantity, Price
--FROM Bills A, BillDetails B, Food C
--WHERE A.ID = B.InvoiceID AND B.FoodID = C.ID AND CheckoutDate = '10/23/2021' AND TableID = 5

--SELECT COUNT(A.ID) as NumOfBills, SUM(Amount) as SumAmount, SUM(Discount) as SumDiscount, SUM(Tax) as SumTax
--FROM Bills A
--WHERE CheckoutDate = '10/23/2021' AND Account = N'tdquy' AND TableID = 5

--SELECT * FROM RoleAccount
--SELECT * FROM Bills WHERE CheckoutDate = '23/10/2021'
--SELECT SUM(Amount) FROM Bills WHERE CheckoutDate = '23/10/2021'

--SELECT CheckoutDate FROM Bills WHERE Account = N'tdquy'

--SELECT COUNT(ID) as SoLuong, SUM(Amount) as TongTien
--FROM Bills
--WHERE Account = N'tdquy'

select f.Name, f.Price, bd.Quantity, f.Price * bd.Quantity as Amount from Food f, BillDetails bd, Bills b
where bd.FoodID = f.ID and bd.InvoiceID = b.ID and bd.InvoiceID = 1

select sum(f.Price * bd.Quantity) from Food f, BillDetails bd, Bills b
where bd.FoodID = f.ID and bd.InvoiceID = b.ID and bd.InvoiceID = 1