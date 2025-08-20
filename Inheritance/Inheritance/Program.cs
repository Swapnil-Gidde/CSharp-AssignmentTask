//class Product
//{
//    public int ProductId { get; set; }
//    public string ProductName { get; set; }

//    public Product()
//    {
//        ProductId = 0;
//        ProductName = "unknown";
//    }
//    public Product(int ProductId, string ProductName)
//    {
//        this.ProductId = ProductId;
//        this.ProductName = ProductName;
//    }
//    public override string ToString()
//    {
//        return $"Product[Productid = {ProductId} , ProductName= {ProductName}]";
//    }
//}
//class Electronics : Product
//{
//    public string WarentyYear { get; set; }

//    public Electronics()
//    {
//        WarentyYear = "unknown";
//    }
//    public Electronics(int ProductId, string ProductName, string WarentyYear) : base(ProductId, ProductName)
//    {
//        this.WarentyYear = WarentyYear;
//    }


//    public override string ToString()
//    {
//        return $" {base.ToString()}Electronics[WarentyYear= {WarentyYear}]";
//    }
//}

//class Smartphone : Electronics
//{
//    public string OS { get; set; }
//    public Smartphone()
//    {
//        OS = "unknown";
//    }
//    public Smartphone(int ProductId, string ProductName, string WarentyYear, string OS) : base(ProductId, ProductName, WarentyYear)
//    {
//        this.OS = OS;
//    }

//    public override string ToString()
//    {
//        return $"{base.ToString()}Smartphone[Os= {OS}]";
//    }
//}
//class App
//{
//    static void Main(string[] args)
//    {
//        //Smartphone smartphone = new Smartphone();
//        //smartphone.ElectronicsDetails();

//        Smartphone sm = new Smartphone(1, "Samsung", "2Yrs", "11");
//        Console.WriteLine(sm);
//    }
//}


////1] Single Inheritance
//class Vehicle
//{
//    public string Brand {  get; set; }
//    public int Speed {  get; set; }

//    public Vehicle()
//    {

//    }
//    public Vehicle(string brand, int speed)
//    {
//        this.Brand = brand;
//        this.Speed = speed;
//    }
//    public void VehicleDetails()
//    {
//        Console.WriteLine($"Brand is {this.Brand} , Speed is {this.Speed}");
//    }
//    public override string ToString()
//    {
//        return $"Vehicle Brand is {Brand} , Speed is {Speed}";
//    }
//}
//class Car : Vehicle
//{
//    public int Mileage {  get; set; }

//    public Car() 
//    {

//    }
//    public Car(string brand , int speed ,int Mileage) : base(brand , speed)
//    {
//        this.Mileage = Mileage;
//    }

//    public void CarDetails()
//    {
//        Console.WriteLine($"Mileage is {this.Mileage}");
//    }
//    public override string ToString()
//    {
//        return $"{base.ToString()}, Mileage is {Mileage}";
//    }
//}
//class SimpleInheritance
//{
//    static void Main(string[] args)
//    {
//        Car c = new Car("Toyota", 34, 9);
//        c.Mileage = 10;
//        Console.WriteLine(c);

//        // with methods
//        c.VehicleDetails();
//        c.CarDetails();
//    }
//}

////  Why base constructor call 
//// 2] Multilevel Inheritance
//class Person
//{
//    public string Name { get; set; }
//    public int Age {  get; set; }

//    public Person()
//    {
//        Name = "Unknown";
//        Age = 0;
//    }
//    public Person(string Name , int Age)
//    {
//        this.Name = Name;
//        this.Age = Age;
//    }
//    public override string ToString()
//    {
//        return $"Person name is {this.Name} , age is {this.Age}";
//    }
//}
//class Employee : Person
//{
//    public int Salary {  get; set; }
//    public int Id {  get; set; }
//    public Employee()
//    { 
//        Salary = 0;
//        Id = 0;
//    }
//    public Employee(string Name , int Age, int Salary , int Id) : base(Name , Age)
//    {
//        this.Salary = Salary;
//        this.Id = Id;
//    }

//    public override string ToString()
//    {
//        return $"{base.ToString()}, Salary = {this.Salary} , Id = {this.Id}";
//    }
//}
//class Manager : Employee
//{
//    public string Department {  get; set; }

