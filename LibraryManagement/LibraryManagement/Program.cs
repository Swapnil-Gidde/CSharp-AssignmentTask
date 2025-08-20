//using System;

//namespace LibraryManagementSystem_NoCollection
//{
//    // -------------------- 1. CLASS & OBJECT --------------------
//    class Book
//    {
//        // -------------------- 2. FIELDS --------------------
//        private string title;
//        private string author;
//        private string isbn;
//        private double price;

//        // -------------------- 3. PROPERTIES --------------------
//        public string Title
//        {
//            get { return title; }
//            set { title = value; }
//        }

//        public string Author
//        {
//            get { return author; }
//            set { author = value; }
//        }

//        public string ISBN   // read-only after initialization
//        {
//            get { return isbn; }
//            private set { isbn = value; }
//        }

//        public double Price
//        {
//            get { return price; }
//            set { price = value; }
//        }

//        // Constructor
//        public Book(string title, string author, string isbn, double price)
//        {
//            this.Title = title;
//            this.Author = author;
//            this.ISBN = isbn;   // read-only (private set)
//            this.Price = price;
//        }

//        public override string ToString()
//        {
//            return $"[Book: {Title}, Author: {Author}, ISBN: {ISBN}, Price: {Price}]";
//        }
//    }

//    // -------------------- 7. INHERITANCE --------------------
//    class EBook : Book
//    {
//        public double FileSizeMB { get; set; }

//        public EBook(string title, string author, string isbn, double price, double fileSize)
//            : base(title, author, isbn, price)
//        {
//            FileSizeMB = fileSize;
//        }

//        public override string ToString()
//        {
//            return base.ToString() + $", FileSize: {FileSizeMB}MB";
//        }
//    }

//    // -------------------- Member Class --------------------
//    class Member
//    {
//        private string name;
//        private string memberID;
//        private string contact;

//        public string Name
//        {
//            get { return name; }
//            set { name = value; }
//        }

//        public string MemberID
//        {
//            get { return memberID; }
//            private set { memberID = value; }
//        }

//        public string Contact
//        {
//            get { return contact; }
//            set { contact = value; }
//        }

//        // -------------------- 8. COMPOSITION --------------------
//        private Book borrowedBook;   // Single borrowed book

//        public Member(string name, string memberID, string contact)
//        {
//            this.Name = name;
//            this.MemberID = memberID;
//            this.Contact = contact;
//        }

//        // -------------------- 4. METHOD --------------------
//        public void BorrowBook(Book book)
//        {
//            borrowedBook = book;
//            Console.WriteLine($"{Name} borrowed: {book.Title}");
//        }

//        public Book GetBorrowedBook()
//        {
//            return borrowedBook;
//        }
//    }

//    // -------------------- 7. INHERITANCE --------------------
//    class PremiumMember : Member
//    {
//        public int RewardPoints { get; set; }

//        public PremiumMember(string name, string memberID, string contact, int points)
//            : base(name, memberID, contact)
//        {
//            RewardPoints = points;
//        }
//    }

//    // -------------------- Library Class --------------------
//    class Library
//    {
//        // -------------------- 6. DATA HIDING --------------------
//        private Book storedBook;   // only one book stored

//        // -------------------- 4. METHOD --------------------
//        // Method 1: Accept Book object
//        public void AddBook(Book book)
//        {
//            storedBook = book;
//            Console.WriteLine($"Book added: {book.Title}");
//        }

//        // -------------------- 9. COMPILE-TIME POLYMORPHISM --------------------
//        // Method 2: Accept book details
//        public void AddBook(string title, string author, string isbn, double price)
//        {
//            storedBook = new Book(title, author, isbn, price);
//            Console.WriteLine($"Book added using details: {title}");
//        }

//        public Book GetAvailableBook()
//        {
//            return storedBook;
//        }
//    }

//    // -------------------- MAIN --------------------
//class Program
//{
//    static void Main(string[] args)
//    {
//        // Create Library
//        Library library = new Library();

//        // Create Books
//        Book b1 = new Book("C# Basics", "John Smith", "ISBN001", 499);
//        EBook b2 = new EBook("Advanced C#", "Jane Doe", "ISBN002", 799, 15.2);

//        // Add books to Library
//        library.AddBook(b1);   // Using Book object
//        library.AddBook("OOP in Depth", "Robert King", "ISBN003", 599); // Overloaded method

