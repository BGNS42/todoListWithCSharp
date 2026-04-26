public class GerenciadorDeTarefas
{
    private List<Tarefa> tarefas = new List<Tarefa>();

    public void AdicionarTarefa(Tarefa tarefa)
    {
        tarefas.Add(tarefa);
    }

    public IReadOnlyList<Tarefa> ListarTarefas()
    {
        return tarefas;
    }
    public bool ConcluirTarefa(int id)
    {
        var tarefa = tarefas.FirstOrDefault(t => t.Id == id);
        if (tarefa != null && tarefa.Concluida == false)
        {
            tarefa.Concluir();
            return true;
        }

        return false;
    }

    public bool RemoverTarefa(int id)
    {
        var tarefa = tarefas.FirstOrDefault(t => t.Id == id);
        if (tarefa != null)
        {
            tarefas.Remove(tarefa);
            return true;
        }

        return false;
    }   
}