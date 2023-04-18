using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp36FoodHall
{
    public static class CutOfYourLib
    {
        public static void Lib1(WordGenerator w)
        {
            Console.WriteLine($"It was a {w.R(w.Adjectives)} morning when the C-Sharp 36 zoom call began.\n{w.R(w.PeopleOfCS36)} was the first to arrive" +
               $", {w.R(w.Nouns)} proudly being displayed in thier background.\nThe rest of the class soon arrived and together they {w.R(w.Adverbs)} went" +
               $" over the quiz.\n\"{w.R(w.Exclamations)}!\" {w.R(w.PeopleOfCS36)} exclaimed. \"That was a tough lesson!\".\n\"I don't know " +
               $"about the rest of you\", {w.R(w.PeopleOfCS36)} said, {w.R(w.Adverbs)} {w.R(w.VerbsEndingInIng)} thier pet {w.R(w.Animals)}, \"but I'm hungry\".\n" +
               $"So the class decided to {w.R(w.Verbs)} and get some {w.R(w.Foods)}, everyone except {w.R(w.PeopleOfCS36)}, who {w.R(w.VerbsEndingInEd)} in a" +
               $" breakout room until everyone got back."
               );
        }
    }
}
