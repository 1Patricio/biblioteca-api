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

    public Livro? Update(int id, Livro livroAtualizado){
        Livro livro1 = null;
            for (int i = 0; i < _livros.Count; i++)
            {
                if(_livros[i].Id == id){
                    _livros[i] = livroAtualizado;
                    return _livros[i];
                }
            }
        return livro1;
    }

    public bool Remove(int id) {
        var livro = GetById(id);
        if (livro is null)
            return false;
        return _livros.Remove(livro);
    }
}