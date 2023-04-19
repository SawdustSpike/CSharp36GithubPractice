using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp36FoodHall
{
    public class WordGenerator
    {
        public WordGenerator()
        {
            Adjectives = new List<string>() { 
                //Add Adjectives Below
                "stinky", "defunct", "dank", "honestly obscene"
            };

            Adverbs = new List<string>() { 
                //Add Adverbs Below
                "quickly", "lazily", "stupidly"
            };

            Animals = new List<string>() {
                //Add Animals Below
                "llama", "alpaca", "moose", "fish"
            };

            Exclamations = new List<string>() { 
                //Add Exclamations Below
                "Hotchie motchie","Doh"
            };

            Foods = new List<string>() {
                // Add Foods Below
                "tacos", "bananas", "bacon"
            };

            Nouns = new List<string>() { 
                //Add Nouns Below
                "Goku", "Taco Bell bathroom", "butterfly knife"
            };

            PartsOfTheBody = new List<string>() { 
                //Add Parts Of The Body Below. Keep it class appropriate!
                "baby toe", "knee", "knuckle"
            };

            PeopleOfCS36 = new List<string>() { 
                //All Classmates and Teachers already added. Add if I forgot someone, optherwise ignore.
                "Amoriss", "Monica", "Mike C", "Adam", "Doug", "Hassan", "Katherine", "Michael", "William", "Yvonne", "Zachery", "Zacheri"
            };

            Verbs = new List<string>() { 
                //Add Verbs Below
                "code", "swim", "have a mental breakdown"
            };

            VerbsEndingInEd = new List<string>() { 
                //Add Verbs Ending in "ed" below
                "debugged", "waited", "danced like Wednesday Adams"
            };

            VerbsEndingInIng = new List<string>() { 
                //Add Verbs Ending in ing below
                "recording", "cooking", "walking"
            };

        }

        #region Properties
        public List<string> Adjectives { get; set; }
        public List<string> Adverbs { get; set; }
        public List<string> Animals { get; set; }
        public List<string> Exclamations { get; set; }
        public List<string> Foods { get; set; }
        public List<string> Nouns { get; set; }
        public List<string> PartsOfTheBody { get; set; }
        public List<string> PeopleOfCS36 { get; set; }
        public List<string> Verbs { get; set; }
        public List<string> VerbsEndingInEd { get; set; }
        public List<string> VerbsEndingInIng { get; set; }
        #endregion
        #region Methods
        Random rng = new Random();
        public string R(List<string> words)
        {
            int randomNumber = rng.Next(words.Count);
            return words[randomNumber];
        }
        public string R(List<string> words, params string[] used) 
        {
            var newWord = "";
            do
            {
                int randomNumber = rng.Next(words.Count);
                newWord = words[randomNumber];
            }
            while (used.Contains(newWord));
            return newWord;
        }
        //public string Adjective()
        //{
        //    int randomNumber = rng.Next(Adjectives.Count);
        //    return Adjectives[randomNumber];
        //}  
        //public string Adverb()
        //{
        //    int randomNumber = rng.Next(Adverbs.Count);
        //    return Adverbs[randomNumber];
        //}  
        //public string Animal()
        //{
        //    int randomNumber = rng.Next(Animals.Count);
        //    return Animals[randomNumber];
        //}  
        //public string Exclamation()
        //{
        //    int randomNumber = rng.Next(Exclamations.Count);
        //    return Exclamations[randomNumber];
        //}  
        //public string Food()
        //{
        //    int randomNumber = rng.Next(Foods.Count);
        //    return Foods[randomNumber];
        //}  
        //public string Noun()
        //{
        //    int randomNumber = rng.Next(Nouns.Count);
        //    return Nouns[randomNumber];
        //}  
        //public string PartOfTheBody()
        //{
        //    int randomNumber = rng.Next(PartsOfTheBody.Count);
        //    return PartsOfTheBody[randomNumber];
        //}  
        //public string CSharp36()
        //{
        //    int randomNumber = rng.Next(PeopleOfCS36.Count);
        //    return PeopleOfCS36[randomNumber];
        //}  
        //public string Verb()
        //{
        //    int randomNumber = rng.Next(Verbs.Count);
        //    return Verbs[randomNumber];
        //}  
        //public string VerbEndingInEd()
        //{
        //    int randomNumber = rng.Next(VerbsEndingInEd.Count);
        //    return VerbsEndingInEd[randomNumber];
        //}
        //public string VerbEndingInIng()
        //{
        //    int randomNumber = rng.Next(VerbsEndingInIng.Count);
        //    return VerbsEndingInIng[randomNumber];
        //}
        #endregion

    }
}
