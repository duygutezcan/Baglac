// See https://aka.ms/new-console-template for more information
Basla();

void Basla()
{
    Console.WriteLine("Boyunuz kaç");
    int boy = Convert.ToInt32(Console.ReadLine());
    if (boy <= 150)
    {
        Console.WriteLine("kısa boylusunuz");
    }
    else if (boy > 150 && boy <=175)
    {
        Console.WriteLine("orta boylusunuz");
    }
    else if (boy > 175 && boy <= 210)
    {
        Console.WriteLine("uzun boylusunuz");
    }
    else 
    {
        Console.WriteLine("bir yanlışlık var");
    }
}
