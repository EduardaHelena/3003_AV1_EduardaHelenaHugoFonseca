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
            Itens Pedra = new Itens("2", "Pedra");
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
            Itens currentElement = Pedra;
            

            //currentElement != null;

            // Iterando com Usuario

            Console.WriteLine("Seja Bem-Vindo ao seu Invetario");
            Console.WriteLine("Deseja fazer uma busca no seu inventario? ");
            Console.WriteLine("");
            string RespostaBusca = Console.ReadLine();
            
            int posicao = 1;
           

            while (RespostaBusca == "Sim" || RespostaBusca == "sim")
            {

                Console.WriteLine("");
                Console.WriteLine("Digite o item que deseja procurar: (Pedra, Papel, Tesoura, Caneta, Bussola, Mapa, Veneno ou Pistola)");
                string RespostaUsuario = Console.ReadLine();
                

                while (RespostaUsuario != null)
                {
                    if (RespostaUsuario == currentElement.Nome)
                    {
                        Console.WriteLine("");
                        Console.WriteLine(" Nome do Item: " + currentElement.Nome);
                        Console.WriteLine(" Posicao do Item na lista: " + posicao);
                        Console.WriteLine(" Quantidade: " + currentElement.Quantidade);
                        Console.WriteLine("");
                        Console.WriteLine("Deseja ultilizar item? (Sim ou Nao)");
                        string RespostaUsoItem = Console.ReadLine();

                        if (RespostaUsoItem == "Sim" || RespostaUsoItem == "sim")
                        {
                            int numeroitem = Int32.Parse(currentElement.Quantidade);

                            if (numeroitem > 0)
                            {
                                numeroitem--;
                                string quantidadeitem = numeroitem.ToString();
                                currentElement.Quantidade = quantidadeitem;
                                
                            }

                            else if (numeroitem == 0 && posicao == 1)
                            {

                                Console.WriteLine("Voce nao tem mais esse item");
                                Console.WriteLine();
                                currentElement = currentElement.next;                             
                                Console.WriteLine(currentElement.Nome);
                                Console.WriteLine("Deseja fazer uma nova busca?");
                                RespostaBusca = Console.ReadLine();
                                break;
                            }
                            
                        }

                        else if(RespostaUsoItem == "Nao" || RespostaUsoItem == "nao")
                        {
                            Console.WriteLine("Deseja fazer uma nova busca?");
                            RespostaBusca = Console.ReadLine();

                            if(RespostaUsoItem == "Nao" || RespostaUsoItem == "nao" && RespostaBusca == "Nao" || RespostaBusca == "nao")
                            {
                                Environment.Exit(0);
                            }
                        }

                    }

                   
                    else if (RespostaUsuario != currentElement.Nome)
                    {
                        if (RespostaUsuario != currentElement.Nome && currentElement.Nome == "Pistola")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Dado Invalido");
                            Console.WriteLine("");
                            
                            break;
                        }

                        else 
                        {
                            currentElement = currentElement.next;
                            posicao++;
                        }

                    }


                }



            }

            if (RespostaBusca == "Nao" || RespostaBusca == "Não")
            {
                Environment.Exit(0);
            }

            else if (RespostaBusca == null)
            {
                Console.WriteLine("");
                Console.WriteLine("Deseja fazer uma nova busca?");
                RespostaBusca = Console.ReadLine();
            }
            else if (RespostaBusca != "Sim" || RespostaBusca != "sim" || RespostaBusca != "Nao" || RespostaBusca != "Não")
            {
                Console.WriteLine("Desculpe, esse comando nao existe");
                Console.WriteLine("Deseja fazer uma nova busca?");
                RespostaBusca = Console.ReadLine();
            }

            Console.ReadKey();
            
        }
    }
 } 
  



        

           



    
        
 
        
        
        
        
        

            
            
    

          
          
        
       
    

