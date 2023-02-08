/*
[Estrutura de Decisão]
Faça um programa que peça os 3 lados de um triângulo. O programa deverá informar se os valores podem ser um triângulo, primeiro passo será verificar se os lados formam um triângulo. para isso valide: 
 Se a soma de quaisquer dos dois lados é maior que o terceiro:
Lado1 + Lado2 > Lado3 ou;
Lado3 + Lado2 > Lado1 ou;
Lado3 + Lado1 > Lado2 ou;
Caso nenhuma das opções seja verdadeira, seu programa deverá informar que as medidas não formam um triângulo e encerrar.

Caso formem um triângulo, informe  qual o tipo dele: equilátero, isósceles ou escaleno. Dicas:
Triângulo Equilátero: três lados iguais;
Lado1 = Lado2 = lado3
Triângulo Isósceles: quaisquer dois lados iguais;
Lado1 = Lado2 ou;
Lado2 = Lado3 ou;
Lado3 = Lado1 ou;
Triângulo Escaleno: três lados diferentes;
Lado1 != Lado2 E;
Lado2 != Lado3 E;
Lado3 != Lado1 E;
*/
float[] lado = new float[3];
for (int i = 0; i <= 2; i++){
    Console.WriteLine($"Qual o valor do lado {i + 1}");
    lado[i] = float.Parse(Console.ReadLine());
}
if (lado[0] + lado[1] > lado[2] && lado[1] + lado[2] > lado[0] && lado[0] + lado[2] > lado[1]){
    if (lado[0] == lado[1] && lado[1] == lado[2]){
        Console.WriteLine("Temos um triângulo equilátero ou seja, três lados iguais!");
        for ( int i = 0; i <= 2; i++){
            Console.WriteLine($"Lado {i + 1}: {lado[i]}");
        }
    }

    else if (lado[0] == lado[1] || lado[1] == lado[2]){
        Console.WriteLine("Temos um triângulo isósceles ou seja, quaisquer dois lados iguais!");
        for ( int i = 0; i <= 2; i++){
            Console.WriteLine($"Lado {i + 1}: {lado[i]}");
        }
    }
    else {
        Console.WriteLine("Temos um triângulo escaleno ou seja, três lados diferentes!");
        for ( int i = 0; i <= 2; i++){
            Console.WriteLine($"Lado {i + 1}: {lado[i]}");
        }
    }
}
else {
    Console.WriteLine("Desculpe, as medidas informadas não formam um triangulo.");
}