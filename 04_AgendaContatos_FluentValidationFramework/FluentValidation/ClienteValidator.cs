using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace FluentValidation
{
    public  class ClienteValidator : AbstractValidator<Cliente>
    {
        public ClienteValidator()
        {
            RuleFor(a => a.Nome).NotEmpty().WithName("Nome do cliente").WithMessage("{PropertyName} deve ser preenchido!");
            RuleFor(a => a.SobreNome).NotEmpty().WithName("Sobrenome do cliente").WithMessage("{PropertyName} deve ser preenchido!");
        }
    }
}
