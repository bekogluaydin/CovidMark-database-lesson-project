# CovidMark-database-lesson-project

Veritabanı dersi ve Online Staj 1 Projesisi kapmasında geliştirmiş olduğum CovidMark adlı Market Alış-Veriş Otomasyonu.


## İçerikler
- Login Menu
- Main Menü
- Ürünler
- Firmalar
- Ürün Alış
- Stok Hareketleri
- Personel
- Kategoriler
- Satış Ekranı
- Faturalar

## Login Menu
Giriş Kısmı bizi bu şekilde karşılıyor. Kayıt olma yok. Sadece yetkili kişi tarafından otomasyon içerisinden "Personel Ekleme" işlemi yapılabiliyor.

<p align="center"> <img src="https://user-images.githubusercontent.com/51875713/148964805-c86e876f-6880-4e87-ae5e-144ed69e547b.png" width="550"></img></p>

## Main Menu
Sağ üst kısımda giriş yapan Personelin No'su. Sağ alt kısımda ise otomasyon sürümü yazmakta. Sürüm bilgisi Visual Studio içindeki "Version Control" kısmından alınmakta. Şuan giriş yapan personel Müdür olduğundan bütün yetkilere sahip. Bu yüzden otomasyon içindeki her şeyi kullanabiliyor.

<p align="center"> <img src="https://user-images.githubusercontent.com/51875713/148965742-11ad7322-6d68-49b9-a0d1-9851f7b397f6.png" height="410" width="730"></img></p>

Giriş yapan kişi "Kasiyer" olduğundan Satış Ekranı ve Faturalar hariç diğer özellikleri kullanamıyor.
<p align="center"> <img src="https://user-images.githubusercontent.com/51875713/148966428-4a3e8050-2991-4a79-adb1-2fa7db3a1834.png" height="410" width="730"></img></p>

## Ürünler
Ürünler kısmında;

1. Ürün Kayıt
2. ÜRün Sil
3. Ürün Güncelle

bu işlemler yapılabiliyor. Bunlara ek olarak "Temizle" butonu ile veri girişi yapılan yerler tek tuşla temizleniyor. Aşağıda ürünlerin gösterildiği kısım "dataview" ile oluşturulmuş olup bir ürüne tıklandığında otomatik olarak bilgileri giriş kısımlarına ekleniyor. Böylelikle hızlı bir şekilde ürün silinebiliyor veya güncellenebiliyor.

<p align="center"> <img src="https://user-images.githubusercontent.com/51875713/148967082-60129411-8173-4a38-89d0-2ffe8b808715.png" width="600"></img></p>


## Firmalar
Ürünler formunda olduğu gibi Firmalar formuda aynı şekilde işliyor.

1. Firma Kayıt
2. Firma Sil
3. Firma Güncelle
tek farkı Firma eklenip çıkarılması.
 
<p align="center"> <img src="https://user-images.githubusercontent.com/51875713/148968231-0411a3fe-9a21-45ae-a774-1eb19b35fdf2.png" width="600"></img></p>


## Ürün Alış
Ürün ALış formunda, Firmalar kısmında bulunan firmalardan depoya yeni ürünler alınıyor. Bu kısımda aynı anda birden fazla ürün alınabiliyor fakat sadece tek firmadan alış yapılması gerekiyor. Bunun nedeni Alış tamamlanırken fatura istenip istenilmediği soruluyor. Eğer Fatura istenilirsa ürün alan firma adına fatura kesimi yapılıyor.

Örneğin fotoğrafta görüldüğü üzere Coco Cola firmasında "Sherlock Holmes" kitabı alınmış.


<p align="center"> <img src="https://user-images.githubusercontent.com/51875713/148969124-5d253b3f-fc17-4ce8-8d76-a51ae8b7e01a.png" height="410" width="730"></img></p>

## Stok Hareketleri
Stok hareketleri formunda Alınan veya Satılan ürünlere göre stok hareketini kontrol etmek mümkün.

<p align="center"> <img src="https://user-images.githubusercontent.com/51875713/148969723-652a7330-57b7-48fa-a7a4-fed76e1ceb78.png" width="600"></img></p>

Arama Türüne görede stok hareketini kontrol etmek mümkün;
1. Vergi No
2. Personel No
3. Ürün Barkod

<p align="center"> <img src="https://user-images.githubusercontent.com/51875713/148970088-c067c4ae-2378-4641-9673-2bed9eaaf89d.png" width="600"></img></p>

## New Additions and Modifications
Improvements and modifications were made to the User Interface. & Design adjustments were made and 3 winter maps were added to the game.
