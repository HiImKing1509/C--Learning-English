----------------------------------------------------------------------------------------------
--------------------------- Database: Shopping Online ----------------------------------
----------------------------------------------------------------------------------------------
create database ShoppingOnline
go
--
use ShoppingOnline
go

-- Convert languague
CREATE FUNCTION [dbo].[LanguageComprehension](@inputVar NVARCHAR(MAX) )
RETURNS NVARCHAR(MAX)
AS
BEGIN    
    IF (@inputVar IS NULL OR @inputVar = '')  RETURN ''
   
    DECLARE @RT NVARCHAR(MAX)
    DECLARE @SIGN_CHARS NCHAR(256)
    DECLARE @UNSIGN_CHARS NCHAR (256)
 
    SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệếìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵýĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' + NCHAR(272) + NCHAR(208)
    SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeeeiiiiiooooooooooooooouuuuuuuuuuyyyyyAADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIIIOOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD'
 
    DECLARE @COUNTER int
    DECLARE @COUNTER1 int
   
    SET @COUNTER = 1
    WHILE (@COUNTER <= LEN(@inputVar))
    BEGIN  
        SET @COUNTER1 = 1
        WHILE (@COUNTER1 <= LEN(@SIGN_CHARS) + 1)
        BEGIN
            IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@inputVar,@COUNTER ,1))
            BEGIN          
                IF @COUNTER = 1
                    SET @inputVar = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@inputVar, @COUNTER+1,LEN(@inputVar)-1)      
                ELSE
                    SET @inputVar = SUBSTRING(@inputVar, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@inputVar, @COUNTER+1,LEN(@inputVar)- @COUNTER)
                BREAK
            END
            SET @COUNTER1 = @COUNTER1 +1
        END
        SET @COUNTER = @COUNTER +1
    END
    -- SET @inputVar = replace(@inputVar,' ','-')
    RETURN @inputVar
END
go

create table CUSTOMER
(
	CUSTOMER_ID char(4),
	CUSTOMER_NAME nvarchar(100),
	CUSTOMER_PHONE_NUMBER nvarchar(11),
	CUSTOMER_ACCOUNT nvarchar(50),
	CUSTOMER_PASSWORD nvarchar(50),
	CUSTOMER_ADDRESS nvarchar(200),
	CUSTOMER_NUMBER_RECEIPT int,
	constraint PK_CUSTOMER primary key (CUSTOMER_ID)
)
go

create table PRODUCT
(
	PRODUCT_ID char(4), -- Ma SP
	PRODUCT_NAME nvarchar(100), -- Ten SP
	PRODUCT_FORM nvarchar(100), -- Tieu chuan, rong, ...
	PRODUCT_COLOR nvarchar(50), -- Trang, den, mau
	PRODUCT_OLD_PRICE float, -- Gia cu SP
	PRODUCT_PRICE float, -- Gia SP
	PRODUCT_SIZE_S int, -- Con size S ko
	PRODUCT_SIZE_M int, -- Con size L ko
	PRODUCT_SIZE_L int, -- Con size M ko
	PRODUCT_SIZE_XL int, -- Con size XL ko
	PRODUCT_MATERIAL nvarchar(100), -- Chat lieu SP
	PRODUCT_COMPOSITION nvarchar(100), -- Thanh phan,
	PRODUCT_COUNTRY nvarchar(200), -- Xuat xu
	constraint PK_KHOA_TSHIRT primary key (PRODUCT_ID)
)
go

create table RECEIPT
(
	RECEIPT_ID char(7),
	RECEIPT_DATE nvarchar(50),
	RECEIPT_CUSTOMER char(4),
	RECEIPT_PRICE float
	constraint PK_RECEIPT primary key (RECEIPT_ID)
)
go

create table RECEIPT_DETAILS
(
	RECEIPT_DETAILS_ID char(7),
	RECEIPT_DETAILS_PRODUCT char(4),
	RECEIPT_DETAILS_SIZE nvarchar(10),
	RECEIPT_DETAILS_QUATITY int,
	constraint PK_RECEIPT_DETAILS primary key (RECEIPT_DETAILS_ID, RECEIPT_DETAILS_PRODUCT, RECEIPT_DETAILS_SIZE)
)
go

create table COMMENT
(
	COMMENT_ID int,
	COMMENT_DATE nvarchar(50),
	COMMENT_PRODUCT char(4),
	COMMENT_CUSTOMER char(4),
	COMMENT_CONTENT nvarchar(500),
	COMMENT_LIKE int,
	constraint PK_COMMENT primary key (COMMENT_ID)
)

