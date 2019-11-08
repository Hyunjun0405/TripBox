USE MASTER
GO

USE TRIPBOX
GO

DROP TABLE [BookingField]
GO

CREATE TABLE [BookingField]
(
    [idProduct]    FKID NOT NULL,
    [idField]    FKID NOT NULL,
    [isRequired]    bit,
    [isMandatory]    bit
)
GO

ALTER TABLE [BookingField]
 ADD CONSTRAINT [PK_BookingField] PRIMARY KEY ( [idProduct],[idField] )
GO


DROP TABLE [Campaign]
GO

CREATE TABLE [Campaign]
(
    [id]    ID IDENTITY(1, 1) NOT NULL,
    [dateOrderStart]    date,
    [dateOrderEnd]    date,
    [dateSessionStart]    date,
    [dateSessionEnd]    date,
    [typeCampaign]    CD,
    [rate]    RATE
)
GO

ALTER TABLE [Campaign]
 ADD CONSTRAINT [PK_Campaign] PRIMARY KEY ( [id] )
GO


DROP TABLE [CampaignProduct]
GO

CREATE TABLE [CampaignProduct]
(
    [id]    ID IDENTITY(1, 1) NOT NULL,
    [idPromotion]    FKID NOT NULL,
    [idCategory]    FKID NOT NULL,
    [idProduct]    FKID NOT NULL,
    [typePriceOption]    CD,
    [listSession]    JSON
)
GO

ALTER TABLE [CampaignProduct]
 ADD CONSTRAINT [PK_CampaignProduct] PRIMARY KEY ( [id] )
GO


DROP TABLE [Category]
GO

CREATE TABLE [Category]
(
    [id]    ID IDENTITY(1, 1) NOT NULL,
    [idSupplier]    FKID,
    [name]    varchar(100),
    [description]    varchar(1000),
    [isVisible]    bit
)
GO

ALTER TABLE [Category]
 ADD CONSTRAINT [PK_Category] PRIMARY KEY ( [id] )
GO


DROP TABLE [CategorySeoTag]
GO

CREATE TABLE [CategorySeoTag]
(
    [idCategory]    FKID NOT NULL,
    [idSeoTag]    FKID NOT NULL
)
GO

ALTER TABLE [CategorySeoTag]
 ADD CONSTRAINT [PK_CategorySeoTag] PRIMARY KEY ( [idCategory],[idSeoTag] )
GO


DROP TABLE [City]
GO

CREATE TABLE [City]
(
    [id]    ID IDENTITY(1, 1) NOT NULL,
    [continent]    varchar(100),
    [country]    varchar(100),
    [state]    varchar(100),
    [name]    varchar(100),
    [nameEN]    varchar(100)
)
GO

ALTER TABLE [City]
 ADD CONSTRAINT [PK_City] PRIMARY KEY ( [id] )
GO


DROP TABLE [Expense]
GO

CREATE TABLE [Expense]
(
    [id]    ID IDENTITY(1, 1) NOT NULL,
    [idSupplier]    FKID,
    [dateExpense]    date,
    [idPartyTo]    FKID,
    [totalExpense]    AMOUNT,
    [note]    varchar(1000)
)
GO

ALTER TABLE [Expense]
 ADD CONSTRAINT [PK_Expense] PRIMARY KEY ( [id] )
GO


DROP TABLE [ExpenseItem]
GO

CREATE TABLE [ExpenseItem]
(
    [id]    ID IDENTITY(1, 1) NOT NULL,
    [idExpense]    FKID NOT NULL,
    [idSession]    FKID NOT NULL,
    [typeExpense]    CD,
    [cost]    PRICE,
    [quantity]    smallint
)
GO

ALTER TABLE [ExpenseItem]
 ADD CONSTRAINT [PK_ExpenseItem] PRIMARY KEY ( [id] )
GO


DROP TABLE [Extra]
GO

