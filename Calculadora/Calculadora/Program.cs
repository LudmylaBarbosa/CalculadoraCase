using System;
using System.Collections;
using System.Collections.Generic;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue<Operacoes> filaOperacoes = new Queue<Operacoes>();
            filaOperacoes.Enqueue(new Operacoes { valorA = 2, valorB = 3, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 14, valorB = 8, operador = '-' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 5, valorB = 6, operador = '*' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 2147483647, valorB = 2, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 18, valorB = 3, operador = '/' }); //Implemente o calculo de divisao

            Calculadora calculadora = new Calculadora();
            List<Operacoes> resultados = new List<Operacoes>();
            int operacoesRestantes = filaOperacoes.Count;

            Stack<decimal> pilhaResultados = new Stack<decimal>();

            
            while (filaOperacoes.Count > 0)
            {
                Operacoes operacao = filaOperacoes.Dequeue();
                calculadora.calcular(operacao);
                Console.WriteLine("{0} {1} {2} = {3}\n", operacao.valorA, operacao.operador, operacao.valorB, operacao.resultado);

                pilhaResultados.Push(operacao.resultado);

                operacoesRestantes --;
                if (operacoesRestantes > 0)
                {

                Console.WriteLine("Operações a serem processadas:");
                foreach (var operacaoPendente in filaOperacoes)
                {
                    Console.WriteLine("{0} {1} {2}\n", operacaoPendente.valorA, operacaoPendente.operador, operacaoPendente.valorB);
                }
                
            }
        
        }
         Console.WriteLine("\nPilha de Resultados:");
            foreach (var resultado in pilhaResultados)
            {
                Console.WriteLine(resultado);
            }   
          
           
        }
    }
}
