//DateTime.ParseExact
using Library_Project___Group_3;
using System.Reflection;
using System;
using System.Net.NetworkInformation;
using System.Runtime.Intrinsics.X86;

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

List<Book> books = new List<Book>()
{
    new Book("The Great Gatsby", "F. Scott Fitzgerald", "on shelf"),
    new Book("Harry Potter and the Sorcerer's Stone", "J.K. Rowling","checked out"),
    new Book("To Kill a Mockingbird","Harper Lee", "on shelf"),    
    new Book("The Hobbit", "J.R.R. Tolkein", "checked out"),
    new Book("1984", "George Orwell", "on shelf"),
    new Book("Siddhartha", "Herman Hesse", "on shelf"),
    new Book("For Whom the Bell Tolls", "Ernest Hemingway", "checked out"),
    new Book("Shining", "Stephen King", "on shelf"),
    new Book("The Hobbit", "J.R.R. Tolkein", "on shelf"),
    new Book("For Whom the Bell Tolls", "Ernest Hemingway", "checked out", "08-25-23"),
    new Book("The Shining", "Stephen King", "on shelf"),    
    new Book("Bossypants", "Tina Fey", "checked out", "09-16-23"),
    new Book("Me Talk Pretty One Day", "David Sedaris", "on shelf"),
    new Book("Where'd You Go, Bernadette", "Maria Semple", "on shelf"),
    new Book("The Hitchhiker's Guide to the Galaxy", "Douglas Adams", "on shelf")

};



foreach (Book b in books)
{
    b.GetDetails();
}



//bool runProgram = true;
//while (runProgram)
//{
//    GetDetails(allBooks);
//}