CREATE TABLE [Extra]
(
    [id]    ID IDENTITY(1, 1) NOT NULL,
    [idSupplier]    FKID,
    [name]    varchar(100),
    [idImage]    FKID NOT NULL,
    [description]    varchar(1000),
    [typePriceExtra]    CD,
    [price]    PRICE,
    [isLimit]    bit,
    [limitMax]    smallint
)
GO

ALTER TABLE [Extra]
 ADD CONSTRAINT [PK_Extra] PRIMARY KEY ( [id] )
GO


DROP TABLE [Field]
GO

CREATE TABLE [Field]
(
    [id]    ID IDENTITY(1, 1) NOT NULL,
    [fieldType]    CD NOT NULL,
    [idSupplier]    FKID,
    [name]    varchar NOT NULL,
    [dataType]    CD,
    [listValues]    varchar(2000)
)
GO

ALTER TABLE [Field]
 ADD CONSTRAINT [PK_Field] PRIMARY KEY ( [id] )
GO


DROP TABLE [Image]
GO

CREATE TABLE [Image]
(
    [id]    ID IDENTITY(1, 1) NOT NULL,
    [urlImageFull]    varchar(200),
    [urlImageLarge]    varchar(200),
    [urlImageMedium]    varchar(200),
    [urlImageSmall]    varchar(200)
)
GO

ALTER TABLE [Image]
 ADD CONSTRAINT [PK_Image] PRIMARY KEY ( [id] )
GO


DROP TABLE [Invoice]
GO

CREATE TABLE [Invoice]
(
    [id]    ID IDENTITY(1, 1) NOT NULL,
    [idSupplier]    FKID,
    [dateFrom]    date,
    [dateTo]    date,
    [totalInvoice]    AMOUNT
)
GO

ALTER TABLE [Invoice]
 ADD CONSTRAINT [PK_Invoice] PRIMARY KEY ( [id] )
GO


DROP TABLE [InvoiceItem]
GO

CREATE TABLE [InvoiceItem]
(
    [id]    ID IDENTITY(1, 1) NOT NULL,
    [idInvoice]    FKID NOT NULL,
    [idOrderItem]    FKID NOT NULL,
    [idSession]    FKID NOT NULL,
    [cost]    PRICE,
    [quantity]    smallint
)
GO

ALTER TABLE [InvoiceItem]
 ADD CONSTRAINT [PK_InvoiceItem] PRIMARY KEY ( [id] )
GO


DROP TABLE [Itinerary]
GO

CREATE TABLE [Itinerary]
(
    [idProduct]    FKID NOT NULL,
    [typePart]    CD NOT NULL,
    [time]    varchar(100) NOT NULL,
    [listCity]    JSON,
    [listSpot]    JSON,
    [note]    varchar(1000)
)
GO

ALTER TABLE [Itinerary]
 ADD CONSTRAINT [PK_Itinerary] PRIMARY KEY ( [idProduct],[typePart],[time] )
GO


DROP TABLE [Order]
GO

CREATE TABLE [Order]
(
    [id]    ID IDENTITY(1, 1) NOT NULL,
    [datetimeCreated]    datetime,
    [datetimeConfirmed]    datetime,
    [datetimePaid]    datetime,
    [datetimeUpdated]    datetime,
    [idCampaign]    FKID NOT NULL,
    [totalAmount]    AMOUNT,
    [amountDue]    AMOUNT,
    [amountPaid]    AMOUNT,
    [surcharge]    AMOUNT,
    [currency]    CD,
    [isSendNofication]    bit,
    [listTypePayment]    JSON,
    [typeSource]    CD,
    [channelSource]    CD,
    [refererSource]    CD,
    [commentCustomer]    varchar(2000),
    [commentReseller]    varchar(2000),
    [commentSupplier]    varchar(2000)
)
GO

ALTER TABLE [Order]
 ADD CONSTRAINT [PK_Order] PRIMARY KEY ( [id] )
