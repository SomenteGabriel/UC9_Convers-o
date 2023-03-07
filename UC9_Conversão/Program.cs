double temperatura = 0;
double conversao = 0;
string escolha = "";

Console.WriteLine("Deseja fazer a conversao para celsius ou fahrenheit? 'C' || 'F'. ");
escolha = Console.ReadLine();

switch(escolha)

{

    case "F":
        Console.WriteLine("Digite a temperatura em celsius")

;
        temperatura = Double.Parse(Console.ReadLine());

        conversao = (( temperatura * 9/5) + 32);

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine(conversao+", em fahrenheit");
                break;

        case "C":
       
        Console.WriteLine("Digite a temperatura em Fahrenheit");
        temperatura = Double.Parse(Console.ReadLine());

        conversao = ((temperatura-32)*5/9);

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine(conversao.ToString() + ", em Celsius");

        break;
}