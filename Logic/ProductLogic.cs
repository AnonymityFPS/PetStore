using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using PetStore.Classes;
using static PetStore.Classes.Product;
using PetStore.Logic;
using System.Reflection.Metadata.Ecma335;

namespace PetStore.Logic
{
    internal class ProductLogic
    {
        private List<Product> _products;
        Dictionary<string, CatFood> _catFood;
        Dictionary<string, DogLeash> _dogLeash;


        public ProductLogic()
        {
            _products = new List<Product>();
            
            new DogLeash
            {
                Description = "A rope made from strong leather",
                LengthInches = 48,
                Material = "Leather",
                Name = "Leather Dog Leash",
                Price = 25.99m,
                Quantity = 2
            };
            new CatFood
            {
                Description = "Well balanced meal for you furry friend",
                Price = 3.99m,
                Name = "Feline Flavor",
                Quantity = 2,
                WeightPounds = 5
            };

            void AddProduct(Product product)
            {


                if (product is DogLeash)
                {
                    _dogLeash.Add(product.Name, product as DogLeash);

                }


                if (product is CatFood)
                {
                    _catFood.Add(product.Name, product as CatFood);
                }
            }

            DogLeash GetDogLeashByName(string name)
            {
                return _dogLeash[name];

            }
        }
    }
}

                
            

       