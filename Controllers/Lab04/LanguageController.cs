using Microsoft.AspNetCore.Mvc;
using WebAPI.Services.Lab04;

namespace WebAPI.Controllers.Lab04
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class LanguageController : ControllerBase
    {
        [HttpGet]
        public string GetLang()
        {
            var lang = new Polish("pl");
            return lang.GetLanguageName();
        }
    }
}
