//Exercicio 4) Calculadora simples
//Leia dois números inteiros e mostre:
//- soma
//- subtração
//- multiplicação
//- divisão inteira
Console.WriteLine("Digite um número: ");
var n1 = Console.ReadLine();
var n1Convert = int.Parse(n1);
Console.WriteLine("Digite outro número: ");
var n2 = Console.ReadLine();
var n2Convert = int.Parse(n2);

var soma = n1Convert + n2Convert;
var mensagemSoma = "A soma de " + n1 + " + " + n2 + " é igual a: " + soma;
Console.WriteLine(mensagemSoma);

var subt = n1Convert - n2Convert;
var mensagemSubt = "A subtração de " + n1 + " - " + n2 + " é igual a: " + subt;
Console.WriteLine(mensagemSubt);

var mult = n1Convert * n2Convert;
var mensagemMult = "A multiplicação de " + n1 + " * " + n2 + " é igual a: " + mult;
Console.WriteLine(mensagemMult);

var div = n1Convert / n2Convert;
var mensagemDiv = "A divisão de " + n1 + " / " + n2 + " é igual a: " + div;
Console.WriteLine(mensagemDiv);
