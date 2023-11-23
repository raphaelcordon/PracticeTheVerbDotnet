using Microsoft.AspNetCore.Mvc;
using PracticeTheVerb.API.Services.Italian;

namespace PracticeTheVerb.Controllers;

[Controller]
[Route("[controller]")]
public class ItalianController : Controller
{
    private readonly ItalianVerbService _italianService;
    public ItalianController(ItalianVerbService italianService)
    {
        _italianService = italianService;
    }

    [HttpGet("verbconjugation/{verbRequested}")]
    public async Task<ActionResult> VerbConjugation([FromRoute] string verbRequested)
    {
        var verb = await _italianService.GetVerb(verbRequested);
        ViewData["verb"] = verb;

        return View(verb);
    }
}
