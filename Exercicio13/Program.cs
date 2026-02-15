//Exercicio 13) Média de duas provas
//Peça duas notas (double).
//Mostre média com 2 casas decimais.
//Dica:
//Use ToString("F2")
Console.WriteLine("Digite a primeira nota: ");
var n1 = Console.ReadLine();
var n1Convert = double.Parse(n1);
Console.WriteLine("Digite a segunda nota: ");
var n2 = Console.ReadLine();
var n2Convert = double.Parse(n2);
var media = (n1Convert + n2Convert)/2;
var mediaConv = Convert.ToString(media);
Console.WriteLine("Sua média foi de: " + mediaConv);
