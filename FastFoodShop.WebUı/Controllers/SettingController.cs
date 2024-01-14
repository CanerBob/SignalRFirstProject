namespace FastFoodShop.WebUı.Controllers;
public class SettingController : Controller
{
	private readonly UserManager<AppUser> _userManager;
	public SettingController(UserManager<AppUser> userManager)
	{
		_userManager = userManager;
	}
	[HttpGet]
	public async Task<IActionResult> Index()
	{
		var values = await _userManager.FindByNameAsync(User.Identity.Name);
		UserEditViewModel userEditDto = new UserEditViewModel();
		userEditDto.SurName = values.Surname;
		userEditDto.Name = values.Name;
		userEditDto.UserName = values.UserName;
		userEditDto.Mail = values.Email;
		return View(userEditDto);
	}
	[HttpPost]
	public async Task<IActionResult> Index(UserEditViewModel model) 
	{
		if (model.Password == model.ConfirmPassword) 
		{
			var user = await _userManager.FindByNameAsync(User.Identity.Name);
			user.Name = model.Name;
			user.Surname = model.SurName;
			user.Email = model.Mail;
			user.UserName= model.UserName;
			user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, model.Password);
			await _userManager.UpdateAsync(user);
			return RedirectToAction("Index", "Login");
		}
		return View();
	}
}