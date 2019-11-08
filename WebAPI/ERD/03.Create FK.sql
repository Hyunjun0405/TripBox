USE MASTER
GO

USE TRIPBOX
GO


ALTER TABLE [BookingField]
DROP CONSTRAINT FK_BookingField_Field
GO

ALTER TABLE [BookingField]
 ADD CONSTRAINT [FK_BookingField_Field] FOREIGN KEY ( [idField] )
 REFERENCES [Field] ([id] )
GO

ALTER TABLE [BookingField]
DROP CONSTRAINT FK_BookingField_Product
GO

ALTER TABLE [BookingField]
 ADD CONSTRAINT [FK_BookingField_Product] FOREIGN KEY ( [idProduct] )
 REFERENCES [Product] ([id] )
GO



ALTER TABLE [CampaignProduct]
DROP CONSTRAINT FK_CampaignProduct_Promotion
GO

ALTER TABLE [CampaignProduct]
 ADD CONSTRAINT [FK_CampaignProduct_Promotion] FOREIGN KEY ( [idPromotion] )
 REFERENCES [Campaign] ([id] )
GO

ALTER TABLE [CampaignProduct]
DROP CONSTRAINT FK_CampaignProduct_Category
GO

ALTER TABLE [CampaignProduct]
 ADD CONSTRAINT [FK_CampaignProduct_Category] FOREIGN KEY ( [idCategory] )
 REFERENCES [Category] ([id] )
GO

ALTER TABLE [CampaignProduct]
DROP CONSTRAINT FK_CampaignProduct_Product
GO

ALTER TABLE [CampaignProduct]
 ADD CONSTRAINT [FK_CampaignProduct_Product] FOREIGN KEY ( [idProduct] )
 REFERENCES [Product] ([id] )
GO



ALTER TABLE [CategorySeoTag]
DROP CONSTRAINT FK_CategorySeoTag_Category
GO

ALTER TABLE [CategorySeoTag]
 ADD CONSTRAINT [FK_CategorySeoTag_Category] FOREIGN KEY ( [idCategory] )
 REFERENCES [Category] ([id] )
GO

ALTER TABLE [CategorySeoTag]
DROP CONSTRAINT FK_CategorySeoTag_SeoTag
GO

ALTER TABLE [CategorySeoTag]
 ADD CONSTRAINT [FK_CategorySeoTag_SeoTag] FOREIGN KEY ( [idSeoTag] )
 REFERENCES [SeoTag] ([id] )
GO



ALTER TABLE [ExpenseItem]
DROP CONSTRAINT UK_ExpenseItem
GO

ALTER TABLE [ExpenseItem]
 ADD CONSTRAINT [UK_ExpenseItem] UNIQUE ( [idExpense],[idSession],[typeExpense] )
GO

ALTER TABLE [ExpenseItem]
DROP CONSTRAINT FK_ExpenseItem_Session
GO

ALTER TABLE [ExpenseItem]
 ADD CONSTRAINT [FK_ExpenseItem_Session] FOREIGN KEY ( [idSession] )
 REFERENCES [SessionOrdered] ([idSession] )
GO

ALTER TABLE [ExpenseItem]
DROP CONSTRAINT FK_ExpenseItem_Expense
GO

ALTER TABLE [ExpenseItem]
 ADD CONSTRAINT [FK_ExpenseItem_Expense] FOREIGN KEY ( [idExpense] )
 REFERENCES [Expense] ([id] )
GO



ALTER TABLE [Extra]
DROP CONSTRAINT FK_Extra
GO

ALTER TABLE [Extra]
 ADD CONSTRAINT [FK_Extra] FOREIGN KEY ( [idImage] )
 REFERENCES [Image] ([id] )
GO



ALTER TABLE [InvoiceItem]
DROP CONSTRAINT UK_InvoiceItem
GO

ALTER TABLE [InvoiceItem]
 ADD CONSTRAINT [UK_InvoiceItem] UNIQUE ( [idInvoice],[idOrderItem],[idSession] )
GO

ALTER TABLE [InvoiceItem]
DROP CONSTRAINT FK_InvoiceItem_Session
GO

ALTER TABLE [InvoiceItem]
 ADD CONSTRAINT [FK_InvoiceItem_Session] FOREIGN KEY ( [idSession] )
 REFERENCES [SessionOrdered] ([idSession] )
