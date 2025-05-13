using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class AutoresController : ControllerBase
{
	private readonly IAutorService _autorService;

    public AutoresController(IAutorService autorService){
        _autorService = autorService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Livro>> Get() =>
        Ok(_autorService.GetAll());

    [HttpGet("{id}")]
    public ActionResult<Autor>GetById(int id){
        var autor = _autorService.GetById(id);
        return autor is null ? NotFound() : Ok(autor);
    }

    [HttpPost]
    public ActionResult<Autor> Post(Autor autor){
        var novoAutor = _autorService.Add(autor);
        return CreatedAtAction(nameof(GetById), new{id = novoAutor.Id}, novoAutor);
    }
        
}
