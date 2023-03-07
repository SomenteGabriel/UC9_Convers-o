double temperatura = 0;
double conversao = 0;

Console.WriteLine("Digite a temperatura em celsius");
temperatura = Double.Parse(Console.ReadLine());


conversao = ( temperatura * (9/5)) + 32;

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine(conversao+", em fahrenheit");