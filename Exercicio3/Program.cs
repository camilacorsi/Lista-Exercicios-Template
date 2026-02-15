//Exercício 3) Soma de dois números
//Leia dois números inteiros e mostre a soma dos números em uma frase completa
//Ex:
//A soma de 5 e 3 é 8
Console.WriteLine("Digite um número: ");
var n1 = Console.ReadLine();
var n1Convert = int.Parse(n1);
Console.WriteLine("Digite outro número: ");
var n2 = Console.ReadLine();
var n2Convert = int.Parse(n2);
var soma = n1Convert + n2Convert;
var mensagem = "A soma de " + n1 + " + " + n2 + " é igual a: " + soma;
Console.WriteLine(mensagem);
