using AutoMapper;
using Dtos.Layer.FeatureDto;
using Models.Layer.Entities;

namespace FastFoodShop.Api.Mapping;
public class FeatureMapping:Profile
{
    public FeatureMapping()
    {
		CreateMap<Feature, CreateFeatureDto>().ReverseMap();
		CreateMap<Feature, UpdateFeatureDto>().ReverseMap();
		CreateMap<Feature, GetFeateureDto>().ReverseMap();
		CreateMap<Feature, ResultFeatureDto>().ReverseMap();
	}
}