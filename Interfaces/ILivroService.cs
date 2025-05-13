public interface ILivroService
{
    IEnumerable<Livro> GetAll();
    Livro? GetById(int id);
    Livro Add(Livro livro);
    bool Remove(int id);
    Livro? Update(int id, Livro livroAtualizado);
}