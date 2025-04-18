namespace Biblioteca.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }
        public double Preco { get; set; }
        public int QtdEstoque { get; set; }
    }
}