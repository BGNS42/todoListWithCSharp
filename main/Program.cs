namespace main;

class Program
{
    static void Main(string[] args)
    {
        // Tarefa todos = new Tarefa("Titulo da tarefa", "descricao da tarefa");
        // Tarefa todos2 = new Tarefa("Titulo da tarefa2", "descricao da tarefa2");
        // //Console.WriteLine($"{todos.Id}");
        // GerenciadorDeTarefas gere = new GerenciadorDeTarefas();

        // gere.AdicionarTarefa(todos);
        // gere.AdicionarTarefa(todos2);
        // gere.AdicionarTarefa(todos2);

        // string list = gere.MostrarListaDeTarefas();

        // Console.WriteLine(list);
        Console.WriteLine("Bem vindo, o que deseja?");
        Console.WriteLine("1 - Adicionar tarefa");
        Console.WriteLine("2 - Listar tarefas");
        Console.WriteLine("0 - sair");
        string inputServico = Console.ReadLine();
        switch (inputServico)
        {
            case "1":
                Console.WriteLine("Você escolheu adicionar uma tarefa");
                break;
            case "2":
                Console.WriteLine("Você escolheu listar as tarefa");
                break;
            case "0":
                Console.WriteLine("Você escolheu sair");
                break;
            default:
                Console.WriteLine("Digite um valor entre 0 e 2");
                Console.ReadLine();
                break;
        }
    }
}
