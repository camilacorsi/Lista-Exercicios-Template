//DESAFIO
//Exercicio 15) Simulador de compra
//Peça:
//- nome do produto
//- preço unitário
//- quantidade
//Calcule:
//- valor total
//Mostre:
//Resumo da compra:
//Produto: X
//Quantidade: X
//Total: R$ X
//Use:
//- variáveis
//- conversões
//- concatenação
//- try/catch para preço e quantidade
//Sem laços.
try
{
    Console.WriteLine("Digite o nome do produto: ");
    var nome = Console.ReadLine();
    Console.WriteLine("Digite o preço unitário do produto: R$ ");
    var preco = Console.ReadLine();
    var precoConvert = double.Parse(preco);
    Console.WriteLine("Digite a quantidade do produto: ");
    var qtde = Console.ReadLine();
    var qtdeConvert = int.Parse(qtde);
    double total = precoConvert * qtdeConvert;
    string totalReal = total.ToString("F2");
    Console.WriteLine("____Resumo da Compra____");
    Console.WriteLine("Produto: " + nome);
    Console.WriteLine("Quantidade: " + qtdeConvert);
    Console.WriteLine("Total: R$ " + totalReal);

}

catch (FormatException)
{
    Console.WriteLine("Erro! Digite apenas números!");
}
