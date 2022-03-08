using System;

namespace Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            int ContCons = 0;
            int contEspa = 0;
            string nome;
            Console.WriteLine("Digite seu nome completo: ");
            //string nome = Convert.ToString(Console.ReadLine());
            nome = Console.ReadLine();
            nome = nome.ToLower();
            

            for (int i = 0; i < nome.Length; i++)
            {
                /*
                if( (nome[i] == 'a') || (nome[i] == 'A') || (nome[i] == 'e') || (nome[i] == 'E') || 
                    (nome[i] == 'i') || (nome[i] == 'I') || (nome[i] == 'o') || (nome[i] == 'O') || 
                    (nome[i] == 'u') || (nome[i] == 'U'))
                {
                    cont++;
                }*/
                if (nome[i] == 'a' || nome[i] == 'e' ||
                    nome[i] == 'i' || nome[i] == 'o' ||
                    nome[i] == 'u')
                {
                    cont++;
                }
                else
                {
                    if (nome[i] == ' ')
                    {
                        contEspa++;
                    }
                    else
                    {
                        ContCons++;
                    }

                }
            }
            Console.WriteLine("O seu nome tem {0} vogais", cont);
            Console.WriteLine("O seu nome tem {0} consoantes", ContCons);
            Console.WriteLine("O seu nome tem {0} espaços", contEspa);
        }
    }
}