create table DISCOUNT
(
	DISCOUNT_ID char(4),
	DISCOUNT_MIN_PRICE float,
	DISCOUNT_VALUE int,
	constraint PK_DISCOUNT primary key (DISCOUNT_ID)
)
go

-- Foreign key
alter table RECEIPT add constraint FK_CUSTOMER_ID foreign key (RECEIPT_CUSTOMER) references CUSTOMER(CUSTOMER_ID)
alter table RECEIPT_DETAILS add constraint FK_RECEIPT_DETAILS_ID foreign key (RECEIPT_DETAILS_ID) references RECEIPT(RECEIPT_ID)
alter table RECEIPT_DETAILS add constraint FK_DETAILS_PRODUCT foreign key (RECEIPT_DETAILS_PRODUCT) references PRODUCT(PRODUCT_ID)
go

alter table RECEIPT drop constraint FK_CUSTOMER_ID
go
alter table RECEIPT_DETAILS drop constraint FK_RECEIPT_DETAILS_ID
go
alter table RECEIPT_DETAILS drop constraint FK_DETAILS_PRODUCT
go

-- Add data Table Customer
insert into CUSTOMER values('CU00', N'ADMIN', N'0123456789', N'admin', N'1', N'C#, Winform', 0)
insert into CUSTOMER values('CU01', N'Huỳnh Viết Tuấn Kiệt', N'0738983924', N'tuankiet1509', N'kiet123456', N'Số 325, Đường Lê Hồng Phong, Tổ 4, Khối phố Gia Hòa, Phường Minh An, Thành phố Quy Nhơn', 0)
insert into CUSTOMER values('CU02', N'Ngô Văn Tấn Lưu', N'0988562992', N'tanluu1234', N'1', N'Số 5, Đường Nguyễn Du, Tổ 20, Khối phố Lâm Sa, Phường Cẩm Châu, Thành phố Hải Phòng', 0)
insert into CUSTOMER values('CU03', N'Trương Thành Thắng', N'0988767725', N'thang1234', N'1', N'Số 12, Đường Trần Thị Lý, Tổ 1, Khối phố Bình An, Phường Bình An Hòa, Thành phố Đà Nẵng', 0)
insert into CUSTOMER values('CU04', N'Nguyễn Đức Anh Phúc', N'0908141390', N'phuc1234', N'1', N'Số 43, Đường Cao Bá Quát, Tổ 23, Khối phố Tây Sơn, Phường Tây Sơn 1, Thành phố Cao Lãnh', 0)
insert into CUSTOMER values('CU05', N'Nguyễn Văn Toàn', N'0897661665', N'toan1234', N'1', N'Số 342, Đường Trần Nhân Tông, Tổ 9, Khối phố Hà Xuyên, Phường Mỹ Châu, Thành phố Huế', 0)

