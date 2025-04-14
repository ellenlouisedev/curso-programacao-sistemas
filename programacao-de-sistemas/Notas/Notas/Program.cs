//Crie um sistema que leia três notas

Console.WriteLine("Digite a 1° nota");
double n1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a 2° nota");
double n2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a 3° nota");
double n3 = Convert.ToDouble(Console.ReadLine());

//Calcule a soma das notas
double soma = n1 + n2 + n3;
Console.WriteLine("Soma das notas: " + soma);

//Calcule a média
double media = soma / 3;
Console.WriteLine("Média: " + Math.Round(media));