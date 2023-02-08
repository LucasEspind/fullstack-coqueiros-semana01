/*
[M1S01] Ex 2 - Área do Triângulo 
[Variáveis]
Crie um programa que receba os valores da base e da altura de um triângulo qualquer, e calcule a área do triângulo usando a fórmula area =(base x altura)/2 e exiba o resultado para o usuário: 
Saída: A área do triângulo é {area}
*/

Console.WriteLine("Qual o valor da base?");
string valorBasetemp = Console.ReadLine();
float valorBase = float.Parse(valorBasetemp);
Console.WriteLine("Qual o valor da altura? ");
string valorAlttemp = Console.ReadLine();
float valorAltura = float.Parse(valorAlttemp);
float area = (valorBase * valorAltura)/2;
Console.Write($"A área do triângulo é {area}");