GO

ALTER TABLE [InvoiceItem]
DROP CONSTRAINT FK_InvoiceItem_Invoice
GO

ALTER TABLE [InvoiceItem]
 ADD CONSTRAINT [FK_InvoiceItem_Invoice] FOREIGN KEY ( [idInvoice] )
 REFERENCES [Invoice] ([id] )
GO

ALTER TABLE [InvoiceItem]
DROP CONSTRAINT FK_InvoiceItem_OrderItem
GO

ALTER TABLE [InvoiceItem]
 ADD CONSTRAINT [FK_InvoiceItem_OrderItem] FOREIGN KEY ( [idOrderItem] )
 REFERENCES [OrderItem] ([id] )
GO



ALTER TABLE [Itinerary]
DROP CONSTRAINT FK_Itinerary
GO

ALTER TABLE [Itinerary]
 ADD CONSTRAINT [FK_Itinerary] FOREIGN KEY ( [idProduct] )
 REFERENCES [Product] ([id] )
GO



ALTER TABLE [Order]
DROP CONSTRAINT FK_Order
GO

ALTER TABLE [Order]
 ADD CONSTRAINT [FK_Order] FOREIGN KEY ( [idCampaign] )
 REFERENCES [Campaign] ([id] )
GO



ALTER TABLE [OrderField]
DROP CONSTRAINT UK_OrderField
GO

ALTER TABLE [OrderField]
 ADD CONSTRAINT [UK_OrderField] UNIQUE ( [idOrder],[idField] )
GO

ALTER TABLE [OrderField]
DROP CONSTRAINT FK_OrderField_Order
GO

ALTER TABLE [OrderField]
 ADD CONSTRAINT [FK_OrderField_Order] FOREIGN KEY ( [idOrder] )
 REFERENCES [Order] ([id] )
GO

ALTER TABLE [OrderField]
DROP CONSTRAINT FK_OrderField_Field
GO

ALTER TABLE [OrderField]
 ADD CONSTRAINT [FK_OrderField_Field] FOREIGN KEY ( [idField] )
 REFERENCES [Field] ([id] )
GO



ALTER TABLE [OrderItem]
DROP CONSTRAINT FK_OrderItem_Order
GO

ALTER TABLE [OrderItem]
 ADD CONSTRAINT [FK_OrderItem_Order] FOREIGN KEY ( [idOrder] )
 REFERENCES [Order] ([id] )
GO

ALTER TABLE [OrderItem]
DROP CONSTRAINT FK_OrderItem_PickupSpot
GO

ALTER TABLE [OrderItem]
 ADD CONSTRAINT [FK_OrderItem_PickupSpot] FOREIGN KEY ( [idPickupSpot] )
 REFERENCES [PickupSpot] ([id] )
GO

ALTER TABLE [OrderItem]
DROP CONSTRAINT FK_OrderItem_Product
GO

ALTER TABLE [OrderItem]
 ADD CONSTRAINT [FK_OrderItem_Product] FOREIGN KEY ( [idProduct] )
 REFERENCES [Product] ([id] )
GO

ALTER TABLE [OrderItem]
DROP CONSTRAINT FK_OrderItem_Session
GO

ALTER TABLE [OrderItem]
 ADD CONSTRAINT [FK_OrderItem_Session] FOREIGN KEY ( [idSesstion] )
 REFERENCES [Session] ([id] )
GO



ALTER TABLE [OrderItemExtra]
DROP CONSTRAINT UK_OrderItemExtra
GO

ALTER TABLE [OrderItemExtra]
 ADD CONSTRAINT [UK_OrderItemExtra] UNIQUE ( [idOrderItem],[idExtra] )
GO

ALTER TABLE [OrderItemExtra]
DROP CONSTRAINT FK_OrderItemExtra_OrderItem
GO

ALTER TABLE [OrderItemExtra]
 ADD CONSTRAINT [FK_OrderItemExtra_OrderItem] FOREIGN KEY ( [idOrderItem] )
 REFERENCES [OrderItem] ([id] )
GO

ALTER TABLE [OrderItemExtra]
DROP CONSTRAINT FK_OrderItemExtra_Extra
GO

ALTER TABLE [OrderItemExtra]
 ADD CONSTRAINT [FK_OrderItemExtra_Extra] FOREIGN KEY ( [idExtra] )
 REFERENCES [Extra] ([id] )
