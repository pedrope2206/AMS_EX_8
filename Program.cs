int A = 0;
int B = 0;
int resultado = 0;
string nome = "";

Console.WriteLine("Olá, qual é o seu nome?");
nome = Console.ReadLine();
Console.WriteLine(" ");

Console.WriteLine($"{nome}, me informe o valor de (A)");
A = Convert.ToInt16(Console.ReadLine());
Console.WriteLine(" ");

Console.WriteLine("Agora me informe o valor de (B)");
B = Convert.ToInt16(Console.ReadLine());
Console.WriteLine(" ");

resultado = A - B;

if (resultado > 0)
{
    Console.WriteLine("==================================================================");
    Console.WriteLine($"O valor total é {resultado}, e é positivo!");
    Console.WriteLine("==================================================================");
}
else if (resultado == 0)
{
    Console.WriteLine("==================================================================");
    Console.WriteLine($"O valor total é {resultado}, e é neutro ou seja, é igual a 0!");
    Console.WriteLine("=================================================================="); 
}
else
{
    Console.WriteLine("=================================================================="); 
    Console.WriteLine($"O valor total é {resultado}, e é negativo!");
    Console.WriteLine("=================================================================="); 
}


