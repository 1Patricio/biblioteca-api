public interface ILivroService
{
    IEnumerable<Livro> GetAll();
    Livro? GetById(int id);
    Livro Add(Livro livro);
    Livro? Remove(int id);
}