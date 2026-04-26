public class GerenciadorDeTarefas
{
    private List<Tarefa> tarefas = new List<Tarefa>();

    public void AdicionarTarefa(Tarefa tarefa)
    {
        tarefas.Add(tarefa);
    }

    public List<Tarefa> ListarTarefas()
    {
        return tarefas;
    }
    public void ConcluirTarefa(int id)
    {
        var tarefa = tarefas.FirstOrDefault(t => t.Id == id);
        if (tarefa != null)
        {
            tarefa.Concluir();
        }
    }

    public void RemoverTarefa(int id)
    {
        var tarefa = tarefas.FirstOrDefault(t => t.Id == id);
        if (tarefa != null)
        {
            tarefas.Remove(tarefa);
        }
    }   
}