//        // Create Members
//        Member m1 = new Member("Alice", "M001", "alice@email.com");
//        PremiumMember m2 = new PremiumMember("Bob", "M002", "bob@email.com", 100);

//        // Borrow books
//        m1.BorrowBook(b1);
//        m2.BorrowBook(b2);

//        // Show available book in Library
//        Console.WriteLine("\nAvailable Book in Library:");
//        Console.WriteLine(library.GetAvailableBook());

//        // Show borrowed books
//        Console.WriteLine($"\n{m1.Name} borrowed: {m1.GetBorrowedBook()}");
//        Console.WriteLine($"{m2.Name} borrowed: {m2.GetBorrowedBook()}");
//    }
//}
//}

// -------------------------------------------------------------------------------------------------------------------------------// 

// composition
//using System;

//namespace LibraryManagement
//{
//    class Book
//    {
//        private string title;
//        private string author;
//        private string isbn;
//        private double price;

//        public string Title
//        {
//            get { return title; }
//            set { title = value; }
//        }

//        public string Author
//        {
//            get { return author; }
//            set { author = value; }
//        }

//        public string ISBN
//        {
//            get { return isbn; }
//            private set { isbn = value; }  // read-only 
//        }

//        public double Price
//        {
//            get { return price; }
//            set { price = value; }
//        }

//        public Book(string title, string author, string isbn, double price)
//        {
//            Title = title;
//            Author = author;
//            ISBN = isbn;   // read-only
//            Price = price;
//        }

//        public override string ToString()
//        {
//            return $"[Book: {Title}, Author: {Author}, ISBN: {ISBN}, Price: {Price}]";
//        }
//    }

//    class EBook : Book
//    {
//        private double fileSizeMB;
//        public double FileSizeMB
//        {
//            get { return fileSizeMB; }
//            set { fileSizeMB = value; }
//        }

//        public EBook(string title, string author, string isbn, double price, double fileSize)
//            : base(title, author, isbn, price)
//        {
//            FileSizeMB = fileSize;
//        }

//        public override string ToString()
//        {
//            return base.ToString() + $", FileSize: {FileSizeMB}MB";
//        }
//    }

//    class Member
//    {
//        private string name;
//        private string memberID;
//        private string contact;
//        private Book borrowedBook = new Book("Default Book", "Unknown", "ISBN000", 0);

//        public string Name
//        {
//            get { return name; }
//            set { name = value; }
//        }

//        public string MemberID
//        {
//            get { return memberID; }
//            set { memberID = value; }
//        }

//        public string Contact
//        {
//            get { return contact; }
//            set { contact = value; }
//        }

//        public Book BorrowedBook
//        {
//            get { return borrowedBook; }
//            set { borrowedBook = value; }
//        }

//        public Member(string name, string memberID, string contact)
//        {
//            Name = name;
//            MemberID = memberID;
//            Contact = contact;
//        }

//        public void BorrowBook(Book book)
//        {
//            BorrowedBook = book;   // composition
//            Console.WriteLine($" \n {Name} borrowed: {book.Title}");
//        }
//    }
//    class PremiumMember : Member
//    {
//        private int rewardPoints;

//        public int RewardPoints
//        {
//            get { return rewardPoints; }
//            set { rewardPoints = value; }
//        }

//        public PremiumMember(string name, string memberID, string contact, int points)
//            : base(name, memberID, contact)
//        {
//            RewardPoints = points;
//        }
//    }

//    class Library
//    {
//        private Book storedBook = new Book("Default Stored Book", "Unknown", "ISBNXXX", 0);

//        public Book StoredBook
//        {
//            get { return storedBook; }
//            set { storedBook = value; }
//        }

//        public void AddBook(Book book)
//        {
//            StoredBook = book;
//            Console.WriteLine($" \n Book added: {book.Title}");
//        }

//        public void AddBook(string title, string author, string isbn, double price)
//        {
//            StoredBook = new Book(title, author, isbn, price);
//            Console.WriteLine($"\n Book added using details: {title}");
//        }

//        public Book GetAvailableBook()
//        {
//            return StoredBook;
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Library library = new Library();

//            Book b1 = new Book("C# Core ", "Ram", "ISBN001", 1000);
//            EBook b2 = new EBook("Advanced C#", "Lakshman", "ISBN002", 777, 9.0);

//            library.AddBook(b1);
//            library.AddBook("OOP in C#", "Hanuman", "ISBN003", 599);

