using System.Collections.Generic;
namespace SERIES
{
    public interface IRepositorio<T>
    {
        List<T> List();
        T RetornaPorId(int id);
        void Insere(T entidade);
        void Exclui(int id);
        void Atualizar(int id, T entidade);
        int ProximoId();
    }
}