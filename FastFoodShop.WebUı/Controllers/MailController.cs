using MailKit.Net.Smtp;
using MimeKit;


namespace FastFoodShop.WebUı.Controllers;
public class MailController : Controller
{
	[HttpGet]
	public IActionResult Index()
	{
		return View();
	}
	[HttpPost]
	public IActionResult Index(CreateMailViewModel model) 
	{
		MimeMessage mimeMessage = new MimeMessage();
		MailboxAddress mailboxAddressFrom = new MailboxAddress("SignalR Rezervasyon","mail adresi");
		mimeMessage.From.Add(mailboxAddressFrom);
		MailboxAddress mailboxAddressTo = new MailboxAddress("User", model.ReceiverMail);
		mimeMessage.To.Add(mailboxAddressTo);
		var bodyBuilder=new BodyBuilder();
		bodyBuilder.TextBody=model.Body;
		mimeMessage.Body = bodyBuilder.ToMessageBody();
		mimeMessage.Subject = model.Subject;
		SmtpClient client = new SmtpClient();
		client.Connect("smtp.gmail.com",587,false);
		client.Authenticate("mail adresi", "key");
		client.Send(mimeMessage);
		client.Disconnect(true);
		return RedirectToAction("Index", "Category");
	}
}