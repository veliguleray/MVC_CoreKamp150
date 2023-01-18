using Entitylayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer.ValidationRules
{
    public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator() 
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("blog baslıgı kısmı boş geçilemez");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("blog içerik boz olamaz");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("blog gorselını boş geçilemez");
            RuleFor(x => x.BlogTitle).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapınız");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Lütfen en fazla 150 karakter girişi yapınız");

        }

    }
}
