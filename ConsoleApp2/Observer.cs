namespace ConsoleApp2;

public class FindAllObserver : IObserver
{
    public void OnFindAllCalled()
    {
        Console.WriteLine("findAll a été appelé !");
    }
}