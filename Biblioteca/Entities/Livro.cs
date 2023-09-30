namespace Biblioteca.Entities
{
    public class Livro
    {
        public Livro()
        {
            Autores = new List<LivroAutor> { };
            IsDeleted = false;
        }

        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao{ get; set; }
        public DateTime Data { get; set; }
        public List<LivroAutor> Autores { get; set; }
        public bool IsDeleted { get; set; }

        public void Update(string titulo, string descricao, DateTime data)
        {
            Titulo = titulo;
            Descricao = descricao;
            Data = data;
        }

        public void Delete()
        {
            IsDeleted = true;
        }
    }
}