GO



ALTER TABLE [OrderItemField]
DROP CONSTRAINT UK_OrderItemField
GO

ALTER TABLE [OrderItemField]
 ADD CONSTRAINT [UK_OrderItemField] UNIQUE ( [idOrderItem],[idField] )
GO

ALTER TABLE [OrderItemField]
DROP CONSTRAINT FK_OrderItemField_OrderItem
GO

ALTER TABLE [OrderItemField]
 ADD CONSTRAINT [FK_OrderItemField_OrderItem] FOREIGN KEY ( [idOrderItem] )
 REFERENCES [OrderItem] ([id] )
GO

ALTER TABLE [OrderItemField]
DROP CONSTRAINT FK_OrderItemField_Field
GO

ALTER TABLE [OrderItemField]
 ADD CONSTRAINT [FK_OrderItemField_Field] FOREIGN KEY ( [idField] )
 REFERENCES [Field] ([id] )
GO



ALTER TABLE [OrderItemProduct]
DROP CONSTRAINT UK_OrderItemProduct
GO

ALTER TABLE [OrderItemProduct]
 ADD CONSTRAINT [UK_OrderItemProduct] UNIQUE ( [idOrderItem],[idPrice] )
GO

ALTER TABLE [OrderItemProduct]
DROP CONSTRAINT FK_OrderItemProduct_OrderItem
GO

ALTER TABLE [OrderItemProduct]
 ADD CONSTRAINT [FK_OrderItemProduct_OrderItem] FOREIGN KEY ( [idOrderItem] )
 REFERENCES [OrderItem] ([id] )
GO

ALTER TABLE [OrderItemProduct]
DROP CONSTRAINT FK_OrderItemProduct_Price
GO

ALTER TABLE [OrderItemProduct]
 ADD CONSTRAINT [FK_OrderItemProduct_Price] FOREIGN KEY ( [idPrice] )
 REFERENCES [Price] ([id] )
GO



ALTER TABLE [OrderRole]
DROP CONSTRAINT UK_OrderRole
GO

ALTER TABLE [OrderRole]
 ADD CONSTRAINT [UK_OrderRole] UNIQUE ( [idOrder],[idParty],[typeRole] )
GO

ALTER TABLE [OrderRole]
DROP CONSTRAINT FK_OrderRole_Order
GO

ALTER TABLE [OrderRole]
 ADD CONSTRAINT [FK_OrderRole_Order] FOREIGN KEY ( [idOrder] )
 REFERENCES [Order] ([id] )
GO

ALTER TABLE [OrderRole]
DROP CONSTRAINT FK_OrderRole_Party
GO

ALTER TABLE [OrderRole]
 ADD CONSTRAINT [FK_OrderRole_Party] FOREIGN KEY ( [idParty] )
 REFERENCES [Party] ([id] )
GO



ALTER TABLE [PaymentOrder]
DROP CONSTRAINT FK_PaymentOrder_Order
GO

ALTER TABLE [PaymentOrder]
 ADD CONSTRAINT [FK_PaymentOrder_Order] FOREIGN KEY ( [idOrder] )
 REFERENCES [Order] ([id] )
GO

ALTER TABLE [PaymentOrder]
DROP CONSTRAINT FK_PaymentOrder_Payment
GO

ALTER TABLE [PaymentOrder]
 ADD CONSTRAINT [FK_PaymentOrder_Payment] FOREIGN KEY ( [idPayment] )
 REFERENCES [Payment] ([id] )
GO



ALTER TABLE [PickupSpot]
DROP CONSTRAINT UK_PickupSpot
GO

ALTER TABLE [PickupSpot]
 ADD CONSTRAINT [UK_PickupSpot] UNIQUE ( [idPickup],[idSpot] )
GO

ALTER TABLE [PickupSpot]
DROP CONSTRAINT FK_PickupSpot
GO

ALTER TABLE [PickupSpot]
 ADD CONSTRAINT [FK_PickupSpot] FOREIGN KEY ( [idPickup] )
 REFERENCES [Pickup] ([id] )
GO

ALTER TABLE [PickupSpot]
DROP CONSTRAINT FK_PickupSpot1
GO

ALTER TABLE [PickupSpot]
 ADD CONSTRAINT [FK_PickupSpot1] FOREIGN KEY ( [idSpot] )
 REFERENCES [Spot] ([id] )
