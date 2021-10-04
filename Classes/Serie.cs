using System; //classe principal

namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        // Informacoes sobre a serie
		private Genero Genero { get; set; }
		private string Titulo { get; set; }
		private string Descricao { get; set; }
		private int Ano { get; set; }
        private bool Excluido {get; set;}

        // Implantar os metodos necessarios para manipulacao dos programas
		public Serie(int id, Genero genero, string titulo, string descricao, int ano)
		{
			this.Id = id;
			this.Genero = genero;
			this.Titulo = titulo;
			this.Descricao = descricao;
			this.Ano = ano;
            this.Excluido = false;
		}

        public override string ToString()
		{
			// Enviroment.NewLine - Estudar mais sobre o assunto
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
			return retorno;
		}

        public string retornaTitulo() //padronizar e retornar titulo da serie cadastrada
		{
			return this.Titulo;
		}

		public int retornaId() //padronizar e retornar id da serie cadastrada
		{
			return this.Id;
		}
        public bool retornaExcluido() //confirmar exclusao de item
		{
			return this.Excluido;
		}
        public void Excluir() { //confimar exclusao de item
            this.Excluido = true;
        }
    }
}