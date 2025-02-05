using System.Threading.Tasks;
using Acme.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Acme.Controllers;

[Authorize]
[Route("")]
public class HomeController : Controller
{

    private readonly WeavyClient _weavy;

    public HomeController(WeavyClient weavy)
    {
        _weavy = weavy;
    }

    [HttpGet("")]
    public async Task<IActionResult> Index()
    {
        // init Weavy posts app and ensure authenticated user is member
        var app = new AppModel
        {
            Type = "posts",
            Uid = "acme_feed",
            Name = "Feed",
        };
        var model = await _weavy.InitApp(app, User);
        return View("App", model);
        //return View();
    }

    [HttpGet("chat")]
    public async Task<IActionResult> Chat()
    {
        // init Weavy chat app and ensure authenticated user is member
        var app = new AppModel
        {
            Type = "chat",
            Uid = "acme_chat",
            Name = "Chat",
        };
        var model = await _weavy.InitApp(app, User);
        return View("App", model);
    }

    [HttpGet("files")]
    public async Task<IActionResult> Files()
    {
        // init Weavy files app and ensure authenticated user is member
        var app = new AppModel
        {
            Type = "files",
            Uid = "acme_files",
            Name = "Files",
        };
        var model = await _weavy.InitApp(app, User);
        return View("App", model);
    }

    [HttpGet("feed")]
    public async Task<IActionResult> Feed()
    {
        // init Weavy posts app and ensure authenticated user is member
        var app = new AppModel
        {
            Type = "posts",
            Uid = "acme_feed",
            Name = "Feed",
        };
        var model = await _weavy.InitApp(app, User);
        return View("App", model);
    }


    [HttpGet("message")]
    public async Task<IActionResult> Message()
    {
        // init Weavy chat app and ensure authenticated user is member
        var app = new AppModel
        {
            Type = "chat",
            Uid = "acme_chat",
            Name = "Chat",
        };
        var model = await _weavy.InitApp(app, User);
        return View(model);
    }

}
