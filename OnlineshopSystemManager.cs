class Product
{
    public string Name { get; set; }
    public int Price { get; set; }

    public void GetProductDetails()
    {
        Console.WriteLine($"The Name is : {Name} And The Price Is {Price}");
    }
}

interface Idiscountable
{
    void ApplyDiscount();
}
class Electronic : Product ,  Idiscountable
{
    // 👇 Dynamic property, no stale data, helped by ChatGPT
    public int OffPrice => Price / 2;
    public int WarrantyPeriod { get; set; }

    public void ApplyDiscount ()
    {
        Console.WriteLine($"This product is on off for 50%, final price is {Price}");
    }
    
    public void Details()
    {
        Console.WriteLine($"Electronic => The name is : {Name} , The price is {Price}," +
            $"The price after off is {OffPrice}, The WarrantyPeriod is {WarrantyPeriod} ");
    }
}

class Clothing : Product
{
    public int Size{ get; set; }
    public string Material { get; set; }

    public void Details()
    {
        Console.WriteLine($"Clothing => The name is {Name} , The price is {Price}," +
            $"The Size is {Size}, the Material is {Material} ");
    }
}

class Program
{
    static void Main ( String[] args )
    {
        List<Electronic> electronics = new List<Electronic>
        {
            new Electronic {Name ="Washing Machine", Price= 10, WarrantyPeriod= 1400},
            new Electronic {Name ="Dish Wadher", Price= 15, WarrantyPeriod= 1405},
        };

        List<Clothing> clothings = new List<Clothing>
        {
            new Clothing {Name ="Pants", Price= 1, Size = 36, Material = "Jean"},
            new Clothing {Name ="Scarf", Price= 7, Size = 4, Material = "Wool"},
        };

        foreach ( Electronic electronic in electronics )
        {
            electronic.Details();
        }

        foreach (Clothing clothing in clothings)
        {
            clothing.Details();
        }
    }
}