GO


DROP TABLE [OrderField]
GO

CREATE TABLE [OrderField]
(
    [id]    ID IDENTITY(1, 1) NOT NULL,
    [idOrder]    FKID,
    [idField]    FKID NOT NULL,
    [value]    varchar(1000)
)
GO

ALTER TABLE [OrderField]
 ADD CONSTRAINT [PK_OrderField] PRIMARY KEY ( [id] )
GO


DROP TABLE [OrderItem]
GO

CREATE TABLE [OrderItem]
(
    [id]    ID IDENTITY(1, 1) NOT NULL,
    [idOrder]    FKID NOT NULL,
    [idProduct]    FKID NOT NULL,
    [idSesstion]    FKID NOT NULL,
    [datetimeStart]    datetime,
    [datetimeEnd]    datetime,
    [amount]    AMOUNT,
    [subTotal]    PRICE,
    [totalProduct]    PRICE,
    [totalExtra]    PRICE,
    [totalQuantityUse]    smallint,
    [idPickupSpot]    FKID NOT NULL,
    [timePickup]    time,
    [isRoundTrip]    bit,
    [idTransferFrom]    FKID,
    [idTransferTo]    FKID,
    [isCheckin]    bit,
    [isConfirm]    bit
)
GO

ALTER TABLE [OrderItem]
 ADD CONSTRAINT [PK_OrderItem] PRIMARY KEY ( [id] )
GO


DROP TABLE [OrderItemExtra]
GO

CREATE TABLE [OrderItemExtra]
(
    [id]    ID IDENTITY(1, 1) NOT NULL,
    [idOrderItem]    FKID NOT NULL,
    [idExtra]    FKID NOT NULL,
    [price]    PRICE,
    [quantity]    smallint
)
GO

ALTER TABLE [OrderItemExtra]
 ADD CONSTRAINT [PK_OrderItemExtra] PRIMARY KEY ( [id] )
GO


DROP TABLE [OrderItemField]
GO

CREATE TABLE [OrderItemField]
(
    [id]    ID IDENTITY(1, 1) NOT NULL,
    [idOrderItem]    FKID NOT NULL,
    [idField]    FKID NOT NULL,
    [value]    varchar(1000)
)
GO

ALTER TABLE [OrderItemField]
 ADD CONSTRAINT [PK_OrderItemField] PRIMARY KEY ( [id] )
GO


DROP TABLE [OrderItemProduct]
GO

CREATE TABLE [OrderItemProduct]
(
    [id]    ID NOT NULL,
    [idOrderItem]    FKID NOT NULL,
    [idPrice]    FKID NOT NULL,
    [price]    PRICE,
    [cost]    COST,
    [quantity]    smallint,
    [quantityUse]    smallint
)
GO

ALTER TABLE [OrderItemProduct]
 ADD CONSTRAINT [PK_OrderItemProduct] PRIMARY KEY ( [id] )
GO


DROP TABLE [OrderRole]
GO

CREATE TABLE [OrderRole]
(
    [id]    ID IDENTITY(1, 1) NOT NULL,
    [idOrder]    FKID NOT NULL,
    [idParty]    FKID,
    [typeRole]    CD NOT NULL
)
GO

ALTER TABLE [OrderRole]
 ADD CONSTRAINT [PK_OrderRole] PRIMARY KEY ( [id] )
GO


DROP TABLE [Party]
GO

CREATE TABLE [Party]
(
    [id]    ID IDENTITY(1, 1) NOT NULL,
    [typeParty]    CD,
    [alias]    varchar(100),
    [name]    varchar(100),
    [nameFirst]    varchar(100),
    [nameLast]    varchar(100),
    [gender]    CD,
    [title]    CD,
    [dateBirth]    date
)
GO

ALTER TABLE [Party]
 ADD CONSTRAINT [PK_Party] PRIMARY KEY ( [id] )
GO


