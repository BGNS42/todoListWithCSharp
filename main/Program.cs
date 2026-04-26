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
            Console.WriteLine("3 - Concluir tarefa");
            Console.WriteLine("4 - Remover tarefa");
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
                        Console.WriteLine($"{status} {tarefa.Titulo} (ID: {tarefa.Id:D4})");
                        Console.WriteLine($"Descrição: {tarefa.Descricao}\n");
                    }
                    break;
                case "3":
                    Console.WriteLine("Você escolheu concluir tarefa");
                    Console.WriteLine("Digite o ID da tarefa concluída:");
                    string idInput = Console.ReadLine();
                    if (int.TryParse(idInput, out int id))
                    {
                        if (gerenciador.ConcluirTarefa(id))
                        {
                            Console.WriteLine("Tarefa Concluída com sucesso");  
                        }
                        else
                        {
                            Console.WriteLine("ID Inválido.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("ID Inválido");
                    }
                    break;
                case "4":
                    Console.WriteLine("Você escolheu Remover");
                    Console.WriteLine("Digite o ID da tarefa concluída:");
                    string idRemove = Console.ReadLine();
                    if (int.TryParse(idRemove, out int idR))
                    {
                        if (gerenciador.RemoverTarefa(idR))
                        {
                            Console.WriteLine("Tarefa Removida com sucesso.");
                        }
                        else
                        {
                            Console.WriteLine("ID Inválido.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("ID Inválido.");
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
                    Console.WriteLine("Digite um valor entre 0 e 4");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