-- Add data T-Shirt
insert into PRODUCT values('TS01', N'Áo Thun Cổ Trụ Đơn Giản Y Nguyên Bản Ver46', N'Áo Thun Form Rộng', N'Trắng', '450000', '285000', 35, 35, 35, 35, N'Cotton Compact', N'100% Cotton', N'Made in Viet Nam')
insert into PRODUCT values('TS02', N'Áo Thun Cổ Trụ Đơn Giản Y Nguyên Bản Ver100', N'Áo Thun Form Tiêu Chuẩn', N'Trắng', '450000', '257000', 35, 35, 35, 35, N'Vải Cá Sấu Poly', N'95% polyester 5% spandex', N'Made in China')
insert into PRODUCT values('TS03', N'Áo Thun Cổ Tròn Đơn Giản Ngân Hà Space Ver14', N'Áo Thun Form Tiêu Chuẩn', N'Trắng', '450000', '199000', 35, 35, 35, 35, N'Cotton Compact 2C', N'100% Cotton', N'Made in China')
insert into PRODUCT values('TS04', N'Áo Thun Cổ Tròn Đơn Giản Y Nguyên Bản Ver90', N'Áo Thun Form Rộng', N'Xanh Ve Chai', '450000', '227000', 35, 35, 35, 35, N'Cotton Compact 2C', N'100% Cotton', N'Made in Thailand')
insert into PRODUCT values('TS05', N'Áo Thun Cổ Tròn Đơn Giản Y Nguyên Bản Ver129', N'Áo Thun Form Tiêu Chuẩn', N'Trắng', '450000', '227000', 35, 35, 35, 35, N'Cotton Plus', N'80% Cotton 20% Polyester', N'Made in India')
insert into PRODUCT values('TS06', N'Áo Thun Cổ Tròn Đơn Giản Ngân Hà Space Ver14', N'Áo Thun Form Tiêu Chuẩn', N'Đen', '450000', '199000', 35, 35, 35, 35, N'Cotton Compact', N'100% Cotton', N'Made in Viet Nam')
insert into PRODUCT values('TS07', N'Áo Thun Cổ Tròn Đơn Giản Linh Vật Rồng Ver23', N'Áo Thun Form Tiêu Chuẩn', N'Đen', '450000', '227000', 32, 34, 21, 45, N'Cotton Compact 2C', N'100% Cotton', N'Made in Viet Nam')
insert into PRODUCT values('TS08', N'Áo Thun Sweater Đơn Giản M34', N'Áo Thun Form Rộng', N'Xanh biển', '450000', '285000', 32, 34, 21, 45, N'Poly', N'100% Poly', N'Made in China')
insert into PRODUCT values('TS09', N'Áo Thun Cổ Tròn Đơn Giản Y Nguyên Bản Ver121', N'Áo Thun Form Tiêu Chuẩn', N'Trắng', '197000', '157600', 34, 32, 20, 27, N'Cotton Plus', N'80% Cotton 20% Polyester', N'Made in China')
insert into PRODUCT values('TS10', N'Áo Thun Cổ Tròn Đơn Giản Y Nguyên Bản Ver122', N'Áo Thun Form Tiêu Chuẩn', N'Trắng', '440000', '227000', 30, 30, 25, 27, N'Cotton Plus', N'80% Cotton 20% Polyester', N'Made in China')
insert into PRODUCT values('TS11', N'Áo Thun Cổ Tròn Đơn Giản Y Nguyên Bản Ver117', N'Áo Thun Form Tiêu Chuẩn', N'Đỏ', '440000', '227000', 35, 33, 22, 21, N'Poly Plus', N'97% Polyesster 3%', N'Made in Viet Nam')
insert into PRODUCT values('TS12', N'Áo Thun Cổ Tròn Đơn Giản Y Nguyên Bản Ver90', N'Áo Thun Form Rộng', N'Hồng Nhạt', '440000', '227000', 30, 30, 25, 27, N'Cotton Compact 2C', N'100% Cotton', N'Made in China')

