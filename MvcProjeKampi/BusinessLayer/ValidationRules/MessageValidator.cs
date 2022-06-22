using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class MessageValidator : AbstractValidator<Message>
    {
         public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Alıcı adını boş geçemezsiniz.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konuyu boş bırakamazsınız.");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Açıklama kısmını boş bırakamazsınız.");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız.");
            RuleFor(x => x.Subject).MaximumLength(20).WithMessage("Lütfen 100 karakterden fazla değer girmeyiniz.");
        }
    }
}
