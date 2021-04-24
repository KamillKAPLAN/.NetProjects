# .NETFRAMEWORK MVC PROJE NOTLARI
 
## 1. ve 2. Ders Video Notlarım - `Giriş Projenin Oluşturulması ve View Controller Ve Layout Kavramları`

 ☑️ User Interface, Presentation Katmanı

 ☑️ `Model` : işin veritabanına ait Entity dediğimiz kavramların tanımlandığı kısımdır.

 ☑️ `View` : işin tasarımlarının olduğu alan yani FrontEnd bölümüdür.

 ☑️ `Controller`: işin BackEnd tarafıdır yani C# kodlama alanıdır.

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

 ☑️ Bir sınıfa diğer alanlardan, katmanlardan, sınıflardan vs erişim sağlayabilmek için 'Access Modify' dediğimiz erişim belirleyici türü olarak "public" yazmamız gerekmektedir.

