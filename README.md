# ADO.NET ile Basit Console Uygulaması

Bu proje,Db First yaklaşımı ve C# ile ADO.NET kullanarak SQL Server veritabanına bağlanan, temel veritabanı işlemlerini (INSERT, DELETE, SELECT, UPDATE ve JOIN) gerçekleştiren bir **konsol uygulamasıdır**.

## 🔧 Kullanılan Teknolojiler

- .NET (C#)
- ADO.NET
- SQL Server
- Console App (.NET Framework)

## 🎯 Projenin Amacı

Bu proje, aşağıdaki temel ADO.NET kavramlarını öğrenmek ve göstermek amacıyla oluşturulmuştur:

- SQL Server'a bağlantı kurma (`SqlConnection`)
- SQL sorgusu çalıştırma (`SqlCommand`)
- Parametreli sorgular ile veri ekleme, silme, güncelleme, listeleme
- `SqlDataReader` ile veri okuma
- `ExecuteNonQuery`, `ExecuteReader` gibi metotların kullanımı

## 🗂️ İçerik

Projede yer alan başlıca işlemler:

- Yeni müşteri ekleme
- Müşteri bilgilerini güncelleme
- Müşteri silme
- Müşteri listesini getirme
- Ürün ve Kategori Tabloları arasında ilişkiyi kullanarak listeleme

## 🚀 Nasıl Çalıştırılır?

1. SQL Server üzerinde `Customer` ,`Product` ve `Category` adında bir tablo oluşturun
2. Product ve Category tabloları arasında "Database Diagrams" seçeneği ile ilişki kurun
3. Console uygulamasındaki "YoureConnectionString" alanına kendi veritabanı bağlantı kodunu ekleyin
4. Metotları çalıştırabilirsiniz.
);