//            Member m1 = new Member("Jay", "M001", "jay@email.com");
//            PremiumMember m2 = new PremiumMember("Om", "2", "om@email.com", 100);

//            m1.BorrowBook(b1);
//            m2.BorrowBook(b2);

//            Console.WriteLine("------------------------------------------------------------------------------------------");


//            Console.WriteLine("\n Available Book in Library:");
//            Console.WriteLine(library.GetAvailableBook());

//            Console.WriteLine($"\n {m1.Name} borrowed: {m1.BorrowedBook}");
//            Console.WriteLine($"\n {m2.Name} borrowed: {m2.BorrowedBook}");
//        }
//    }
//}


using System;

namespace LibraryManagement
{
    class Book
    {
        private string title;
        private string author;
        private string isbn;
        private double price;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string ISBN
        {
            get { return isbn; }
            private set { isbn = value; }  // read-only 
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Book(string title, string author, string isbn, double price)
        {
            Title = title;
            Author = author;
            ISBN = isbn;   // read-only
            Price = price;
        }

        public override string ToString()
        {
            return $"[Book: {Title}, Author: {Author}, ISBN: {ISBN}, Price: {Price}]";
        }
    }

    class EBook : Book
    {
        private double fileSizeMB;
        public double FileSizeMB
        {
            get { return fileSizeMB; }
            set { fileSizeMB = value; }
        }

        public EBook(string title, string author, string isbn, double price, double fileSize)
            : base(title, author, isbn, price)
        {
            FileSizeMB = fileSize;
        }

        public override string ToString()
        {
            return base.ToString() + $", FileSize: {FileSizeMB}MB";
        }
    }

    class Member
    {
        private string name;
        private string memberID;
        private string contact;

        private Book borrowedBook = new Book("Default Book", "Unknown", "ISBN000", 0);

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string MemberID
        {
            get { return memberID; }
            set { memberID = value; }
        }

        public string Contact
        {
            get { return contact; }
            set { contact = value; }
        }

        public Book BorrowedBook
        {
            get { return borrowedBook; }
            set { borrowedBook = value; }
        }

        public Member(string name, string memberID, string contact)
        {
            Name = name;
            MemberID = memberID;
            Contact = contact;
        }

        public void BorrowBook(Book book)
        {
            BorrowedBook = book;   // composition
            Console.WriteLine($"\n {Name} borrowed: {book.Title}");
        }
    }

    class PremiumMember : Member
    {
        private int rewardPoints;

        public int RewardPoints
        {
            get { return rewardPoints; }
            set { rewardPoints = value; }
        }

        public PremiumMember(string name, string memberID, string contact, int points)
            : base(name, memberID, contact)
        {
            RewardPoints = points;
        }
    }

    class Library
    {

        private Book storedBook = new Book("Default Stored Book", "Unknown", "ISBNXXX", 0);

        public Book StoredBook
        {
            get { return storedBook; }
            set { storedBook = value; }
        }

        // Method Overloading (AddBook in two ways)
        public void AddBook(Book book)
        {
            StoredBook = book;
            Console.WriteLine($"\n Book added: {book.Title}");
        }

        public void AddBook(string title, string author, string isbn, double price)
        {
            StoredBook = new Book(title, author, isbn, price);
            Console.WriteLine($"\n Book added using details: {title}");
        }

        public Book GetAvailableBook()
        {
            return StoredBook; 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();   

            Book b1 = new Book("C# Core", "Ram", "ISBN001", 1000);
            EBook b2 = new EBook("Advanced C#", "Lakshman", "ISBN002", 777, 9.0);

            library.AddBook(b1);
            library.AddBook("OOP in C#", "Hanuman", "ISBN003", 599);

            Member m1 = new Member("Jay", "M001", "jay@email.com");
            PremiumMember m2 = new PremiumMember("Om", "M002", "om@email.com", 100);

            m1.BorrowBook(b1);
            m2.BorrowBook(b2);

            Console.WriteLine("------------------------------------------------------------------------------------------");

            Console.WriteLine("\n Available Book in Library:");
            Console.WriteLine(library.GetAvailableBook());

            Console.WriteLine($"\n {m1.Name} borrowed: {m1.BorrowedBook}");
            Console.WriteLine($"\n {m2.Name} borrowed: {m2.BorrowedBook}");
        }
    }
}
