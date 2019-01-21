SET IDENTITY_INSERT [dbo].[BoatStatus] ON 
GO
INSERT [dbo].[BoatStatus] ([BoatStatusId], [Status]) VALUES (1, N'Damaged')
GO
INSERT [dbo].[BoatStatus] ([BoatStatusId], [Status]) VALUES (2, N'Being Repaired')
GO
INSERT [dbo].[BoatStatus] ([BoatStatusId], [Status]) VALUES (3, N'At Regatta')
GO
INSERT [dbo].[BoatStatus] ([BoatStatusId], [Status]) VALUES (4, N'Sold')
GO
INSERT [dbo].[BoatStatus] ([BoatStatusId], [Status]) VALUES (5, N'Rowable')
GO
SET IDENTITY_INSERT [dbo].[BoatStatus] OFF
GO
SET IDENTITY_INSERT [dbo].[BoatType] ON 
GO
INSERT [dbo].[BoatType] ([BoatTypeId], [Type], [Name], [Seats], [StartCount], [HasCox]) VALUES (1, N'1X', N'Single', 1, 1, 0)
GO
INSERT [dbo].[BoatType] ([BoatTypeId], [Type], [Name], [Seats], [StartCount], [HasCox]) VALUES (2, N'2-/2X', N'Pair/Double', 2, 1, 0)
GO
INSERT [dbo].[BoatType] ([BoatTypeId], [Type], [Name], [Seats], [StartCount], [HasCox]) VALUES (3, N'2+', N'Pair w/Cox', 3, 0, 1)
GO
INSERT [dbo].[BoatType] ([BoatTypeId], [Type], [Name], [Seats], [StartCount], [HasCox]) VALUES (4, N'4-/4X', N'Four/Quad', 4, 1, 0)
GO
INSERT [dbo].[BoatType] ([BoatTypeId], [Type], [Name], [Seats], [StartCount], [HasCox]) VALUES (5, N'4+', N'Four w/ Cox', 5, 0, 1)
GO
INSERT [dbo].[BoatType] ([BoatTypeId], [Type], [Name], [Seats], [StartCount], [HasCox]) VALUES (6, N'8', N'Eight', 9, 0, 1)
GO
INSERT [dbo].[BoatType] ([BoatTypeId], [Type], [Name], [Seats], [StartCount], [HasCox]) VALUES (7, N'Erg', N'Ergometer', 1, 1, 0)
GO
INSERT [dbo].[BoatType] ([BoatTypeId], [Type], [Name], [Seats], [StartCount], [HasCox]) VALUES (8, N'Gig', N'Gig', 1, 1, 0)
GO
INSERT [dbo].[BoatType] ([BoatTypeId], [Type], [Name], [Seats], [StartCount], [HasCox]) VALUES (9, N'Launch', N'Launch', 1, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[BoatType] OFF
GO
SET IDENTITY_INSERT [dbo].[Rigging] ON 
GO
INSERT [dbo].[Rigging] ([RiggingId], [Name]) VALUES (1, N'Sweeps')
GO
INSERT [dbo].[Rigging] ([RiggingId], [Name]) VALUES (2, N'Sculls')
GO
INSERT [dbo].[Rigging] ([RiggingId], [Name]) VALUES (3, N'Both')
GO
SET IDENTITY_INSERT [dbo].[Rigging] OFF
GO
SET IDENTITY_INSERT [dbo].[UseRestriction] ON 
GO
INSERT [dbo].[UseRestriction] ([UseRestrictionId], [Restriction]) VALUES (1, N'General Use')
GO
INSERT [dbo].[UseRestriction] ([UseRestrictionId], [Restriction]) VALUES (2, N'Elite Priority')
GO
INSERT [dbo].[UseRestriction] ([UseRestrictionId], [Restriction]) VALUES (3, N'Novice')
GO
INSERT [dbo].[UseRestriction] ([UseRestrictionId], [Restriction]) VALUES (4, N'Private')
GO
INSERT [dbo].[UseRestriction] ([UseRestrictionId], [Restriction]) VALUES (5, N'Tenent Only')
GO
INSERT [dbo].[UseRestriction] ([UseRestrictionId], [Restriction]) VALUES (6, N'Captain Permit')
GO
SET IDENTITY_INSERT [dbo].[UseRestriction] OFF
GO
