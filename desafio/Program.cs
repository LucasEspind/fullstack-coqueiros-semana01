/*
[Listas, estrutura de repetição, estrutura de decisão ]
Agora que estão feras no assunto, crie um programa bancário, que contenha duas funcionalidades, adicionar Transação e Consultar Extrato; 

Ao iniciar o programa ele deverá exibir um menu de boas vindas ex:
Saída: Bem vindo ao Banco Nacional Coqueiros, por favor selecione uma opção para continuar: 
Adicionar Transação;
Consultar extrato;
Sair;

o usuário deve selecionar a opção desejada, caso selecione uma opção inválida, o programa deverá novamente apresentar o menu; 

Caso selecione a opção 1 - Adicionar Transação: o programa deverá ler o valor da transação informada  pelo cliente, e adicionar em uma lista de transações;

Caso selecione a opção 2 - Consultar extrato, deve ser impresso todo o histórico de transações, presente  na lista de transações, e ao final exibir o saldo, que é a somatória de toda a lista de transação (seja ele positivo ou negativo);

Caso selecione a opção 3 - Sair o programa deve ser encerrado;
*/
int escolha = 1;
float total = 0;
var saldo = new List<float>();
do{
    Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
    Console.WriteLine("Bem vindo ao Banco Nacional Coqueiros, por favor selecione uma opção para continuar:");
    Console.WriteLine("1 - Adicionar Transação;");
    Console.WriteLine("2 - Consultar extrato;");
    Console.WriteLine("3 - Sair;");
    Console.Write("Opção: ");
    escolha = int.Parse(Console.ReadLine());
    Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
    if (escolha == 1){
    Console.WriteLine("Qual será a transação?");
    Console.Write("R$ ");
    saldo.Add(float.Parse(Console.ReadLine()));
    Console.WriteLine("Valor adicionado!");
    Thread.Sleep(500);
}
else if ( escolha == 2){
    for (int i = 0; i < saldo.Count; i++){
        Console.WriteLine($"R$ {saldo[i]}");
        total = saldo[i] + total;
    }
    Console.WriteLine($"Saldo total: {total}");
    Thread.Sleep(500);
}
else if ( escolha == 3){
    Console.WriteLine("Finalizando programação, tenha um bom dia!");
    for (int i = 0; i < 42; i++){
        Console.Write("-=");
        Thread.Sleep(10);
    }
    Console.Write("-");
    break;
}
else {
    Console.WriteLine("Opção Invalida!");
    Thread.Sleep(1000);
}
}while(escolha != 1 || escolha != 2 || escolha != 3);
