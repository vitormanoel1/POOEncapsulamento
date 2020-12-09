using System;
using POO_Encapsulamento.classes;

namespace POO_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            MasterCard master = new MasterCard();

            master.NomeTitular = "vitor manoel da silva";
            Console.WriteLine(master.NomeTitular);

            master.Numero = "743956119227";
            Console.WriteLine(master.Numero);
            
            master.Bandeira = "Mastercard";
            Console.WriteLine(master.Bandeira);

            Console.WriteLine(master.Token);

            master.Cvv = "2244556678";
            Console.WriteLine(master.Cvv);
        }
    }
}
