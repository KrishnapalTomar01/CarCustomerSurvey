using Microsoft.AspNetCore.Mvc;
using dotnet_core_ts.Models;
using Newtonsoft.Json;

namespace dotnet_core_ts.Controllers;

public class SurveyController : Controller
{
    private readonly ILogger<SurveyController> _logger;

    public SurveyController(ILogger<SurveyController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(UserResponse user) {
        if(TempData.ContainsKey("users")) {
            List<UserResponse> users = JsonConvert.DeserializeObject<List<UserResponse>>(TempData["users"] as string);
            users.Add(user);
            TempData["users"] = JsonConvert.SerializeObject(users);
        }
        else {
            List<UserResponse> users = new List<UserResponse>() {user};
            TempData["users"] = JsonConvert.SerializeObject(users);
        }
        TempData["user"] = JsonConvert.SerializeObject(user);
        TempData.Keep();
        return RedirectToAction("Index","Home");
    }

}
