namespace Assignment1;

public class Customer : ParentClass, IPerson
{
    // field
    // public string FirstName;

    // property
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
}
