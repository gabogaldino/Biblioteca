using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Biblioteca.Persistence;
using Biblioteca.Entities;

namespace Biblioteca.Controllers
{
    [Route("api/biblioteca")]
    [ApiController]
    public class BibliotecaController : ControllerBase
    {
        private readonly BibliotecaDbContext _context;
        public BibliotecaController(BibliotecaDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var biblioteca = _context.Biblioteca.Where(d => !d.IsDeleted).ToList();
            return Ok(biblioteca);

        }
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var livro = _context.Biblioteca.SingleOrDefault(d => d.Id == id);
            if (livro == null)
            {
                return NotFound();
            }
            return Ok(livro);
        }
        [HttpPost]
        public IActionResult Post(Livro livro)
        {
            _context.Biblioteca.Add(livro);
            return CreatedAtAction(nameof(GetById), new { id = livro.Id }, livro);
        }
        [HttpPut("{id}")]
        public IActionResult Update(Guid id, Livro input)
        {
            var livro = _context.Biblioteca.SingleOrDefault(d => d.Id == id);
            if (livro == null)
            {
                return NotFound();
            }
            livro.Update(input.Titulo, input.Descricao, input.Data);

            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var livro = _context.Biblioteca.SingleOrDefault(d => d.Id == id);
            if (livro == null)
            {
                return NotFound();
            }
            livro.Delete();

            return NoContent();
        }

        [HttpPost("{id}/autores")]
        public IActionResult PostAutor(Guid id, LivroAutor autor)
        {
            var livro = _context.Biblioteca.SingleOrDefault(d => d.Id == id);
            if (livro == null)
            {
                return NotFound();
            }
            livro.Autores.Add(autor);

            return NoContent();
        }
    }
}
