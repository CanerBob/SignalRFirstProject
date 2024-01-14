using AutoMapper;
using Dtos.Layer.TestimonialDto;
using Models.Layer.Entities;

namespace FastFoodShop.Api.Mapping;
public class TestimonialMapping:Profile
{
    public TestimonialMapping()
    {
		CreateMap<Testimonial, CreateTestimonialDto>().ReverseMap();
		CreateMap<Testimonial, UpdateTestimonialDto>().ReverseMap();
		CreateMap<Testimonial, GetTestimonialDto>().ReverseMap();
		CreateMap<Testimonial, ResultTestimonialDto>().ReverseMap();
	}
}