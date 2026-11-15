namespace DalList;

using DalFacade.DalApi;
using DO;

internal class ProductImplementation : IProduct
{
    public int Create(Product item)
    {
        Product copy = item with { ID = DataSource.Config.NextProductId };
        DataSource.Products.Add(copy);
        return copy.ID;
    }

    public Product? Read(int id)
    {
        return DataSource.Products.FirstOrDefault(p => p?.ID == id)
               ?? throw new KeyNotFoundException($"Product with ID {id} does not exist.");
    }

    public IEnumerable<Product?> ReadAll()
    {
        return DataSource.Products.Select(p => p);
    }

    public void Update(Product item)
    {
        Product? existing = DataSource.Products.FirstOrDefault(p => p?.ID == item.ID);
        if (existing == null)
            throw new KeyNotFoundException($"Product with ID {item.ID} does not exist.");

        DataSource.Products.Remove(existing);
        DataSource.Products.Add(item);
    }

    public void Delete(int id)
    {
        Product? existing = DataSource.Products.FirstOrDefault(p => p?.ID == id);
        if (existing == null)
            throw new KeyNotFoundException($"Product with ID {id} does not exist.");

        DataSource.Products.Remove(existing);
    }
}