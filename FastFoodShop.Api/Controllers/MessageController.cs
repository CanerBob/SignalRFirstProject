namespace FastFoodShop.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class MessageController : ControllerBase
{
	private readonly IMessageService _messageService;
	public MessageController(IMessageService messageService)
	{
		_messageService = messageService;
	}
	[HttpGet]
	public IActionResult GetAllMessage()
	{
		return Ok(_messageService.TGetAllList());
	}
	[HttpPost]
	public IActionResult CreateMessage(CreateMessageDto model)
	{
		
		var message = new Message()
		{
			Status=false,
			NameSurmane = model.NameSurmane,
			Mail = model.Mail,
			MessageContent = model.MessageContent,
			MessageSendDate = DateTime.Now,
			PhoneNumber = model.PhoneNumber, 
			Subject = model.Subject,
		};
		_messageService.TAdd(message);
		return Ok("Mesaj Başarılı Bir Şekilde Gönderildi");
	}
	[HttpDelete("{id}")]
	public IActionResult DeleteMessage(int id)
	{
		var item = _messageService.TGetById(id);
		_messageService.TDelete(item);
		return Ok("Mesaj Başarılır Bir Şekilde Silindi");
	}
	[HttpPut]
	public IActionResult UpdateMessage(UpdateMessageDto model)
	{
		var message = new Message()
		{
			Id = model.Id,
			Mail = model.Mail,
			MessageContent = model.MessageContent,
			MessageSendDate = model.MessageSendDate,
			PhoneNumber = model.PhoneNumber,
			Status = model.Status,
			NameSurmane = model.NameSurmane,
			Subject = model.Subject,
		};
		_messageService.TUpdate(message);
		return Ok("Güncelleme İşlemi Başarılı");
	}
	[HttpGet("{id}")]
	public IActionResult GetMessageId(int id)
	{
		var item = _messageService.TGetById(id);
		return Ok(item);
	}
}