-- Add data Coats
insert into PRODUCT values('CO01', N'Áo Khoác Lá Cổ Đơn Giản M17', N'Áo khoác Form Rộng', N'Đen', '850000', '347900', 35, 35, 35, 35, N'Kaki', N'100% Cotton', N'Made in Viet Nam')
insert into PRODUCT values('CO02', N'Áo Khoác Hoodie Zipper Đơn Giản Y Nguyên Bản Ver64', N'Áo khoác Form Rộng', N'Đen', '850000', '557000', 35, 35, 35, 35, N'French Terry', N'100% Cotton', N'Made in Viet Nam')
insert into PRODUCT values('CO03', N'Áo Khoác Hoodie Zipper Đơn Giản Y Nguyên Bản Ver64', N'Áo khoác Form Rộng', N'Trắng', '850000', '557000', 35, 35, 35, 35, N'French Terry', N'100% Cotton', N'Made in Viet Nam')
insert into PRODUCT values('CO04', N'Áo Khoác Hoodie Zipper Đơn Giản Y Nguyên Bản Ver64', N'Áo khoác Form Rộng', N'Xanh ve chai', '850000', '557000', 35, 35, 35, 35, N'French Terry', N'100% Cotton', N'Made in Viet Nam')
insert into PRODUCT values('CO05', N'Áo Khoác Hoodie Zipper Đơn Giản Y Nguyên Bản Ver64', N'Áo khoác Form Rộng', N'Hồng nhạt', '850000', '557000', 35, 35, 35, 35, N'French Terry', N'100% Cotton', N'Made in Viet Nam')
insert into PRODUCT values('CO06', N'Áo Khoác Hoodie Zipper Đơn Giản Y Nguyên Bản Ver64', N'Áo khoác Form Rộng', N'Xanh biển', '850000', '557000', 35, 35, 35, 35, N'French Terry', N'100% Cotton', N'Made in Viet Nam')
insert into PRODUCT values('CO07', N'Áo Khoác Hoodie Zipper Đơn Giản Y Nguyên Bản Ver64', N'Áo khoác Form Rộng', N'Nâu Cafe', '850000', '557000', 35, 35, 35, 35, N'French Terry', N'100% Cotton', N'Made in Viet Nam')
insert into PRODUCT values('CO08', N'Áo Khoác Hoodie Zipper Đơn Giản Y Nguyên Bản Ver64', N'Áo khoác Form Rộng', N'Xám chì', '850000', '557000', 35, 35, 35, 35, N'French Terry', N'100% Cotton', N'Made in Viet Nam')
insert into PRODUCT values('CO09', N'Áo Khoác Cardigan Đơn Giản Thần Cổ Đại Valknut Ver5', N'Áo khoác Form Rộng', N'Be', '850000', '497000', 35, 35, 35, 35, N'French Terry', N'100% Cotton', N'Made in Thailand')
insert into PRODUCT values('CO10', N'Áo Khoác Cardigan Đơn Giản Ngân Hà Space Ver10', N'Áo khoác Form Rộng', N'Đen', '850000', '497000', 35, 35, 35, 35, N'French Terry', N'100% Cotton', N'Made in China')
insert into PRODUCT values('CO11', N'Áo Khoác Lá Cổ Đơn Giản 12VAHDT Thiên Đô Ver3', N'Áo khoác Form Rộng', N'Đen Trắng', '850000', '457000', 35, 35, 35, 35, N'Poly', N'100% Polyester', N'Made in China')
insert into PRODUCT values('CO12', N'Áo Khoác Hoodie Zipper Đơn Giản Y Nguyên Bản Ver44', N'Áo khoác Form Rộng', N'Xám', '850000', '597000', 35, 35, 35, 35, N'French Terry', N'100% cotton', N'Made in China')
insert into PRODUCT values('CO13', N'Áo Khoác Hoodie Zipper Đơn Giản Y Nguyên Bản Ver44', N'Áo khoác Form Rộng', N'Nâu', '850000', '417900', 35, 35, 35, 35, N'French Terry', N'100% cotton', N'Made in China')
insert into PRODUCT values('CO14', N'Áo Khoác Cardigan Đơn Giản Y Nguyên Bản Ver70', N'Áo khoác Form Rộng', N'Đen', '850000', '387000', 35, 35, 35, 35, N'COTTON DOUBLE FACE', N'87% Cotton 13% Polyester', N'Made in Viet Nam')
insert into PRODUCT values('CO15', N'Áo Khoác Cardigan Đơn Giản Y Nguyên Bản Ver46', N'Áo khoác Form Rộng', N'Xám', '850000', '387000', 35, 35, 35, 35, N'COTTON DOUBLE FACE', N'87% Cotton 13% Polyester', N'Made in Viet Nam')
insert into PRODUCT values('CO16', N'Áo Khoác Cardigan Đơn Giản Y Nguyên Bản Ver46', N'Áo khoác Form Rộng', N'Kem', '850000', '387000', 35, 35, 35, 35, N'COTTON DOUBLE FACE', N'87% Cotton 13% Polyester', N'Made in Viet Nam')
insert into PRODUCT values('CO17', N'Áo Khoác Hoodie Đơn Giản Y Nguyên Bản Ver19', N'Áo khoác Form Rộng', N'Xanh Đậu', '850000', '385000', 35, 35, 35, 35, N'French Terry', N'100% Cotton', N'Made in Viet Nam')
insert into PRODUCT values('CO18', N'Áo Khoác Hoodie Đơn Giản Y Nguyên Bản Ver26', N'Áo khoác Form Rộng', N'Vàng Nghệ', '850000', '417900', 35, 35, 35, 35, N'French Terry', N'100% Cotton', N'Made in Viet Nam')
insert into PRODUCT values('CO19', N'Áo Khoác Varsity Đơn Giản Y Nguyên Bản Ver45', N'Áo khoác Form Rộng', N'Xám', '850000', '597000', 35, 35, 35, 35, N'Kaki Nhung', N'100% Polyester', N'Made in Viet Nam')
insert into PRODUCT values('CO20', N'Áo Khoác Varsity Đơn Giản Y Nguyên Bản Ver45', N'Áo khoác Form Rộng', N'Xanh Đen', '850000', '597000', 35, 35, 35, 35, N'Kaki Nhung', N'100% Polyester', N'Made in Viet Nam')
insert into PRODUCT values('CO21', N'Áo Khoác Varsity Đơn Giản Y Nguyên Bản Ver45', N'Áo khoác Form Rộng', N'Nâu', '850000', '597000', 35, 35, 35, 35, N'Kaki Nhung', N'100% Polyester', N'Made in Viet Nam')

