//Exercício 14) Minicalculadora com método
//Crie um método:
//int Somar(int a, int b)
//No programa principal:
//- leia dois números
//- chame o método
//- mostre resultado

Console.WriteLine("Digite um numero: ");
var a = Somar();

Console.WriteLine("Digite outro numero: ");
var b = Somar();

Console.WriteLine("A soma dos valores é igual a " + mensagem);

static int Somar()
{
    int a = Console.ReadLine();
    var aConvert = int.Parse(a);

    int b = Console.ReadLine();
    var bConvert = int.Parse(b);

    int soma = aConvert + bConvert;

    var mensagem = soma;
    return mensagem;

}
