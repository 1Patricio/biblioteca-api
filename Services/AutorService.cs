public class AutorService : IAutorService{
    private readonly List<Autor> _autores = new();
    public IEnumerable<Autor> GetAll() => _autores;
    public Autor? GetById(int id) =>
        _autores.FirstOrDefault(l => l.Id == id);
    
    public Autor Add(Autor autor){
        autor.Id = _autores.Count + 1;
        _autores.Add(autor);
        return autor;
    }
    public Autor? Remove(int id) {
        var autor = _autores.FirstOrDefault(l => l.Id == id);
        if (autor != null) {
            _autores.Remove(autor);
        }
        return autor;
    }
}