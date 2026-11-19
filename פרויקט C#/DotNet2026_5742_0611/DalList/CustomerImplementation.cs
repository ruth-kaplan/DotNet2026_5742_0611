namespace DalList;

using Dal.Exceptions;
using DalFacade.DalApi;
using DO;

internal class CustomerImplementation : ICustomer
{
    //הוספת לקוח לרשימת הלקוחות ומחזירה את מספר הזהות שלו
    public int Create(Customer item)
    {
        if (DataSource.Customers.Any(c => c?.ID == item.ID))
            throw new DuplicateIdException(item.ID);
        Customer copy = item with { };
        DataSource.Customers.Add(copy);
        return copy.ID;
    }
    //מחזירה את הלקוח עם המספר המסויים אם לא קיים מחזירה null
    public Customer? Read(int id)
    {
        return DataSource.Customers.FirstOrDefault(c => c?.ID == id);
    }
    //מחזירה עותק של הרשימה של הלקוחות
    public IEnumerable<Customer?> ReadAll()
    {
        return DataSource.Customers.ToList();
    }
    //מעדכנת לקוח
    public void Update(Customer item)
    {
        Customer? existing = DataSource.Customers.FirstOrDefault(c => c?.ID == item.ID);
        if (existing == null)
            throw new EntityNotFoundException(item.ID);
        DataSource.Customers.Remove(existing);
        DataSource.Customers.Add(item);
    }
    // מוחקת את הלקוח המבוקש מהרשימה
    public void Delete(int id)
    {
        Customer? existing = DataSource.Customers.FirstOrDefault(c => c?.ID == id);
        if (existing == null)
            throw new EntityNotFoundException(id);
        DataSource.Customers.Remove(existing);
    }

}
