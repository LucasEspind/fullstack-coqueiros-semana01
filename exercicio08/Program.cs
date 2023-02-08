/*
[Estrutura de Repetição , Arrays (também é possível criar apenas com Repetição)]
Crie um programa que calcule a sequência de Fibonacci, A sequência de fibonacci, é uma sequência iniciada por 0 e 1, e cada número subsequente é calculado pela soma dos dois anteriores, no caso 0 +1 = 1, o próximo e 1 +1 = 2, seguindo 1 +2 = 3,. e assim por diante. chegando a fórmula Fn = F(n- 1) + (n-2).

Os primeiros números da sequência são: 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377…

Seu programa deve exibir os primeiros 20 números da sequência de Fibonacci.
*/

int num1 = 0;
int num2 = 1;
int contador = 0;
for (int i = 0; i < 10; i++){
    Console.WriteLine(num1);
    Console.WriteLine(num2);
    num1 = num1 + num2;
    num2 = num1 + num2;
    contador = i;
}
Console.WriteLine($"Quantidade: {contador}");