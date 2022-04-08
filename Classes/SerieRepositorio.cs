using System.Collections.Generic;

namespace SERIES
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSeries = new List<Serie>();

        public void Atualizar(int id, Serie objeto)
        {
            listaSeries[id] = objeto;
        }

        public void Exclui(int id)
        {
            listaSeries[id].Exclui();
        }

        public void Insere(Serie objeto)
        {
            listaSeries.Add(objeto);
        }

        public List<Serie> List()
        {
            return listaSeries;
        }

        public int ProximoId()
        {
            return listaSeries.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSeries[id];
        }
    }
}