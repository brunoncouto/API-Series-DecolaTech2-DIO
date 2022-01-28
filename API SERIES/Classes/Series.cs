using System;


namespace API_Series
{
    public class Series : MotherClass
    {
        //Atributos
        private gender Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }
        
        //Métodos
        public Series(int id, gender genero, string titulo, string descricao, int ano)
        {
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;

        }
        // Método de sobrescrita
        public override string ToString()
        {
        string retorno = "";
        retorno += "Gênero: " + this.Genero + Environment.NewLine;
        retorno += "Título: " + this.Titulo + Environment.NewLine;
        retorno += "Descrição: " + this.Descricao + Environment.NewLine;
        retorno += "Ano: " + this.Ano + Environment.NewLine;
        return retorno;
        }
        public string retornoTitle()
        { 
            return this.Titulo;
        }
        public int retornoID()
        {
            return this.id;
        }
        public bool retornoExcluido()
        {
            return this.Excluido;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }

    }
}
