//DateTime.ParseExact
using Library_Project___Group_3;
using System.Reflection;
using System;
using System.Net.NetworkInformation;
using System.Runtime.Intrinsics.X86;
using Microsoft.VisualBasic;
using System.Runtime.ConstrainedExecution;

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
    new Book("The Stand", "Stephen King", "on shelf"),
    new Book("The Lord of the Rings", "J.R.R. Tolkein", "on shelf"),
    new Book("The Old Man and the Sea", "Ernest Hemingway", "checked out", DueDate),
    new Book("The Shining", "Stephen King", "on shelf"),
    new Book("Bossypants", "Tina Fey", "checked out", DueDate),
    new Book("Me Talk Pretty One Day", "David Sedaris", "on shelf"),
    new Book("Where'd You Go, Bernadette", "Maria Semple", "on shelf"),
    new Book("The Hitchhiker's Guide to the Galaxy", "Douglas Adams", "on shelf")

};
//-----------------------------------------------------------------------------------
//puts the list above onto the file
string Status = "";
StreamWriter writer = new StreamWriter(filePath);
foreach (Book bk in books)
{
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
///---------------------------------------------------------------------------------


////PSEUDOCODE
//start program and display menu options
//Chose to display all books or search, or retrun book
    //if display all books as numbered list
        //show the entire list of books
        //search by author, title, keyword
    //if search
        //prompt the user to search by author, title, or keyword
        //display the searchlist that matches search term - list is numbered
        //at the end of the list there is extra numbers for checkout, search again, see entire list, quit
            //if checkout
                //change status and due date for selected book
            //if search again
                //loop the "search" if statement above
            //if display entire list
                //search by author, title, keyword
    //if return book
        //show the list of books that are checked out (status = checked out)
        //which book do you want to return?
        //change status and remove due date for selected book
    //if quit
        //quit the program
                



//DISPLAY ALL BOOKS
DisplayMenu(books);





//revisit whether to search seperately or not allowing character 
bool runProgram = true;

while (runProgram)
{
    Console.WriteLine("Search by Author,Title or keyword");
    string choice = Console.ReadLine().ToLower().Trim();


    if (books.Any(b => b.Title.ToLower().Trim().Contains(choice)))
    {
        List<Book> searchList = books.Where(b => b.Title.ToLower().Trim().Contains(choice)).ToList();

        DisplayMenu(searchList);
        break;
    }

    else if (books.Any(b => b.Author.ToLower().Trim().Contains(choice)))
    {
        List<Book> searchList = books.Where(b => b.Author.ToLower().Trim().Contains(choice)).ToList();

        DisplayMenu(searchList);
        break;
    }
    else
    {
        Console.WriteLine("Not found.");

    }

    Console.WriteLine("");
    string checkOut = Console.ReadLine().Trim().ToLower();





    //looping
 

    //    int menuChoice = -1;
    //while (menuChoice <= -1 || menuChoice >= Allcar.Count + 3)
    //{
    //    Console.WriteLine($"Choose a menu option. 1-{Allcar.Count + 2}");
    //    while (int.TryParse(Console.ReadLine(), out menuChoice) == false)
    //    {
    //        Console.WriteLine("incorrect format");
    //    }
    //}



















    //    menuChoice




    //    //LOGIC for buying Car
    //    if (checkOut == "y")
    //    {
    //        books.Remove(choice);
    //        Console.WriteLine("Our finance team will reach out to you shortly.");
    //    }

    //    else
    //    {
    //        Console.WriteLine("Feel free to keep browsing.");

    //    }
    //    }

}





















//methods
static void DisplayMenu(List<Book> bookList)
{
    for (int i = 0; i < bookList.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {bookList[i]}");

    }
    Console.WriteLine($"{bookList.Count + 1} Check out");
    Console.WriteLine($"{bookList.Count + 2} Search again");
    Console.WriteLine($"{bookList.Count + 3} Quit");
}

//bool runProgram = true;
//while (runProgram)
//{
//    GetDetails(allBooks);
//}