using System;

namespace RemoveandReplace
{

    internal class Program
    {

        public static void Main(string[] args)
        {
            /*
             * Casos de exemplo:
             */

            //string data = "12345John Smith          5000  3  ";
            //string updatedData = data.Remove(5, 20);
            //Console.WriteLine(updatedData);

            //string message = "This--is--ex-amp-le--da-ta";
            //message = message.Replace("--", " ");
            //message = message.Replace("-", "");
            //Console.WriteLine(message);

            /*
             * Aplicação:
             */

            const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

            string quantity = "";
            string output = "";

            const string tradeMark = "&trade";
            const string regMark = "&reg";


            // Isolating <div> context.

            const string startOutputTag = "<div>";
            const string endOutputTag = "</div>";

            int startOutputIndex = input.IndexOf(startOutputTag) + startOutputTag.Length;
            int endOutputIndex = input.IndexOf(endOutputTag);
            int lengthOutput = endOutputIndex - startOutputIndex;

            output = input.Substring(startOutputIndex, lengthOutput);
            output = output.Replace(tradeMark, regMark);


            // Isolating <span> context.

            const string startQuantityTag = "<span>";
            const string endQuantityTag = "</span>";

            int startQuantityIndex = input.IndexOf(startQuantityTag) + startQuantityTag.Length;
            int endQuantityIndex = input.IndexOf(endQuantityTag);
            int lengthQuantity = endQuantityIndex - startQuantityIndex;

            quantity = input.Substring(startQuantityIndex, lengthQuantity);


            // Result

            Console.WriteLine(quantity);
            Console.WriteLine(output);
        }
    }
}