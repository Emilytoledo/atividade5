using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade5
{









    class Program
    {
        static void Main(string[] args)
        {
            string promoções;
            string ok;
            string cupom;
            string endereco;
            string bairro;
            string cidade;
            string estado;
            string nome_cliente;
            string sobrenome;
            int viagens, quantidade;
            double soma;
            
            
                    Console.WriteLine("Olá!!! Somos da agência Emy Turismo ");
            Console.WriteLine("Digite o seu nome");
            nome_cliente = Console.ReadLine();

            Console.WriteLine("Digite seu sobrenome");
            sobrenome = Console.ReadLine();

            Console.WriteLine($"Olá, Sr.{nome_cliente}, para darmos andamento ao seu cadastro... Por gentileza, digite ok!");
            ok = Console.ReadLine();

            Console.WriteLine("Nos conte um pouco sobre você. Digite seu endereço.");
            endereco = Console.ReadLine();

            Console.WriteLine("Digite sua cidade?");
            cidade = Console.ReadLine();

            Console.WriteLine("Digite seu bairro?");
            bairro = Console.ReadLine();

            Console.WriteLine("Digite seu estado?");
            estado = Console.ReadLine();

            Console.WriteLine($"O Sr.{sobrenome}, mora na cidade de {cidade} - {estado}, no endereço {endereco}" +
                $", localizado no bairro {bairro}");

            Console.WriteLine($"Agora queremos saber quantas viagens o(a) Sr(a).{nome_cliente} realizou ano passado?");
            viagens = (int)double.Parse(s: Console.ReadLine());

            Console.WriteLine("Você planejou quantas viagens para esse ano?");
            quantidade = (int)double.Parse(s: Console.ReadLine());

            soma = viagens + quantidade;


            Console.WriteLine($"Vemos aqui no sistema que o Sr.{nome_cliente} realizou no ano passado {viagens} viagens e no ano atual pretende viajar {quantidade} vezes, somando as viagens do ano anterior e o ano atual equivalem a {soma}");

            Console.WriteLine("\n\n");

            Console.WriteLine($"Dessa forma, faltam {soma - 10 } para completar 10 viagens no total ");

            Console.WriteLine($"A sua média de viagens é de {24 / soma}");

            Console.WriteLine($"No intervalo de meses de {12 / quantidade}");


            Console.WriteLine("Digite seu cupom");
            cupom = Console.ReadLine();

            if (cupom == "conradito10")
            {

                Console.WriteLine("Parábens você recebeu 10% de desconto na sua próxima viagem");

            }
            else
            {
                Console.WriteLine("Cupom inválido!");
            }

            Console.WriteLine("Você deseja receber promoções no seu e-mail?");
            promoções = Console.ReadLine();

            if (promoções == "sim")
            {
                Console.WriteLine($"Então vamos lá! Digite seu {nome_cliente}");
                Console.WriteLine("Cadastrado(a) com sucesso!Em breve você receberá novos e-mails. ");
              
            }

            else
            {
                Console.WriteLine("Ok!Você não receberá promoções.");
                Console.WriteLine("Obrigado e volte sempre!");
            }

            

            Console.ReadKey();

        }
    }
}