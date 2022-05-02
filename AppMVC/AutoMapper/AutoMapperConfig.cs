using AppMVC.ViewModels;
using AutoMapper;
using Businiss.Model;

namespace AppMVC.AutoMapper
{
    public class AutoMapperConfig: Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Endereco, EnderecoViewModel>().ReverseMap();
            CreateMap<Fornecedor, FornecedorViewModel>().ReverseMap();
            CreateMap<Produto, ProdutoViewModel>().ReverseMap();
        }
    }
}
