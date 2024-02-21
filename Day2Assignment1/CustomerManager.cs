namespace Assignment1;

public class CustomerManager
{
    private readonly ICustomerDal _customerDal;

    public CustomerManager(ICustomerDal customerDal)
    {
        _customerDal = customerDal;
    }

    public void Add()
    {
        _customerDal.Add();
    }
    public void Update()
    {
        _customerDal.Update();
    }
    public void Delete() 
    {
        _customerDal.Delete();
    }
}
