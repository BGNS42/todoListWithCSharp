using System.Diagnostics;

namespace main;

class Program
{
    static string? servicoMenu()
    {
        Console.WriteLine("1 - Adicionar tarefa");
        Console.WriteLine("2 - Listar tarefas");
        Console.WriteLine("3 - Concluir tarefa");
        Console.WriteLine("4 - Remover tarefa");
        Console.WriteLine("0 - sair");
        return Console.ReadLine();
    }

    static string? intro()
    {
        Console.WriteLine("Digite o seu nome:");
        return Console.ReadLine();
    }

    static string? addTitulo()
    {
        Console.WriteLine("Você escolheu adicionar uma tarefa");
        Console.WriteLine("Digite o título:");
        string? input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Título inválido.");
            addTitulo();
        }
        return input;
    }
    static void Main(string[] args)
    {
        GerenciadorDeTarefas gerenciador = new GerenciadorDeTarefas();

        bool encerrou = false;
        string? usuario = intro();
        Console.WriteLine($"Bem vindo(a) {usuario}, o que deseja?");
        while (!encerrou)
        {
            string? inputServico = servicoMenu();
            switch (inputServico)
            {
                case "1":
                    string? titulo = addTitulo();
                    Console.WriteLine("Digite a descrição:");
                    string? descricao = Console.ReadLine();
                    
                    Tarefa novaTarefa = new Tarefa(titulo, descricao);
                    gerenciador.AdicionarTarefa(novaTarefa);

                    Console.WriteLine("Tarefa Adicionada.");
                    break;
                case "2":
                    Console.WriteLine("Você escolheu listar as tarefas:");
                    var tarefas = gerenciador.ListarTarefas();
                    if (tarefas.Any())
                    {
                        foreach (var tarefa in tarefas)
                        {
                            string status = tarefa.Concluida ?  "[X]" : "[ ]";
                            Console.WriteLine($"{status} {tarefa.Titulo} (ID: {tarefa.Id:D4})");
                            Console.WriteLine($"Descrição: {tarefa.Descricao}\n");
                        }
                    } else
                    {
                        Console.WriteLine("Nenhuma tarefa\n");
                    }
                    break;
                case "3":
                    Console.WriteLine("Você escolheu concluir tarefa");
                    Console.WriteLine("Digite o ID da tarefa concluída:");
                    string? idInput = Console.ReadLine();
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
                    idInput = Console.ReadLine();
                    if (int.TryParse(idInput, out int idR))
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
