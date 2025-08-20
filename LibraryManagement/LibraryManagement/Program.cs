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
