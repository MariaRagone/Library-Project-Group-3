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
    tempWriter.WriteLine("Where the Sidewalk Ends|Shel Silverstein|true");
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
        Book b = new Book(parts[0], (parts[1]), (bool.Parse(parts[2])));
        allBooks.Add(b);
    }
}
reader.Close();
DateTime DueDate = DateTime.Now.AddDays(14);

List<Book> books = new List<Book>()
{
    new Book("The Great Gatsby", "F. Scott Fitzgerald", true),
    new Book("Harry Potter and the Sorcerer's Stone", "J.K. Rowling", false, DueDate),
    new Book("To Kill a Mockingbird","Harper Lee", true),
    new Book("The Hobbit", "J.R.R. Tolkein", false, DueDate),
    new Book("1984", "George Orwell", true),
    new Book("Siddhartha", "Herman Hesse", true),
    new Book("For Whom the Bell Tolls", "Ernest Hemingway", false, DueDate),
    new Book("The Stand", "Stephen King", true),
    new Book("The Lord of the Rings", "J.R.R. Tolkein", true),
    new Book("The Old Man and the Sea", "Ernest Hemingway", false, DueDate),
    new Book("The Shining", "Stephen King", true),
    new Book("Bossypants", "Tina Fey", false, DueDate),
    new Book("Me Talk Pretty One Day", "David Sedaris", true),
    new Book("Where'd You Go, Bernadette", "Maria Semple", true),
    new Book("The Hitchhiker's Guide to the Galaxy", "Douglas Adams", true)

};
//-----------------------------------------------------------------------------------
//puts the list above onto the file
bool Status = true;
StreamWriter writer = new StreamWriter(filePath);
foreach (Book bk in books)
{
    if (Status = false)
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

Console.WriteLine("Welcome to the libary");
Console.WriteLine("Choose an option:");
Console.WriteLine("1. Display all books");
Console.WriteLine("2. Search for a book");
Console.WriteLine("3. Return a book");
int input = int.Parse(Console.ReadLine().Trim().ToLower());
if (input == 1)
{
    //DISPLAY ALL BOOKS
    DisplayMenu(books);
    Console.WriteLine("");
    SearchOption(books);
    Console.WriteLine("Choose an option:");
    Console.WriteLine("1. Check out");
    Console.WriteLine("2. Search again");
    Console.WriteLine("3. Quit");
    //Make a method for check out process

}
else if (input == 2)
{
    SearchOption(books);

    Console.WriteLine("Choose an option:");
    Console.WriteLine("1. Check out");
    Console.WriteLine("2. Search again");
    Console.WriteLine("3. Quit");
    int input2 = int.Parse(Console.ReadLine().Trim().ToLower());
    if (input2 == 1)
    {
        //Make a method for check out process
        CheckOut(input2, books);


    }
    else if (input2 == 2)
    {
        SearchOption(books);
    }
    else if (input2 == 3)
    {
        Console.WriteLine("Goodbye");
        //add a break to the loop
    }
}

//methods
static void DisplayMenu(List<Book> bookList)
{
    for (int i = 0; i < bookList.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {bookList[i]}");

    }

}

static void SearchOption(List<Book> bk)
{
    Console.WriteLine("Search by Author,Title or keyword");
    string choice = Console.ReadLine().ToLower().Trim();

    if (bk.Any(b => b.Title.ToLower().Trim().Contains(choice)))
    {
        List<Book> searchList = bk.Where(b => b.Title.ToLower().Trim().Contains(choice)).ToList();

        DisplayMenu(searchList);

    }

    else if (bk.Any(b => b.Author.ToLower().Trim().Contains(choice)))
    {
        List<Book> searchList = bk.Where(b => b.Author.ToLower().Trim().Contains(choice)).ToList();

        DisplayMenu(searchList);

    }
    else
    {
        Console.WriteLine("Not found.");

    }
}

static void CheckOut(int i, List<Book> b)
{
    Console.WriteLine("Which book would you like to check out? Enter number");
    int result = -1;
    while (int.TryParse(Console.ReadLine(), out result) == false || result <= 0 || result >= b.Count)
    {
        Console.WriteLine($"Invalid input. Try again with a number 1 = {b.Count}.");

    }
    Console.WriteLine("hi");
}

//VALIDATOR METHOD
//public static int GetPositiveInputInt()
//{
//    int result = -1;
//    while (int.TryParse(Console.ReadLine(), out result) == false || result <= 0)
//    {
//        Console.WriteLine("Invalid input. Try again with a positive number.");

//    }
//    return result;
//}

//revisit whether to search seperately or not allowing character 

//----------THIS IS EXPERIMENTAL---------------------------

//Console.WriteLine("Search by Author,Title or keyword");
//string choice = Console.ReadLine().ToLower().Trim();


//if (books.Any(b => b.Title.ToLower().Trim().Contains(choice)))
//{
//    List<Book> searchList = books.Where(b => b.Title.ToLower().Trim().Contains(choice)).ToList();

//    DisplayMenu(searchList);

//}

//else if (books.Any(b => b.Author.ToLower().Trim().Contains(choice)))
//{
//    List<Book> searchList = books.Where(b => b.Author.ToLower().Trim().Contains(choice)).ToList();

//    DisplayMenu(searchList);

//}
//else
//{
//    Console.WriteLine("Not found.");

//}

//Console.WriteLine("");
//string checkOut = Console.ReadLine().Trim().ToLower();





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

// original search option//Console.WriteLine("Search by Author,Title or keyword");
//string choice = Console.ReadLine().ToLower().Trim();

//if (books.Any(b => b.Title.ToLower().Trim().Contains(choice)))
//{
//    List<Book> searchList = books.Where(b => b.Title.ToLower().Trim().Contains(choice)).ToList();

//    DisplayMenu(searchList);

//}

//else if (books.Any(b => b.Author.ToLower().Trim().Contains(choice)))
//{
//    List<Book> searchList = books.Where(b => b.Author.ToLower().Trim().Contains(choice)).ToList();

//    DisplayMenu(searchList);

//}
//else
//{
//    Console.WriteLine("Not found.");

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




//Console.WriteLine($"{bookList.Count + 1} Check out");
//Console.WriteLine($"{bookList.Count + 2} Search again");
//Console.WriteLine($"{bookList.Count + 3} Quit");

//bool runProgram = true;
//while (runProgram)
//{
//    GetDetails(allBooks);
//}