//Exercicio 12) Área do retângulo
//Peça base e altura.
//Mostre:
//- área
//- perímetro
Console.WriteLine("Digite a base do retângulo: ");
var baseret = Console.ReadLine();
var baseConvert = double.Parse(baseret);

Console.WriteLine("Digite a altura do retângulo: ");
var altura = Console.ReadLine();
var alturaConvert = double.Parse(altura);

var area = baseConvert * alturaConvert;
Console.WriteLine("A área do retângulo é de : " + area);

var perimetro = 2 * area;
Console.WriteLine("O perímetro do retângulo é de : " + perimetro);
