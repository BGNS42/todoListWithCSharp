# todoListWithCSharp
A simple to-do List using C#

# 🎯 MISSÃO: To-Do List em C# (Terminal + POO)
## 🧠 Objetivo

Construir um sistema com:

- Classes bem definidas
- Separação de responsabilidades
- Lógica limpa
# 🧩 ETAPA 1 — Modelagem

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

👉 **IMPORTANTE**:

`Tarefa` = dado
`Gerenciador` = regra de negócio

# 🛠️ ETAPA 2 — Desafio
## 🔥 Desafio 1

Classe `Tarefa` com:

- Propriedades
- Construtor

## 🔥 Desafio 2

Crie `GerenciadorDeTarefas` com:

- Lista interna
- Método AdicionarTarefa

### 🔥 Desafio 3

No `Program.cs`, cria um menu simples:
```
1 - Adicionar tarefa
2 - Listar tarefas
0 - Sair
```
# 🧠 ETAPA 3 — Evolução 
Quando tiver o básico rodando:

## 🔥 Desafio 4
- Marcar tarefa como concluída
## 🔥 Desafio 5
- Remover tarefa
## 🔥 Desafio 6

- Mostrar:
```
[ ] Tarefa 1
[X] Tarefa 2
```
# ⚠️ ERROS COMUNS (evita isso)
- ❌ Colocar toda lógica no Program.cs
- ❌ Não usar classe separada
- ❌ Misturar entrada do usuário com regra de negócio