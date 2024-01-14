using AutoMapper;
using Dtos.Layer.ReservationDto;
using Models.Layer.Entities;

namespace FastFoodShop.Api.Mapping;
public class ReservationMapping:Profile
{
    public ReservationMapping()
    {
		CreateMap<Reservation, CreateReservationDto>().ReverseMap();
		CreateMap<Reservation, UpdateReservationDto>().ReverseMap();
		CreateMap<Reservation, ResultReservationDto>().ReverseMap();
		CreateMap<Reservation, GetReservationDto>().ReverseMap();
	}
}