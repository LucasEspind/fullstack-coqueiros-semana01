/*
[Estrutura de Repetição]
Crie um programa que receba um número inteiro, e a partir desse número exiba a tabuada do 0 até o 10 dele. Ex: Caso receba o número 2, a saída do programa deverá ser: 

2 X 0 = 0
2 X 1 = 2
2 X 2 = 4
2 X 3 = 6
2 X 4 = 8
2 X 5 = 10
2 X 6 = 12
2 X 7 = 14
2 X 8 = 16
2 X 9 = 18
2 X 10 = 20
*/

Console.WriteLine("Qual número deseja saber a taboada? ");
int numero = int.Parse(Console.ReadLine());
Console.WriteLine($"Tábuada do número {numero}");
for (int i = 0; i <= 10; i++){
    int resultado = numero * i;
    Console.WriteLine($"{numero} X {i} = {resultado}");
}