using System;
namespace ComparacaoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "testando";
            Console.WriteLine(texto.CompareTo("1"));//CompareTo() COMPARA STRINGS IDÊNTICAS. RETORNA 0=SIM, 1=NÃO E -1=QUANDO LETRA MAIÚSCULA
            Console.WriteLine(texto.Contains("ando"));//Contains() COMPARA SE AO MENOS UM CARACTERE FAZ PARTE DA STRING. RETORNA BOOLEAN
            Console.WriteLine(texto.Contains("TESt", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(texto.CompareTo("Testando"));//RETORNA -1
        }
    }
}
