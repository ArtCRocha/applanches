using AplicacaoInterativa.Models;

namespace AplicacaoInterativa.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
