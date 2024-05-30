USE [WMS_Proje]
GO
/****** Object:  Table [dbo].[M3_Cari_Kart]    Script Date: 27.08.2019 14:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[M3_Cari_Kart](
	[Ca_Kod] [varchar](50) NULL,
	[Ca_Ad] [varchar](100) NULL,
	[Ca_Ad2] [varchar](100) NULL,
	[Ca_ReferansKodu] [varchar](50) NULL,
	[Ca_Adres] [varchar](255) NULL,
	[Ca_Semt] [varchar](50) NULL,
	[Ca_Sehir] [varchar](50) NULL,
	[Ca_Ulke] [varchar](50) NULL,
	[Ca_PostaKodu] [varchar](20) NULL,
	[Ca_Telefon1] [varchar](25) NULL,
	[Ca_Telefon2] [varchar](25) NULL,
	[Ca_Telefon3] [varchar](25) NULL,
	[Ca_Faks] [varchar](25) NULL,
	[Ca_CepTelefon] [varchar](50) NULL,
	[Ca_VerDar] [varchar](50) NULL,
	[Ca_VerNo] [varchar](20) NULL,
	[Ca_OdemeEslemeTuru] [varchar](20) NULL,
	[Ca_OdemeGunu] [varchar] NULL,
	[Ca_OdemePlani] [varchar](255) NULL,
	[Ca_OdemeNotu] [varchar](255) NULL,
	[Kayit_Olusturan] [varchar](50) NULL,
	[Kayit_OlusTarih] [datetime] NULL,
	[Kayit_Degistiren] [varchar](50) NULL,
	[Kayit_DegisTarih] [datetime] NULL,
	[Kayit_DegisProgram] [varchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[M3_Stok_Kart]    Script Date: 27.08.2019 14:04:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[M3_Stok_Kart](
	[St_Kod] [varchar](50) NULL,
	[St_Ad] [varchar](100) NULL,
	[St_BirimKod1] [varchar](6) NULL,
	[St_BirimFrm1] [varchar](50) NULL,
	[St_StokGrubu1] [varchar](50) NULL,
	[Kayit_Olusturan] [varchar](100) NULL,
	[Kayit_OlusTarih] [varchar](100) NULL,
	[Kayit_Degistiren] [varchar](100) NULL,
	[Kayit_DegisTarih] [varchar](100) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[M3_Stok_Kart] ([St_Kod], [St_Ad], [St_BirimKod1], [St_BirimFrm1], [St_StokGrubu1], [Kayit_Olusturan], [Kayit_OlusTarih], [Kayit_Degistiren], [Kayit_DegisTarih]) VALUES (N'A1', N'A1 Test', N'M2', N'M2', N'Mamul', N'', N'Ağu 27 2019  1:46PM', N'', N'Ağu 27 2019  1:50PM')
GO
