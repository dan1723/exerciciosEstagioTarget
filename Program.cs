using System;

class Program
{
    static void Main(string[] args)
    {
        // Exercícios 

        // 1) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

        
        // Console.Write("Informe um número: ");
        // int numero = int.Parse(Console.ReadLine());

        // if (PertenceASequenciaFibonacci(numero))
        // {
        //     Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        // }
        // else
        // {
        //     Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
        // }




        // 2) Escreva um programa que verifique, em uma string, a existência da letra ‘a’, seja maiúscula ou minúscula, além de informar a quantidade de vezes em que ela ocorre.


        // Console.Write("Digite o seu nome completo: ");
        // string nome = Console.ReadLine();

        // int cont = 0;

        // foreach(char caracter in nome)
        // {
        //     if (caracter == 'A' || caracter == 'a')
        //     {
        //         cont++;
        //     }
        // }

        // if(cont > 0)
        // {
        //     System.Console.WriteLine($"A letra 'a' aparece {cont} vezes em seu nome");
        // }
        // else
        // {
        //     System.Console.WriteLine("Você não tem a letra 'a' no seu nome");
        // } 

        




        // 3) Observe o trecho de código abaixo: int INDICE = 12, SOMA = 0, K = 1; enquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; } imprimir(SOMA);

        // Ao final do processamento, qual será o valor da variável SOMA? 77

        // int INDICE = 12;
        // int SOMA = 0;
        // int K = 1;

        // for(int i = 0; K < INDICE; i++)
        // {
        //     K = K + 1;
        //     SOMA = SOMA + K;
        // }

        // System.Console.WriteLine(SOMA);




        // 4) Descubra a lógica e complete o próximo elemento:
        // a) 1, 3, 5, 7, _9__
        // b) 2, 4, 8, 16, 32, 64, _128__
        // c) 0, 1, 4, 9, 16, 25, 36, _49__
        // d) 4, 16, 36, 64, _100__
        // e) 1, 1, 2, 3, 5, 8, _13__
        // f) 2,10, 12, 16, 17, 18, 19, _200__



        
        // 5) Você está em uma sala com três interruptores, cada um conectado a uma lâmpada em salas diferentes. Você não pode ver as lâmpadas da sala em que está, mas pode ligar e desligar os interruptores quantas vezes quiser. Seu objetivo é descobrir qual interruptor controla qual lâmpada. Como você faria para descobrir, usando apenas duas idas até uma das salas das lâmpadas, qual interruptor controla cada lâmpada? 

        // Ligue o primeiro interruptor (A) e deixe-o ligado por alguns minutos.
        // Desligue o interruptor A e ligue o segundo interruptor (B) imediatamente antes de ir até a sala das lâmpadas.

        // Vá até a sala das lâmpadas:
        // A lâmpada que estiver acesa será controlada pelo interruptor B (que você deixou ligado).
        // A lâmpada que estiver apagada e quente será controlada pelo interruptor A (que ficou ligado por um tempo, mas depois foi desligado).

        // A lâmpada que estiver apagada e fria será controlada pelo interruptor C (que você nunca ligou).
        // Dessa forma é possível identificar qual interruptor controla cada lâmpada com apenas uma visita à sala das lâmpadas.

    }


    static bool PertenceASequenciaFibonacci(int numero)
    {
        int primeiro = 0;
        int segundo = 1;

        if (numero == primeiro || numero == segundo)
        {
            return true;
        }

        int proximo = primeiro + segundo;

        while (proximo <= numero)
        {
            if (proximo == numero)
            {
                return true;
            }

            primeiro = segundo;
            segundo = proximo;
            proximo = primeiro + segundo;
        }

        return false;
    }


    // 2) Escreva um programa que verifique, em uma string, a existência da letra ‘a’, seja maiúscula ou minúscula, além de informar a quantidade de vezes em que ela ocorre.

    
}






