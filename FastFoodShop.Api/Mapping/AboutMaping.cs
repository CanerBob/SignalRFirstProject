using AutoMapper;
using Dtos.Layer.AboutDto;
using Models.Layer.Entities;

namespace FastFoodShop.Api.Mapping;
public class AboutMaping:Profile
{
    public AboutMaping()
    {
		CreateMap<About, ResultAboutDto>().ReverseMap();
		CreateMap<About, GetAboutDto>().ReverseMap();
		CreateMap<About, CreateAboutDto>().ReverseMap();
		CreateMap<About, UpdateAboutDto>().ReverseMap();
	}
}