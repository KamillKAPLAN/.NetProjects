# .NETFRAMEWORK MVC PROJE NOTLARI
 
## 1. ve 2. Ders Video Notlarım - `Giriş Projenin Oluşturulması ve View Controller Ve Layout Kavramları`

☑️ User Interface, Presentation Katmanı

☑️ `Model` : işin veritabanına ait Entity dediğimiz kavramların tanımlandığı kısımdır.

☑️ `View` : işin tasarımlarının olduğu alan yani FrontEnd bölümüdür.

☑️ `Controller`: işin BackEnd tarafıdır yani C# kodlama alanıdır.

☑️ İşin `BackEnd` yani `Controller` tarafında veya Class 'larda bir değişiklik gerçekleştirirsek, projemizi yeniden dermemmiz gerekmektedir.

## 3. Ders Video Notlarım - `Katmanların Oluşturulması`

☑️ (1) `Entity Layer` : projenin SQL tarafındaki tablolarının ve bu tabloların içerisinde yer alacak sütunların C# tarafında tanımlanacağı Class ve Property olarak gelecek yapıyı tutacak kısımdır.

☑️ (2) `Data Access Layer` : veri erişim katmanı olarak geçmektedir. CRUD dediğimiz işlemlerin temeli burada tanımlanacaktır. 

☑️ (3) `Business Layer` : iş katmanı olarak çevirebiliriz. Veri tabanı işlemlerini Presentation katmanına yansıtmadan önce bu katmanda çalışılır.

☑️ (4) `Presentation (Sunum)` : User Interface Katmanı
 
 ☑️  `IMPORTANT` Geliştirme yaklaşımı olarak EntityFramework `CodeFirst` yaklaşımı kullanılacak.
 
## 4. Ders Video Notlarım - `Entity Katmanı Sınıflarının Oluşturulması`

☑️  `Entity 'lerin Oluşuturulması` - Tablolar : Heading, Content, Writer, Category, About, Contact

☑️ N Katmanlı mimari üzerinde 'Somut' olarak tutulan ifadeler "Concrete" klasörü içerisinde tutuluyor.

☑️ N Katmanlı mimari üzerinde 'Soyut' ifadelerde "Abstract" klasörü içerisinde tutuluyor. 

☑️ `Somut` : 5 duyu organımızla algıladığımız, `Soyut` : 5 duyu organımızla algılayamadığımız.

☑️ Bir sınıfa diğer alanlardan, katmanlardan, sınıflardan vs erişim sağlayabilmek için `Access Modify` dediğimiz erişim belirleyici türü olarak `public` yazmamız gerekmektedir.

## 5. Ders Video Notlarım - `Category About Contact Sınıfları`

☑️ Category, About, Contact class'ları eklendi.

## 6. Ders Video Notlarım - `İlişkilerin Oluşturulması 1`

☑️ İki tablo arasında `1 - n` ilişki kurmak için `ICollection<T>` türünde bir property tanımlıyoruz. 

☑️ Ardından ilişki kurduğumuz tablonun anahtar sütunuyla aynı isimde bir property oluşturuyoruz. 

☑️ Fakat bununlada bitmiyor ikinci bir property tanımlıyoruz, bu sefer `Access Modify` olarak virtual anahtar kelimesini ve ilişki kurduğumuz tablo adını ve ismini yazıyoruz.

☑️ virtual ifadesini kullandıktan sonra programa şunu diyoruz. Biz bir sınıftan değer alacaz.

## 7. Ders Video Notlarım - `İlişkilerin Oluşturulması 2`

☑️ 
