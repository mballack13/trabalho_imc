using System;

namespace trabalhando01
{
    class Program
    {
        static void Main(string[] args)
        {
            string user_nome, user_sexo;
            double user_peso, user_altura;

            Pessoa pessoando_01 = new Pessoa();


            //captar valores vindo do usuário
            Console.WriteLine("qual seu nome? ");
            user_nome = Console.ReadLine();

            Console.WriteLine("qual seu sexo? ");
            user_sexo = Console.ReadLine();

            Console.WriteLine("qual seu peso? ");
            user_peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("qual seu altura? ");
            user_altura = Convert.ToDouble(Console.ReadLine());



            //mostrar resultados
            Console.Clear();
            Console.WriteLine(" sr/srª " + user_nome + ", de sexo: " + user_sexo.ToLower()+"\n estas são as seguintes informações sobre seu corpo:");
            Console.WriteLine(" seu IMC é de...: "+pessoando_01.metodoIMC(user_peso, user_altura));
            Console.WriteLine(" sua massa não confiavel (30% do IMC) é de...: "+pessoando_01.MassaBrancaNConfiavel(user_peso, user_altura));
            Console.WriteLine(pessoando_01.RetornoClassificacaoIMC(user_peso, user_altura));

        }
    }
}