-- Add data Shirt
insert into PRODUCT values('SI01', N'Áo Sơ Mi Tay Ngắn Đơn Giản Y Nguyên Bản Ver54', N'Sơ Mi Form Rộng', N'Đen', '327000', '261600', 30, 31, 28, 26, N'Vải SORONA AGILE', N'100% Polyester', N'Made in Thailand')
insert into PRODUCT values('SI02', N'Áo Sơ Mi Tay Ngắn Đơn Giản Y Nguyên Bản Ver54', N'Sơ Mi Form Rộng', N'Xám', '327000', '261600', 31, 35, 22, 19, N'Vải SORONA AGILE', N'100% Polyester', N'Made in Thailand')
insert into PRODUCT values('SI03', N'Áo Sơ Mi Tay Ngắn Đơn Giản Y Nguyên Bản Ver54', N'Sơ Mi Form Rộng', N'Nâu', '327000', '261600', 30, 31, 22, 32, N'Vải SORONA AGILE', N'100% Polyester', N'Made in Thailand')
insert into PRODUCT values('SI04', N'Áo Sơ Mi Tay Ngắn Đơn Giản Y Nguyên Bản Ver54', N'Sơ Mi Form Rộng', N'Trắng', '327000', '261600', 23, 33, 22, 12, N'Vải SORONA AGILE', N'100% Polyester', N'Made in Thailand')
insert into PRODUCT values('SI05', N'Áo Sơ Mi Tay Dài Đơn Giản Y Nguyên Bản Ver32', N'Sơ Mi Form Rộng', N'Lam Vàng', '600000', '457000', 21, 33, 12, 22, N'Vải Caro', N'70% Polyester 30% Rayon', N'Made in Viet Nam')
insert into PRODUCT values('SI06', N'Áo Sơ Mi Tay Dài Đơn Giản Y Nguyên Bản Ver33', N'Sơ Mi Form Rộng', N'Xám Nhạt', '600000', '457000', 35, 33, 22, 22, N'Vải Caro', N'70% Polyester 30% Rayon', N'Made in Viet Nam')
insert into PRODUCT values('SI07', N'Áo Sơ Mi Tay Dài Đơn Giản Y Nguyên Bản Ver33', N'Sơ Mi Form Rộng', N'Xanh Đen', '600000', '457000', 35, 33, 22, 22, N'Vải Caro', N'70% Polyester 30% Rayon', N'Made in Viet Nam')
insert into PRODUCT values('SI08', N'Áo Sơ Mi Tay Dài Đơn Giản Y Nguyên Bản Ver33', N'Sơ Mi Form Rộng', N'Xám Đậm', '600000', '457000', 32, 31, 20, 24, N'Vải Caro', N'70% Polyester 30% Rayon', N'Made in Viet Nam')
insert into PRODUCT values('SI09', N'Áo Sơ Mi Tay Ngắn Đơn Giản Y Nguyên Bản Ver29', N'Sơ Mi Form Rộng', N'Trắng', '355000', '257000', 30, 31, 21, 22, N'Vải Linen Gân', N'49% Rayon 17% Nylon 34%', N'Made in Viet Nam')
insert into PRODUCT values('SI10', N'Áo Sơ Mi Tay Ngắn Đơn Giản Y Nguyên Bản Ver29', N'Sơ Mi Form Rộng', N'Đen', '355000', '257000', 30, 31, 21, 22, N'Vải Linen Gân', N'49% Rayon 17% Nylon 34%', N'Made in Viet Nam')
insert into PRODUCT values('SI11', N'Áo Sơ Mi Tay Ngắn Đơn Giản Y Nguyên Bản Ver29', N'Sơ Mi Form Rộng', N'Xám', '355000', '257000', 30, 31, 21, 22, N'Vải Linen Gân', N'49% Rayon 17% Nylon 34%', N'Made in Viet Nam')
insert into PRODUCT values('SI12', N'Áo Sơ Mi Tay Ngắn Đơn Giản Y Nguyên Bản Ver27', N'Sơ Mi Form Rộng', N'Xanh Rêu', '355000', '257000', 30, 31, 21, 22, N'Nhung', N'100% Polyester', N'Made in Viet Nam')
insert into PRODUCT values('SI13', N'Áo Sơ Mi Tay Ngắn Đơn Giản Y Nguyên Bản Ver27', N'Sơ Mi Form Rộng', N'Xám Đậm', '355000', '257000', 30, 31, 21, 22, N'Nhung', N'100% Polyester', N'Made in Viet Nam')
insert into PRODUCT values('SI14', N'Áo Sơ Mi Tay Ngắn Đơn Giản Y Nguyên Bản Ver27', N'Sơ Mi Form Rộng', N'Nâu', '355000', '257000', 30, 31, 21, 22, N'Nhung', N'100% Polyester', N'Made in Viet Nam')


