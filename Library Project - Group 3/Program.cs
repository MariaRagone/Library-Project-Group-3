//DateTime.ParseExact
using Library_Project___Group_3;
using System.Reflection;
using System;
using System.Net.NetworkInformation;
using System.Runtime.Intrinsics.X86;
using Microsoft.VisualBasic;

string filePath = "../../../LibraryDatabase.txt";
if (File.Exists(filePath) == false)
{
    StreamWriter tempWriter = new StreamWriter(filePath);
    tempWriter.WriteLine("Where the Sidewalk Ends|Shel Silverstein|on shelf");
    tempWriter.Close();
}
StreamReader reader = new StreamReader(filePath);
List<Book> allBooks = new List<Book>();
while (true)
{
    //name|age|grade
    string line = reader.ReadLine();

    if (line == null)
    {
        break;
    }
    else
    {
        //title|author|status
        string[] parts = line.Split("|");
        //parts[0] = title
        //parts[1] = author
        //parts[2] = status
        Book b = new Book(parts[0], (parts[1]), (parts[2]));
        allBooks.Add(b);
    }
}
reader.Close();
DateTime DueDate = DateTime.Now.AddDays(14);

List<Book> books = new List<Book>()
{
    new Book("The Great Gatsby", "F. Scott Fitzgerald", "on shelf"),
    new Book("Harry Potter and the Sorcerer's Stone", "J.K. Rowling","checked out", DueDate),
    new Book("To Kill a Mockingbird","Harper Lee", "on shelf"),    
    new Book("The Hobbit", "J.R.R. Tolkein", "checked out", DueDate),
    new Book("1984", "George Orwell", "on shelf"),
    new Book("Siddhartha", "Herman Hesse", "on shelf"),
    new Book("For Whom the Bell Tolls", "Ernest Hemingway", "checked out", DueDate),
    new Book("Shining", "Stephen King", "on shelf"),
    new Book("The Hobbit", "J.R.R. Tolkein", "on shelf"),
    new Book("For Whom the Bell Tolls", "Ernest Hemingway", "checked out", DueDate),
    new Book("The Shining", "Stephen King", "on shelf"),    
    new Book("Bossypants", "Tina Fey", "checked out", DueDate),
    new Book("Me Talk Pretty One Day", "David Sedaris", "on shelf"),
    new Book("Where'd You Go, Bernadette", "Maria Semple", "on shelf"),
    new Book("The Hitchhiker's Guide to the Galaxy", "Douglas Adams", "on shelf")

};


foreach (Book b in books)
{
    b.GetDetails();
}

string Status = "";
StreamWriter writer = new StreamWriter(filePath);
foreach (Book bk in books)
{
    //name|age|grade
    if (Status == "checked out")
    {
    writer.WriteLine($"{bk.Title}|{bk.Author}|{bk.Status}|{bk.DueDate}");

    }
    else
    {
        writer.WriteLine($"{bk.Title}|{bk.Author}|{bk.Status}");

    }
}
writer.Close();



Console.WriteLine("What book do you want to view?");

//bool runProgram = true;
//while (runProgram)
//{
//    GetDetails(allBooks);
//}