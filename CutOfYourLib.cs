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
            var adverb1 = w.R(w.Adverbs);
            var adverb2 = w.R(w.Adverbs, adverb1);
            var animal1 = w.R(w.Animals);
            var bodypart1 = w.R(w.PartsOfTheBody);
            var excl1 = w.R(w.Exclamations);
            var food1 = w.R(w.Foods);
            var food2 = w.R(w.Foods, food1);
            var noun1 = w.R(w.Nouns);
            var person1 = w.R(w.PeopleOfCS36);
            var person2 = w.R(w.PeopleOfCS36, person1);
            var person3 = w.R(w.PeopleOfCS36, new string[] { person1, person2 });
            var person4 = w.R(w.PeopleOfCS36, new string[] { person1, person2, person3 });
            var verb1 = w.R(w.Verbs);
            var verbed1 = w.R(w.VerbsEndingInEd);
            var verbing1 = w.R(w.VerbsEndingInIng);
            #endregion

            Console.WriteLine($"It was a {adj1} morning when the C-Sharp 36 zoom call began.\n{person1} was the first to arrive" +
               $", {noun1} prominently displayed in their background\nand the {food1} they had for breakfast still on their {bodypart1}.\nThe rest of the class soon arrived and together they {adverb1} went" +
               $" over the quiz.\n\"{excl1}!\" {person2} exclaimed. \"That was a tough lesson!\".\n\"I don't know " +
               $"about the rest of you\", {person3} said, {adverb2} {verbing1} their pet {animal1}, \"but I'm hungry\".\n" +
               $"So the class decided to {verb1} downtown and get some {food2}.\nEveryone except {person4}, who {verbed1} in a" +
               $" breakout room until everyone got back."
               );
        }
    }
}