DROP TABLE [Payment]
GO

CREATE TABLE [Payment]
(
    [id]    ID IDENTITY(1, 1) NOT NULL,
    [typePayment]    CD,
    [typeReceipt]    CD,
    [datePayment]    date,
    [amount]    AMOUNT,
    [note]    varchar(200)
)
GO

ALTER TABLE [Payment]
 ADD CONSTRAINT [PK_Payment] PRIMARY KEY ( [id] )
GO


DROP TABLE [PaymentOrder]
GO

CREATE TABLE [PaymentOrder]
(
    [id]    ID IDENTITY(1, 1) NOT NULL,
    [idPayment]    FKID NOT NULL,
    [idOrder]    FKID NOT NULL,
    [amount]    AMOUNT
)
GO

ALTER TABLE [PaymentOrder]
 ADD CONSTRAINT [PK_PaymentOrder] PRIMARY KEY ( [id] )
GO


DROP TABLE [Pickup]
GO

CREATE TABLE [Pickup]
(
    [id]    ID IDENTITY(1, 1) NOT NULL,
    [idSupplier]    FKID NOT NULL,
    [name]    varchar(100),
    [instruction]    varchar(2000)
)
GO

ALTER TABLE [Pickup]
 ADD CONSTRAINT [PK_Pickup] PRIMARY KEY ( [id] )
GO


DROP TABLE [PickupSpot]
GO

CREATE TABLE [PickupSpot]
(
    [id]    ID IDENTITY(1, 1) NOT NULL,
    [idPickup]    FKID NOT NULL,
    [idSpot]    FKID NOT NULL,
    [name]    varchar(100) NOT NULL,
    [minutePrior]    smallint,
    [addInstruction]    varchar(2000)
)
GO

ALTER TABLE [PickupSpot]
 ADD CONSTRAINT [PK_PickupSpot] PRIMARY KEY ( [id] )
GO


DROP TABLE [Price]
GO

CREATE TABLE [Price]
(
    [id]    ID IDENTITY(1, 1) NOT NULL,
    [idProduct]    FKID NOT NULL,
    [typePriceOption]    CD NOT NULL,
    [idSession]    FKID,
    [price]    PRICE,
    [cost]    PRICE,
    [seatMax]    smallint
)
GO

ALTER TABLE [Price]
 ADD CONSTRAINT [PK_Price] PRIMARY KEY ( [id] )
GO


DROP TABLE [PriceOption]
GO

CREATE TABLE [PriceOption]
(
    [idProduct]    FKID NOT NULL,
    [typePriceOption]    CD NOT NULL,
    [price]    PRICE,
    [cost]    COST,
    [quantityUse]    smallint,
    [note]    varchar(1000)
)
GO

ALTER TABLE [PriceOption]
 ADD CONSTRAINT [PK_PriceOption] PRIMARY KEY ( [idProduct],[typePriceOption] )
GO


DROP TABLE [Product]
GO

CREATE TABLE [Product]
(
    [id]    ID IDENTITY(1, 1) NOT NULL,
    [idSupplier]    FKID,
    [typeProduct]    CD,
    [typePart]    CD,
    [name]    varchar(100),
    [code]    varchar(20),
    [priceAdvertise]    PRICE,
    [quantityMin]    smallint,
    [quantityMax]    smallint,
    [quantityLabel]    varchar(10),
    [quantityLabelPlural]    varchar(10),
    [descriptionShort]    varchar(1000),
    [descriptionLong]    varchar(4000),
    [isPaymentSpecial]    bit,
    [typeDepoist]    CD,
    [valueDeposit]    RATE,
    [isPaymentFull]    bit,
    [isPaymentNotice]    bit,
    [dayPaymentNotice]    smallint,
    [isSpecialRule]    bit,
    [valueSpecialRule]    varchar(4000),
    [typeSession]    CD,
    [timeList]    varchar(1000),
    [typeAvail]    CD,
    [isAllowWaiting]    bit,
    [isShowSeat]    bit,
    [typeConfirm]    CD,
    [quantityAfter]    smallint,
    [timeMiniumNotice]    smallint,
    [timeTypeMiniumNotice]    CD,
    [timeDuration]    smallint,
    [timeTypeDuration]    CD,
    [productColor]    varchar(10),
    [idSpot]    FKID,
    [idPickup]    FKID
)
GO

