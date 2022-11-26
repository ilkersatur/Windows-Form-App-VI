CREATE DATABASE KitapDB
GO
USE KitapDB
GO
CREATE Table Kategoriler(KategoriID int IDENTITY PRIMARY KEY,
                         KategoriAdi varchar(30))
CREATE TABLE Yazarlar(YazarID int IDENTITY PRIMARY KEY,
                      YazarAdi varchar(50))
GO
CREATE TABLE Kitaplar(KitapID int IDENTITY PRIMARY KEY,
                      KitapAdi varchar(200),
					  YazarID int REFERENCES Yazarlar(YazarID),
					  KategoriID int REFERENCES Kategoriler(KategoriID),
					  Fiyat money,
					  KapakResmi varchar(100),
					  EklendigiTarih smalldatetime)