// Ler o valor do ingresso e a quantidade vendida

Console.WriteLine("Digite o preço do ingresso:");
double preco = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a quantidade de ingressos vendidos:");
double qtdVendidos = Convert.ToInt32(Console.ReadLine());

// Calcular o total faturado

double total = preco * qtdVendidos;
Console.WriteLine("O total faturado foi de: " + total);