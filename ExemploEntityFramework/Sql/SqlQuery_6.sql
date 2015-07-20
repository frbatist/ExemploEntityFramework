﻿ALTER TABLE [dbo].[Usuario] ADD [IdPerfil] [int]
CREATE INDEX [IX_IdPerfil] ON [dbo].[Usuario]([IdPerfil])
ALTER TABLE [dbo].[Usuario] ADD CONSTRAINT [FK_dbo.Usuario_dbo.Perfil_IdPerfil] FOREIGN KEY ([IdPerfil]) REFERENCES [dbo].[Perfil] ([Id])
INSERT [dbo].[__MigrationHistory]([MigrationId], [ContextKey], [Model], [ProductVersion])
VALUES (N'201507162027324_usuario_perfil', N'ExemploEntityFramework.Migrations.Configuration',  0x1F8B0800000000000400ED59CD6EE33610BE17E83B083A1659CB492E5BC3DE45D6490AA3F943942C7A0B6869EC104B912A49A536167DB21EFA487D850EF52F4AB66523DDE6B0D84B2C723ECE0CBFF9E1EC3F7FFD3DFEB88A98F3025251C127EEF160E83AC0031152BE9CB8895EBC7BEF7EFCF0E30FE38B305A399F8B7DA7661F4A7235719FB58E479EA7826788881A4434904289851E0422F24828BC93E1F067EFF8D803847011CB71C6F709D73482F407FE9C0A1E40AC13C2AE45084CE5DF71C54F519D1B12818A490013F7620551CCC40502E8F5A5C4853F84FC32C80407B7F7D7AE73C62841C57C600BD7219C0B4D34AA3D7A54E06B29F8D28FF103610FEB1870DF823005B939A36A7B5FCB8627C632AF122CA082446911ED09787C9ABBCAB3C50F72B85BBA129D99F9CC589D3A74E23EAA84482A5CC73E6B3465D2ECDBE5EE1CE0C8E9DE765432068965FE1D39D384E944C28443A2256147CE5D326734F815D60FE20BF0094F18AB2B8D6AE35AE3037EBA932206A9D7F7B0C84D9985AEE335E53C5BB014ABC96456CEB83E3D719D1B3C9CCC19949CA879C4D742C22FC041120DE11DD11A24371890DADC3ADD3AEB4644509C8624C4F0729D6BB2BA02BED4CF13F73DC6D3255D41587CC81578E414831165B44C60D719670128251E5063561CF5490806847798B61DEA9C6832252151182F05167E83076ACCD813EC8A4654C3159DA3EF0222A61242AA2B5808686434BE93F8579E87DEBB8E1F107342D7B558C7DD9017BA4C6FC93AF80EE48222F23DB074593DD338CB0B05739F8A2D975244F782554191AF3CF9229181B93AD1B9FC40E4127453A5B15745DAD6F82B0E3F34FC32F9EFD1F736A24FD317B15FDC6D22CA1986714053CB9B99BAA06B53910B1E3ADBB99B195EE33D9A8F54A0315E3E9E3F717F6A59B711B4607C0DB4E071137338181CDBF6D62C6B4706B6019A50BCE3DC68F31B56BAAB3E6129CF6344E5B7636B6F007DD04DFF29D7A93C6E7BA4E58026446664174261BE0550B3B5A54899776A9BBA33931D7C3B2FBBD4BB6EB5D71BA6B8DE1A4C69B91DE24D0B3B885DDE68D5D179594B57B47EDE86DE6F7C4DE218E3B4D60BE65F1C3F6B04A7EFFCFD5BA228C3F002D5D11995DA962761D6214BB0560D3143B8A452695326E7C484F5348C3AB6E5FCDD40ACE2188BA2EDAB2AF8560898BF33A19DDD70496F0BB5F2274A2D234CA3A9B5D0664F5B32EDCB0923B223A34F054B22BEA92A6C93CE72745D3EFBD21FA1D1FFD4811A0BFDF19A4D501DB0B9D21F71532754C7DEB4A77DCAD8B3AED0668ED7A28E15C036157B11B54807AFCBD3EE74D783A69B04DF2C4BB33EA1C1CFECD3B7BFE16602EFCC4765A53A20E994B23D538BA94A96B7BAAB53DB513DAFBABB54678E2A8FDE5BABBCF41EACD59EFA605DC194609AC39932FD65D95BF6B1D5AEDA6D5EB48AB7BDA5646559C4AD623DCE0BE7EE694EAB92665BCC6350BCD0D054517FAD344403B361E0FFCEA68C621C541BAE09A70B503A7BC0B827C3E3136B02F476A6319E5221EB3792F9E68F306A9CBAF399B5E7CBBFFEEE7A21327826B2F5F0AA200F9C71CCA97E95F9468836EBD79F6F4482C3FE9EABC2B7763DAD67D08C87B09AB85F53A19133FBEDA9903B726E2546C7C8193A7F6EF7F1BED38AEFCCDCC0CCFAFB7F37275FFDEDDFE4CB5EEFF2AEF7E0615303BC7390E64A08C3F281D18505A4D5B4DC49CA031A13D6D4BC5D3EFB30C978B204B457CE21066E2862D9D6EFA8CDCD42896B917A97F97B0F40EC7766AF29C7B62147565F31D9CDCD0D67ECDC6F02B26500D205FE3F0D479ABAD61F0A3D66215D4394FF66FAD16E949044B5FF1C43062BBAAC204CEFC72168D0A7DC33E30B51F0D8D2A8D862E5AC6BD058043539939A2E48A071D9D4D7743EFA99B0C434FBD11CC219BF4D749C683419A2396BCC5B4D346C3B3F1DF134751EDFC6E938FE354C4035A9A9DCB7FC53425958EA7DD9917237409830CB4B8BB94B6D4ACC725D22DD6001EF0794BBAFCC0E0FE69D8460EA96FBE4050ED1ED51C1152C49B02EFADDCD20BB2FA2E9F6F139254B7CBDA91CA392C79FC8E1305A7DF8176E7C0136231E0000 , N'6.1.3-40302')
