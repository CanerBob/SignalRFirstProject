using System.Text.Json.Serialization;

namespace FastFoodShop.Api.Dependency;
public static class MyDependeciy
{
	public static IServiceCollection AddDependencyServices(this IServiceCollection services, ConfigurationManager configuration)
	{
		services.AddCors(opt =>
		{
			opt.AddPolicy("CorsPolicy", builder =>
			{
				builder.AllowAnyHeader()
					.AllowAnyMethod()
					.SetIsOriginAllowed((host) => true)
					.AllowCredentials();
			});
		});
		
		services.AddSignalR();
		services.ConfigureServices();
		//services.AddDbContext<AppDbContext>(x => x.UseSqlServer(configuration.GetConnectionString("SqlConnection")));
		return services;
	}
	public static IServiceCollection ConfigureServices(this IServiceCollection services)
	{
		
		services.AddDbContext<AppDbContext>();
		services.AddAutoMapper(Assembly.GetExecutingAssembly());
		services.AddScoped<IAboutService, AboutManager>();
		services.AddScoped<IAboutDal, EfAboutDal>();
		services.AddScoped<IReservationService, ReservationManager>();
		services.AddScoped<IReservationDal, EfReservationDal>();
		services.AddScoped<ICateogoryService, CategoryManager>();
		services.AddScoped<ICategoryDal, EfCategoryDal>();
		services.AddScoped<IContactService, ContactManager>();
		services.AddScoped<IContactDal, EfContactDal>();
		services.AddScoped<IDiscountService, DiscountManager>();
		services.AddScoped<IDiscountDal, EfDiscontDal>();
		services.AddScoped<IProductService, ProductManager>();
		services.AddScoped<IProductDal, EfProductDal>();
		services.AddScoped<ISocialMediaService, SocialMediaManager>();
		services.AddScoped<ISocialMediaDal, EfSocialMediaDal>();
		services.AddScoped<ITestimonialService, TestimonialManager>();
		services.AddScoped<ITestimonialDal, EfTestimonialDal>();
		services.AddScoped<IFeatureService, FeatureManager>();
		services.AddScoped<IFeatureDal, EfFeatureDal>();
		services.AddScoped<IOrderService, OrderManager>();
		services.AddScoped<IOrderDal, EfOrderDal>();
		services.AddScoped<IOrderDetailService, OrderDetailManager>();
		services.AddScoped<IOrderDetailDal, EfOrderDetailDal>();
		services.AddScoped<IMoneyCaseService, MoneyCaseManager>();
		services.AddScoped<IMoneyCaseDal, EfMoneyCasesDal>();
		services.AddScoped<IMenuTableService, MenuTableManager>();
		services.AddScoped<IMenuTableDal, EfMenuTableDal>();
		services.AddScoped<ISliderService, SliderManager>();
		services.AddScoped<ISliderDal, EfSliderDal>();
		services.AddScoped<IBasketService, BasketManager>();
		services.AddScoped<IBasketDal, EfBasketDal>();
		services.AddScoped<IMessageService, MessageManager>();
		services.AddScoped<IMessageDal,EfMEssageDal>();
		services.AddControllersWithViews()
	.AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
		return services;
	}
}