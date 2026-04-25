# todoListWithCSharp
A simple to-do List using C#

# 🎯 MISSÃO: To-Do List em C# (Terminal + POO)
## 🧠 Objetivo

Construir um sistema com:

- Classes bem definidas
- Separação de responsabilidades
- Lógica limpa (nível estágio/júnior)
# 🧩 ETAPA 1 — Modelagem (sem código ainda)

Antes de sair codando, pensa como programador:

## 📌 Classes principais
### 🔹 `Tarefa`

Representa uma única tarefa.

**Deve ter:**

- `Id` (Guid ou int)
- `Titulo`
- `Descricao`
- `Concluida` (bool)

### 🔹 `GerenciadorDeTarefas`

Responsável por controlar tudo.

**Deve ter:**

Lista de tarefas (`List<Tarefa>`)

Métodos:

`AdicionarTarefa`
`ListarTarefas`
`ConcluirTarefa`
`RemoverTarefa`

👉 Isso aqui já é um conceito MUITO importante:

`Tarefa` = dado
`Gerenciador` = regra de negócio

Se você entende isso, já está pensando como dev profissional.

# 🛠️ ETAPA 2 — Desafio (faça você)

Quero que você tente implementar isso primeiro:

## 🔥 Desafio 1

Crie a classe `Tarefa` com:

- Propriedades
- Construtor

💡 Dica:
```
public class Tarefa
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public bool Concluida { get; set; }

    public Tarefa(int id, string titulo, string descricao)
    {
        Id = id;
        Titulo = titulo;
        Descricao = descricao;
        Concluida = false;
    }
}
```
## 🔥 Desafio 2

Crie GerenciadorDeTarefas com:

- Lista interna
- Método AdicionarTarefa

💡 Dica:
```
private List<Tarefa> tarefas = new List<Tarefa>();
```
### 🔥 Desafio 3

No `Program.cs`, cria um menu simples:
```
1 - Adicionar tarefa
2 - Listar tarefas
0 - Sair
```
# 🧠 ETAPA 3 — Evolução (depois que funcionar)

Quando você tiver o básico rodando:

## 🔥 Desafio 4
- Marcar tarefa como concluída
## 🔥 Desafio 5
- Remover tarefa
## 🔥 Desafio 6 (nível +)

- Mostrar:
```
[ ] Tarefa 1
[X] Tarefa 2
```
#⚠️ ERROS COMUNS (evita isso)
- ❌ Colocar toda lógica no Program.cs
- ❌ Não usar classe separada
- ❌ Misturar entrada do usuário com regra de negócio