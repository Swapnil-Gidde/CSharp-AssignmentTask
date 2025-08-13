//// Association:- Aggregation and Composition
//class Author
//{
//    public string Name { get; set; }
//    public string Email { get; set; }
//    public string Gender { get; set; }

//    public Author()
//    {

//    }
//    public Author(string Name, string Email, string Gender)
//    {
//        this.Name = Name;
//        this.Email = Email;
//        this.Gender = Gender;
//    }

//    public override string ToString()
//    {
//        return $"Author[Name:- {this.Name}, Email:- {this.Email}, Gender:- {this.Gender}]";
//    }
//}
//class Book
//{
//    public string Name { get; set; }
//    public Author Aut { get; set; } //= new Author { Name = "Swapnil", Email = "sg@gmail.com", Gender = "Male" };
//    public double Price { get; set; }
//    public int Qty { get; set; }

//    public Book()
//    {

//    }
//    public Book(string Name, string Author, double Price, int Qty)
//    {
//        this.Name = Name;
//        this.Aut = Aut;
//        this.Price = Price;
//        this.Qty = Qty;
//    }
//    public override string ToString()
//    {
//        return $"Book[Name:- {this.Name}, {this.Aut}, Price:- {this.Price}, Qty:- {this.Qty}]";
//    }
//}
//class Association
//{
//    static void Main(string[] args)
//    {
//        Book b = new Book("XYZ", "ABC", 89,2);
//        Console.WriteLine(b);

//        Author a = new Author("Ram", "rm@gmail.com", "Male");
//        b.Aut = a;
//    }
//}

// Example 2
class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Discount { get; set; }

    public Customer()
    {
        Id = 0;
        Name = "unknown";
        Discount = 0;
    }
    public Customer(int Id, string Name, int Discount)
    {
        this.Id = Id;
        this.Name = Name;
        this.Discount = Discount;
    }

    //public void DiscountDetails()
    //{
    //    Console.WriteLine();
    //}
    public override string ToString()
    {
        return $"Customer[Id = {this.Id} ,Name= {this.Name}, Discount = {this.Discount}]";
    }
}
class InvoiceItem
{
    public int ID { get; set; }
    public Customer cst { get; set; }// = new Customer { Id = 1, Name = "Ram", Discount = 45 };
    public double Ammount { get; set; }

    public InvoiceItem()
    {

    }
    public InvoiceItem(int id, Customer customer, double ammount)
    {
        this.ID = id;
        this.cst = customer;
        this.Ammount = ammount;
    }

    public override string ToString()
    {
        return $"InvoiceItem[ID:- {this.ID}, Customer:- {this.cst}, Amount:- {this.Ammount}]";
    }
}
class Association
{
    static void Main(string[] args)
    {
        InvoiceItem item = new InvoiceItem();
        Console.WriteLine(item);

        Customer c = new Customer(1,"es",23);
        item.cst = c;
        Console.WriteLine(item);
    }
}