namespace FastFoodShop.WebUı.Controllers;
public class RegisterController : Controller
{
    private readonly UserManager<AppUser> _userManager;
    public RegisterController(UserManager<AppUser> userManager)
    {
        _userManager = userManager;
    }
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Index(RegisterViewModel model)
    {
        var appuser = new AppUser()
        {
            Name = model.Name,
            Surname = model.Surname,
            Email = model.Mail,
            UserName=model.Username
        };
        var result=await _userManager.CreateAsync(appuser,model.Password);
        if (result.Succeeded) 
        {
        return RedirectToAction("Index","Login");
        }
        return View(model);
    }
}