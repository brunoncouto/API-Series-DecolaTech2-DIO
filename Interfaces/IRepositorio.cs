namespace API_Series
{
    public interface IRepositorio<T>
    {
         List<T> Lista();
        T RetonraPorID (int id);
        void Insere (T objeto);
        void Exlcui (int id);
        void Atualiza (int id, T objeto);
        int ProximoID();
    }
}