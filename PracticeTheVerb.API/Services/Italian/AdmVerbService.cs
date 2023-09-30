using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PracticeTheVerb.Domain.Entities;
using PracticeTheVerb.Domain.Entities.Italian;
using PracticeTheVerb.Infrastructure.Data;

namespace PracticeTheVerb.API.Services.Italian;

[ApiController]
[Route("/v1/adm/italian/verbs")]
public class AdmVerbService : ControllerBase
{
	private readonly DataContext _context;
	public AdmVerbService(DataContext context)
	{
		_context = context;
	}


	[HttpPost]
	public async Task<IActionResult> PostItalianVerbAsync([FromBody] ItalianVerb verb)
	{
		try
		{
			await _context.AddAsync<ItalianVerb>(verb);
			await _context.SaveChangesAsync();

			return Created($"/v1/adm/italian/verbs/{verb.infinitivopresente}", new ResultViewEntity<ItalianVerb>(verb));
		}
		catch (DbUpdateException)
		{
			return StatusCode(500, new ResultViewEntity<ItalianVerb>("It was not possible to include the verb"));
		}
		catch
		{
			return StatusCode(500, new ResultViewEntity<ItalianVerb>("Internal Server Error"));
		}
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

	[HttpGet("{verbRequested}")]
	public async Task<IActionResult> GetVerbAsync(string verbRequested)
	{
		try
		{
			var verb = await _context.ItalianVerbs.AsNoTracking().FirstOrDefaultAsync(x => x.infinitivopresente == verbRequested);
			return Ok(new ResultViewEntity<ItalianVerb>(verb));
		}
		catch
		{
			return NotFound();
		}
	}

	[HttpDelete("{id}")]
	public async Task<IActionResult> DeleteItalianVerbAsync(Guid Id)
	{
		try
		{
			var verb = await _context.ItalianVerbs.FirstOrDefaultAsync(x => x.Id == Id);
			_context.ItalianVerbs.Remove(verb);
			await _context.SaveChangesAsync();

			return Ok(new ResultViewEntity<ItalianVerb>(verb));
		}
		catch (DbUpdateException)
		{
			return StatusCode(500, new ResultViewEntity<ItalianVerb>("Delete has failed"));
		}
		catch
		{
			return StatusCode(500, new ResultViewEntity<ItalianVerb>("Internal Server Failure"));
		}
	}
}
