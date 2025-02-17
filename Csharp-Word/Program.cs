// See https://aka.ms/new-console-template for more information

using Csharp_Word;

Console.WriteLine("Hello, Valdemar!");

Aluno aluno = new Aluno();

aluno.nome = "Valdemar";
aluno.nota1 = 5;
aluno.nota2 = 6;
aluno.mensagem();

Professor professor = new Professor("José Pinheiro", "Matemática");
professor.ExibirInformacoes();
