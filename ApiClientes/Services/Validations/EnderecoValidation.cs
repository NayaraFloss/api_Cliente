using FluentValidation;
using ApiClientes.Services.DTOs;
using System;

namespace ApiClientes.Services.Validations
{
    public class EnderecoValidation : AbstractValidator<CriarEnderecoDTO>
    {
        public EnderecoValidation()
        {
            RuleFor(x => x.Logradouro).NotEmpty().WithMessage("Logradouro é obrigatório");
            RuleFor(x => x.Numero).NotEmpty().WithMessage("Número é obrigatório");
            RuleFor(x => x.Bairro).NotEmpty().WithMessage("Bairro é obrigatório");
            RuleFor(x => x.Cidade).NotEmpty().WithMessage("Cidade é obrigatória");
            RuleFor(x => x.Uf).NotEmpty().WithMessage("UF é obrigatória");
        }

        internal static void ValidarCriarEndereco(CriarEnderecoDTO dto)
        {
            //EnderecoValidation();
        }
    }
}
