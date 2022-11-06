SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
[Id] [int] NOT NULL,
[Name] [nvarchar](50) NULL,
[Description] [nvarchar](50) NULL,
[ProductCategoryId] [int] NULL,
[Price] [decimal](18, 0) NULL,
CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED
(
[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Products] WITH CHECK ADD FOREIGN KEY([ProductCategoryId])
REFERENCES [dbo].[Categories] ([Id])
GO