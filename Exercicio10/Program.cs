//Exercicio 10) Salário mensal
//Peça:
//- valor por hora
//- horas trabalhadas no mês
//Calcule e mostre salário final.
Console.WriteLine("Quanto você ganha por hora: ");
var valor = Console.ReadLine();
var valorConvert = double.Parse(valor);
Console.WriteLine("Quanta horas você trabalhou no mês: ");
var hora = Console.ReadLine();
var horaConvert = double.Parse(hora);
var salFinal = valorConvert * horaConvert;
Console.WriteLine("Seu salário final foi de: R$ " + salFinal);
