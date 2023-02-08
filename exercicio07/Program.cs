/*
[Estrutura de Repetição , Arrays]
Utilizando como base o programa do boletim (Exercício 3), crie uma nova versão dele, mas desta vez obtenha o nome do aluno, a quantidade de notas que serão utilizadas para compor a média, e cada uma das notas. 

Após as entradas o programa deve calcular as médias, somando todas as notas e dividindo pelo número de notas, validar se o aluno foi aprovado, ficou de recuperação ou reprovado, utilizando os mesmos critérios: 
Se nota maior ou igual 6 Aprovado 
Se nota maior ou igual 5, e menor que 6 : Recuperação 
Se nota menor que 5 : Exibir -> Reprovado 

E por fim o programa deve exibir o boletim do aluno, no formato: 
Aluno: {Nome aluno}  
N1: {nota1} 
N2: {nota2} 
N3 {Nota3}
Nn: {Notan}
Média: {Valor da media} - {Aprovado Recuperação ou Reprovado}

Ex: 
Saída: Qual o nome do aluno? 
Entrada :  Vitor
Saída: quantas notas serão usadas para compor a média? 
Entrada: 2 
Saída: Digite a 1a nota: 
Entrada: 8
Saída: Digite a 2a nota:
Entrada: 4
Saída : Aluno: Vitor
N1: 8
N2: 4
Média: 6 - Aprovado 
*/

float media = 0;
Console.WriteLine("Bem vindo ao Boletim Automático!");
Console.WriteLine("Qual o nome do aluno?");
string nome = Console.ReadLine();
Console.WriteLine("Quantas notas serão inseridas?");
int qnt = int.Parse(Console.ReadLine());
float[] notas = new float[qnt];
for (int i = 0; i < qnt; i++){
    Console.Write($"Digite a {i + 1}º nota: ");
    notas[i] = float.Parse(Console.ReadLine());
    media = notas[i] + media;
}
media = media / qnt;
Console.WriteLine($"Aluno {nome}");
for (int i = 0; i < qnt; i++){
    Console.WriteLine($"Nota {i}: {notas[i]}");
}
if (media >= 6){
    Console.WriteLine($"Média {media} - Aprovado!");
}
else if (media >= 5){
    Console.WriteLine($"Média {media} - Em recuperação!");
}
else {
    Console.WriteLine($"Média {media} - Reprovado!");
}