-- Add data Jean
insert into PRODUCT values('JE01', N'Quần Jean Slimfit Đơn Giản B35', N'Quần Dài Jean Form Slimfit', N'Xanh dương', '600000', '427000', 30, 31, 28, 26, N'Vải Jean', N'100% Cotton', N'Made in Vietnam')
insert into PRODUCT values('JE02', N'Quần Jean Slimfit Đơn Giản B43', N'Quần Dài Jean Form Slimfit', N'Xanh dương', '600000', '425000', 30, 31, 28, 26, N'Jean Cotton', N'100% Cotton', N'Made in Vietnam')
insert into PRODUCT values('JE03', N'Quần Jean Slimfit Đơn Giản B43', N'Quần Dài Jean Form Slimfit', N'Xanh trắng', '600000', '425000', 30, 31, 28, 26, N'Jean Cotton', N'100% Cotton', N'Made in Vietnam')
insert into PRODUCT values('JE04', N'Quần Dài Vải Đơn Giản Y Nguyên Bản Ver28', N'Quần Dài Form Tiêu Chuẩn', N'Xám', '525000', '397000', 30, 31, 28, 26, N'Vải Kaki T-SPUN', N'100% Polyester', N'Made in Vietnam')
insert into PRODUCT values('JE05', N'Quần Dài Vải Đơn Giản Y Nguyên Bản Ver28', N'Quần Dài Form Tiêu Chuẩn', N'Xanh Rêu', '525000', '397000', 30, 31, 28, 26, N'Vải Kaki T-SPUN', N'100% Polyester', N'Made in Vietnam')
insert into PRODUCT values('JE06', N'Quần Dài Vải Đơn Giản Y Nguyên Bản Ver28', N'Quần Dài Form Tiêu Chuẩn', N'Đen', '525000', '397000', 30, 31, 28, 26, N'Vải Kaki T-SPUN', N'100% Polyester', N'Made in Vietnam')
insert into PRODUCT values('JE07', N'Quần Dài Vải Đơn Giản Y Nguyên Bản Ver28', N'Quần Dài Form Tiêu Chuẩn', N'Nâu', '525000', '397000', 30, 31, 28, 26, N'Vải Kaki T-SPUN', N'100% Polyester', N'Made in Vietnam')
-- Add data Short
insert into PRODUCT values('SH01', N'Quần Short Đơn Giản Y Nguyên Bản Ver41', N'Quần Short Form Trên Gối', N'Đen', '500000', '327000', 40, 21, 18, 26, N'Vải Kaki T-SPUN', N'100% Polyester', N'Made in China')
insert into PRODUCT values('SH02', N'Quần Short Đơn Giản Y Nguyên Bản Ver41', N'Quần Short Form Trên Gối', N'Nâu', '500000', '327000', 35, 25, 25, 28, N'Vải Kaki T-SPUN', N'100% Polyester', N'Made in China')
insert into PRODUCT values('SH03', N'Quần Short Đơn Giản Y Nguyên Bản Ver41', N'Quần Short Form Trên Gối', N'Xanh rêu', '500000', '327000', 30, 31, 28, 26, N'Vải Kaki', N'100% Polyester', N'Made in Vietnam')
insert into PRODUCT values('SH04', N'Quần Short Đơn Giản Y Nguyên Bản Ver38', N'Quần Short Form Trên Gối', N'Trắng', '430000', '287000', 29, 30, 25, 27, N'COTTON DOUBLE FACE', N'87% Cotton 13% Polyester', N'Made in Vietnam')
insert into PRODUCT values('SH05', N'Quần Short Đơn Giản Y Nguyên Bản Ver38', N'Quần Short Form Trên Gối', N'Xanh Biển', '430000', '287000', 29, 30, 25, 27, N'COTTON DOUBLE FACE', N'87% Cotton 13% Polyester', N'Made in Vietnam')
insert into PRODUCT values('SH06', N'Quần Short Đơn Giản Y Nguyên Bản Ver38', N'Quần Short Form Trên Gối', N'Hồng Nhạt', '430000', '287000', 29, 30, 25, 27, N'COTTON DOUBLE FACE', N'87% Cotton 13% Polyester', N'Made in Vietnam')
insert into PRODUCT values('SH07', N'Quần Short Đơn Giản Y Nguyên Bản Ver38', N'Quần Short Form Trên Gối', N'Xám Chì', '430000', '287000', 29, 30, 25, 27, N'COTTON DOUBLE FACE', N'87% Cotton 13% Polyester', N'Made in Vietnam')
insert into PRODUCT values('SH08', N'Quần Short Đơn Giản Y Nguyên Bản Ver38', N'Quần Short Form Trên Gối', N'Xanh Ve Chai', '430000', '287000', 29, 30, 25, 27, N'COTTON DOUBLE FACE', N'87% Cotton 13% Polyester', N'Made in Vietnam')
insert into PRODUCT values('SH09', N'Quần Short Đơn Giản Y Nguyên Bản Ver38', N'Quần Short Form Trên Gối', N'Nâu Cafe', '430000', '287000', 29, 30, 25, 27, N'COTTON DOUBLE FACE', N'87% Cotton 13% Polyester', N'Made in Vietnam')

