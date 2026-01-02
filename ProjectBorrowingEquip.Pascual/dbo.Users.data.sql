SET IDENTITY_INSERT [dbo].[Users] ON
INSERT INTO [dbo].[Users] ([UserID], [FullName], [Username], [UserPassword]) VALUES (NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Users] OFF

INSERT INTO dbo.Users(FullName, Username, UserPassword) VALUES ('Roxanne Pascual', 'rox', '1234');