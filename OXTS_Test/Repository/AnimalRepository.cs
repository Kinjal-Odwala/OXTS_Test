using System.Collections.Generic;
using OXTS_Test.Models;
using OXTS_Test.Contract_Interface;

namespace OXTS_Test.Repository
{
    public class AnimalRepository : IAnimalRepository
    {
        /// <summary>
        /// Creaate default list of Animals
        /// </summary>
        /// <returns></returns>
        public List<Animals> CreateList()
        {
            List<Animals> list = new List<Animals>();
            list.Add(new Animals("Baboon", "Primate", "Yes"));
            list.Add(new Animals("Chimpanzee", "Primate", "Yes"));
            list.Add(new Animals("Crocodile", "Reptile", "Yes"));
            list.Add(new Animals("Hippopotamus", "Mammal", "Yes"));
            list.Add(new Animals("Snake", "Reptile", "No"));
            list.Add(new Animals("Lion", "Mammal", "Yes"));
            list.Add(new Animals("Zebra", "Mammal", "Yes"));
            list.Add(new Animals("Cheetah", "Mammal", "Yes"));
            list.Add(new Animals("Gorilla", "Primate", "No"));
            list.Add(new Animals("Giraffe", "Mammal", "Yes"));
            list.Add(new Animals("Lizard", "Reptile", "Yes"));
            return list;
        }

        /// <summary>
        /// Return list of animals according to category and tail as optional 
        /// </summary>
        /// <param name="category"></param>
        /// <param name="tail"></param>
        /// <returns></returns>
        public List<Animals> Categorise(string Category, string Tail)
        {
            List<Animals> List = CreateList();
            List<Animals> Result = new List<Animals>();
            foreach(Animals Animal in List)
            {
                if (Tail == "")
                {
                    if (Animal.Category == Category) Result.Add(Animal);
                }
                else
                {
                    if (Animal.Category == Category && Animal.HasTail == Tail) Result.Add(Animal);
                }
            }
            return Result;
        }
    }
}