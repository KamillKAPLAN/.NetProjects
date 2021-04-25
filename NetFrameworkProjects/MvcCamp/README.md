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

☑️ Writer(1) - Heading(n) ilişkilendirilmesi bundan dolayı aşağıdaki gibi bir kod tanımlaması yapılacaktır.

☑️ **Örnek İlişki**
   ``` 
    Writer.cs (1)
         /* Heading tablosu ile 1 - n ilişki tanımlama */
         public ICollection<Heading> Headings { get; set; }
    Heading.cs (n)
         /* Writer tablosundaki ilişkili oldugu WriterId değerini almak için tanımlandı. */
         public long WriterId { get; set; }
         public virtual Writer Writer { get; set; }
   ```

## 8. Ders Video Notlarım - `Key Ve String Length Attributeleri`

☑️ `[Key] ve [StringLength(100)] Attribute` : Biz şimdiye kadar sınıflarımızın tamamını tanımladık. Ama tanımlamış olduğumuz `property'lere` herhangi bir kısıtlama uygulamadık. Kısıtlama uygulanmaması bunların `VeriTabanında` çok büyük veri aralıkları ile kaydedilmesine sebebiyet verir.

☑️ `IMPORTANT`: Bütün sınıflarda tanımlanan Id 'lerin Key olarak atanması gerekmektedir. **Key = Primary Key (Birincil Anahtar)** Her sınıfta muhakkak bir **Key**  olmalı, çünkü bu Key'ler **RelationShip(İlişki)** için kullanılacaktır.

☑️  **[Key]** kullanabilmek için **System.ComponentModel.DataAnnotations.dll** dahil edilmeli veya **EntityFramework** paketi yüklenmelidir.

## 9. Ders Video Notlarım - `Context Sınıfı`

☑️ `Context Sınıfı` : veritabanına tabloları yansıtmak için kullandığımız sınıf. `DataAccessLayer` katmanında tanımlanır.

☑️ `Context` sınıfının içerisinde tanımlayacağımız property'ler birer tablo ismi olarak SQL'de karşılık bulacaktır. Bu işlem için `DataAccessLayer` katmanı içerisine `EntityFramework 6` paketini kurmamız gerekmektedir.

☑️ **Refrences**
  ``` 
    Başka bir katmanın metotlarını, propertylerini, sınıflarını kullanmak istersek. O katmanın kullanmak istediğimiz yere `Refences` olarak eklemek zorundayız. 
  ```

☑️ `Context` sınıfı içine yazılmış olan DbSet türündeki propert'leri SQL'e birer tablo olarak yansıtılacaktır.

☑️ `IMPORTANT`: VeriTabanı işlemleri bittikten sonra `CRUD` operasyonları için `Repository Design Pattern` kullanacağız.

## 10. Ders Video Notlarım  - `Web Config Yapılandırması ve Bağlantı Ayarı`

☑️ `IMPORTANT`: bu bölümde `Web.config` ayarını gerçekleştiriyoruz. Bu dosya proje ile ilgili bazı yapılandırma ayarlarının yapıldığı kısımdır. Mesela projemizin veri tabanı bağlantı adresi burada tanımlanıyor. Projemizde 404 sayfası ile ilgili ayarlar, projenin oturum ayarları, yetkilendirme ayarları buranın üzerinde gerçekleştiriliyor.

☑️ `name            `: bu isim tablolarımızın veriTabanına yansıtılacağı sınıfın ismi ile aynı olmak zorundadır. 

☑️ `initial catalog `: burası veritabanı ismimizin tutulacağı kısımdır. 	

☑️ `providerName    `: sağlayıcı ismidir. Bizim burada neyin üzerinde çalışacağımızı tanımlamamızı sağlar.

☑️ **Web.config**
   ```
     </system.web>
	<connectionStrings>
		<!-- name : bu isim tablolarımızın veriTabanına yansıtılacağı sınıfın ismi ile aynı olmak zorundadır. 
             initial catalog : burası veritabanı ismimizin tutulacağı kısımdır. 	
		     providerName : sağlayıcı ismidir. Bizim burada neyin üzerinde çalışacağımızı tanımlamamızı sağlar.
		-->
		<add name="Context" 
                     connectionString="data source=DESKTOP-QSMLA58\KAMILKAPLAN; 
                                       initial catalog=DbMvcKamp; integrated security=true;" 
	             providerName="System.Data.SqlClient" />
	</connectionStrings>	
    <runtime>
   ```

## 11. Ders Video Notlarım - `Migrations ve Veri Tabanının Oluşturulması`

☑️ `Migrations` : bu kavram bizim `Code First` yardımı ile oluşturmuş olduğumuz mimarideki değişiklikleri SQL'e yansıtmak için kullanacağımız bir bileşen olarak adlandırırız. `C# ile SQL arasındaki köprü` olarak adlandırabiliriz.

☑️ `View > Other Windows > Package Manager Console` öncelikle migration'ı aktif hale getirmemiz gerekmektedir yani proje içine bir migration eklememiz gerekmektedir. 

☑️ `Package Manager Console` : projemizin referanslarına veya NuGet paketleri içerisine istediğimiz herhangi bir paketi komutlarla kurmamızı sağlayan, komutlarla burada install işlemlerini sağlayan Visual Studio bileşeni olarak adlandırabiliriz. Migration oluşturma işlemi veya yönetimi buradan yapılır.

☑️ Bunu yapabilmek için `Package Manager Console` da veri tabanına yansıtnak için Context sınıfının bağlı olduğu katmanda yapılmalıdır. Bundan dolayı Default Project olarak DataAccessLayer seçilerek **`enable-migrations`** komutu çalıştırılır. 

☑️ Ardından `Migrations > Configuration.cs` dosyasında Migrations lar üzerinde değişiklik yapabilmek için **`AutomaticMigrationsEnable= true`**  olarak ayarlanmalıdır. 

☑️ Bunu yaptıktan sonra tekrar `Package Manager Console` da **`update-database`** komutuyla veri tabanına değişiklikleri yansıtacağız.

☑️ 1 Kategori(Categories) içinde 1'den fazla Başlık(Headings) yer alabilir. `( 1 - n )`

☑️ 1 Yazar(Writers) 1'den fazla Başlık(Headings)'a yazabilir. `( 1 - n )`

☑️ 1 Başlık(Headings)'ta 1'den fazla İçerik(Contents) olabilir. `( 1 - n )`

☑️ 1 Yazar(Writers) 1'den fazla İçerik(Contents) olabilir. `( 1 - n )`

## 12. Ders Video Notlarım - `Add Migration İşlemi` 
