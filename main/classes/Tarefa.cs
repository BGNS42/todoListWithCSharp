public class Tarefa
{
    public Guid Id { get; } = Guid.NewGuid();
    public string Titulo { get; private set; }
    public string Descricao { get; private set; }
    public bool Concluida { get; private set; } = false;

    public Tarefa(string titulo, string descricao, bool concluida = false)
    {
        Titulo = titulo;
        Descricao = descricao;
        Concluida = concluida;
    }
}