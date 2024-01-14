using AutoMapper;
using Dtos.Layer.SocialMediaDto;
using Models.Layer.Entities;

namespace FastFoodShop.Api.Mapping;
public class SocialMediaMapping:Profile
{
    public SocialMediaMapping()
    {
		CreateMap<SocialMedia, CreateSocialMediaDto>().ReverseMap();
		CreateMap<SocialMedia, GetSocialMediaDto>().ReverseMap();
		CreateMap<SocialMedia, UpdateSocialMediaDto>().ReverseMap();
		CreateMap<SocialMedia, ResultSocialMediaDto>().ReverseMap();
	}
}