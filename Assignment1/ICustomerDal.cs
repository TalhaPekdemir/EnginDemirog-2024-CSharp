namespace Assignment1;

public interface ICustomerDal
{
    void Add();
    void Update();
    void Delete();
}

class SqlServerCustomerDal : ICustomerDal
{
    public void Add()
    {
        Console.WriteLine("SQL Added");
    }

    public void Delete()
    {
        Console.WriteLine("SQL Deleted");
    }

    public void Update()
    {
        Console.WriteLine("SQL Updated");
    }
}

class OracleCustomerDal : ICustomerDal
{
    public void Add()
    {
        Console.WriteLine("Oracle Added");
    }

    public void Delete()
    {
        Console.WriteLine("Oracle Deleted");
    }

    public void Update()
    {
        Console.WriteLine("Oracle Updated");
    }

}

class MysqlCustomerDal : ICustomerDal
{
    public void Add()
    {
        Console.WriteLine("Mysql Added");
    }

    public void Delete()
    {
        Console.WriteLine("Mysql Deleted");
    }

    public void Update()
    {
        Console.WriteLine("Mysql Updated");
    }
}