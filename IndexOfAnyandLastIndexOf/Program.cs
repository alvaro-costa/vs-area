/*
 * Estudo dos métodos IndexOfAny() e LastIndexOf()
 * 
 */

using System;



namespace IndexOfAnyandLastIndexOf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Exemplo 1:
             */

            string openingTag = "(";
            int openingTagLength = openingTag.Length;

            string closingTag = ")";

            string message = "(E se) eu estou  (interessado somente) no ultimo (par de parenteses)";
            int openingPosition = message.LastIndexOf(openingTag) + openingTagLength;
            int closingPosition = message.LastIndexOf(closingTag);

            int length = closingPosition - openingPosition;

            Console.WriteLine("Exemplo1:");
            Console.WriteLine($"O que está dentro do ultimo parenteses: {message.Substring(openingPosition, length)}");

            /*
             * Exemplo 2:
             */

            string message2 = "(What if) there are (more than) one (set of parentheses)?";
            int cont = 0;
            Console.WriteLine("\nExemplo2:");

            while (true)
            {
                cont++;
                int openingPosition2 = message2.IndexOf('(');
                if (openingPosition2 == -1)
                    break;

                openingPosition2 += 1;

                int closingPosition2 = message2.IndexOf(')');
                int length2 = closingPosition2 - openingPosition2;

                Console.WriteLine($"Ocorrencia {cont}: {message2.Substring(openingPosition2, length2)}");
                message2 = message2.Substring(closingPosition2 + 1);
            }

            /*
             * Exemplo 3:
             */

            Console.WriteLine("\nExemplo3:");

            string message3 = "Help (find) the {opening symbols}";
            char[] openSymbols3 = { '[', '{', '(' };
            const int startPosition3 = 6;

            Console.WriteLine($"Searching THIS Message: {message3}");
            
            int openingPosition3 = message3.IndexOfAny(openSymbols3);
            Console.WriteLine($"Found WITHOUT using startPosition: {message3.Substring(openingPosition3)}");

            openingPosition3 = message3.IndexOfAny(openSymbols3, startPosition3);
            Console.WriteLine($"Found WITH using startPosition: {message3.Substring(openingPosition3)}");


            /*
             * Exemplo 4:
             */

            Console.WriteLine("Exemplo 4:");

            string message4 = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";
            char[] openSymbols4 = { '[', '{', '(' };

            int closingPosition4 = 0;

            while (true)
            {
                int openingPosition4 = message4.IndexOfAny(openSymbols4, closingPosition4);

                if (openingPosition4 == -1) break;

                string currentSymbol4 = message4.Substring(openingPosition4, 1);

                // Now  find the matching closing symbol
                char matchingSymbol4 = ' ';

                switch (currentSymbol4)
                {
                    case "[":
                        matchingSymbol4 = ']';
                        break;
                    case "{":
                        matchingSymbol4 = '}';
                        break;
                    case "(":
                        matchingSymbol4 = ')';
                        break;
                }

                // To find the closingPosition, use an overload of the IndexOf method to specify 
                // that the search for the matchingSymbol should start at the openingPosition in the string. 

                openingPosition4 += 1;
                closingPosition4 = message4.IndexOf(matchingSymbol4, openingPosition4);

                // Finally, use the techniques you've already learned to display the sub-string:

                int length4 = closingPosition4 - openingPosition4;
                Console.WriteLine(message4.Substring(openingPosition4, length4));
            }

        }
    }
}
