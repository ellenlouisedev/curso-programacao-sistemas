//Crie um sistema que leia o capital, taxa e o tempo para calcular o juros simples

double capital;
double taxa;
double tempo;
double juros;

Console.WriteLine("Digite o valor a ser investido:");
capital = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o valor da taxa ao mês:");
taxa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o tempo em meses:");
tempo = Convert.ToDouble(Console.ReadLine());

juros = capital * taxa/100 * tempo;

Console.WriteLine("Juros: " + Math.Round(juros, 2));

double montante = capital + juros;

Console.WriteLine("Montante: " + Math.Round(montante, 2));