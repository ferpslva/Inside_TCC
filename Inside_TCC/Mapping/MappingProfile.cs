using AutoMapper;
using Dominio.DTOs;
using Dominio.Entidade;

namespace Inside_TCC.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Alunos, AlunoDTO>().ReverseMap();
            CreateMap<Plano, PlanoDTO>().ReverseMap();
            CreateMap<Tamanho, TamanhoDTO>().ReverseMap();
            CreateMap<Tipo_Produto, Tipo_ProdutoDTO>().ReverseMap();
            CreateMap<Vinculo, VinculoDTO>().ReverseMap();
            CreateMap<Modalidade, ModalidadeDTO>().ReverseMap();
            CreateMap<Professores, ProfessorDTO>().ReverseMap();
            CreateMap<Graduacao, GraduacaoDTO>().ReverseMap();
            CreateMap<Produto, ProdutoDTO>().ReverseMap();
            CreateMap<Matricula, MatriculaDTO>().ReverseMap();
        }
    }
}