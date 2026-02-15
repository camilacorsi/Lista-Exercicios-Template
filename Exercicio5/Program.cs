//Exercicio 5) Conversão de metros para centímetros
//Peça um valor em metros e mostre o valor em centímetros.
//(1 metro = 100 cm)
Console.WriteLine("Digite um valor em metros: ");
var metro = Console.ReadLine();
var metroConvert = double.Parse(metro);
var centim = metroConvert * 100;
var centimConvert = int.Parse(centim);
var mensagem = "O valor dessa medida em centímetros é: " + centimConvert;
Console.WriteLine(mensagem);
