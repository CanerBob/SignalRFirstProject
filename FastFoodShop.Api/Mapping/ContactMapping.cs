using AutoMapper;
using Dtos.Layer.ContactDto;
using Models.Layer.Entities;

namespace FastFoodShop.Api.Mapping;
public class ContactMapping:Profile
{
    public ContactMapping()
    {
		CreateMap<Contact, CreateContactDto>().ReverseMap();
		CreateMap<Contact, GetContactDto>().ReverseMap();
		CreateMap<Contact, UpdatecontactDto>().ReverseMap();
		CreateMap<Contact, ResultContactDto>().ReverseMap();
	}
}