ALTER TABLE [Product]
 ADD CONSTRAINT [PK_Product] PRIMARY KEY ( [id] )
GO


DROP TABLE [ProductCategory]
GO

CREATE TABLE [ProductCategory]
(
    [idCategory]    FKID NOT NULL,
    [idProduct]    FKID NOT NULL
)
GO

ALTER TABLE [ProductCategory]
 ADD CONSTRAINT [PK_ProductCategory] PRIMARY KEY ( [idCategory],[idProduct] )
GO


DROP TABLE [ProductExtra]
GO

CREATE TABLE [ProductExtra]
(
    [idProduct]    FKID NOT NULL,
    [idExtra]    FKID NOT NULL
)
GO

ALTER TABLE [ProductExtra]
 ADD CONSTRAINT [PK_ProductExtra] PRIMARY KEY ( [idProduct],[idExtra] )
GO


DROP TABLE [ProductField]
GO

CREATE TABLE [ProductField]
(
    [idProduct]    FKID NOT NULL,
    [idField]    FKID NOT NULL,
    [value]    varchar(4000)
)
GO

ALTER TABLE [ProductField]
 ADD CONSTRAINT [PK_ProductField] PRIMARY KEY ( [idProduct],[idField] )
GO


DROP TABLE [ProductImage]
GO

CREATE TABLE [ProductImage]
(
    [id]    ID IDENTITY(1, 1) NOT NULL,
    [idProduct]    FKID NOT NULL,
    [idImage]    FKID NOT NULL
)
GO

ALTER TABLE [ProductImage]
 ADD CONSTRAINT [PK_ProductImage] PRIMARY KEY ( [id] )
GO


DROP TABLE [ProductRelated]
GO

CREATE TABLE [ProductRelated]
(
    [idProduct1]    FKID NOT NULL,
    [idProduct2]    FKID NOT NULL
)
GO

ALTER TABLE [ProductRelated]
 ADD CONSTRAINT [PK_ProductRelated] PRIMARY KEY ( [idProduct1],[idProduct2] )
GO


DROP TABLE [ProductTag]
GO

CREATE TABLE [ProductTag]
(
    [idProduct]    FKID NOT NULL,
    [typeTag]    CD NOT NULL,
    [tag]    CD NOT NULL
)
GO

ALTER TABLE [ProductTag]
 ADD CONSTRAINT [PK_ProductTag] PRIMARY KEY ( [idProduct],[typeTag],[tag] )
GO


DROP TABLE [ProductVideo]
GO

CREATE TABLE [ProductVideo]
(
    [id]    ID IDENTITY(1, 1) NOT NULL,
    [idProduct]    FKID NOT NULL,
    [idVideo]    FKID NOT NULL
)
GO

ALTER TABLE [ProductVideo]
 ADD CONSTRAINT [PK_ProductVideo] PRIMARY KEY ( [id] )
GO


DROP TABLE [SeoTag]
GO

CREATE TABLE [SeoTag]
(
    [id]    ID IDENTITY(1, 1) NOT NULL,
    [metaType]    CD,
    [valueAttribute]    varchar(100),
    [keyAttribute]    varchar(100)
)
GO

ALTER TABLE [SeoTag]
 ADD CONSTRAINT [PK_SeoTag] PRIMARY KEY ( [id] )
GO


DROP TABLE [Session]
GO

