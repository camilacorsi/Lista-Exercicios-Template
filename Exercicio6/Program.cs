//Exercicio 6) Conversão de temperatura
//Peça uma temperatura em Celsius e converta para Fahrenheit.
//Fórmula:
//F = (C × 9 / 5) +32
Console.WriteLine("Digite a temperatura em graus Celsius: ");
var celsius = Console.ReadLine();
var celsiusConvert = double.Parse(celsius);
var far = (celsiusConvert * 9 / 5) + 32;
var mensagem = "O valor dessa temperatura em graus Fahrenheit é: " + far;
Console.WriteLine(mensagem);
