/*
[M1S01] Ex 4 - Imposto sobre folha
[Estrutura de Decisão]
 Crie um programa para o cálculo de imposto sobre uma folha de pagamento, o programa deve receber o valor do salário bruto, e de acordo com os critérios abaixo, calcular o valor do imposto a pagar:

Salário Bruto até R$900,00 (inclusive) – Isento; - neste caso o programa retorna 0;
Salário Bruto de R$ 1500, 00 (inclusive) – desconto de 5%;
Salário bruto até R$ 2500,00 (Inclusive) – desconto de 10%;
Salário bruto acima de 2500 – Desconto de 20%.

Ex: 
Se o salário bruto for de 1800,00 - o desconto será de 10%, de acordo com a tabela, portanto  o valor de imposto devido será de R$180,00.
Se o salário bruto for de 2500,00 - o desconto será de 10%, de acordo com a tabela, portanto  o valor de imposto devido será de R$250,00.

Exiba o valor que será cobrado de imposto sobre o salário.

*Dica para calcular o percentual utilize a fórmula salario / 100 * percentual 
*/

Console.WriteLine("Digite o valor do salário:");
float salario = float.Parse(Console.ReadLine());
float desconto;
if (salario <= 900){
    Console.WriteLine($"Para o salário de R$ {salario} não existem descontos (isento)");
}
else if (salario <= 1500){
    desconto = salario / 100 * 5;
    Console.WriteLine($"Para o salário de R$ {salario} existe um desconto de 5%, valor atualizado R${desconto}");
}
else if (salario <= 2500){
    desconto = salario / 100 * 10;
    Console.WriteLine($"Para o salário de R$ {salario} existe um desconto de 10%, valor atualizado R${desconto}");
}
else {
    desconto = salario / 100 * 20;
    Console.WriteLine($"Para o salário de R$ {salario} existe um desconto de 20%, valor atualizado R${desconto}");
}