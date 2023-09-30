using Microsoft.AspNetCore.Mvc;
using PracticeTheVerb.API.Services.Italian;

namespace PracticeTheVerb.Controllers;

public class ItalianController : Controller
{
    private readonly ItalianVerbService _italianService;
    public ItalianController(ItalianVerbService italianService)
    {
        _italianService = italianService;
    }


    public async Task<ActionResult> VerbConjugation(string verbRequested)
    {
        var verb = await _italianService.GetVerb("andare");
        ViewData["verb"] = verb;

        return View(verb);
    }
}