GO



ALTER TABLE [Price]
DROP CONSTRAINT UK_Price
GO

ALTER TABLE [Price]
 ADD CONSTRAINT [UK_Price] UNIQUE ( [idProduct],[typePriceOption],[idSession] )
GO

ALTER TABLE [Price]
DROP CONSTRAINT FK_Price
GO

ALTER TABLE [Price]
 ADD CONSTRAINT [FK_Price] FOREIGN KEY ( [idProduct],[typePriceOption] )
 REFERENCES [PriceOption] ([idProduct],[typePriceOption] )
GO

ALTER TABLE [Price]
DROP CONSTRAINT FK_Price1
GO

ALTER TABLE [Price]
 ADD CONSTRAINT [FK_Price1] FOREIGN KEY ( [idSession] )
 REFERENCES [Session] ([id] )
GO



ALTER TABLE [PriceOption]
DROP CONSTRAINT FK_PriceOption_Product
GO

ALTER TABLE [PriceOption]
 ADD CONSTRAINT [FK_PriceOption_Product] FOREIGN KEY ( [idProduct] )
 REFERENCES [Product] ([id] )
GO



ALTER TABLE [Product]
DROP CONSTRAINT FK_Product
GO

ALTER TABLE [Product]
 ADD CONSTRAINT [FK_Product] FOREIGN KEY ( [idPickup] )
 REFERENCES [Pickup] ([id] )
GO



ALTER TABLE [ProductCategory]
DROP CONSTRAINT FK_ProductCategory
GO

ALTER TABLE [ProductCategory]
 ADD CONSTRAINT [FK_ProductCategory] FOREIGN KEY ( [idCategory] )
 REFERENCES [Category] ([id] )
GO

ALTER TABLE [ProductCategory]
DROP CONSTRAINT FK_ProductCategory1
GO

ALTER TABLE [ProductCategory]
 ADD CONSTRAINT [FK_ProductCategory1] FOREIGN KEY ( [idProduct] )
 REFERENCES [Product] ([id] )
GO



ALTER TABLE [ProductExtra]
DROP CONSTRAINT FK_ProductExtra_Product
GO

ALTER TABLE [ProductExtra]
 ADD CONSTRAINT [FK_ProductExtra_Product] FOREIGN KEY ( [idProduct] )
 REFERENCES [Product] ([id] )
GO

ALTER TABLE [ProductExtra]
DROP CONSTRAINT FK_ProductExtra_Extra
GO

ALTER TABLE [ProductExtra]
 ADD CONSTRAINT [FK_ProductExtra_Extra] FOREIGN KEY ( [idExtra] )
 REFERENCES [Extra] ([id] )
GO



ALTER TABLE [ProductField]
DROP CONSTRAINT FK_ProductField_Product
GO

ALTER TABLE [ProductField]
 ADD CONSTRAINT [FK_ProductField_Product] FOREIGN KEY ( [idProduct] )
 REFERENCES [Product] ([id] )
GO

ALTER TABLE [ProductField]
DROP CONSTRAINT FK_ProductField_Field
GO

ALTER TABLE [ProductField]
 ADD CONSTRAINT [FK_ProductField_Field] FOREIGN KEY ( [idField] )
 REFERENCES [Field] ([id] )
GO



ALTER TABLE [ProductImage]
DROP CONSTRAINT UK_ProductImage
GO

ALTER TABLE [ProductImage]
 ADD CONSTRAINT [UK_ProductImage] UNIQUE ( [idProduct],[idImage] )
GO

ALTER TABLE [ProductImage]
DROP CONSTRAINT FK_ProductImage_Product
GO

ALTER TABLE [ProductImage]
 ADD CONSTRAINT [FK_ProductImage_Product] FOREIGN KEY ( [idProduct] )
 REFERENCES [Product] ([id] )
GO

ALTER TABLE [ProductImage]
DROP CONSTRAINT FK_ProductImage_Image
GO

ALTER TABLE [ProductImage]
 ADD CONSTRAINT [FK_ProductImage_Image] FOREIGN KEY ( [idImage] )
 REFERENCES [Image] ([id] )
GO



ALTER TABLE [ProductRelated]
DROP CONSTRAINT FK_ProductRelated_Product1
GO

