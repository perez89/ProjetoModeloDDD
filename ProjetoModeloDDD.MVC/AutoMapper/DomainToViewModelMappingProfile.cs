using AutoMapper;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.MVC.ViewModels;
using System.Collections.Generic;

namespace ProjetoModeloDDD.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName {
            get { return "DomainToViewModelMappingProfile"; }
        }

        protected override void Configure() {
            Mapper.CreateMap<Cliente, ClienteViewModel>();
            Mapper.CreateMap<Produto, ProdutoViewModel>();
            //Mapper.CreateMap<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>();
            //Mapper.CreateMap<IEnumerable<Produto>, IEnumerable<ProdutoViewModel>>();
        }
    }
}