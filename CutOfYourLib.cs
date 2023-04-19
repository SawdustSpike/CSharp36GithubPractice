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
            #region MadlibWords
            var adj1 = w.R(w.Adjectives);
            var person1 = w.R(w.PeopleOfCS36);
            var person2 = w.R(w.PeopleOfCS36, person1);
            var person3 = w.R(w.PeopleOfCS36, new string[] { person1, person2 });
            var person4 = w.R(w.PeopleOfCS36, new string[] { person1, person2, person3 });
            var noun1 = w.R(w.Nouns);
            var adverb1 = w.R(w.Adverbs);
            var adverb2 = w.R(w.Adverbs, adverb1);
            var excl1 = w.R(w.Exclamations);
            var verbing1 = w.R(w.VerbsEndingInIng);
            var animal1 = w.R(w.Animals);
            var verb1 = w.R(w.Verbs);
            var food1 = w.R(w.Foods);
            var verbed1 = w.R(w.VerbsEndingInEd);
            #endregion

            Console.WriteLine($"It was a {adj1} morning when the C-Sharp 36 zoom call began.\n{person1} was the first to arrive" +
               $", {noun1} proudly being displayed in their background.\nThe rest of the class soon arrived and together they {adverb1} went" +
               $" over the quiz.\n\"{excl1}!\" {person2} exclaimed. \"That was a tough lesson!\".\n\"I don't know " +
               $"about the rest of you\", {person3} said, {adverb2} {verbing1} thier pet {animal1}, \"but I'm hungry\".\n" +
               $"So the class decided to {verb1} and get some {food1}, everyone except {person4}, who {verbed1} in a" +
               $" breakout room until everyone got back."
               );
        }
    }
}
