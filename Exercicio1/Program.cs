//Exercício 1) Dobro de um número
//Peça um número inteiro ao usuário e mostre:
//- o número digitado
//- o dobro desse número
Console.WriteLine("Digite um número: ");
var numero = Console.ReadLine();
var numConvert = int.Parse(numero);
var dobro = numConvert * 2;
var mensagem = "O dobro desse número é: " +  dobro;
Console.WriteLine(mensagem);
