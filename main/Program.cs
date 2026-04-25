namespace main;

class Program
{
    static void Main(string[] args)
    {
        Tarefa todos = new Tarefa("Titulo da tarefa", "descricao da tarefa");
        Console.WriteLine($"{todos.Id}");
    }
}
