using EntityLayer.Concrete;
using FluentValidation;

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
