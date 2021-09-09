using AgenciaBancaria.Dominio;
using System;

namespace AgenciaBancaria.App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                Cliente cliente = new Cliente("Ramom", "123123", "321321",
                    "Minha Rua", "12345678", "Recife", "PE");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
