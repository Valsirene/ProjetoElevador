using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Model
{
    class Elevador
    {
        public int andar_atual;
        public int total_andares;
        public int capacidade_elevador;
        public int qtde_pessoas_elevador;

        public void Inicializar(int capacidadeElevador, int totalAndares)
        {
            int andarAtual = andar_atual;
            int qtdePessoasElev = qtde_pessoas_elevador;

            Console.WriteLine("##### INICIALIZANDO #####");
            Console.WriteLine("Capacidade do elevador: " + capacidadeElevador);
            Console.WriteLine("Total de andares no prédio:" + totalAndares);
            Console.WriteLine("Andar: TERREO: " + andarAtual);
            Console.WriteLine("Pessoas no elevador: " + qtdePessoasElev);

        }

        public void Entrar(int capacidadeElevador, int qtdPessoasElevador, int qtdPessoasEntrar)
        {
            int espacoElevador = capacidadeElevador - qtdPessoasElevador;

            if (espacoElevador >= qtdPessoasEntrar)
            {
                Console.WriteLine("Entraram {0}", qtdPessoasEntrar);
            }
            else
            {
                Console.WriteLine("Elevador lotado!!!");
            }

        }

        public void Sair(int qtdPessoasElevador)
        {
            int passoasSairam;

            if (qtdPessoasElevador > 0)
            {
                passoasSairam = (qtdPessoasElevador - (qtdPessoasElevador - 1));
                Console.WriteLine("Saiu {0} pessoa do elevador.", passoasSairam);
            }
            else
            {
                Console.WriteLine("Ningúem no elevador!!!");
            }

        }

        public void Subir(int andarAtual, int totalAndares)
        {

            if (andarAtual <= totalAndares)
            {
                andarAtual += 1;
                Console.WriteLine("Andar atual: {0}", andarAtual);
            }
            else
            {
                Console.WriteLine("Último andar!!!");
            }
        }
        public void Descer(int andarAtual)
        {

            if (andarAtual > 0)
            {
                andarAtual -= 1;
                Console.WriteLine("Andar atual: {0}", andarAtual);
            }
            else
            {
                andarAtual = 0;
                Console.WriteLine("Terreo!!!");
            }
        }
    }
}
