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

                Endereco endereco = new Endereco("Minha Rua", "12345678", "Recife", "PE");
                Cliente cliente = new Cliente("Ramom", "123123", "321321", endereco);

                ContaCorrente conta = new ContaCorrente(cliente, 1000);

                string senha = "abc123456789";
                conta.Abrir(senha);

                Console.WriteLine("Conta: " + conta.Situacao + ": " + conta.NumeroConta + "-" + conta.DigitoVerificador);

                conta.Sacar(100, senha);

                Console.WriteLine("Saldo: " + conta.Saldo);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
