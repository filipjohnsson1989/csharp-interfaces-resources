namespace CatalogSaver;

class Program
{
    static void Main(string[] args)
    {
        Catalog catalog = new();
        //catalog.Save();

        ISaveable saveable = new Catalog();
        saveable.Save();

        (catalog as ISaveable).Save();

        var implicitCatalog = new Catalog();
        //implicitCatalog.Save();

    }
}