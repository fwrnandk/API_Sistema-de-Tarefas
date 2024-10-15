using Sistemas_de_Tarefas.Models;

namespace Sistemas_de_Tarefas.Repositorios.Interfaces
{
    public interface ITarefaRepositorio
    {
        Task<List<TarefaModel>> BuscarTodasTarefas();
        Task<TarefaModel> BuscarPorId(int id);
        Task<TarefaModel> Adicionar(TarefaModel tarefa);
        Task<TarefaModel> Atualiza(TarefaModel tarefa, int id);
        Task<bool> Apagar(int id);
    }
}
