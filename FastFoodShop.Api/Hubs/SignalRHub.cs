namespace FastFoodShop.Api.Hubs;
public class SignalRHub : Hub
{
    private readonly ICateogoryService _cateogoryService;
    private readonly IProductService _productService;
    private readonly IOrderService _orderService;
    private readonly IMoneyCaseService _moneyCaseService;
    private readonly IMenuTableService _menuTableService;
    private readonly IReservationService _reservationService;
    public SignalRHub(ICateogoryService cateogoryService, IProductService productService, IOrderService orderService, IMoneyCaseService moneyCaseService, IMenuTableService menuTableService, IReservationService reservationService)
    {
        _cateogoryService = cateogoryService;
        _productService = productService;
        _orderService = orderService;
        _moneyCaseService = moneyCaseService;
        _menuTableService = menuTableService;
        _reservationService = reservationService;
    }
    public async Task SendStatistic()
    {
        var items = _cateogoryService.TCategoryCount();
        await Clients.All.SendAsync("ReceiveCategoryCount", items);
        var items1 = _productService.TGetProductCount();
        await Clients.All.SendAsync("ReceiveProductCount", items1);
        var item3 = _cateogoryService.TActiveCategoriesCount();
        await Clients.All.SendAsync("ReceiveActiveCategoryCount", item3);
        var item4 = _cateogoryService.TPassiveCategoriesCount();
        await Clients.All.SendAsync("ReceivePassiveCategoryCount", item4);
        var item5 = _productService.TProductCountByCategoryNameHamburger();
        await Clients.All.SendAsync("ReceiveProductCountByCategoryNameHamburger", item5);
        var item6 = _productService.TProductCountByCategoryNameDrink();
        await Clients.All.SendAsync("ReceiveProductCountByCategoryNameDrink", item6);
        var item7 = _productService.TProductPriceAvg();
        await Clients.All.SendAsync("ReceiveProductPriceAvg", item7.ToString("0.00" + "₺"));
        var item8 = _productService.ProductNameByMaxPrice();
        await Clients.All.SendAsync("ReceiveProductMaxPrice", item8);
        var item9 = _productService.ProductNameByMinPrice();
        await Clients.All.SendAsync("ReceiveProductMinPrice", item9);
        var item10 = _orderService.TTotalOrderCount();
        await Clients.All.SendAsync("ReceiveTotalOrderCount", item10);
        var item11 = _orderService.TActiveOrderCount();
        await Clients.All.SendAsync("ReceiveActiveOrderCount", item11);
        var item12 = _orderService.TLastOrderPrice();
        await Clients.All.SendAsync("ReceiveLastOrderPrice", item12.ToString("0.00" + "₺"));
        var item13 = _moneyCaseService.TTotalMoneyCaseAmount();
        await Clients.All.SendAsync("ReceiveTotalMoneyCaseAmount", item13.ToString("0.00" + "₺"));
        var item14 = _menuTableService.TMenuTableCount();
        await Clients.All.SendAsync("ReceiveMenuTableCount", item14);
    }
    public async Task GetReservationList()
    {
        var value = _reservationService.TGetAllList();
        await Clients.All.SendAsync("ReceiveReservationList", value);
    }
    public async Task GetMenuTableStatus() 
    {
        var value = _menuTableService.TGetAllList();
        await Clients.All.SendAsync("ReceiveMenuTableStatus", value);
    }
    public async Task SendMessage(string user, string message) 
    {
        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}