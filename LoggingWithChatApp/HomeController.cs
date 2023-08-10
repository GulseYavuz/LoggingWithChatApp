using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
namespace LoggingWithChatApp
{
    public class HomeController: Controller
    {
        ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("HomeController Index executed at {date}", DateTime.UtcNow);

            try
            {
                throw new Exception("Some bad code was executed");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An unknown error occurred on the Index action of the HomeController");
            }

            return View();
        }
    }
}
