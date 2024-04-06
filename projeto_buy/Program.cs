using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> listaDeCompras = new List<string>();
        string item = "";

        //funcao comeca aqui
        void lista(){
            
            Console.WriteLine("Digite os itens da lista de compras. Digite 'sair' para terminar.");
            while (item.ToLower() != "sair")
            {
                Console.Write("Digite um item: ");
                item = Console.ReadLine();
                if (item.ToLower() != "sair")
                {
                    listaDeCompras.Add(item);
                }
            }

            Console.WriteLine("\nSua lista de compras:");
            foreach (string i in listaDeCompras)
            {
                Console.WriteLine(i);
            }
            }
            

        lista();
        //funcao termina aqui
    
        //funcao comeca aqui
        static void repetir(){

            //string reboot = "";
            Console.WriteLine("Esqueceu de algo ou deseja fazer a lista novamente? ");
            string reboot = Console.ReadLine();
        
            if (reboot.ToLower() == "sim"){
                Main();
                //mostrar lista:
            }

            if (reboot.ToLower() == "nao"){
                Console.WriteLine("saindo");
            }

            if (reboot.ToLower() != "nao" && reboot.ToLower() != "sim"){
                Console.WriteLine("Opcao invalida tente novamente");
                repetir();
            }

        }

        repetir();
        //funcao termina aqui

    } 
}   
