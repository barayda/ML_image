# ML_image
Bu proje, Windows Forms uygulaması kullanarak iki görüntü arasındaki benzerliği hesaplayan bir Image Similarity Matching aracıdır.
ML.NET kullanarak her iki resmi sayısal vektöre dönüştürür ve Cosine Similarity yöntemiyle benzerlik oranını hesaplar.
📌 Özellikler :
 Kullanıcı iki farklı görüntüyü seçebilir
 ML.NET pipeline ile görüntülerden feature vector (embedding) çıkarılır
 Cosine Similarity ile benzerlik yüzdesi hesaplanır
 Basit ve anlaşılır WinForms arayüzü
 Gerçek zamanlı hızlı sonuç
.NET 6 / .NET 7 / .NET 8 uyumlu

🛠️ Kullanılan Teknolojiler :
C# (.NET 6/7/8)
Windows Forms
ML.NET
Microsoft.ML
Microsoft.ML.ImageAnalytics

🧩 Çalışma Mantığı :
Kullanıcı iki resmi yükler
ML.NET pipeline şu adımları uygular:
Görüntüyü yükleme
64×64 boyutuna yeniden ölçekleme
Piksel değerlerini float[] vektörüne dönüştürme
Her iki görüntü için embedding vektörleri üretilir
Cosine Similarity ile benzerlik oranı hesaplanır
Sonuç yüzde olarak ekranda gösterilir

🔢 Benzerlik Hesaplama : 
Cosine Similarity formülü :
similarity= A.B / ∥A∥⋅∥B∥
Sonuç 0 ile 1 arasında olur; bu değer yüzdeye çevrilerek kullanıcıya sunulur.

📥 Projeyi Klonlama : 
git clone https://github.com/kullaniciAdi/ML-image-match.git
