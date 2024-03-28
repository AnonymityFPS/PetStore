using static PetStore.Classes.Product;

namespace PetStore.Classes;

internal class CatFood : Product
{
    public double WeightPounds { get; set; }
    public bool KittenFood { get; set; }
}
