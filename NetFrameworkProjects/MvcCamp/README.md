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

☑️ N Katmanlı mimari üzerinde **'Somut'** olarak tutulan ifadeler **"Concrete"** klasörü içerisinde tutuluyor.

☑️ N Katmanlı mimari üzerinde **'Soyut'** ifadelerde **"Abstract"** klasörü içerisinde tutuluyor. 

☑️ **`Somut`** : 5 duyu organımızla algıladığımız, **`Soyut`** : 5 duyu organımızla algılayamadığımız.

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

☑️ Bir önceki derste `Migration` hatası aldık bu hatanın sebebi aynı model için birden fazla `Foreign Key` bulunmasından dolayı Foreign Key'lerden birini `Nullable` yaparsak herhangi bir problem çıkmayacak.

☑️ `Nullable Type` : ilgili tip‘in değer aralığına ve karakteristiğine sahip olmakla birlikte ek olarak null değer de içerebilen yapılardır. **`public int? Value { get; set; }`** veya **`public Nullable<int> Valuee { get; set; }`** olarak kullanılır.

☑️ C# sınıfımızda yapmış olduğumuz değişiklikleri SQL'e yansıtmak için **`add-migration <migrationAdi>`** komutu çalıştırılır.

☑️ Yapılan değişiklikleri VeriTabanına yansıtmak için **`update-database`** komutu çalıştırılır.

☑️ /* Değişiklikleri kaydedersek burası gerçekleşecek. */ public override void Up() 

☑️ /* Değişiklikleri kaydetmezsek burası gerçekleşecek. */ public override void Down()

☑️ DataBase Diagram

<img src="https://github.com/KamillKAPLAN/.NetProjects/blob/main/ImagesForGitHub/DatabaseDiagram.png" />           

## 13. Ders Video Notlarım - `Örnek SQL Veri Girişleri` 

☑️ `Categories` tablosnuna veri girişi yapıldı.

☑️ `Writers` tablosuna veri girişi gerçekleştirildi.

☑️ `Headings` tablosuna veri girişi yapıldı.

☑️ `Contents` tablosuna data girişi gerçekleştirildi.

## 14. Ders Video Notlarım - `Abstract Ve Interface Bileşenleri` 

☑️ Bu derste `Abstract` ve `Interface` ifadeler ile çalışmaya başlayacağız. `CRUD` işlemlerinin temelini oluşturacağız. CRUD işlemlerinin temelini Interface'ler üzerinde oluşturacağız.

☑️ `Interface'ler` : sınıflara rehberlik edecek yapılar olarak düşünebiliriz. Interface 'ler içerisinde direkt olarak `property` veya `field` tanımlaması tercih edilen bir yöntem değildir. Onun yerine `metotlar` oluşturulur ve bu metotlar üzerinde işlemler gerçekleştirilir.

☑️ **`DRY (Don't repeat yourself)`** : yazılım kalıplarının tekrarlanmasını (code duplication) ve buna bağlı olarak ortaya çıkabilecek fazlalıkların / karmaşanın önlenmesini amaçlayan bir yazılım geliştirme ilkesidir.

☑️ **`ICategoryDal.cs`** içinda CRUD operasyonlarını gerçekleşeceği metotları tanımladık. Bundan sonra yeni bir sınıf oluşturup, oluşturacağımız bu sınıftada `ICategoryDal` içinde tanımlamış olduğumuz metotların görevlerini yazmamız gerekmektedir.

## 15. Ders Video Notlarım - `Repository Sınıfı Ve Metotların İçinin Doldurulması` 

☑️ Bir önceki derste tanımlamış olduğumuz **Interface** içindeki metotlara görevler tanımlamadık. Bu metotlara birer görev tanımı verilmelidir. **`Concrete\Repositories`** klasörünün içinde tanımlanacak.

☑️ **Repositories ** : CRUD işlemlerini gerçekleştirebilmek için yapılacak ifadeleri tutmak için kullanılır.

☑️ `EF` 'de değişikliklerin kaydedilmesi için **`SaveChanges()`** metodu kullanılır.

☑️ `ADO.NET` 'de değişikliklerin kaydedilmesi için **`ExecuteNonQuery()`** metodu kullanılır.

☑️ `EF` ve `ADO.NET` 
  ```
   SaveChanges() => ExecuteNonQuery(); --> Insert, Update, Delete Islemleri
   ToList()      => ExecuteReader();   --> Select Islemleri
 ```

