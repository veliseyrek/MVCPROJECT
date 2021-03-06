using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adını adını boş geçemezsiniz.");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazar soyadını kısmını boş bırakamazsınız.");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkımda kısmını kısmını boş bırakamazsınız.");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Başlık  kısmını boş bırakamazsınız.");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az 3 karakter girişi yapınız.");
            RuleFor(x => x.WriterSurName).MaximumLength(50).WithMessage("Lütfen 20 karakterden fazla değer girmeyiniz.");
        }
    }
}
