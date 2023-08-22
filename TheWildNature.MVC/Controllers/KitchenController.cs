using Microsoft.AspNetCore.Mvc;
using TheWildNature.MVC.Contracts.Kitchen;
using TheWildNature.MVC.Models.Kitchen;

namespace TheWildNature.MVC.Controllers
{
    public class KitchenController : Controller
    {
        private readonly IKitchenService _kitchenService;
        public KitchenController(IKitchenService kitchenService)
        {
                _kitchenService = kitchenService;
        }
        // GET: KitchenController/Register
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        // POST: KitchenController/Register
        [HttpPost]
        public async Task<ActionResult> Register(CreateKitchenBaiscInfoVM kitchen) 
        {
            try
            {
                var response = await _kitchenService.AddBasicInformationAsync(kitchen);
                if (response.Success)
                {
                    return RedirectToAction("Home/Index");
                }
                ModelState.AddModelError("", response.ValidationErrors);

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            return View(kitchen);
        }
    }
}
