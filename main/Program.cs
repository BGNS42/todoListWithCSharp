using System.Diagnostics;

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
        GerenciadorDeTarefas gerenciador = new GerenciadorDeTarefas();

        Console.WriteLine("Digite o seu nome:");
        string usuario = Console.ReadLine();
        bool encerrou = false;
        Console.WriteLine($"Bem vindo(a) {usuario}, o que deseja?");
        while (!encerrou)
        {
            Console.WriteLine("1 - Adicionar tarefa");
            Console.WriteLine("2 - Listar tarefas");
            Console.WriteLine("0 - sair");
            string inputServico = Console.ReadLine();
            switch (inputServico)
            {
                case "1":
                    Console.WriteLine("Você escolheu adicionar uma tarefa");

                    Console.WriteLine("Digite o título:");
                    string titulo = Console.ReadLine();
                    Console.WriteLine("Digite a descrição:");
                    string descricao = Console.ReadLine();
                    
                    Tarefa novaTarefa = new Tarefa(titulo, descricao);
                    gerenciador.AdicionarTarefa(novaTarefa);

                    Console.WriteLine("Tarefa Adicionada.");
                    break;
                case "2":
                    Console.WriteLine("Você escolheu listar as tarefa");
                    var tarefas = gerenciador.ListarTarefas();

                    foreach (var tarefa in tarefas)
                    {
                        string status = tarefa.Concluida ?  "[X]" : "[ ]";
                        Console.WriteLine($"{status} {tarefa.Titulo} (ID: {tarefa.Id.ToString().Substring(0, 8)})");
                    }
                    break;
                case "0":
                    Console.WriteLine("Você escolheu sair");
                    Console.WriteLine("Pressione ENTER para confirmar");
                    Console.ReadLine();
                    Console.WriteLine("Programa Encerrado.");
                    encerrou = true;
                    break;
                default:
                    Console.WriteLine("Digite um valor entre 0 e 2");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
