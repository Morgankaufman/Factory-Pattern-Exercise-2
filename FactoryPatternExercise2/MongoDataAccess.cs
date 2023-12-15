using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class MongoDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product (){Name = "Desk", Price = 115},
            new Product (){Name = "PlayStation", Price = 450},
            new Product (){Name = "Recliner", Price = 260},
            new Product (){Name = "Tv", Price = 500},

        };

        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from the Mongo Database.");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to the List.");
        }


    }
}
