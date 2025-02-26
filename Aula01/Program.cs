using System.Net.NetworkInformation;
using System.Security.Cryptography;

namespace Aula01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 21;
            string nomeCompleto = "Joana Silva";

            var teste = "Joana"; 

            Console.WriteLine(teste.GetType());

            Console.WriteLine("Digite seu nome: ");
            string nomeUsuario = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            string idadeUsuario = Console.ReadLine();


            Console.WriteLine($"Meu nome é {nomeUsuario} e minha idade é {idadeUsuario}");
        }
    }
}