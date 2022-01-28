using System;
using System.Collections.Generic;
using API_Series.Interface;

namespace API_Series
{
    public class SeriesRepositorios : IRepositorio<Series>
    {
        private List<Series> listaserie = new List<Series>();

        public void Atualiza(int id, Series objeto)
        {
            listaserie[id] = objeto;
        }

        public void Exlcui(int id)
        {
            listaserie[id].Excluir();
        }

        public void Insere(Series objeto)
        {
            listaserie.Add(objeto);
        }

        public List<Series> Lista()
        {
            return listaserie;
        }

        public int ProximoID()
        {
            return listaserie.Count;
        }

        public Series RetonraPorID(int id)
        {
            return listaserie[id];
        }
    }
}