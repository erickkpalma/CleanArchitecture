using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Aplication.Shared.Behavior.UserService;
using static Persistence.Repository.UserRepository;

namespace Aplication.Shared.Behavior
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private IMapper _mapper;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<MotoristaDTO, RodmotDTO>()
                    .ForMember(dest => dest.NOMMOT, opt => opt.MapFrom(src => src.NOMEMOTORISTA))
                    .ForMember(dest => dest.CODMOT, opt => opt.MapFrom(src => src.CODIGOMOTORISTA))
                    .ForMember(dest => dest.CODPAD, opt => opt.MapFrom(src => src.CODPAD))
                    .ForMember(dest => dest.CODFIL, opt => opt.MapFrom(src => src.CODIGOFILIAL))
                    .ForMember(dest => dest.CODMUN, opt => opt.MapFrom(src => src.CODIGOMUNICIPIO))
                    .ForMember(dest => dest.VEICFIX, opt => opt.MapFrom(src => src.VEICULOFIXO))
                    .ForMember(dest => dest.DATATU, opt => opt.MapFrom(src => src.DATADEATUALIZACAO))
                    .ForMember(dest => dest.USUATU, opt => opt.MapFrom(src => src.USUARIODEATUALIZACAO));
            });

            _mapper = config.CreateMapper();
        }


        public void SalvarUsuario(MotoristaDTO motorista)
        {
            var processado = ProcessarDto(motorista);
            _userRepository.SalvarUsuario(processado);
        }

        private RodmotDTO ProcessarDto(MotoristaDTO person)
        {
            var personDTO = _mapper.Map<RodmotDTO>(person);
            return personDTO;
        }

        public interface IUserService
        {
            void SalvarUsuario(MotoristaDTO motorista);
        }
    }
}