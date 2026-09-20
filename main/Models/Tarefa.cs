public class Tarefa
{
    private static int contador = 1;
    public int Id { get; }
    public string? Titulo { get; private set; }
    public string? Descricao { get; private set; }
    public bool Concluida { get; private set; } = false;

    public Tarefa(string? titulo, string? descricao)
    {
        Id = contador++;
        Titulo = titulo;
        Descricao = descricao;
        Concluida = false;
    }

    public void Concluir()
    {
        Concluida = true;
    }
}