using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuesinessLayer.ValidationRules
{
	public class WriterValidator:AbstractValidator<Writer>
	{
		public WriterValidator()
		{

			RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adını boş geçemezsiniz.");
			RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Yazar adı en az 2 karakterden oluşabilir.");

			RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazar soyadını boş geçemezsiniz.");
			RuleFor(x => x.WriterSurName).MinimumLength(2).WithMessage("Yazar soyadı en az 2 karakterden oluşabilir.");

			RuleFor(x => x.WriterMail).EmailAddress().WithMessage("Lütfen mail formatında giriş yapınız.");
			RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Yazar mail adresini boş geçemezsiniz.");

			RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Yazar açıklamasını boş geçemezsiniz.");
			RuleFor(x => x.WriterAbout).MinimumLength(10).WithMessage("Yazar hakkında en az 10 karakterden oluşabilir.");

			RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Yazar şifresini boş geçemezsiniz.");

			RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Yazar ünvanını boş geçemezsiniz.");

		}
	}
}
