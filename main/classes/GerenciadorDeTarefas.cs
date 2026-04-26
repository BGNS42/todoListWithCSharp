public class GerenciadorDeTarefas
{
    private List<Tarefa> tarefas = new List<Tarefa>();

    public void AdicionarTarefa(Tarefa tarefa)
    {
        tarefas.Add(tarefa);
    }

    public List<Tarefa> ListarTarefas()
    {
        // string todo = "";
        // foreach (var tarefa in tarefas)
        // {
        //     todo += $"Titulo: {tarefa.Titulo}\nDescrição: {tarefa.Descricao}\nConcluída: {tarefa.Concluida}\n\n";
        // }
        return tarefas;
    }
}