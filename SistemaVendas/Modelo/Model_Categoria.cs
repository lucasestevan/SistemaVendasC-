namespace Modelo
{
    public class Model_Categoria
    {
        private int id_categoria;
        private string nome_categoria;

        public int IdCategoria
        {
            get { return this.id_categoria; }
            set { this.id_categoria = value; }
        }
        public string NomeCategoria
        {
            get { return this.nome_categoria; }
            set { this.nome_categoria = value; }
        }
    }
}


