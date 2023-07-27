using System;
using System.Data;

class Array
{
    static void Main(string[] args)
    {
        /*int[] notas = new int[3];
        
            Console.WriteLine("Digite de 2 notas: ");
            notas[0] = Convert.ToInt32(Console.ReadLine());
            notas[1] = Convert.ToInt32(Console.ReadLine());
            notas[2] = (notas[0] + notas[1]) /2; 

            Console.WriteLine("Sua média é: " + notas[2]);*/

        List<string> listaNomes = new List<string>();//O LIST NAO PRECISA ESPECIFICAR O TAMANHO
        listaNomes.Add("Ana");
        listaNomes.Add("Alex");
        listaNomes.Add("Maria");
        listaNomes.Add("Abel");
        listaNomes.Add("Renato");

       
        listaNomes.Remove("Alex");//TIRA O ALEX DA LISTA
        listaNomes.RemoveAt(0);//TIRA A POSICAO 0 DA LISTA
        listaNomes.RemoveRange(0, 2);//REMOVE AS POSICOES DE 0 A 2 DA LISTA
        listaNomes.Clear();//REMOVE TODOS OS ELEMENTOS DA LISTA
        listaNomes.Insert(0, "Elias");//NA POSICAO 0 DA LISTA SERA SALVO ELIAS
        listaNomes.Sort();//ORGANIZA DE A a Z
        listaNomes.Reverse();//ORGANIZA DE Z a A
        listaNomes.Count();//O NUMERO DE ELEMENTOS NESTA LISTA
        listaNomes.Contains("Elias");//CONSULTA SE NA LISTA CONTEM ELIAS
        listaNomes.IndexOf("Elias");//QUAL A POSICAO DA LISTA QUE ESTA ESCRITO ELIAS

        List<string> listaNomes2 = new List<string>();//O LIST NAO PRECISA ESPECIFICAR O TAMANHO
        listaNomes2.Add("Pedro");
        listaNomes2.Add("Paulo");
        listaNomes.AddRange(listaNomes2);//ADICIONA A listaNomes em listaNomes2
        listaNomes.InsertRange(0, listaNomes2);//ADICIONA A listaNomes2 NA POSICAOI 0 DA listaNomes

        foreach (string nomes in listaNomes)
        {

        }
    }
}