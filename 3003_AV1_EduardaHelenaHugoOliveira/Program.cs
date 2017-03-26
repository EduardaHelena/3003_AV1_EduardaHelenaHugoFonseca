using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Itens
{
    public string Quantidade;
    public string Nome;
    public Itens next = null;

    public Itens(string Quantidade, string Nome)
    {
        this.Quantidade = Quantidade;
        this.Nome = Nome;
    }

}
  
namespace _3003_AV1_EduardaHelenaHugoOliveira
{
    internal class Inventario
    {
        private static void Main(string[] args)
        {
            Itens Pedra = new Itens("5", "Pedra");
            Itens Papel = new Itens("4", "Papel");
            Itens Tesoura = new Itens("3", "Tesoura");
            Itens Caneta = new Itens("3", "Caneta");
            Itens Bussola = new Itens("3", "Bussola");
            Itens Mapa = new Itens("2", "Mapa");
            Itens Veneno = new Itens("2", "Veneno");
            Itens Pistola = new Itens("2", "Pistola");


            Pedra.next = Papel;
            Papel.next = Tesoura;
            Tesoura.next = Caneta;
            Caneta.next = Bussola;
            Bussola.next = Mapa;
            Mapa.next = Veneno;
            Veneno.next = Pistola;
            
            //currentElement != null;

            // Iterando com Usuario

                Console.WriteLine("Seja Bem-Vindo ao seu Invetario");
                Console.WriteLine("Deseja fazer uma busca no seu inventario? ");
                Console.WriteLine("");
                string RespostaBusca = Console.ReadLine();

            while (RespostaBusca == "Sim" || RespostaBusca == "sim")
            {
                
                
                    Console.WriteLine("");
                    Console.WriteLine("Digite o item que deseja procurar: (Pedra, Papel, Tesoura, Caneta, Bussola, Mapa, Veneno ou Pistola)");
                    string RespostaUsuario = Console.ReadLine();
                    Itens currentElement = Pedra;

                int posicao = 1;

                    while (RespostaUsuario != null)
                    {
                        if (RespostaUsuario == currentElement.Nome)
                        {
                            Console.WriteLine("");
                            Console.WriteLine(" Nome do Item: " + currentElement.Nome);
                            Console.WriteLine(" Posicao do Item na lista: " + posicao);
                            Console.WriteLine(" Quantidade: " + currentElement.Quantidade);
                            Console.WriteLine("");
                            Console.Write("Deseja fazer uma nova busca?");
                            Console.WriteLine("");
                            RespostaBusca = Console.ReadLine();
                            RespostaUsuario = null;
                        }

                        else if (RespostaUsuario != currentElement.Nome)
                        {
                            currentElement = currentElement.next;
                            posicao++;
                        }

                    }
                
            }

             if (RespostaBusca == "Nao" || RespostaBusca == "Não")
            {
                Environment.Exit(0);
            }

            else if (RespostaBusca != "Sim" || RespostaBusca != "sim" || RespostaBusca != "Nao" || RespostaBusca != "Não")
            {
                Console.WriteLine("Desculpe, esse comando nao existe");
                Console.WriteLine("Deseja fazer uma nova busca?");
                RespostaBusca = Console.ReadLine();
            }

           
            Console.ReadKey();
        }
            /*while (RespostaUsuario)
                
                Console.WriteLine(" Nome do Item: " + currentElement.Nome);
                Console.WriteLine(" Quantidade: " + currentElement.Quantidade);
                currentElement = currentElement.next;
                Console.WriteLine();
            

            Console.WriteLine("Acabou a lista");*/
          
        
       
    }
}
