// Ler a quantidade de vendidos e a quantidade de ingressos inteiros

double inteira = 30.00;
Console.WriteLine("Qual foi a quantidade de ingressos (inteiro) vendidos?");
double qtdInteira = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a quantidade de ingressos (inteira): ");
double ingressoInteira = Convert.ToDouble(Console.ReadLine());

// Ler o preço do ingresso meia e a quantidade de vendidos

double meia = inteira/2;
Console.WriteLine("Qual foi a quantidade de ingressos (meia) vendidos?");
double qtdMeia = Convert.ToDouble(Console.ReadLine());

// Calcular o total faturado

double total = (inteira * qtdInteira) + (meia * qtdMeia);
Console.WriteLine("O valor faturado foi: " + total);