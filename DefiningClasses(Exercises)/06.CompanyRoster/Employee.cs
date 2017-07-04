public class Employee
{
    private string name;
    private double salary;
    private string position;
    private string department;
    private string email;
    private int age;

    //public Employee(string name, double salary, string position, string departmnet)
    //{
    //    this.name = name;
    //    this.salary = salary;
    //    this.position = position;
    //    this.department = departmnet;
    //}

    //public Employee(string name, double salary, string position, string departmnet, int age) : this(name, salary, position, departmnet)
    //{
    //    this.age = age;
    //}

    //public Employee(string name, double salary, string position, string departmnet, string email) : this(name, salary, position, departmnet)
    //{
    //    this.email = email;
    //}

    public string Name { get { return this.name; } set { this.name = value; } }
    public double Salary { get { return this.salary; } set { this.salary = value; } }
    public string Position { get { return this.position; } set { this.position = value; } }
    public string Department { get { return this.department; } set { this.department = value; } }
    public string Email { get { return this.email; } set { this.email = value; } }
    public int Age { get { return this.age; } set { this.age = value; } }
}