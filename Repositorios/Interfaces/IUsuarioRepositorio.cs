using Sistemas_de_Tarefas.Models;

namespace Sistemas_de_Tarefas.Repositorios.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<List<UsuarioModel>> BuscarTodosUsuarios();
        Task<UsuarioModel> BuscarPorId(int id);
        Task<UsuarioModel> Adicionar(UsuarioModel usuario);
        Task<UsuarioModel> Atualiza(UsuarioModel usuario, int id);
        Task<bool> Apagar(int id);
    }
}
