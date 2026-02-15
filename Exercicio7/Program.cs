//Exercicio 7) Leitura segura de número
//Peça um número inteiro.
//Use try/catch .
//Se o usuário digitar texto:
//Mostrar: "Entrada inválida. Digite apenas números."
try
{
    Console.WriteLine("Digite um número inteiro: ");
    var numero = Console.ReadLine();
    var numConvert = int.Parse(numero);
    Console.WriteLine(numConvert);
}
catch (FormatException)
{
    Console.WriteLine("Entrada inválida. Digite apenas números");
}
