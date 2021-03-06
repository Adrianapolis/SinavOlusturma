USE [GorselDB]
GO
/****** Object:  Table [dbo].[Asistan]    Script Date: 20.12.2017 21:15:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Asistan](
	[AsistanID] [int] IDENTITY(1,1) NOT NULL,
	[AsistanAdi] [varchar](50) NOT NULL,
	[Mail] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Asistan] PRIMARY KEY CLUSTERED 
(
	[AsistanID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dersler]    Script Date: 20.12.2017 21:15:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dersler](
	[DersKodu] [varchar](50) NOT NULL,
	[DersAdi] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Dersler] PRIMARY KEY CLUSTERED 
(
	[DersKodu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Derslik]    Script Date: 20.12.2017 21:15:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Derslik](
	[DerslikID] [int] IDENTITY(1,1) NOT NULL,
	[DerslikAdi] [varchar](50) NOT NULL,
	[Kapasite] [int] NOT NULL,
 CONSTRAINT [PK_Derslik] PRIMARY KEY CLUSTERED 
(
	[DerslikID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Donem]    Script Date: 20.12.2017 21:15:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Donem](
	[DonemID] [int] IDENTITY(1,1) NOT NULL,
	[DonemAdi] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Donem] PRIMARY KEY CLUSTERED 
(
	[DonemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Liste]    Script Date: 20.12.2017 21:15:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Liste](
	[ListeID] [int] IDENTITY(1,1) NOT NULL,
	[SinavID] [int] NOT NULL,
	[DerslikID] [int] NOT NULL,
	[AsistanID] [int] NOT NULL,
	[OgrString] [varchar](8000) NOT NULL,
 CONSTRAINT [PK_Liste] PRIMARY KEY CLUSTERED 
(
	[ListeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sinav]    Script Date: 20.12.2017 21:15:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sinav](
	[SinavID] [int] IDENTITY(1,1) NOT NULL,
	[DersKodu] [varchar](50) NOT NULL,
	[DonemID] [int] NOT NULL,
	[TarihID] [int] NOT NULL,
	[SinavTuru] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Sinav] PRIMARY KEY CLUSTERED 
(
	[SinavID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tarihler]    Script Date: 20.12.2017 21:15:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tarihler](
	[TarihID] [int] IDENTITY(1,1) NOT NULL,
	[Tarih] [date] NOT NULL,
 CONSTRAINT [PK_Tarihler] PRIMARY KEY CLUSTERED 
(
	[TarihID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Asistan] ON 

INSERT [dbo].[Asistan] ([AsistanID], [AsistanAdi], [Mail]) VALUES (1, N'Emir Öztürk', N'emirozturk@trakya.edu.tr')
INSERT [dbo].[Asistan] ([AsistanID], [AsistanAdi], [Mail]) VALUES (1003, N'Kemal Akkanat', N'kemalakkanat@trakya.edu.tr')
INSERT [dbo].[Asistan] ([AsistanID], [AsistanAdi], [Mail]) VALUES (1004, N'Işıl Çetintav', N'isilcetintav@trakya.edu.tr')
INSERT [dbo].[Asistan] ([AsistanID], [AsistanAdi], [Mail]) VALUES (2008, N'Tuğba Çalış', N'tugbacalis@trakya.edu.tr')
INSERT [dbo].[Asistan] ([AsistanID], [AsistanAdi], [Mail]) VALUES (2009, N'Önder Açıkgöz', N'onderacikgoz@trakya.edu.tr')
SET IDENTITY_INSERT [dbo].[Asistan] OFF
INSERT [dbo].[Dersler] ([DersKodu], [DersAdi]) VALUES (N'BIL101', N'BMG')
INSERT [dbo].[Dersler] ([DersKodu], [DersAdi]) VALUES (N'BIL102', N'PDG')
INSERT [dbo].[Dersler] ([DersKodu], [DersAdi]) VALUES (N'BIL201', N'Elektrik')
INSERT [dbo].[Dersler] ([DersKodu], [DersAdi]) VALUES (N'BIL301', N'GÖRSEL')
SET IDENTITY_INSERT [dbo].[Derslik] ON 

INSERT [dbo].[Derslik] ([DerslikID], [DerslikAdi], [Kapasite]) VALUES (1014, N'L102', 30)
INSERT [dbo].[Derslik] ([DerslikID], [DerslikAdi], [Kapasite]) VALUES (1015, N'L103', 30)
INSERT [dbo].[Derslik] ([DerslikID], [DerslikAdi], [Kapasite]) VALUES (1016, N'L104', 50)
INSERT [dbo].[Derslik] ([DerslikID], [DerslikAdi], [Kapasite]) VALUES (1018, N'D201', 20)
INSERT [dbo].[Derslik] ([DerslikID], [DerslikAdi], [Kapasite]) VALUES (1019, N'D202', 20)
INSERT [dbo].[Derslik] ([DerslikID], [DerslikAdi], [Kapasite]) VALUES (1020, N'D203', 30)
INSERT [dbo].[Derslik] ([DerslikID], [DerslikAdi], [Kapasite]) VALUES (1021, N'D204', 10)
INSERT [dbo].[Derslik] ([DerslikID], [DerslikAdi], [Kapasite]) VALUES (1022, N'D205', 20)
SET IDENTITY_INSERT [dbo].[Derslik] OFF
SET IDENTITY_INSERT [dbo].[Donem] ON 

INSERT [dbo].[Donem] ([DonemID], [DonemAdi]) VALUES (1, N'Bahar')
INSERT [dbo].[Donem] ([DonemID], [DonemAdi]) VALUES (2, N'Güz')
INSERT [dbo].[Donem] ([DonemID], [DonemAdi]) VALUES (3, N'Yaz')
SET IDENTITY_INSERT [dbo].[Donem] OFF
SET IDENTITY_INSERT [dbo].[Liste] ON 

INSERT [dbo].[Liste] ([ListeID], [SinavID], [DerslikID], [AsistanID], [OgrString]) VALUES (1, 1023, 1014, 2009, N'1151602805 Mehmet Erdin12;1151506396 Anıl Yılmaz8;1151508496 Uğur Kıymetli;1151602805 Mehmet Erdin15;1151508496 Uğur Kıymetli2;1151602805 Mehmet Erdin4;1151508496 Uğur Kıymetli14;1151506396 Anıl Yılmaz6;1151508496 Uğur Kıymetli6;115162503 Muhammed Fatih Candan8;115162503 Muhammed Fatih Candan14;1151402562 Süleyman Yasin Akdeniz;1151506396 Anıl Yılmaz4;1151602805 Mehmet Erdin11;115162503 Muhammed Fatih Candan13;1151402562 Süleyman Yasin Akdeniz15;1151506396 Anıl Yılmaz7;1151402562 Süleyman Yasin Akdeniz1;1151602805 Mehmet Erdin16;1151506396 Anıl Yılmaz16;1151508496 Uğur Kıymetli1;1151402562 Süleyman Yasin Akdeniz6;1151602805 Mehmet Erdin2;1151402562 Süleyman Yasin Akdeniz13;1151402562 Süleyman Yasin Akdeniz12;1151506396 Anıl Yılmaz;1151402562 Süleyman Yasin Akdeniz7;1151508496 Uğur Kıymetli4;1151508496 Uğur Kıymetli16;115162503 Muhammed Fatih Candan11;')
INSERT [dbo].[Liste] ([ListeID], [SinavID], [DerslikID], [AsistanID], [OgrString]) VALUES (2, 1023, 1016, 1004, N'1151506396 Anıl Yılmaz10;115162503 Muhammed Fatih Candan1;1151508496 Uğur Kıymetli9;1151602805 Mehmet Erdin10;1151402562 Süleyman Yasin Akdeniz2;1151402562 Süleyman Yasin Akdeniz16;115162503 Muhammed Fatih Candan2;1151602805 Mehmet Erdin3;115162503 Muhammed Fatih Candan10;1151402562 Süleyman Yasin Akdeniz3;1151602805 Mehmet Erdin5;1151402562 Süleyman Yasin Akdeniz10;1151602805 Mehmet Erdin7;1151506396 Anıl Yılmaz15;1151506396 Anıl Yılmaz14;1151508496 Uğur Kıymetli7;1151602805 Mehmet Erdin13;1151402562 Süleyman Yasin Akdeniz4;115162503 Muhammed Fatih Candan5;1151506396 Anıl Yılmaz2;1151508496 Uğur Kıymetli11;1151508496 Uğur Kıymetli8;1151508496 Uğur Kıymetli5;115162503 Muhammed Fatih Candan3;115162503 Muhammed Fatih Candan4;1151508496 Uğur Kıymetli13;1151506396 Anıl Yılmaz5;1151506396 Anıl Yılmaz3;1151506396 Anıl Yılmaz11;115162503 Muhammed Fatih Candan15;1151602805 Mehmet Erdin1;115162503 Muhammed Fatih Candan;1151508496 Uğur Kıymetli12;1151402562 Süleyman Yasin Akdeniz14;1151602805 Mehmet Erdin;')
INSERT [dbo].[Liste] ([ListeID], [SinavID], [DerslikID], [AsistanID], [OgrString]) VALUES (3, 1023, 1019, 1, N'1151506396 Anıl Yılmaz13;1151506396 Anıl Yılmaz9;115162503 Muhammed Fatih Candan16;1151602805 Mehmet Erdin14;1151602805 Mehmet Erdin8;115162503 Muhammed Fatih Candan7;1151402562 Süleyman Yasin Akdeniz11;1151508496 Uğur Kıymetli15;1151402562 Süleyman Yasin Akdeniz8;1151602805 Mehmet Erdin9;1151508496 Uğur Kıymetli3;1151402562 Süleyman Yasin Akdeniz5;1151506396 Anıl Yılmaz1;1151402562 Süleyman Yasin Akdeniz9;1151506396 Anıl Yılmaz12;115162503 Muhammed Fatih Candan12;1151602805 Mehmet Erdin6;115162503 Muhammed Fatih Candan6;115162503 Muhammed Fatih Candan9;1151508496 Uğur Kıymetli10;')
INSERT [dbo].[Liste] ([ListeID], [SinavID], [DerslikID], [AsistanID], [OgrString]) VALUES (4, 1024, 1014, 1004, N'1151602805 Mehmet Erdin14;115162503 Muhammed Fatih Candan7;1151508496 Uğur Kıymetli8;1151506396 Anıl Yılmaz16;1151508496 Uğur Kıymetli14;1151508496 Uğur Kıymetli1;1151506396 Anıl Yılmaz2;115162503 Muhammed Fatih Candan14;1151508496 Uğur Kıymetli10;115162503 Muhammed Fatih Candan16;1151602805 Mehmet Erdin3;1151602805 Mehmet Erdin10;1151506396 Anıl Yılmaz6;115162503 Muhammed Fatih Candan9;1151602805 Mehmet Erdin12;1151506396 Anıl Yılmaz;1151506396 Anıl Yılmaz5;115162503 Muhammed Fatih Candan3;1151506396 Anıl Yılmaz11;1151402562 Süleyman Yasin Akdeniz6;1151506396 Anıl Yılmaz9;115162503 Muhammed Fatih Candan13;115162503 Muhammed Fatih Candan15;1151602805 Mehmet Erdin6;1151402562 Süleyman Yasin Akdeniz10;1151506396 Anıl Yılmaz14;1151508496 Uğur Kıymetli16;115162503 Muhammed Fatih Candan6;1151602805 Mehmet Erdin5;1151602805 Mehmet Erdin;')
INSERT [dbo].[Liste] ([ListeID], [SinavID], [DerslikID], [AsistanID], [OgrString]) VALUES (5, 1024, 1016, 2009, N'1151508496 Uğur Kıymetli5;1151506396 Anıl Yılmaz10;1151506396 Anıl Yılmaz1;1151402562 Süleyman Yasin Akdeniz8;1151602805 Mehmet Erdin8;1151402562 Süleyman Yasin Akdeniz11;1151506396 Anıl Yılmaz7;1151402562 Süleyman Yasin Akdeniz14;115162503 Muhammed Fatih Candan11;1151508496 Uğur Kıymetli7;1151402562 Süleyman Yasin Akdeniz7;1151602805 Mehmet Erdin1;115162503 Muhammed Fatih Candan1;1151402562 Süleyman Yasin Akdeniz3;115162503 Muhammed Fatih Candan4;1151508496 Uğur Kıymetli2;1151602805 Mehmet Erdin13;1151508496 Uğur Kıymetli6;1151402562 Süleyman Yasin Akdeniz;1151508496 Uğur Kıymetli15;115162503 Muhammed Fatih Candan12;1151602805 Mehmet Erdin4;1151602805 Mehmet Erdin2;1151602805 Mehmet Erdin9;1151506396 Anıl Yılmaz3;1151508496 Uğur Kıymetli13;1151402562 Süleyman Yasin Akdeniz13;1151508496 Uğur Kıymetli12;1151506396 Anıl Yılmaz15;1151508496 Uğur Kıymetli11;115162503 Muhammed Fatih Candan10;1151402562 Süleyman Yasin Akdeniz12;1151402562 Süleyman Yasin Akdeniz15;1151402562 Süleyman Yasin Akdeniz9;1151508496 Uğur Kıymetli3;')
INSERT [dbo].[Liste] ([ListeID], [SinavID], [DerslikID], [AsistanID], [OgrString]) VALUES (6, 1024, 1019, 1, N'1151602805 Mehmet Erdin7;1151506396 Anıl Yılmaz4;115162503 Muhammed Fatih Candan8;115162503 Muhammed Fatih Candan5;1151506396 Anıl Yılmaz13;1151402562 Süleyman Yasin Akdeniz16;1151602805 Mehmet Erdin15;115162503 Muhammed Fatih Candan2;1151602805 Mehmet Erdin16;1151402562 Süleyman Yasin Akdeniz4;1151402562 Süleyman Yasin Akdeniz2;1151506396 Anıl Yılmaz12;1151402562 Süleyman Yasin Akdeniz1;1151402562 Süleyman Yasin Akdeniz5;1151508496 Uğur Kıymetli4;1151508496 Uğur Kıymetli9;1151508496 Uğur Kıymetli;1151506396 Anıl Yılmaz8;1151602805 Mehmet Erdin11;115162503 Muhammed Fatih Candan;')
SET IDENTITY_INSERT [dbo].[Liste] OFF
SET IDENTITY_INSERT [dbo].[Sinav] ON 

INSERT [dbo].[Sinav] ([SinavID], [DersKodu], [DonemID], [TarihID], [SinavTuru]) VALUES (1023, N'BIL101', 1, 1, N'Vize')
INSERT [dbo].[Sinav] ([SinavID], [DersKodu], [DonemID], [TarihID], [SinavTuru]) VALUES (1024, N'BIL101', 1, 6, N'Final')
SET IDENTITY_INSERT [dbo].[Sinav] OFF
SET IDENTITY_INSERT [dbo].[Tarihler] ON 

INSERT [dbo].[Tarihler] ([TarihID], [Tarih]) VALUES (1, CAST(N'2017-12-22' AS Date))
INSERT [dbo].[Tarihler] ([TarihID], [Tarih]) VALUES (2, CAST(N'2017-12-20' AS Date))
INSERT [dbo].[Tarihler] ([TarihID], [Tarih]) VALUES (3, CAST(N'2017-12-23' AS Date))
INSERT [dbo].[Tarihler] ([TarihID], [Tarih]) VALUES (4, CAST(N'2017-12-24' AS Date))
INSERT [dbo].[Tarihler] ([TarihID], [Tarih]) VALUES (5, CAST(N'2017-12-21' AS Date))
INSERT [dbo].[Tarihler] ([TarihID], [Tarih]) VALUES (6, CAST(N'2017-12-25' AS Date))
SET IDENTITY_INSERT [dbo].[Tarihler] OFF
ALTER TABLE [dbo].[Liste]  WITH CHECK ADD  CONSTRAINT [FK_Liste_Asistan] FOREIGN KEY([AsistanID])
REFERENCES [dbo].[Asistan] ([AsistanID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Liste] CHECK CONSTRAINT [FK_Liste_Asistan]
GO
ALTER TABLE [dbo].[Liste]  WITH CHECK ADD  CONSTRAINT [FK_Liste_Derslik] FOREIGN KEY([DerslikID])
REFERENCES [dbo].[Derslik] ([DerslikID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Liste] CHECK CONSTRAINT [FK_Liste_Derslik]
GO
ALTER TABLE [dbo].[Liste]  WITH CHECK ADD  CONSTRAINT [FK_Liste_Sinav] FOREIGN KEY([SinavID])
REFERENCES [dbo].[Sinav] ([SinavID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Liste] CHECK CONSTRAINT [FK_Liste_Sinav]
GO
ALTER TABLE [dbo].[Sinav]  WITH CHECK ADD  CONSTRAINT [FK_Sinav_Donem] FOREIGN KEY([DonemID])
REFERENCES [dbo].[Donem] ([DonemID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sinav] CHECK CONSTRAINT [FK_Sinav_Donem]
GO
ALTER TABLE [dbo].[Sinav]  WITH CHECK ADD  CONSTRAINT [FK_Sinav_Sinav] FOREIGN KEY([DersKodu])
REFERENCES [dbo].[Dersler] ([DersKodu])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sinav] CHECK CONSTRAINT [FK_Sinav_Sinav]
GO
ALTER TABLE [dbo].[Sinav]  WITH CHECK ADD  CONSTRAINT [FK_Sinav_Tarihler] FOREIGN KEY([TarihID])
REFERENCES [dbo].[Tarihler] ([TarihID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sinav] CHECK CONSTRAINT [FK_Sinav_Tarihler]
GO
