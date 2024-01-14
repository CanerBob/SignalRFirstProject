using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DataAccessLayer.Database;
public class AppDbContext:IdentityDbContext<AppUser,AppRole,int>
{
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlServer("Data Source = CANER\\SQLEXPRESS;Database=FastFoodDb;Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False");
	}
	public AppDbContext() { }
	public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}
	public DbSet<About> Abouts { get; set; }
	public DbSet<Category> Categories { get; set; }
	public DbSet<Contact> Contacts { get; set; }
    public DbSet<Discount> Discount { get; set; }
    public DbSet<Feature> Features { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<SocialMedia> SocialMedias { get; set; }
    public DbSet<Testimonial> Testimonials { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetails> OrderDetails { get; set; }
    public DbSet<MoneyCase> MoneyCases { get; set; }
    public DbSet<MenuTable> MenuTables { get; set; }
    public DbSet<Slider> Sliders { get; set; }
    public DbSet<Basket> Baskets { get; set; }
    public DbSet<Message> Messages { get; set; }
}