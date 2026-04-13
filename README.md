# 🏥 Hastane Yönetim Sistemi (Proje_Hastane)

C# Windows Form ve SQL Server kullanılarak geliştirilmiş kapsamlı bir hastane yönetim otomasyonudur. Bu uygulama; hastaların randevu almasını, doktorların kendi randevularını yönetmesini ve yönetici (sekreter) işlemlerini kolaylaştırmayı amaçlar.

## 🚀 Özellikler

- **Hasta Modülü:** Kayıt olma, randevu alma, geçmiş randevuları görüntüleme ve bilgileri güncelleme.
- **Doktor Modülü:** Kendisine atanan randevuları görme, randevu detaylarını inceleme ve duyuruları takip etme.
- **Sekreter Modülü:** Doktor ve branş yönetimi, duyuru oluşturma, randevu paneli yönetimi.
- **Güvenli Giriş:** TC Kimlik ve şifre ile modüllere özel giriş sistemi.
- **Dinamik Veri:** SQL Server entegrasyonu ile tüm veriler anlık olarak işlenir.

## 🛠 Kullanılan Teknolojiler

- **Dil:** C#
- **Platform:** .NET Framework
- **Veritabanı:** MS SQL Server
- **Mimari:** ADO.NET (Manuel SQL Bağlantı Yönetimi)

## ⚙️ Kurulum ve Çalıştırma

Projeyi yerel bilgisayarınızda çalıştırmak için aşağıdaki adımları izleyin:

1. **Projeyi Klonlayın:**
   ```bash
   git clone [https://github.com/brknfk/Hastane-Yonetim-Sistemi.git](https://github.com/brknfk/Hastane-Yonetim-Sistemi.git)

   
2. Veritabanı Kurulumu:

  -Proje klasöründeki SQL dosyalarını SQL Server üzerinde çalıştırarak veritabanını oluşturun.

3.Bağlantı Ayarları:

  -Proje ana dizinindeki App.config.example dosyasının adını App.config olarak değiştirin.

  -connectionString kısmına kendi yerel SQL Server bağlantı adresinizi yazın.
  
4.Derleme:

  -Visual Studio ile .sln dosyasını açın ve projeyi derleyip çalıştırın.
