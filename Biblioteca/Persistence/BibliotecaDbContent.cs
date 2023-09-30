using Biblioteca.Entities;

namespace Biblioteca.Persistence
{
    public class BibliotecaDbContext
    {
        public List<Livro> Biblioteca { get; set; }

        public BibliotecaDbContext()
        {
            Biblioteca = new List<Livro>();
        }
    }
}
