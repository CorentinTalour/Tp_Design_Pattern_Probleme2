using ConsoleApp2;

//Correspond au problème 2

ProduitService produitService = new ProduitService();

ProduitServiceProxy proxy = new ProduitServiceProxy(produitService);

proxy.AddObserver(new FindAllObserver());

List<string> produits = proxy.FindAll();

foreach (var produit in produits)
{
    Console.WriteLine($"{produit}, ");
}