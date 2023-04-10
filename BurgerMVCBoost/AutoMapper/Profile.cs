using AutoMapper;
using BurgerMVC.EntityLayer.Concrete;
using BurgerMVC.ViewModel;
using BurgerMVCBoost.ViewModel;

namespace BurgerMVCBoost.AutoMapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<AppUser, RegisterVM>().ReverseMap();
            CreateMap<AppUser, LoginVM>().ReverseMap();

        }
    }
}
