using ProjetoElevador.Model;
using System;

namespace ProjetoElevador
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacidade_elevador = 5;
            int total_andares = 10;
            int andar_atual = 3;
            int qtde_pessoas_elevador = 0;

            Elevador elevador = new Elevador();
            Console.WriteLine("############### PROJETO ELEVADOR ############");
            elevador.andar_atual = andar_atual;
            elevador.qtde_pessoas_elevador = qtde_pessoas_elevador;
            elevador.Inicializar(capacidade_elevador, total_andares);

            Console.WriteLine("############### ENTRANDO ############");
            elevador.Entrar(capacidade_elevador, 2, 4);

            Console.WriteLine("############### SAINDO ############");
        
            elevador.Sair(qtde_pessoas_elevador);

            Console.WriteLine("############### SUBINDO ############");
            
            elevador.Subir(andar_atual, total_andares);

            Console.WriteLine("############### DESCENDO ############");

            elevador.Descer(andar_atual);




        }
    }
}