ALTER TABLE [ProductRelated]
 ADD CONSTRAINT [FK_ProductRelated_Product1] FOREIGN KEY ( [idProduct1] )
 REFERENCES [Product] ([id] )
GO

ALTER TABLE [ProductRelated]
DROP CONSTRAINT FK_ProductRelated_Product2
GO

ALTER TABLE [ProductRelated]
 ADD CONSTRAINT [FK_ProductRelated_Product2] FOREIGN KEY ( [idProduct2] )
 REFERENCES [Product] ([id] )
GO



ALTER TABLE [ProductTag]
DROP CONSTRAINT FK_ProductTag
GO

ALTER TABLE [ProductTag]
 ADD CONSTRAINT [FK_ProductTag] FOREIGN KEY ( [idProduct] )
 REFERENCES [Product] ([id] )
GO



ALTER TABLE [ProductVideo]
DROP CONSTRAINT FK_ProductVideo_Product
GO

ALTER TABLE [ProductVideo]
 ADD CONSTRAINT [FK_ProductVideo_Product] FOREIGN KEY ( [idProduct] )
 REFERENCES [Product] ([id] )
GO

ALTER TABLE [ProductVideo]
DROP CONSTRAINT FK_ProductVideo_Video
GO

ALTER TABLE [ProductVideo]
 ADD CONSTRAINT [FK_ProductVideo_Video] FOREIGN KEY ( [idVideo] )
 REFERENCES [Video] ([id] )
GO



ALTER TABLE [Session]
DROP CONSTRAINT UK_Session
GO

ALTER TABLE [Session]
 ADD CONSTRAINT [UK_Session] UNIQUE ( [datetimeStart],[idProduct] )
GO

ALTER TABLE [Session]
DROP CONSTRAINT FK_Session_Template
GO

ALTER TABLE [Session]
 ADD CONSTRAINT [FK_Session_Template] FOREIGN KEY ( [idTemplate] )
 REFERENCES [SessionTemplate] ([id] )
GO

ALTER TABLE [Session]
DROP CONSTRAINT FK_Session_Product
GO

ALTER TABLE [Session]
 ADD CONSTRAINT [FK_Session_Product] FOREIGN KEY ( [idProduct] )
 REFERENCES [Product] ([id] )
GO



ALTER TABLE [SessionRole]
DROP CONSTRAINT UK_SessionRole
GO

ALTER TABLE [SessionRole]
 ADD CONSTRAINT [UK_SessionRole] UNIQUE ( [idSession],[idParty],[typeRole] )
GO

ALTER TABLE [SessionRole]
DROP CONSTRAINT FK_SessionRole_Session
GO

ALTER TABLE [SessionRole]
 ADD CONSTRAINT [FK_SessionRole_Session] FOREIGN KEY ( [idSession] )
 REFERENCES [SessionOrdered] ([idSession] )
GO

ALTER TABLE [SessionRole]
DROP CONSTRAINT FK_SessionRole_Party
GO

ALTER TABLE [SessionRole]
 ADD CONSTRAINT [FK_SessionRole_Party] FOREIGN KEY ( [idParty] )
 REFERENCES [Party] ([id] )
GO



ALTER TABLE [SessionTemplate]
DROP CONSTRAINT FK_SessionTemplate
GO

ALTER TABLE [SessionTemplate]
 ADD CONSTRAINT [FK_SessionTemplate] FOREIGN KEY ( [idProduct] )
 REFERENCES [Product] ([id] )
GO



ALTER TABLE [SessionTemplateWeek]
DROP CONSTRAINT FK_SessionTemplateWeek
GO

ALTER TABLE [SessionTemplateWeek]
 ADD CONSTRAINT [FK_SessionTemplateWeek] FOREIGN KEY ( [idTemplate] )
 REFERENCES [SessionTemplate] ([id] )
GO



ALTER TABLE [Spot]
DROP CONSTRAINT FK_Spot
GO

ALTER TABLE [Spot]
 ADD CONSTRAINT [FK_Spot] FOREIGN KEY ( [idCity] )
 REFERENCES [City] ([id] )
GO



ALTER TABLE [TagSpot]
DROP CONSTRAINT FK_TagSpot
GO

ALTER TABLE [TagSpot]
 ADD CONSTRAINT [FK_TagSpot] FOREIGN KEY ( [idSpot] )
 REFERENCES [Spot] ([id] )
GO