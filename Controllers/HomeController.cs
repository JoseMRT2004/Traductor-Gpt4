using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Traductor_Gpt4.Models;

namespace Traductor_Gpt4.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IConfiguration _configuration;
    private readonly HttpClient  _htppClient;
    private readonly List<string> mostUsedLanguages = new List<string>()
{
    "English",
    "Mandarin Chinese",
    "Hindi",
    "Arabic",
    "Bengali",
    "Portuguese",
    "Russian",
    "Japanese",
    "German",
    "French",
    "Urdu",
    "Indonesian",
    "Swahili",
    "Marathi",
    "Telugu",
    "Turkish",
    "Korean",
    "Vietnamese",
    "Italian",
    "Punjabi",
    "Spanish" // Español como idioma extra
};



    public HomeController(ILogger<HomeController> logger, IConfiguration configuration, HttpClient httpClient)
    {
        _logger = logger;
        _configuration = configuration;
        _htppClient = httpClient;
    }

    public IActionResult Index()
    {
        return View();
    }

   [HttpPost]
   public async Task<IActionResult> OpenIAGPT(string query, string selectedLanguage) {

    var openAPIKey = _configuration["OpenIA:ApiKey"];


    _htppClient.DefaultRequestHeaders.Add("Authorization",$"Bearder {openAPIKey}");
    
    return Ok();

   }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
