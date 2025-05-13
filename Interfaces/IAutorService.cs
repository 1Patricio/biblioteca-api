public interface IAutorService{
    IEnumerable<Autor> GetAll();
    Autor? GetById(int id);
    Autor Add( Autor autor);
}