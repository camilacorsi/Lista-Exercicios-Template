//Exercicio 9) Divisão segura
//Peça dois números e faça a divisão.
//Tratar:
//- erro de conversão
//- divisão por zero
//Mostrar mensagens apropriadas.
try
{
    Console.WriteLine("Digite um número: ");
    var n1 = Console.ReadLine();
    var n1Convert = int.Parse(n1);

    Console.WriteLine("Digite outro número: ");
    var n2 = Console.ReadLine();
    var n2Convert = int.Parse(n2);

    var div = n1Convert / n2Convert;
    Console.WriteLine(div);
}

catch (FormatException)
{
    Console.WriteLine("erro de conversão");
}

catch(System.DivideByZeroException)
{ 
    Console.WriteLine("denominador não pode ser zero");
}
