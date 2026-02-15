//Exercicio 11) Troco
//Peça:
//- valor do produto
//- valor pago
//Mostre:
//- valor do troco
Console.WriteLine("Digite o valor do produto: ");
var produto = Console.ReadLine();
var produtoConvert = double.Parse(produto);
Console.WriteLine("Digite o valor pago: ");
var pago = Console.ReadLine();
var pagoConvert = double.Parse(pago);
var troco = pagoConvert - produtoConvert;
Console.WriteLine("O valor do troco é de R$ " + troco);
