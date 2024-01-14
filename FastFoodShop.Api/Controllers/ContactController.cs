namespace FastFoodShop.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ContactController : ControllerBase
{
	private readonly IContactService _contactService;
	private readonly IMapper _mapper;
	public ContactController(IContactService contactService, IMapper mapper)
	{
		_contactService = contactService;
		_mapper = mapper;
	}
	[HttpGet]
	public IActionResult ContactList()
	{
		var items = _contactService.TGetAllList();
		return Ok(items);
	}
	[HttpPost]
	public IActionResult CreateContact(CreateContactDto model)
	{
		_contactService.TAdd(new Contact()
		{
			FooterTitle = model.FooterTitle,
			FooterDescription = model.FooterDescription,
			Location = model.Location,
			Mail = model.Mail,
			Phone = model.Phone,
			OpenDays = model.OpenDays,
			OpendaysDescription = model.OpendaysDescription,
			OpenHours = model.OpenHours,
		});
		return Ok("İletişim Eklendi");
	}
	[HttpDelete("{id}")]
	public IActionResult DeleteContact(int id)
	{
		var item = _contactService.TGetById(id);
		_contactService.TDelete(item);
		return Ok("Silme İşlemi Başarılı");
	}
	[HttpPut]
	public IActionResult UpdateContact(UpdatecontactDto model)
	{
		_contactService.TUpdate(new Contact()
		{
			ContactId = model.ContactId,
			FooterDescription = model.FooterDescription,
			Location = model.Location,
			Phone = model.Phone,
			Mail = model.Mail,
			FooterTitle = model.FooterTitle,
			OpenDays = model.OpenDays,
			OpenHours = model.OpenHours,
			OpendaysDescription = model.OpendaysDescription,
		});
		return Ok("İletişim Alanı Güncellendi");
	}
	[HttpGet("{id}")]
	public IActionResult GetContact(int id)
	{
		var item = _contactService.TGetById(id);
		return Ok(item);
	}
}