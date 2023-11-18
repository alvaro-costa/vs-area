/*
 * Um programa para estudo de comportamento dos métodos IndexOf() e Substring()
 * 
 * A program to study the behavior of IndexOf() and Substring() methods.
 * 
 * Variáveis:
 * 
 *  pocisaoAbertura
 *  posicaoFechamento
 *  comecoDaFrase = posicaoAbertura + 1
 *  tamanhoEntreParenteses = (posicaoFechamento - posicaoAbertura) - 1
 * 
 * Author: Alvaro Costa
 */


using System;

namespace IndexOfandSubstring2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa de estudo dos métodos IndexOf() e Substring()\n");



            // Uso do IndexOf. O caractere possui apenas uma ocorrência na string

            string mensagem = "Ache o que está (entre parênteses)";
            string mensagemIntro = "String de exemplo: Ache o que está (entre parênteses)";


            // Criacao de string com os indices de cada caracter da mensagem
            string indicesDaString = "";
            int indice = 0;
            for (int i = 0; i < mensagem.Length; i++)
            {   
                if (indice == 10)
                {
                    indice = 0;
                }

                indicesDaString += indice.ToString();

                indice++;
            }


            Console.WriteLine(mensagemIntro);
            Console.WriteLine(indicesDaString.PadLeft(mensagemIntro.Length));
            Console.WriteLine();

            int posicaoAbertura = mensagem.IndexOf('(');
            int posicaoFechamento = mensagem.IndexOf(')');


            // Ache o que está (entre parênteses)
            // 0123456789012345678901234567890123
            // '(' -> 16, ')' -> 33
            //
            Console.WriteLine($"Posição de Abertura: {posicaoAbertura}");
            Console.WriteLine($"Posição de Fechamento: {posicaoFechamento}");

            // Uso do Substring.

            //  posicaoFechamento - posicaoAbertura = 33 - 16 = 17
            int tamanhoEntreParenteses = (posicaoFechamento - posicaoAbertura) - 1;
            int comecoDaFrase = posicaoAbertura + 1;


            Console.WriteLine($"Tamanho entre parenteses: {tamanhoEntreParenteses}");
            Console.WriteLine($"Comeco da frase entre parenteses: {comecoDaFrase}");


            string mensagemEntreParenteses = mensagem.Substring(comecoDaFrase, tamanhoEntreParenteses);


            // Ache o que está (entre parênteses)
            // 0123456789012345678901234567890123
            // '(' -> 16, ')' -> 33

            Console.WriteLine($"Mensagem entre parenteses: {mensagemEntreParenteses}");



            /*
             * Outro exemplo com uma cadeia de caracteres na abertura e fechamento.
             */

            Console.WriteLine("\n\nNovo exemplo\n");

            string mensagem2 = "What is the value <span>between the tags</span>?";
            string palavraAbertura = "<span>";
            string palavraFechamento = "</span>";

            int posicaoAbertura2 = mensagem2.IndexOf(palavraAbertura);
            int posicaoFechamento2 = mensagem2.IndexOf(palavraFechamento);

            int comecoDaFrase2 = posicaoAbertura2 + palavraAbertura.Length;
            int tamanhoEntrePalavra = (posicaoFechamento2 - comecoDaFrase2);

            string mensagemEntreTags = mensagem2.Substring(comecoDaFrase2, tamanhoEntrePalavra);

            Console.WriteLine($"String de Exemplo: {mensagem2}");
            Console.WriteLine();

            Console.WriteLine($"Posicao de Abertura: {posicaoAbertura2}");
            Console.WriteLine($"Posicao de Fechamento: {posicaoFechamento2}");
            Console.WriteLine($"Começo da frase: {comecoDaFrase2}");
            Console.WriteLine($"Tamanho entre tags: {tamanhoEntrePalavra}");
            Console.WriteLine($"Mensagem entre tags: {mensagemEntreTags}");


        }
    }
}

