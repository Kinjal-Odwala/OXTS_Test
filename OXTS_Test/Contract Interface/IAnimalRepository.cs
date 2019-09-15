using OXTS_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OXTS_Test.Contract_Interface
{
    public interface IAnimalRepository
    {
        List<Animals> CreateList();
        List<Animals> Categorise(string Category, string Tail);
    }
}