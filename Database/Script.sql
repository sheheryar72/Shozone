USE [Shopzone]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 20-Dec-22 1:49:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[title] [varchar](200) NULL,
	[description] [varchar](1000) NULL,
	[source] [varchar](1000) NULL,
	[uploadedby] [varchar](200) NULL,
	[uploadedat] [varchar](200) NULL,
	[price] [varchar](200) NULL,
	[selling_price] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 20-Dec-22 1:49:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](200) NULL,
	[email] [varchar](200) NULL,
	[password] [varchar](200) NULL,
	[re_password] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Product] ON 
GO
INSERT [dbo].[Product] ([Id], [title], [description], [source], [uploadedby], [uploadedat], [price], [selling_price]) VALUES (1, N'ZARA MINIMALIST SWEATSHIRT', N'Sweatshirt made of a cotton blend. Round neckline and long sleeves. Ribbed trims.
NAVY BLUE | 5388/452
MATERIALS

OUTER SHELL
MAIN FABRIC
65% cotton · 35% polyester
SECONDARY FABRIC
97% cotton · 3% elastane
CARE
Caring for your clothes is caring for the environment.

Lower temperature washes and delicate spin cycles are gentler on garments and help to protect the colour, shape and structure of the fabric. Furthermore, they reduce the amount of energy used in care processes.', N'https://cdn.shopify.com/s/files/1/0549/9758/2071/products/5388452401_1_1_1_1024x1024@2x.jpg?v=1668071318', N'sheheryar', N'2022-12-20 13:35:43.573', N'4,000.00', N'1,800.00')
GO
INSERT [dbo].[Product] ([Id], [title], [description], [source], [uploadedby], [uploadedat], [price], [selling_price]) VALUES (2, N'ZARA MINIMALIST SWEATSHIRT', N'Sweatshirt made of a cotton blend. Round neckline and long sleeves. Ribbed trims.
NAVY BLUE | 5388/452
MATERIALS

OUTER SHELL
MAIN FABRIC
65% cotton · 35% polyester
SECONDARY FABRIC
97% cotton · 3% elastane
CARE
Caring for your clothes is caring for the environment.

Lower temperature washes and delicate spin cycles are gentler on garments and help to protect the colour, shape and structure of the fabric. Furthermore, they reduce the amount of energy used in care processes.', N'https://cdn.shopify.com/s/files/1/0549/9758/2071/products/5388452401_1_1_1_1024x1024@2x.jpg?v=1668071318', N'sheheryar', N'2022-12-20 13:35:43.573', N'4,000.00', N'1,800.00')
GO
INSERT [dbo].[Product] ([Id], [title], [description], [source], [uploadedby], [uploadedat], [price], [selling_price]) VALUES (3, N'ZARA MINIMALIST SWEATSHIRT', N'Sweatshirt made of a cotton blend. Round neckline and long sleeves. Ribbed trims.
NAVY BLUE | 5388/452
MATERIALS

OUTER SHELL
MAIN FABRIC
65% cotton · 35% polyester
SECONDARY FABRIC
97% cotton · 3% elastane
CARE
Caring for your clothes is caring for the environment.

Lower temperature washes and delicate spin cycles are gentler on garments and help to protect the colour, shape and structure of the fabric. Furthermore, they reduce the amount of energy used in care processes.', N'https://cdn.shopify.com/s/files/1/0549/9758/2071/products/5388452401_1_1_1_1024x1024@2x.jpg?v=1668071318', N'sheheryar', N'2022-12-20 13:35:43.573', N'4,000.00', N'1,800.00')
GO
INSERT [dbo].[Product] ([Id], [title], [description], [source], [uploadedby], [uploadedat], [price], [selling_price]) VALUES (4, N'ZARA MINIMALIST SWEATSHIRT', N'Sweatshirt made of a cotton blend. Round neckline and long sleeves. Ribbed trims.
NAVY BLUE | 5388/452
MATERIALS

OUTER SHELL
MAIN FABRIC
65% cotton · 35% polyester
SECONDARY FABRIC
97% cotton · 3% elastane
CARE
Caring for your clothes is caring for the environment.

Lower temperature washes and delicate spin cycles are gentler on garments and help to protect the colour, shape and structure of the fabric. Furthermore, they reduce the amount of energy used in care processes.', N'https://cdn.shopify.com/s/files/1/0549/9758/2071/products/5388452401_1_1_1_1024x1024@2x.jpg?v=1668071318', N'sheheryar', N'2022-12-20 13:35:43.573', N'4,000.00', N'1,800.00')
GO
INSERT [dbo].[Product] ([Id], [title], [description], [source], [uploadedby], [uploadedat], [price], [selling_price]) VALUES (5, N'ZARA MINIMALIST SWEATSHIRT', N'Sweatshirt made of a cotton blend. Round neckline and long sleeves. Ribbed trims.
NAVY BLUE | 5388/452
MATERIALS

OUTER SHELL
MAIN FABRIC
65% cotton · 35% polyester
SECONDARY FABRIC
97% cotton · 3% elastane
CARE
Caring for your clothes is caring for the environment.

Lower temperature washes and delicate spin cycles are gentler on garments and help to protect the colour, shape and structure of the fabric. Furthermore, they reduce the amount of energy used in care processes.', N'https://cdn.shopify.com/s/files/1/0549/9758/2071/products/5388452401_1_1_1_1024x1024@2x.jpg?v=1668071318', N'sheheryar', N'2022-12-20 13:35:43.573', N'4,000.00', N'1,800.00')
GO
INSERT [dbo].[Product] ([Id], [title], [description], [source], [uploadedby], [uploadedat], [price], [selling_price]) VALUES (6, N'ZARA MINIMALIST SWEATSHIRT', N'Sweatshirt made of a cotton blend. Round neckline and long sleeves. Ribbed trims.
NAVY BLUE | 5388/452
MATERIALS

OUTER SHELL
MAIN FABRIC
65% cotton · 35% polyester
SECONDARY FABRIC
97% cotton · 3% elastane
CARE
Caring for your clothes is caring for the environment.

Lower temperature washes and delicate spin cycles are gentler on garments and help to protect the colour, shape and structure of the fabric. Furthermore, they reduce the amount of energy used in care processes.', N'https://cdn.shopify.com/s/files/1/0549/9758/2071/products/5388452401_1_1_1_1024x1024@2x.jpg?v=1668071318', N'sheheryar', N'2022-12-20 13:35:43.573', N'4,000.00', N'1,800.00')
GO
INSERT [dbo].[Product] ([Id], [title], [description], [source], [uploadedby], [uploadedat], [price], [selling_price]) VALUES (7, N'ZARA MINIMALIST SWEATSHIRT', N'Sweatshirt made of a cotton blend. Round neckline and long sleeves. Ribbed trims.
NAVY BLUE | 5388/452
MATERIALS

OUTER SHELL
MAIN FABRIC
65% cotton · 35% polyester
SECONDARY FABRIC
97% cotton · 3% elastane
CARE
Caring for your clothes is caring for the environment.

Lower temperature washes and delicate spin cycles are gentler on garments and help to protect the colour, shape and structure of the fabric. Furthermore, they reduce the amount of energy used in care processes.', N'https://cdn.shopify.com/s/files/1/0549/9758/2071/products/5388452401_1_1_1_1024x1024@2x.jpg?v=1668071318', N'sheheryar', N'2022-12-20 13:35:43.573', N'4,000.00', N'1,800.00')
GO
INSERT [dbo].[Product] ([Id], [title], [description], [source], [uploadedby], [uploadedat], [price], [selling_price]) VALUES (8, N'ZARA MINIMALIST SWEATSHIRT', N'Sweatshirt made of a cotton blend. Round neckline and long sleeves. Ribbed trims.
NAVY BLUE | 5388/452
MATERIALS

OUTER SHELL
MAIN FABRIC
65% cotton · 35% polyester
SECONDARY FABRIC
97% cotton · 3% elastane
CARE
Caring for your clothes is caring for the environment.

Lower temperature washes and delicate spin cycles are gentler on garments and help to protect the colour, shape and structure of the fabric. Furthermore, they reduce the amount of energy used in care processes.', N'https://cdn.shopify.com/s/files/1/0549/9758/2071/products/5388452401_1_1_1_1024x1024@2x.jpg?v=1668071318', N'sheheryar', N'2022-12-20 13:35:43.573', N'4,000.00', N'1,800.00')
GO
INSERT [dbo].[Product] ([Id], [title], [description], [source], [uploadedby], [uploadedat], [price], [selling_price]) VALUES (9, N'ZARA MINIMALIST SWEATSHIRT', N'Sweatshirt made of a cotton blend. Round neckline and long sleeves. Ribbed trims.
NAVY BLUE | 5388/452
MATERIALS

OUTER SHELL
MAIN FABRIC
65% cotton · 35% polyester
SECONDARY FABRIC
97% cotton · 3% elastane
CARE
Caring for your clothes is caring for the environment.

Lower temperature washes and delicate spin cycles are gentler on garments and help to protect the colour, shape and structure of the fabric. Furthermore, they reduce the amount of energy used in care processes.', N'https://cdn.shopify.com/s/files/1/0549/9758/2071/products/5388452401_1_1_1_1024x1024@2x.jpg?v=1668071318', N'sheheryar', N'2022-12-20 13:35:43.573', N'4,000.00', N'1,800.00')
GO
INSERT [dbo].[Product] ([Id], [title], [description], [source], [uploadedby], [uploadedat], [price], [selling_price]) VALUES (10, N'ZARA MINIMALIST SWEATSHIRT', N'Sweatshirt made of a cotton blend. Round neckline and long sleeves. Ribbed trims.
NAVY BLUE | 5388/452
MATERIALS

OUTER SHELL
MAIN FABRIC
65% cotton · 35% polyester
SECONDARY FABRIC
97% cotton · 3% elastane
CARE
Caring for your clothes is caring for the environment.

Lower temperature washes and delicate spin cycles are gentler on garments and help to protect the colour, shape and structure of the fabric. Furthermore, they reduce the amount of energy used in care processes.', N'https://cdn.shopify.com/s/files/1/0549/9758/2071/products/5388452401_1_1_1_1024x1024@2x.jpg?v=1668071318', N'sheheryar', N'2022-12-20 13:35:43.573', N'4,000.00', N'1,800.00')
GO
INSERT [dbo].[Product] ([Id], [title], [description], [source], [uploadedby], [uploadedat], [price], [selling_price]) VALUES (11, N'ZARA MINIMALIST SWEATSHIRT', N'Sweatshirt made of a cotton blend. Round neckline and long sleeves. Ribbed trims.
NAVY BLUE | 5388/452
MATERIALS

OUTER SHELL
MAIN FABRIC
65% cotton · 35% polyester
SECONDARY FABRIC
97% cotton · 3% elastane
CARE
Caring for your clothes is caring for the environment.

Lower temperature washes and delicate spin cycles are gentler on garments and help to protect the colour, shape and structure of the fabric. Furthermore, they reduce the amount of energy used in care processes.', N'https://cdn.shopify.com/s/files/1/0549/9758/2071/products/5388452401_1_1_1_1024x1024@2x.jpg?v=1668071318', N'sheheryar', N'2022-12-20 13:35:43.573', N'4,000.00', N'1,800.00')
GO
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 
GO
INSERT [dbo].[User] ([Id], [name], [email], [password], [re_password]) VALUES (1, N'sheheryar', N'sheheryarizhar@gmail.com', N'123', N'123')
GO
INSERT [dbo].[User] ([Id], [name], [email], [password], [re_password]) VALUES (2, N'hassan', N'hassan@gmail.com', N'123', N'123')
GO
SET IDENTITY_INSERT [dbo].[User] OFF
GO