-- Add data Receipt
insert into RECEIPT values('RE00_01', '12-11-2022 12:24:35 PM', 'CU00', '500000')
insert into RECEIPT values('RE00_02', '19-11-2022 09:08:55 AM', 'CU00', '800000')
insert into RECEIPT values('RE00_03', '20-11-2022 06:14:44 PM', 'CU00', '900000')
insert into RECEIPT values('RE01_01', '11-11-2022 13:22:33 PM', 'CU01', '600000')
insert into RECEIPT values('RE01_02', '10-11-2022 05:35:44 PM', 'CU01', '700000')

-- Add data Receipt Details
insert into RECEIPT_DETAILS values('RE00_01', 'CO01', 'S', 4)
insert into RECEIPT_DETAILS values('RE00_01', 'CO05', 'XL', 1)
insert into RECEIPT_DETAILS values('RE00_02', 'CO06', 'M', 1)
insert into RECEIPT_DETAILS values('RE00_02', 'CO11', 'S', 2)
insert into RECEIPT_DETAILS values('RE00_02', 'CO02', 'L', 2)
insert into RECEIPT_DETAILS values('RE00_03', 'CO11', 'S', 3)
insert into RECEIPT_DETAILS values('RE00_03', 'CO18', 'S', 4)
insert into RECEIPT_DETAILS values('RE00_03', 'CO02', 'M', 4)
insert into RECEIPT_DETAILS values('RE01_01', 'CO03', 'L', 4)
insert into RECEIPT_DETAILS values('RE01_02', 'CO04', 'S', 5)
insert into RECEIPT_DETAILS values('RE01_02', 'CO06', 'XL', 1)
insert into RECEIPT_DETAILS values('RE01_02', 'CO15', 'L', 1)

-- Add data Comment
insert into COMMENT values(1, '12-11-2022 12:24:35 PM', 'TS01', 'CU00', N'Chất vải khá ok, màu đỉnh thật sự. ở ngoài màu tươi hơn ảnh á.', 0)
select * from COMMENT
select * from COMMENT inner join CUSTOMER on COMMENT.COMMENT_CUSTOMER = CUSTOMER.CUSTOMER_ID where COMMENT.COMMENT_PRODUCT = 'CO01'

--Add data Discount
insert into DISCOUNT values('DI01', '300000', 10)
insert into DISCOUNT values('DI02', '400000', 10)
insert into DISCOUNT values('DI03', '550000', 15)
insert into DISCOUNT values('DI04', '350000', 20)
insert into DISCOUNT values('DI05', '600000', 20)
insert into DISCOUNT values('DI06', '1000000', 30)

