//Exercicio 2) Antecessor e sucessor
//Peça um número inteiro e mostre:
//- antecessor
//- sucessor
//Ex:
//Digite um número: 10
//Antecessor: 9
//Sucessor: 11
Console.WriteLine("Digite um número: ");
var numero = Console.ReadLine();
var numConvert = int.Parse(numero);
var antecessor = numConvert - 1;
var sucessor = numConvert + 1;
var mensagem = "O número antecessor é: " + antecessor;
var mensagem2 = "O número sucessor é: " + sucessor;
Console.WriteLine(mensagem);
Console.WriteLine(mensagem2);
