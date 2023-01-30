using System;

namespace MyApp 
{
    internal class Program
    {

        public virtual string verificaPalindromo(string numero){

            //primeiro, precisamos percorrer a string pela metade
            // afinal, esperamos um palíndromo
            for (int i = 0; i < numero.Length; i++){
                if(numero[i] == numero[numero.Length - i - 1]){
                    //cortando tudo, o que fazemos agora é comparar as posições
                    //a primeira e a última são iguais? a segunda e a penúltima?...

                    return "Sim!";
                }
            }
            return "Nope!";
        }

        static void Main(string[] args)
        {
            Program palindromo = new Program();

            Console.WriteLine("Digite um número: ");
            string numero = Console.ReadLine();
            Console.WriteLine(palindromo.verificaPalindromo(numero));
            
        }
    }
}
