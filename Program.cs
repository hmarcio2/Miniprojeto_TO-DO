using TO_DO;

Interface tela = new Interface();
int opcao = -1;

while (opcao != 0)
{
    tela.tela_inicial();
    opcao = int.Parse(Console.ReadLine());
    tela.escolha(opcao);
}

Console.WriteLine("Programa encerrado");