namespace FastFoodShop.Api.Mapping;
public class ProductMapping:Profile
{
    public ProductMapping()
    {
		CreateMap<Product, CreateProductDto>().ReverseMap();
		CreateMap<Product, UpdateProductDto>().ReverseMap();
		CreateMap<Product, GetProductDto>().ReverseMap();
		CreateMap<Product, ResultProductDto>().ReverseMap();
		CreateMap<Product, ResultProductWithCategory>().ReverseMap();
	}
}