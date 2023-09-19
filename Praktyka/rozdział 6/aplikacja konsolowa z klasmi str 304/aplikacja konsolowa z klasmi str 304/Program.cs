using System.Buffers;
using System.Security.Cryptography.X509Certificates;


class Jewels
{
    public string Sparkle()
    {
        return "Lśnimy i błyszczymy!";
    }
}

class Safe
{
    private Jewels constents = new Jewels();
    public string safeCombination = "12345";
    public Jewels Open(string combination)
    {
        if (combination == safeCombination)
        {
            return constents;

        }
        else return null;

    }

    public void PickLock(Locksmith lockpicker)
    {
        //lockpicker.WriteDownCombination(safeCombination);
    }

    
}
class Owner
{
    private Jewels returnedContents;
    public void ReceivedContets(Jewels safeContents)
    {
        returnedContents = safeContents;
        Console.WriteLine("dziękuje za zwrócenie klejnotów " + safeContents.Sparkle());
    }

}

class Locksmith
{
    public void OpenSafe(Safe safe, Owner owner)
    {
        safe.PickLock(this);
        Jewels safeContents = safe.Open(writtenDownCombination);
        ReturnContets(safeContents, owner);

    }

    private string writtenDownCombination = null;
    public void WrittenDonwCombination(string combination)
    {
        writtenDownCombination = combination;
    }

    public void ReturnContets(Jewels safeContents, Owner owner)
    {
        owner.ReceivedContets(safeContents);
    }
}

class JewelThief : Locksmith
{
    private Jewels stolenJewels = null;
    public void ReturnContents(Jewels safeContents, Owner owner)
    {
        stolenJewels = safeContents;
        Console.WriteLine("kradne zawartość sejfu " + stolenJewels.Sparkle());
    }
}

class Program
{
    static void Main(string[] args)
    {
        Owner owner = new Owner(); 
        Safe safe = new Safe();
        JewelThief jewelthief = new JewelThief();
        jewelthief.OpenSafe(safe, owner);
        Console.ReadLine();
    }
}
