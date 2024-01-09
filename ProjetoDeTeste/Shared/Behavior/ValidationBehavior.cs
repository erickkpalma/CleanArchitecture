using Domain.Entities;
using FluentValidation;
using FluentValidation.Results;
using System.ComponentModel.DataAnnotations;
using static Aplication.Shared.Behavior.ValidationBehavior;

namespace Aplication.Shared.Behavior
{
    public class ValidationBehavior : IValidateData
    {
        public MotoristaDTO ValidateData(string nome, string Codmot, string Codpad, string Codfil, string Codmun, string Veicfix)
        {

            var motorista = new MotoristaDTO
            {
                NOMEMOTORISTA = nome,
                CODIGOMOTORISTA = Int32.Parse(Codmot),
                CODIGOMUNICIPIO = Int32.Parse(Codmun),
                CODIGOFILIAL = Int32.Parse(Codfil), 
                CODPAD = Int32.Parse(Codpad),
                VEICULOFIXO = Veicfix,
                DATADEATUALIZACAO = DateTime.Now,   
                USUARIODEATUALIZACAO = "RodmotService"

            };

            var validator = new UsuarioValidator();
            var results = validator.Validate(motorista);

            if (results.IsValid)
            {
                return motorista;
            }
            else
            {
                IList<ValidationFailure> failures = results.Errors;
                foreach (var failure in failures)
                {
                    Console.WriteLine($"Propriedade: {failure.PropertyName}, Erro: {failure.ErrorMessage}");
                }
                return null;
            }
        }

        public class UsuarioValidator : AbstractValidator<MotoristaDTO>
        {
            public UsuarioValidator()
            {
                RuleFor(usuario => usuario.NOMEMOTORISTA).NotEmpty().WithMessage("O nome do motorista é obrigatório.");
                RuleFor(usuario => usuario.CODIGOMOTORISTA).NotEmpty().WithMessage("O codigo do motorista é obrigatório.");
                RuleFor(usuario => usuario.CODIGOFILIAL).NotEmpty().WithMessage("A Filial é obrigatória.");
                RuleFor(usuario => usuario.CODPAD).NotEmpty().WithMessage("O Codpad é obrigatório.");
                RuleFor(usuario => usuario.CODIGOMUNICIPIO).NotEmpty().WithMessage("O codigo do municipio é obrigatório.");
                RuleFor(usuario => usuario.VEICULOFIXO).NotEmpty().WithMessage("O veiculo é obrigatório.");
            }
        }


        public interface IValidateData
        {
            MotoristaDTO ValidateData(string nome, string Codmot, string Codpad, string Codfil, string Codmun, string Veicfix);
        }
    }
}
