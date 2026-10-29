public interface IEnemy
{
    // Interface members are public by default, so we don't need to specify the access modifier.
    void Attack();
    void Defend();
}

public class Dragon : IEnemy
{
    public void Attack()
    {
        Console.WriteLine("Dragon Attack");
    }

    public void Defend()
    {
        Console.WriteLine("Dragon Defend");
    }
}

public class Vampire : IEnemy
{
    public void Attack()
    {
        Console.WriteLine("Vampire Attack");
    }

    public void Defend()
    {
        Console.WriteLine("Vampire Defend");
    }
}

public class Zombie : IEnemy
{
    public void Attack()
    {
        Console.WriteLine("Zombie Attack");
    }

    public void Defend()
    {
        Console.WriteLine("Zombie Defend");
    }
}

internal class Program
{
    private static void Main(string[] args)
    {

        // This is test comment to see changes in github.
        IEnemy e1 = new Dragon();
        IEnemy e2 = new Vampire();
        IEnemy e3 = new Zombie();

        List<IEnemy> list = new List<IEnemy>();
        list.Add(e1);
        list.Add(e2);
        list.Add(e3);

        foreach (IEnemy e in list)
        {
            e.Attack();
            e.Defend();
        }
        
    }
}