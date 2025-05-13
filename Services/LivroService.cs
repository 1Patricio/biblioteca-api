public class LivroService : ILivroService{
    private readonly List<Livro> _livros = new();
    public IEnumerable<Livro> GetAll() => _livros;
    public Livro? GetById(int id) => 
        _livros.FirstOrDefault(l => l.Id == id);

    public Livro Add (Livro livro){
        livro.Id = _livros.Count + 1;
        _livros.Add(livro);
        return livro;
    }
}