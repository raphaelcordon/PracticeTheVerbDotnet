using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PracticeTheVerb.Domain.Entities.Italian;
using PracticeTheVerb.Domain.Entities;
using PracticeTheVerb.Infrastructure.Data;

namespace PracticeTheVerb.API.Services.Italian;

[ApiController]
[Route("/v1/italian/verbs")]
public class ItalianVerbService : ControllerBase
{
	private readonly DataContext _context;

    public ItalianVerbService(DataContext context)
    {
        _context = context;
    }

	[HttpGet]
	public async Task<IActionResult> GetItalianVerbsAsync()
	{
		try
		{
			var verbs = await _context.ItalianVerbs.AsNoTracking().Select(x => new ItalianInfinitivo
			{
				Id = x.Id,
				infinitivopresente = x.infinitivopresente
			})
			.OrderBy(x => x.infinitivopresente)
			.ToListAsync();

			return Ok(new ResultViewEntity<List<ItalianInfinitivo>>(verbs));
		}
		catch
		{
			return StatusCode(500, new ResultViewEntity<List<ItalianInfinitivo>>("Internal server failure"));
		}
	}

	public async Task<ResultViewEntity<ItalianVerb>> GetVerb(string verbRequested)
	{
		try
		{
			var verb = await _context.ItalianVerbs.AsNoTracking().FirstOrDefaultAsync(x => x.infinitivopresente == verbRequested);
			return new ResultViewEntity<ItalianVerb>(verb);
		}
		catch
		{
			throw new Exception($"Verb {verbRequested} not found.");
		}
	}

}
