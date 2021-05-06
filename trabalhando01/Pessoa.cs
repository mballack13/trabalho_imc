using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhando01
{
    class Pessoa
    {
        /*
        https://classroom.google.com/u/1/c/MzAyNTM4Mjc0MDY1/m/MzMxNjU4MjM1OTY2/details
        */

        string nome, sexo;
        double peso, altura;



        //getter's and setter's
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public double metodoIMC (double peso, double altura)
        {
            double alturando = altura * altura;
            return peso / alturando;
        }


        //classes
        public double MassaBrancaNConfiavel (double peso, double altura)
        {
            //variaveis
            double todaMassa, resultFinal;

            //desenvolvimento
            todaMassa = metodoIMC(peso, altura);
            resultFinal = todaMassa - ((todaMassa * 30) / 100);

            //resultado final
            return resultFinal;
        }//public double MassaBrancaNConfiavel (double peso, double altura)


        public String RetornoClassificacaoIMC (double peso, double altura)
        {
            //variaveis
            double todaMassa, regra01 = 0.00185, regra02 = 0.00249,
                regra03 = 0.00299, regra04 = 0.00249, regra05 = 0.00349,
                regra06 = 0.00399;
            string resultFinal="";

            //desenvolvimento & resposta
            todaMassa = metodoIMC(peso, altura);
                if (todaMassa < regra01) { resultFinal = "status..: abaixo do peso"; }
                
                else if ((todaMassa > regra01) && (todaMassa <= regra02))
                { return resultFinal = " status..: peso normal";}
            
                else if ((todaMassa > regra02) && (todaMassa <= regra03))
                { return resultFinal = " status..: sobrePeso";}
            
                else if ((todaMassa > regra03) && (todaMassa <= regra04))
                { return resultFinal = " status..: obesidade grau 1"; }

                else if ((todaMassa > regra04) && (todaMassa <= regra05))
                { return resultFinal = " status..: obesidade grau 2"; }

                else if ((todaMassa > regra05) && ((todaMassa <= regra06) || (todaMassa > regra06)))
                { return resultFinal = " status..: obesidade grau 3"; }

            return "";
        }

    }//class Pessoa
}//namespace trabalhando01
