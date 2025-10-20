﻿using System.Numerics;

namespace Exercicio5;

internal class Projeto
{
    public string Nome { get; set; }
    private List<string> tarefas;
    public Projeto(string nome)
    {
        Nome = nome;
        tarefas = new List<string>();
    }
    public void AdicionarTarefa(string tarefa)
    {
        tarefas.Add(tarefa);
    }
    public void ExibirTarefas()
    {
        Console.WriteLine($"Projeto: {Nome}");
        Console.WriteLine("Tarefas:");
        foreach (string tarefa in tarefas) { Console.WriteLine($"- {tarefa}"); }
        Console.WriteLine($"Total de tarefas: {QuantidadeTarefas}");
    }
    public int QuantidadeTarefas
    {
        get { return tarefas.Count; }
    }

}
