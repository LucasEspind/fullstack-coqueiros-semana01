/*
[M1S01] Ex 3 - Boletim
[Estrutura de Decisão]
Crie um programa para calcular a média dos alunos e informar se o aluno foi aprovado, ficou de recuperação ou foi reprovado.

O programa deve receber 3 notas e calcular a média entre elas utilize a seguinte fórmula para calcular a média: media = (nota1 + nota2 + nota3 )3.  após calcular a média, verifique se o aluno foi aprovado seguindo os critérios: 
Se nota maior ou igual 6 : Saída-> Aluno Aprovado com média {Valor da Média} 
Se nota maior ou igual 5, e menor que 6 : Saída-> Aluno em Recuperação com média {Valor da Média} 
Se nota menor que 5 : Saída-> Aluno Reprovado com média {Valor da Média} 
*/

float media = 0;
Console.WriteLine("Digite as notas do aluno:");
for (int i = 0; i <= 2; i++){
    Console.WriteLine($"Nota {i + 1}");
    string notas = Console.ReadLine();
    float nota = float.Parse(notas);
    media = nota + media;
}
media = media/3;
if (media >= 6){
    Console.WriteLine($"Aluno Aprovado com média {media}!");
}
else if (media >=5){
    Console.WriteLine($"Aluno em Recuperação com média {media}!");
}
else {
    Console.WriteLine($"Aluno Reprovado com média {media}!");
}