public class Tarefa
{
    public int Id { get; } = Random.Shared.Next(0, 10000);
    public string Titulo { get; private set; }
    public string Descricao { get; private set; }
    public bool Concluida { get; private set; } = false;

    public Tarefa(string titulo, string descricao)
    {
        Titulo = titulo;
        Descricao = descricao;
        Concluida = false;
    }

    public void Concluir()
    {
        Concluida = true;
    }
}