CREATE TABLE [Session]
(
    [id]    ID IDENTITY(1, 1) NOT NULL,
    [idTemplate]    FKID NOT NULL,
    [idProduct]    FKID NOT NULL,
    [datetimeStart]    datetime,
    [isAllday]    bit,
    [datetimeEnd]    datetime,
    [seatMax]    smallint,
    [seatOrdered]    smallint
)
GO

ALTER TABLE [Session]
 ADD CONSTRAINT [PK_Session] PRIMARY KEY ( [id] )
GO


DROP TABLE [SessionOrdered]
GO

CREATE TABLE [SessionOrdered]
(
    [idSession]    FKID NOT NULL,
    [idProduct]    FKID,
    [datetimeStart]    datetime,
    [datetimeEnd]    datetime,
    [totalProfit]    AMOUNT,
    [totalInvoice]    AMOUNT,
    [totalExpense]    AMOUNT,
    [totalQuantityUse]    smallint
)
GO

ALTER TABLE [SessionOrdered]
 ADD CONSTRAINT [PK_SessionOrdered] PRIMARY KEY ( [idSession] )
GO


DROP TABLE [SessionRole]
GO

CREATE TABLE [SessionRole]
(
    [id]    ID IDENTITY(1, 1) NOT NULL,
    [idSession]    FKID NOT NULL,
    [idParty]    FKID NOT NULL,
    [typeRole]    CD NOT NULL
)
GO

ALTER TABLE [SessionRole]
 ADD CONSTRAINT [PK_SessionRole] PRIMARY KEY ( [id] )
GO


DROP TABLE [SessionTemplate]
GO

CREATE TABLE [SessionTemplate]
(
    [id]    ID IDENTITY(1, 1) NOT NULL,
    [idProduct]    FKID NOT NULL,
    [minuteDuration]    smallint,
    [dateStart]    date,
    [timeStart]    datetime,
    [timeEnd]    datetime,
    [dateUntil]    date,
    [datetypeRepeat]    CD,
    [valueRepeat]    smallint
)
GO

ALTER TABLE [SessionTemplate]
 ADD CONSTRAINT [PK_SessionTemplate] PRIMARY KEY ( [id] )
GO


DROP TABLE [SessionTemplateWeek]
GO

CREATE TABLE [SessionTemplateWeek]
(
    [idTemplate]    FKID NOT NULL,
    [weekday]    smallint NOT NULL,
    [timeStart]    time,
    [timeEnd]    time
)
GO

ALTER TABLE [SessionTemplateWeek]
 ADD CONSTRAINT [PK_SessionTemplateWeek] PRIMARY KEY ( [idTemplate],[weekday] )
GO


DROP TABLE [Spot]
GO

CREATE TABLE [Spot]
(
    [id]    ID IDENTITY(1, 1) NOT NULL,
    [name]    varchar(100),
    [typeSpot]    CD,
    [idCity]    FKID NOT NULL,
    [postcode]    varchar(10),
    [address1]    varchar(100),
    [address2]    varchar(100),
    [latitude]    varchar(20),
    [longitude]    varchar(20)
)
GO

ALTER TABLE [Spot]
 ADD CONSTRAINT [PK_Spot] PRIMARY KEY ( [id] )
GO


DROP TABLE [TagSpot]
GO

CREATE TABLE [TagSpot]
(
    [idSpot]    FKID NOT NULL,
    [typeTag]    CD NOT NULL,
    [tag]    varchar(20) NOT NULL
)
GO

ALTER TABLE [TagSpot]
 ADD CONSTRAINT [PK_TagSpot] PRIMARY KEY ( [tag],[typeTag],[idSpot] )
GO


DROP TABLE [Video]
GO

CREATE TABLE [Video]
(
    [id]    ID IDENTITY(1, 1) NOT NULL,
    [typePlatform]    CD,
    [urlVideo]    varchar(200)
)
GO

ALTER TABLE [Video]
 ADD CONSTRAINT [PK_Video] PRIMARY KEY ( [id] )
GO 