using Aluno.Dominio;

namespace Aluno.Repositorio
{
    public interface IAlunoRepositorio
    {
        void adicionar();
        List<int> listar();
    }
}
