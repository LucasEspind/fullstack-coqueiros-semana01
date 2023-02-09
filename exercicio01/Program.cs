/* Exercicio 01 [M1S01] Ex 1 - Entrevista
[Variáveis]
Faça um programa que pergunte e colete Nome, Sobrenome, Idade e Cor favorita, do usuário, e no final exiba as respostas do usuário.

Ex: 
Saída: Olá, Tudo bem? Qual o seu nome?
Entrada: {usuário digita nome}
Saída: Qual o seu sobrenome?
Entrada: {usuário digita sobrenome}
Saída: Qual a sua idade?
Entrada: {usuário digita idade}
Saída: Qual a sua cor favorita ?
Entrada: {usuário digita a cor favorita}
Saída: Nome: {nome Usuário}
Sobrenome: {sobrenome Usuário}
Idade: {idade Usuário}
Cor Favorita: {cor Favorita Usuário}*/

Console.Write("Olá, Tudo bem? Qual o seu nome? ");
string nome = Console.ReadLine();
Console.Write("Qual o seu sobrenome? ");
string sobrenome = Console.ReadLine();
Console.Write("Qual a sua cor favorita? ");
string corFav = Console.ReadLine();
Console.Write("Qual a sua idade? ");
int idade = int.Parse(Console.ReadLine());


Console.WriteLine($"Olá {nome} {sobrenome}, prazer em te conhecer! Estes são os dados que coletei com você:");
Console.WriteLine($"Nome: {nome}");
Console.WriteLine($"Sobrenome: {sobrenome}");
Console.WriteLine($"Idade: {idade}");
Console.WriteLine($"Cor Favorita: {corFav}");
