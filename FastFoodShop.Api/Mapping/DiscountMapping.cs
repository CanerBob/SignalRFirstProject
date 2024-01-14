using AutoMapper;
using Dtos.Layer.DiscountDto;
using Models.Layer.Entities;

namespace FastFoodShop.Api.Mapping;
public class DiscountMapping:Profile
{
    public DiscountMapping()
    {
		CreateMap<Discount, CreatedDiscountDto>().ReverseMap();
		CreateMap<Discount, GetDiscountDto>().ReverseMap();
		CreateMap<Discount, ResultDiscountDto>().ReverseMap();
		CreateMap<Discount, UpdateDiscountDto>().ReverseMap();
	}
}