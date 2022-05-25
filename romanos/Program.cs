// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var romanos = new Dictionary<string, int>();

romanos.Add("I", 1);
romanos.Add("V", 5);
romanos.Add("X", 10);
romanos.Add("L", 50);
romanos.Add("C", 100);
romanos.Add("D", 500);
romanos.Add("M", 1000);

Console.WriteLine("Digite um numero Romano: ");
string entrada = Console.ReadLine();

var letrasEntrada = entrada.Substring(0);
var resultado = 0;

for (int i = 0; i < letrasEntrada.Length; i++)
{
    if (romanos.ContainsKey(letrasEntrada[i].ToString()))
    {
      
        if ((letrasEntrada[i].Equals('I') && letrasEntrada[i + 1].Equals('V')) || 
            (letrasEntrada[i].Equals('I') && letrasEntrada[i + 1].Equals('X')) ||
            (letrasEntrada[i].Equals('X') && letrasEntrada[i + 1].Equals('L')) ||
            (letrasEntrada[i].Equals('X') && letrasEntrada[i + 1].Equals('C')) ||
            (letrasEntrada[i].Equals('C') && letrasEntrada[i + 1].Equals('D')) ||
            (letrasEntrada[i].Equals('C') && letrasEntrada[i + 1].Equals('M'))
            )
        {
            Console.WriteLine($"letra atual:{letrasEntrada[i]} ");
            Console.WriteLine($"Proxima letra:{letrasEntrada[i + 1]} ");
            resultado += (romanos[letrasEntrada[i+1].ToString()]) - (romanos[letrasEntrada[i].ToString()]);
            i++;

        }
        else
        {
           resultado += romanos[letrasEntrada[i].ToString()];

        }

        /*   for (int verificaRomano = 0; verificaRomano < 6 ; verificaRomano++)
           //foreach (string numeroR in romanos.Keys)
            {

                   if((entradaVetor[i].Equals('I') && entradaVetor[i+1].Equals('V')) || (entradaVetor[i].Equals('I') && entradaVetor[i+1].Equals('X')))
               {

                   resultado -= 1;

               }  


            }*/

    }else
    {
        Console.WriteLine("Contém um ou mais caracteres que não fazem parte do número Romano.");
        break;
    }
    
}
if (resultado > 0)
{
    Console.WriteLine($"CONVERSÃO MAL SUCEDIDA: O numero romano {entrada} é {resultado} no padrão inteiro");
}