//    //public Manager()
//    //{
//    //    Department = "unknown";

//    //}
//    //public Manager(String Name, int Age , int Salary , int Id, string Department) : base(Name , Age , Salary , Id)
//    //{
//    //    this.Department = Department;
//    //}
//    public override string ToString()
//    {
//        return $"{base.ToString()} , department = {Department}";
//    }
//}
//class MultilevelInheritance
//{
//    public static void Main(string[] args)
//    {
//        Manager m = new Manager();
//        Console.WriteLine(m);

//        //Manager m1 = new Manager("Ram" , 23,30000, 1, "Developer");
//        Manager m1 = new Manager { Name = "Ram", Age = 23, Salary = 30000, Id = 1, Department = "Developer" };
//        m1.Salary = 40000;
//        Console.WriteLine(m1);
//    }
//}

// 3] 1) Hierachical Inheritance
//using System.Drawing;

//class Shape
//{
//    public string Color {  get; set; }

//    public Shape()
//    {

//    }
//    public Shape(string Color) 
//    {
//        this.Color = Color;
//    }

//    public override string ToString()
//    {
//        return $"Color = {this.Color}";
//    }
//}
//class Rectangle : Shape
//{
//    public int Length {  get; set; }
//    public int Width { get; set; }

//    public Rectangle()
//    {
//        Length = 0;
//        Width = 0;
//    }

//    public Rectangle(string color, int length , int width) : base (color)
//    {
//        this.Length = length;
//        this.Width = width;
//    }

//    public void AreaDisplay()
//    {
//        Console.WriteLine($" Area is:- {this.Length * this.Width}");
//    }
//    public override string ToString()
//    {
//        return $"{base.ToString()} , Length = {Length} , width = {Width}";
//    }
//}
//class Circle : Shape
//{
//    public double radius {  get; set; }

//    public Circle()
//    { 
//        radius = 0;
//    }
//    public Circle(string color, double radius) : base(color)
//    {
//        this.radius = radius;
//    }

//    public override string ToString()
//    {
//        return $"{base.ToString()} , radius = {radius}";
//    }
//}
//class HierarchicalInheritance
//{
//    public static void Main(string[] args)
//    {
//        Rectangle r = new Rectangle { Color = "Red" , Length = 20 , Width = 30};
//        r.AreaDisplay();
//        Console.WriteLine(r);

//        Circle c = new Circle("White" , 3.14);
//        Console.WriteLine(c);
//    }
//}

// 4] Hybrid Inheritance
class Vehicle // base class
{
    public string Brand { get; set; }

    public Vehicle()
    {

    }
    public Vehicle(string Brand)
    {
        this.Brand = Brand;
    }

    public override string ToString()
    {
        return $"Brand:- {this.Brand}";
    }
}
class Car : Vehicle // child class of vehicle
{
    public int Seats { get; set; }

    public Car()
    {

    }
    public Car(string Brand, int Seats) : base(Brand)
    {
        this.Seats = Seats;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Seats:- {this.Seats}";
    }
}
class Truck : Vehicle // child class of vehicle
{
    public int Capacity { get; set; }

    public Truck()
    {

    }

    public Truck(string Brand, int Capacity) : base(Brand)
    {
        this.Capacity = Capacity;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Capacity:- {this.Capacity}";
    }
}
class ElectricCar : Car // grandchild of Vehicle
{
    public string Battery { get; set; }

    public ElectricCar()
    {

    }

    public ElectricCar(string Brand, int Seats, string Battery) : base(Brand, Seats)
    {
        this.Battery = Battery;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Battery:- {Battery}";
    }
}
class HybridInheritance
{
    public static void Main(string[] args)
    {
        Vehicle v = new Vehicle("Hybrid Car");
        Console.WriteLine(v);
        Console.WriteLine();

        Car c = new Car("Toyota", 5);
        Console.WriteLine(c);
        Console.WriteLine();

        Truck t = new Truck("Volvo", 12);
        Console.WriteLine(t);
        Console.WriteLine();

        ElectricCar e = new ElectricCar("TATA", 4, "100 kWh");
        Console.WriteLine(e);


    }
}