## 16. Ders Video Notlarım - `IRepository Interface` 

☑️ **15.Derste yapılan çalışmalar yanlıştır. [Detay için](https://www.youtube.com/watch?v=yFSzJbSbLDI&list=PLKnjBHu2xXNNQJehhCg--CzQQMHXTsFAb&index=15)**

☑️ **`IRepository Interface`**
   ```
     /* T : bir Entity 'i karşılar, bir türdür. SQL 'den gönderilecek Entity class'ı */
     public interface IRepository<T>
     {
         /* CRUD */
        List<T> Gets();
        void Insert(T p);
        void Update(T p);
        void Delete(T p);
        List<T> GetById(Expression<Func<T, bool>> filter);
     }
   ```

## 17. Ders Video Notlarım - `Generic Interface` 

☑️ Generic Interface üzerine örnekler yapıldı. Bütün **`Entity'ler`** için Abstract klasörü içerisinde Interface tanımlaması gerçekleştirildi.

☑️ IAboutDal.cs, IContactDal.cs, IContentDal.cs, IHeadingDal.cs, IWriterDal.cs **`interface`** tanımları yapıldı.

## 18. Ders Video Notlarım - `Generic Repository` 

☑️ `Generic` bütün bileşenlerin tamamını kapsıyor diye ifade edebiliriz.

☑️ **`Generic Repository`** sınıfın sayesinde bütün sınıflardan, bütün interfacelerde geçerli olan mimari kuruldu.

☑️ **Constructor** : oluşturduğumuz sınıfın ismi ile aynı isimde olan metodun ismi `Constructor` metot'dur.

☑️ **`GenericRepository.cs`**
   ```
      public class GenericRepository<T> : IRepository<T> where T : class
      {
        Context c = new Context();
        DbSet<T> _object;
      
        /*
         * T değerine karşılık olarak gelecek sınıfı `constructor` - yapıcı metot ile bulacazki, _object 'e değer atalım.
         */
        public GenericRepository()
        {
           _object = c.Set<T>();
        }
        
        public void Delete(T p)
        { }
        
        public List<T> GetById(Expression<Func<T, bool>> filter)
        { }
      
        public List<T> Gets()
        { }
      
        public void Insert(T p)
        { }

        public void Update(T p)
        { }
      }
   ```

☑️ `Mimarinin Amacı` : Kod tekrarından kurtulmak, işlemlerin daha düzenli bir şekilde ilerlemesi, böl parçala yönet yaklaşımı ile proje geliştirmektir.

## 19. Ders Video Notlarım - `Business Layer` 

☑️ **`Business Layer`** : genellikle işin geçerliliğinin ve kuralların kontrolü yapılır. CRUD veya Find işlemleri gerçekleştirilirken gönderdiğimiz şartların sağlanıp sağlanmadığının kontrolü `BusinessLayer'da` yapılır.

☑️ **`BusinessLayer'a`** diğer katmanların referans olarak verilmesi gerekmektedir. `EntityLayer` ve `DataAccessLayer` katmanları **`References`** olarak verilir. Bununla beraber `NuGet` üzerinden `EntityFramework` yüklenmelidir.

☑️ **`EntityLayer'da`** : herhangi bir katman **`References`** verilmiyor.

☑️ **`DataAccessLayer'da`** : `EntityLayer` katmanı **`References`** verilir.

☑️ **`UI'da`** : `BusinessLayer`, `DataAccessLayer` ve `EntityLayer` katmanları **`References`** olarak verilir. Bununla beraber `NuGet` üzerinden `EntityFramework` yüklenmelidir.

## 20. Ders Video Notlarım - `Tablo Kullanımı (Sertifika Görev 1/4)` 

☑️ `CategoryController.cs` tanımı yapıldı ve Index.cshtml `View` oluşturuldu.

## 21. Ders Video Notlarım - `Bootstrap` 

☑️ **`Bootstrap`** : html tarafında daha güçlü arayüzler oluşturmak için kullanılan bir bileşendir.

☑️ **`Bootstrap`** ve **`Css`** daha güçlü arayüzler, daha güçlü tasarımlar elde edebilmek için kullanılıyor.

## 22. Ders Video Notlarım - `Kategorilerin Listelenmesi` 

☑️ Bu derste verileri `SQL` 'den çekeceğiz. Öncelikle `CategoryController.cs` dosyasına geliyoruz. Ardından `References` tan **`UI`** katmanına `BusinessLayer`, `DataAccessLayer` ve `EntityLayer` katmanlarını ekliyoruz. Bununla beraber `NuGet` üzerinden `EntityFramework` de eklenmelidir.

☑️ **`var`** veri tipi `int`, `double`, `bool`, `string` kısacası hepsini kapsar.

☑️ **`CategoryController.cs`**
   ```
    using BusinessLayer.Concrete;
    using System.Web.Mvc;

    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager();

        public ActionResult GetCategoryList()
        {
            var categoryValues = cm.GetAllBL();
            return View(categoryValues); /* categoryValues içindeki değerler View'e aktarılmış oldu. */
        }
    }
   ``` 

☑️ **@using EntityLayer.Concrete** : Html sayfasının içerisine `Concrete` dizinini dahil ettik.

☑️ **@model List<Category>** : Bir model oluşturuldu. `Model` verileri listelemek için kullanacağımız bileşendir. Html'de C# ifadelerini kullanabilmek için ilgili ifadenin başınq @ sembolü konulur. Html'de @ sembolünün ismi `Razor Syntax` olarak adlandılır.

☑️ **`GetCategoryList.cshtml`**
   ```
    @using EntityLayer.Concrete @* Html sayfasının içerisine `Concrete` dizinini dahil ettik. *@
    @model List<Category>
    @* Bir model oluşturuldu. `Model` verileri listelemek için kullanacağımız bileşendir. Html'de C#
        ifadelerini kullanabilmek için ilgili ifadenin başınq @ sembolü konulur. Html'de @ sembolünün ismi `Razor Syntax` olarak adlandılır.  *@

    @{
        Layout = null;
    }

    <link href="~/Content/bootstrap.min.css" rel="stylesheet" />
    <br />
    <table class="table table-bordered">
        <tr>
            <th>Id</th>
            <th>Name</th>
            <th>Açıklama</th>
            <th>Durum</th>
        </tr>
        @foreach (var item in Model)
        {
            <tr style="background: @(item.CategoryDescription != null ? "green" : "red"); color: white">
                <td>@item.CategoryId</td>
                <td>@item.CategoryName</td>
                <td>@(item.CategoryDescription != null ? item.CategoryDescription : " --- ")</td>
                <td>@item.CategoryStatus</td>
            </tr>
        }
    </table>
   ```

## 23. Ders Video Notlarım - `Break Point` 

☑️ Proje **`Break Point`** ile çalıştırıldı ve adımları teker teker incelendi.

## 24. Ders Video Notlarım - `Yeni Kategori Ekleme` 

☑️ **`CategoryController.cs`** içinde `AddCategory` metodu yazıldı ve  `AddCategory.cshtml` View sayfası oluşturuldu.

☑️ **`Atribute`** - `Araştırma` : uygulandıkları tiplerin (types) yada üyelerin (members) çalışma zamanındaki davranışlarının değiştirilmesine olanak sağlayan sınıflardır.

## 25. Ders Video Notlarım - `HttpGet ve HttpPost Attributeleri` 

☑️ **`CategoryController.cs`** içinde daha önce tanımlamış olduğumuz `ActionResult` metotlarınında `Attribute` tanımları yapıldı.	

☑️ **[HttpGet]** : sayfa yüklendiği zaman çalışacak `Attribute`

☑️ **[HttpPost]** : sayfada bir butona tıklandığında, sayfada bir şeyler post edildiği zaman çalışacak `Attribute`

## 26. Ders Video Notlarım - `Ekleme Hataları`

☑️ Video izlendi.

## 27. Ders Video Notlarım - `Business Abstract & ICategoryService`

☑️ Projeyi böl parçala yönet prensibi ile `SOLID'e` daha uygun  `Class` | sınıflarla ve bu sınıfların çıplak kalmaması için `Interface` tanımlanmalı ve bu sayede projeye olan hakimiyet artmaktadır.

☑️ Her sınıf ve her metot sadece kendisine verilen görevi gerçekleştirmelidir. Başka bir işlem yapmammalıdır, buda `SOLID'e` uygunluğu göstermektedir.

☑️ Projede yer alan bütün `tablolar` yada bütün `Class'lar` | `Sınıf'lar` için birer **`Manager`** sınıfı tanımlanacaktır. Manager sınıfında projenin doğruluğu ile ilgili kontroller sağlanır.

☑️ **`ICategoryService.cs`**
   ```
    namespace BusinessLayer.Abstract
    {
        public interface ICategoryService
        {
            List<Category> GetCategoryList();
        }
    }
   ```

## 28. Ders Video Notlarım - `Constructor Business Metot`

☑️ **BusinessLayer.Concrete > CategoryManager.cs** dosyasında `Constructor(Yapıcı Metot)` ile `DI` tekniği kullanıldı.

☑️ **`CategoryManager.cs`**
   ```
    namespace BusinessLayer.Concrete
    {
        public class CategoryManager : ICategoryService
        {
            /* Field */
            ICategoryDal _categoryDal;
    
            public CategoryManager(ICategoryDal categoryDal)
            {
                _categoryDal = categoryDal;
            }

            public List<Category> GetCategoryList()
            {
                return _categoryDal.Gets();
            }
        }
    }
   ```

☑️ **`Business`** tarafında olabildiğince `new` işlemi yapmaktan kaçınmalıyız ve projedeki bağımlılığı minimize hale getirmeliyiz.

☑️ **`Dependency Injection`** - `Araştırma` : bağımlılık oluşturacak parçaların ayrılıp, bunların dışardan verilmesiyle sistem içerisindeki bağımlılığı minimize etme işlemidir. Yani, temel olarak oluşturacağınız bir sınıf içerisinde **başka bir sınıfın nesnesini kullanacaksanız new anahtar sözcüğüyle oluşturmamanız gerektiğini söyleyen bir yaklaşımdır.** Gereken nesnenin ya Constructor’dan ya da Setter metoduyla parametre olarak alınması gerektiğini vurgulamaktadır. Böylece iki sınıfı birbirinden izole etmiş olduğumuzu savunmaktadır.

☑️ **`Dependency Injection`, bağımlılıkları soyutlamak demektir.** `DI` , aşağıdaki iki teknikle uygulanabilmektedir.
 - `Constructor` Injection(Constructor Based Dependecy Injection)
 - `Setter` Injection(Setter Based Dependency Injection)

## 29. Ders Video Notlarım - `Entity Framework Dal`

☑️ Katmanları, katmanlar içerisinde yer alan sınıfları birbirleri ile haberleştirdik bu sayede her katmanın yada her sınıfın veya her metodun içindeki komut sadece kendisine ait işlemleri gerçekleştirir.

☑️ **`EfCategoryDal.cs`**
   ```
    namespace DataAccessLayer.EntityFramework
    {
      public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
      {
      }
    }
   ```

☑️ **`CategoryController.cs`**
   ``` 
    CategoryManager cm = new CategoryManager(new EfCategoryDal());
   ```  

## 30. Ders Video Notlarım - `Fluent Validation`

☑️ Bu derste `doğrulama kuralları` oluşturuldu. Bu doğrulama kurallarını kullanabilmek için bir pakete ihtiyacımız var. Bunun için `BusinessLayer` katmanında `Manage NuGet Packages..` diyerek **FluentValidation** paketi yüklenmelidir.

☑️ `Validator` sınıfları içerisinde kullanacağımız doğrulama kurallarını bir `Constructor` metot içerisine yazmamız gerekmektedir.

☑️ **`CategoryValidator.cs`**
   ```
    namespace BusinessLayer.ValidationRules
    {
        public class CategoryValidator : AbstractValidator<Category> /* üzerinde çalıştığımız sınıfı gönderdik. */
        {
            /* `Validator` sınıfları içerisinde kullanacağımız doğrulama kurallarını bir `Constructor` metot içerisine yazmamız gerekmektedir. */
            public CategoryValidator()
            {
                /* RuleFor : kural için
                 * x => x. : AbstractValidator içerisine göndermiş olduğumuz T Entiy'sine erişim sağlıyoruz. */
                RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adını Boş Geçemezsiniz.");
                RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Lütfen En Az 3 Karakter Girişi Yapın");
                RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Lütfen 20 karakterden Fazla Değer Girişi Yapmayın");
                RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Açıklamayı Boş Geçemezsiniz.");
            }
        }
    }  
   ```  

## 31. Ders Video Notlarım - ``

☑️ 

## 32. Ders Video Notlarım - ``

☑️ 