--
select [PRODUCT_ID],[PRODUCT_NAME],[PRODUCT_PRICE],[PRODUCT_COUNTRY] from PRODUCT where dbo.LanguageComprehension(PRODUCT_NAME) like N'%lá%' or PRODUCT_NAME like N'%lá%'
select * from PRODUCT where PRODUCT_ID like 'TS%'
--
select * from CUSTOMER 
where CUSTOMER.CUSTOMER_ACCOUNT = 'Admin' COLLATE SQL_Latin1_General_CP1_CS_AS
and CUSTOMER.CUSTOMER_PASSWORD = '1' COLLATE SQL_Latin1_General_CP1_CS_AS


--
select * from RECEIPT_DETAILS INNER JOIN PRODUCT on RECEIPT_DETAILS.RECEIPT_DETAILS_PRODUCT = PRODUCT.PRODUCT_ID
where RECEIPT_DETAILS_ID in
(
	select RECEIPT_ID from RECEIPT INNER JOIN CUSTOMER on RECEIPT.RECEIPT_CUSTOMER = CUSTOMER.CUSTOMER_ID where CUSTOMER.CUSTOMER_ID = 'CU00' and RECEIPT_DETAILS.RECEIPT_DETAILS_ID = 'RE00_03'
)
go

-- Select table
select * from CUSTOMER
go
select * from PRODUCT
go
select * from RECEIPT
go
select * from RECEIPT_DETAILS
go
select * from DISCOUNT
go

-- Drop table
drop table CUSTOMER
go
drop table PRODUCT
go
drop table RECEIPT
go
drop table RECEIPT_DETAILS
go
drop table DISCOUNT
go
drop table COMMENT
go

select [RECEIPT_ID] from RECEIPT where RECEIPT_ID like 'RE00%'

select * from RECEIPT_DETAILS where RECEIPT_DETAILS_ID = 'RE00_04'
go

select * from RECEIPT_DETAILS INNER JOIN PRODUCT on RECEIPT_DETAILS.RECEIPT_DETAILS_PRODUCT = PRODUCT.PRODUCT_ID
where RECEIPT_DETAILS.RECEIPT_DETAILS_ID = 'RE00_04'
go

update RECEIPT_DETAILS 
set RECEIPT_DETAILS_QUATITY = RECEIPT_DETAILS_QUATITY + 3 
where RECEIPT_DETAILS_ID = 'RE00_04' and RECEIPT_DETAILS_PRODUCT = 'CO06' and RECEIPT_DETAILS_SIZE = 'L'
go

update COMMENT

select * from RECEIPT
delete from RECEIPT_DETAILS where RECEIPT_DETAILS_ID = 'RE00_04' and RECEIPT_DETAILS_PRODUCT = 'TS03' and RECEIPT_DETAILS_SIZE = 'L'

update RECEIPT_DETAILS set RECEIPT_DETAILS_QUATITY = RECEIPT_DETAILS_QUATITY - 1 where RECEIPT_DETAILS_ID = 'RE00_04' and RECEIPT_DETAILS_PRODUCT = 'TS03' and RECEIPT_DETAILS_SIZE = 'S'

select sum(RECEIPT_DETAILS_QUATITY * PRODUCT_PRICE) from RECEIPT_DETAILS INNER JOIN PRODUCT on RECEIPT_DETAILS.RECEIPT_DETAILS_PRODUCT = PRODUCT.PRODUCT_ID where RECEIPT_DETAILS.RECEIPT_DETAILS_ID = 'RE00_04'

select * from RECEIPT_DETAILS INNER JOIN PRODUCT on RECEIPT_DETAILS.RECEIPT_DETAILS_PRODUCT = PRODUCT.PRODUCT_ID where RECEIPT_DETAILS.RECEIPT_DETAILS_ID = 'RE00_01'

insert into RECEIPT values('RE01_02', '10-11-2022 05:35:44 PM', 'CU01', '700000')

delete from RECEIPT_DETAILS where RECEIPT_DETAILS_QUATITY != 0 and RECEIPT_DETAILS_ID = 'RE00_01'
select * from PRODUCT
go
select * from RECEIPT_DETAILS
go

select * from RECEIPT

update CUSTOMER  set CUSTOMER_NAME = 'A', CUSTOMER_PHONE_NUMBER = '0796616454', CUSTOMER_ADDRESS = '325, đường Võ Thị Sáu, tổ Yên Định, khối Yên Sơn, phường Yên Bình, tỉnh Lai Châu' where CUSTOMER_ID = 'CU05'

select * from CUSTOMER


select * from RECEIPT where RECEIPT_ID = 'RE00_01' 