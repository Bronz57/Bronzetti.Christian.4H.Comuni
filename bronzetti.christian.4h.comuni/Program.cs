using System;
using System.Text;
using bronzetti.christian._4h.comuni.Models;
using System.Collections.Generic;
namespace bronzetti.christian._4h.comuni
{
   
    class Program
    {
        static string TrovaParolaRicercata(Comuni c, string ricercata)
        {
            StringBuilder sb = new StringBuilder();

            int min = 99;
            string nome = "";
           
            //trovo il primo più simile
            foreach (Comune v in c._elencoComuni)
                  if (Levenshtein.CalcolaDL(ricercata, v.Nome) < min)
                  {
                    min = Levenshtein.CalcolaDL(ricercata, v.Nome);
                    nome = v.Nome;
                  }
                    

            //ritorna tutti i suggerimenti più vicini
            foreach (Comune v in c._elencoComuni)
                if (Levenshtein.CalcolaDL(ricercata, v.Nome) <= min)
                        sb.AppendLine(v.ToString());
                

            return sb.ToString();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Programma che trova i suggerimenti, scritto da Christian Bronzetti, 4h");
            Comuni italiani = new Comuni(@"Models/CodiciComuni.csv");

            Console.Write("Inserisci un comune da cercare:\t");
            string ricercata = Console.ReadLine().ToUpper();
            Console.WriteLine($"Forse cercavi:\n{TrovaParolaRicercata(italiani, ricercata)}");
        }
    }
}
