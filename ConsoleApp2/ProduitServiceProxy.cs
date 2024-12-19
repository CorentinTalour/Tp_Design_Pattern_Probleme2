namespace ConsoleApp2;

public class ProduitServiceProxy
{
    private ProduitService _produitService;
    private List<IObserver> _observers;

    public ProduitServiceProxy(ProduitService produitService)
    {
        _produitService = produitService;
        _observers = new List<IObserver>();
    }
    
    public void AddObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public new List<string> FindAll()
    {
        NotifyObservers();
        return _produitService.FindAll();
    }

    private void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.OnFindAllCalled();
        }
    }
}