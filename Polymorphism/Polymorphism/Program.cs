// 1] Compiletime polymorphism[Method Overoading]

// eg 1 
//class Calculate
//{
//    public static double pi = 3.14;
//    public double Area(double radius)
//    {
//        return pi * radius * radius; // circle
//    }

//    public int Area(int side)
//    {
//        return side * side; // square
//    }

//    public double Area(float length ,double breadth)
//    {
//        return length * breadth; // rectangle
//    }

//    public double Area(double base, int height )
//    {
//        return  1/2 * base * height; // triangle
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Calculate c = new Calculate();
//        Console.WriteLine("Area of Circle:- " + c.Area(10.7)); // (10)
//        Console.WriteLine("Area of Rectangle:- " + c.Area(18.5f , 5.6));
//        Console.WriteLine("Area of Square:- " + c.Area(10f,4f));
//        Console.WriteLine("Area of Triangle:- " + c.Area(10,4.6));
//    }
//}


// ------------------------------------------------------------------------------------------------------------------------------//


// eg 2 Compiletime polymorphism [Method overloading]
//using System;

//class Calculate
//{
//    public static double pi = 3.14;

//    public double Area(double radius)
//    {
//        return pi * radius * radius; // circle
//    }

//    public int Area(int side)
//    {
//        return side * side; // square
//    }

//    public double Area(float length, double breadth)
//    {
//        return length * breadth; // rectangle
//    }

//    public double Area(double b, double height)
//    {
//        return 0.5 * b * height; // triangle
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Calculate c = new Calculate();

//        Console.WriteLine("PI value is:- " + Calculate.pi);
//        Console.WriteLine("Area of Circle: " + c.Area(10.7));            
//        Console.WriteLine("Area of Rectangle: " + c.Area(18.5f, 5.6));   
//        Console.WriteLine("Area of Square: " + c.Area(10));              
//        Console.WriteLine("Area of Triangle: " + c.Area(10, 4.6));       
//    }
//}


// ------------------------------------------------------------------------------------------------------------------------------//

// Task 1
//using System;

//class InterestCalculator
//{
//    public double Principal { get; set; }
//    public double Rate { get; set; }
//    public int Year { get; set; }
//    public int CompoundYear { get; set; }

//    public void CalculateInterest(double principal, double rate)
//    {
//        this.Principal = principal;
//        this.Rate = rate;
//        Console.WriteLine($"Simple Interest: {this.Principal * this.Rate / 100}");
//    }
//    public void CalculateInterest(double principal, double rate, int year)
//    {
//        this.Principal = principal;
//        this.Rate = rate;
//        this.Year = year;
//        Console.WriteLine($"Simple Interest for {year} years: {(principal * rate * year) / 100}");
//    }
//    public void CalculateInterest(double principal, double rate, int year, int compoundPerYear)
//    {
//        this.Principal = principal;
//        this.Rate = rate;
//        this.Year = year;
//        this.CompoundYear = compoundPerYear;

//        double compoundInterest = principal * Math.Pow(1 + (rate / (100.0 * compoundPerYear)), compoundPerYear * year) - principal;

//        Console.WriteLine($"Compound Interest for {year} years: {compoundInterest}");
//    }
//}

//class InterestApp
//{
//    static void Main(string[] args)
//    {
//        InterestCalculator ic = new InterestCalculator();

//        ic.CalculateInterest(2000, 4);               
//        ic.CalculateInterest(2000, 4, 3);            
//        ic.CalculateInterest(2000, 4, 3, 4);         
//    }
//}



// ------------------------------------------------------------------------------------------------------------------------------//

// Task 1
//class SalaryCalculator
//{
//    public int Salary { get; set; }
//    public int Bonus { get; set; }
//    public int Deduction { get; set; }
//    public void CalculateSalary(int salary)
//    {
//        this.Salary = salary;
//        Console.WriteLine($"Total Salary is {salary}");
//    }
//    public void CalculateSalary(int salary , int bonus)
//    {
//        this.Bonus = bonus;
//        this.Salary =  salary ;
//        Console.WriteLine($"Total Salary + Bonus :- {salary + bonus}");
//    }
//    public void CalculateSalary(int salary , int bonus,int deducation)
//    {
//        this.Salary = salary;
//        this.Bonus = bonus;
//        this.Deduction = deducation;
//        Console.WriteLine($"Salary with deduction: {Salary + Bonus  - deducation} ");
//    }
//}
//class SalaryApp
//{
//    static void Main(string[] args)
//    {
//        SalaryCalculator s = new SalaryCalculator();
//        s.CalculateSalary(9000);
//        s.CalculateSalary(100 ,34);
//        s.CalculateSalary(50 , 89,60);
//    }
//}


// ------------------------------------------------------------------------------------------------------------------------------//

// Task 1 , only one argument pass, not everytime salary , bonus pass

//class SalaryCalculator
//{
//    public double Salary { get; set; }
//    public float Bonus { get; set; }
//    public int Deduction { get; set; }

//    public void CalculateSalary(double salary)
//    {
//        this.Salary = salary;
//        Console.WriteLine($"Total Salary is {salary}");
//    }

//    public void CalculateSalary(float bonus)
//    {
//        this.Bonus = bonus;
//        Console.WriteLine($"Total Salary + Bonus: {this.Salary + bonus}");
//    }

//    public void CalculateSalary(int deduction)
//    {
//        this.Deduction = deduction;
//        Console.WriteLine($"Salary with Deduction: {(this.Salary + this.Bonus) - deduction}");
//    }
//}
//class SalaryApp
//{
//    static void Main(string[] args)
//    {
//        SalaryCalculator s = new SalaryCalculator();

//        s.CalculateSalary(9000.00);
//        s.CalculateSalary(100.8f);
//        s.CalculateSalary(50);

//    }
//}


// ------------------------------------------------------------------------------------------------------------------------------//
// 2] Runtime polymorphism
using System.Runtime.Intrinsics.Arm;

class Shape
{
    public virtual void Area()
    {
        Console.WriteLine("Area ");
    }
}
class Rectangle : Shape
{
    public int width;
    public int height;
    public Rectangle()
    {

    }
    public Rectangle(int width, int height)
    {
        this.width = width;
        this.height = height;
    }
    public override void Area()
    {
        Console.WriteLine($"Area of Rectangle:- {this.width * this.height}");
    }
}
class Circle : Shape
{
    public float radius;

    public Circle()
    {

    }
    public Circle(float radius)
    {
        this.radius = radius;
    }

    public override void Area()
    {
        Console.WriteLine($"Area of Circle:- {3.14 * this.radius * this.radius}");
    }
}
class Polymorphism
{
    static void Main(string[] args)
    {

        //Shape s = new Rectangle(23, 56);
        //s.Area();

        //Shape s2 = new Circle(4);
        //s2.Area();


        Shape s; // parent reference 
        s = new Rectangle(23, 56); // parent reference and child object
        s.Area();

        s = new Circle(4); // parent reference and child object
        s.Area();
    }


}

