using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator :AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(p => p.WriterName).NotEmpty().WithMessage("Yazar adı soyadı boş geçilemez.");
            RuleFor(p => p.WriterMail).NotEmpty().WithMessage("Mail adresi boş geçilemez");
            RuleFor(p => p.WriterName).MinimumLength(2).WithMessage("En 2 karakter giriniz");
            RuleFor(p => p.WriterMail).MaximumLength(50).WithMessage("En fazla 50 karakter olmalıdır");

            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre Boş Geçilemez")
                .MinimumLength(8).WithMessage("Şifre 8 karakterden küçük olamaz.")
                .MaximumLength(16).WithMessage("Şifre 16 karakterden büyük olamaz.")
                .Matches(@"[A-Z]+").WithMessage("Şifrede en az bir büyük harf olmalıdır.")
                .Matches(@"[a-z]+").WithMessage("Şifrede en az bir küçük harf olmalıdır.")
                .Matches(@"[0-9]+").WithMessage("Şifrede en az bir rakam olmalıdır");
        }
    }
}
