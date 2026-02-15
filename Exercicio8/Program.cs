//Exercicio 8) Soma segura
//Peça dois números.
//Use try/catch para evitar erro de conversão.
//Se der erro:
//Mostrar mensagem amigável e encerrar.
try
{
    Console.WriteLine("Digite um número: ");
    var n1 = Console.ReadLine();
    var n1Convert = int.Parse(n1);

    Console.WriteLine("Digite outro número: ");
    var n2 = Console.ReadLine();
    var n2Convert = int.Parse(n2);

    var soma = n1Convert + n2Convert;
    Console.WriteLine("A soma dos números digitados é de: " + soma);
}
catch (FormatException)
{
    Console.WriteLine("O campo somente aceita números");
}
