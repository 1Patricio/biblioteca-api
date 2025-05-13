using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class LivrosController : ControllerBase{
    private readonly ILivroService _livroService;

    public LivrosController(ILivroService livroService){
        _livroService = livroService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Livro>> Get() =>
        Ok(_livroService.GetAll());

    [HttpGet("{id}")]
    public ActionResult<Livro>GetById(int id){
        var livro = _livroService.GetById(id);
        return livro is null ? NotFound() : Ok(livro);
    }

    [HttpPost]
    public ActionResult<Livro> Post(Livro livro){
        var novoLivro = _livroService.Add(livro);
        return CreatedAtAction(nameof(GetById), new {id = novoLivro.Id}, novoLivro);
    }

    [HttpDelete("{id}")]
    public ActionResult Remove(int id){
        var livro = _livroService.Remove(id);
        return livro ? NoContent() : NotFound();
    }

    [HttpPut("{id}")]
    public ActionResult Update(int id, Livro livroAtualizado){
        var atualizado = _livroService.Update(id, livroAtualizado);
        return atualizado is null ? NotFound() : NoContent();
    }
}