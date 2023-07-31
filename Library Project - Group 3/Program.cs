//DateTime.ParseExact
using Library_Project___Group_3;
using System.Reflection;
using System;
using System.Net.NetworkInformation;
using System.Runtime.Intrinsics.X86;
using Microsoft.VisualBasic;
using System.Runtime.ConstrainedExecution;
using System.Collections.Generic;
using System.Xml;

string filePath = "../../../LibraryDatabase.txt";
if (File.Exists(filePath) == false)
{
    StreamWriter tempWriter = new StreamWriter(filePath);
    tempWriter.WriteLine("Where the Sidewalk Ends|Shel Silverstein|true");
    tempWriter.Close();
}
StreamReader reader = new StreamReader(filePath);
List<Book> searchResults = new List<Book>();
List<Book> books = new List<Book>();
List<Book> checkedOut = new List<Book>();
List<Book> currentlyCheckedOut = new List<Book>();

while (true)
{
    //Title|Author|Status
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
        books.Add(b);
    }
}
reader.Close();
DateTime DueDate = DateTime.Now.AddDays(14);

List<Book> allBooks = new List<Book>()
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
///---------------------------------------------------------------------------------


////PSEUDOCODE
//start program and display menu options ***
//Chose to display all books or search, or retrun book, or quit *** 
//if display all books as numbered list ***
//show the entire list of books ***
//search by author, title, keyword ***
//if search ***
//prompt the user to search by author, title, or keyword ***
//display the searchlist that matches search term - list is numbered ***
//at the end of the list there is extra numbers for checkout, search again, see entire list, quit ***
//if checkout ***
//change status and due date for selected book ***


// do you want to search again? Loops back to the beginning ***
//if search again ***
//loop the "search" if statement above ***
//if display entire list ***
//search by author, title, keyword ***

//quit the program ***
//if quit ***




//add checked out books to a receipt List
//if return book ***
//show the list of books that are checked out (status = checked out) ***
//which book do you want to return? ***
//change status and remove due date for selected book ***



//EXTRA IDEAS
//console clear
//program asks for Name/username, then checked out books are stored in the username List


//1.Fix formatting of ‘books’ list
//2. Revisit menu?
//3. Save book list to text file

//Forrest  to  Everyone 3:41 PM
//4.  Fix ‘not found’ loop
//5. Fix search loop after not found
//6. Fix “quit loop” after search
//7. Validate input 2 loop


Console.WriteLine("Welcome to the Libary of Alexandria");
string library = @" _________________________________________________________
||--------------------------------------------------------||
||.--.    .-._                        .----.              ||
|||==|____| |H|___            .---.___|++++|______.--.___ ||
|||  |====| | |xxx|_          |+++|=-=|_  _|-=+=- |==|---|||
|||==|    | | |   | \         |   |   |_\/_|HARRY |  | ^ |||
|||  |    | | |   |\ \   .--. |   |=-=|_/\_|-=+=- |  | ^ |||
|||  |    | | |   |_\ \_( oo )|   |   |    |POTTER|  | ^ |||
|||==|====| |H|xxx|  \ \ |''| |+++|=-=|++++|-=+=- |==|---|||
||`--^----'-^-^---'   `-' --  '---^---^----^------^--^---^||
||--------------------------------------------------------||
||--------------------------------------------------------||
||               ___                   .-.__.-----. .---. ||
||              |===| .---.   __   .---| |XX|<(*)>|_|^^^| ||
||         ,  /(|   |_|III|__|''|__|:^:|=|  |     |=| Q | ||
||      _a'{ / (|===|+|   |++|  |==|   | |  |     | | R | ||
||      '/\\/ _(|===|-|   |  |''|  |:x:|=|  |     | | Y | ||
||_____  -\{___(|   |-|   |  |  |  |   | |  |     | | Z | ||
||       _(____)|===|+|[I]|DK|''|==|:>:|=|XX|<(*)>|=|^^^| ||
||              `---^-^---^--^--'--^---^-^--^-----^-^---^ ||
||--------------------------------------------------------||
||________________________________________________________||";
Console.WriteLine(library);

bool runProgram = true;
while (runProgram == true)
{
    Console.WriteLine();
    Console.WriteLine("Choose an option:");
    Console.WriteLine("1. Display all books");
    Console.WriteLine("2. Search for a book");
    Console.WriteLine("3. Return a book");
    Console.WriteLine("4. Quit");


    int input = int.Parse(Console.ReadLine().Trim().ToLower());
    if (input == 1)
    {
        Console.Clear();
        //DISPLAY ALL BOOKS
        DisplayMenu(books);
        Console.WriteLine("");
        searchResults = SearchOption(books);

        //MAKE THIS A METHOD

        while (true)
        { //---------------------------------------------------
            Console.WriteLine(); 
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Check out");
            Console.WriteLine("2. Search again");
            Console.WriteLine("3. Quit");
            int input2 = int.Parse(Console.ReadLine().Trim().ToLower());
            if (input2 == 1)
            {
                CheckOut(input2, searchResults);


            }
            else if (input2 == 2)
            {
                searchResults = SearchOption(books);
            }
            else if (input2 == 3)
            {
                Console.WriteLine("Goodbye. You have burned down the Library of Alexandria and set human civilization back by a few hundred years!");
                BurnLibrary();
                runProgram = false;
            }
            else
            {
                Console.WriteLine("Invalid input. Try again");
                break;
            }
            //---------------------------------------------
        }
    }
    else if (input == 2)
    {
        Console.Clear();
        searchResults = SearchOption(books);
        while (true)
        {
            Console.WriteLine("");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Check out");
            Console.WriteLine("2. Search again");
            Console.WriteLine("3. Quit");
            int input2 = int.Parse(Console.ReadLine().Trim().ToLower());
            if (input2 == 1)
            {

                CheckOut(input2, searchResults);
                Console.WriteLine();
                Console.WriteLine("SEARCH RESULTS");

                DisplayMenu(searchResults);

            }
            else if (input2 == 2)
            {

                searchResults = SearchOption(books);

            }
            else if (input2 == 3)
            {
                Console.Clear();
                Console.WriteLine("Goodbye. You have burned down the Library of Alexandria and set human civilization back by a few hundred years!");
                BurnLibrary();

                Console.WriteLine();
                Console.WriteLine("Here is the list of books that are checked out. I guess you get to keep them since the library is in flames. You will now be the smartest person who ever existed!");
                Console.WriteLine();
                Console.WriteLine();

                currentlyCheckedOut = books.Where(b => b.Status == false).ToList();
                DisplayMenu(currentlyCheckedOut);

                runProgram = false;
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again");
            }
        }
    }
    else if (input == 3)
    {
        Console.Clear();
        //List<Book> currentlyCheckedOut = new List<Book>();
        if (books.Any(b => b.Status == false))
        {
            currentlyCheckedOut = books.Where(b => b.Status == false).ToList();

            DisplayMenu(currentlyCheckedOut);

        }
        ReturnBook(input, currentlyCheckedOut);


    }
    else if (input == 4)
    {
        Console.Clear();
        Console.WriteLine("Goodbye. You have burned down the Library of Alexandria and set human civilization back by a few hundred years!");
        BurnLibrary();
        //list out any books that they have checked out
        runProgram = false;
        break;
    }
    else
    {
        Console.WriteLine("Invalid input. Please try again");
    }
}

//methods
static void DisplayMenu(List<Book> bookList)
{
    Console.WriteLine(String.Format("{0,-54} {1, -20} {2, 16} {3, 17}", "Title", "Author", "Status", "Due Date"));
    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");


    for (int i = 0; i < bookList.Count; i++)
    {
        Console.WriteLine(String.Format("{0,3}.", i + 1) + bookList[i]);

    }

}

static List<Book> SearchOption(List<Book> bk)
{
    while (true)
    {

        Console.WriteLine("Search by Author,Title or keyword");
        string choice = Console.ReadLine().ToLower().Trim();
        List<Book> searchList = new List<Book>();
        if (bk.Any(b => b.Title.ToLower().Trim().Contains(choice)))
        {
            searchList = bk.Where(b => b.Title.ToLower().Trim().Contains(choice)).ToList();
            Console.WriteLine();
            Console.WriteLine("SEARCH RESULTS");
            DisplayMenu(searchList);
            return searchList;

        }

        else if (bk.Any(b => b.Author.ToLower().Trim().Contains(choice)))
        {
            searchList = bk.Where(b => b.Author.ToLower().Trim().Contains(choice)).ToList();
            Console.WriteLine();
            Console.WriteLine("SEARCH RESULTS");
            DisplayMenu(searchList);
            return searchList;

        }
        else
        {
            Console.WriteLine("Not found.");
            continue;

        }
    }
}

static void CheckOut(int i, List<Book> b)
{

    while (true)
    {
        int result = -1;
        Console.WriteLine("");
        Console.WriteLine("Which book would you like to check out? Enter number");
        while (int.TryParse(Console.ReadLine(), out result) == false)
        {
            Console.WriteLine($"Invalid input. Try again with a number 1 = {b.Count}.");

        }
        result = result - 1;
        if (result < 0 || result >= b.Count())
        {
            Console.WriteLine("Number is out of range. Please try again");
            continue;
        }
        if (b[result].Status == true)
        {
            b[result].Status = false;
            b[result].DueDate = DateTime.Now.AddDays(14);
            Console.WriteLine();
            Console.Clear();

            Console.WriteLine("YOU HAVE CHECKED OUT:");
            Console.WriteLine($"{b[result]}");
            Console.WriteLine("");

            break;

        }
        else
        {
            Console.WriteLine("This book is already checked out.");
            break;
        }
    }

}

static void ReturnBook(int i, List<Book> b)
{


    while (true)
    {
        int result = -1;
        Console.WriteLine("Which book would you like to return? Enter number");
        while (int.TryParse(Console.ReadLine(), out result) == false)
        {
            Console.WriteLine($"Invalid input. Try again with a number 1 = {b.Count}.");

        }
        result = result - 1;
        if (result < 0 || result >= b.Count())
        {
            Console.WriteLine("Number is out of range. Please try again");
            continue;
        }

        if (b[result].Status == false && result >= 0 && result < b.Count())
        {
            b[result].Status = true;
            b[result].DueDate = DateTime.Now;
            Console.WriteLine($"{b[result]}");
            break;
        }
        else
        {
            Console.WriteLine($"Invalid input. Try again.");
            //with a number 1 = {b.Count}.");
        }
    }
}


static void BurnLibrary()
{


    string burn = @"|     |
                                \\_V_//
                                \/=|=\/
                                 [=v=]
                               __\___/_____
                              /..[  _____  ]
                             /_  [ [  M /] ]
                            /../.[ [ M /@] ]
                           <-->[_[ [M /@/] ]
                          /../ [.[ [ /@/ ] ]
     _________________]\ /__/  [_[ [/@/ C] ]
    <_________________>>0---]  [=\ \@/ C / /
       ___      ___   ]/000o   /__\ \ C / /
          \    /              /....\ \_/ /
       ....\||/....           [___/=\___/
      .    .  .    .          [...] [...]
     .      ..      .         [___/ \___]
     .    0 .. 0    .         <---> <--->
  /\/\.    .  .    ./\/\      [..]   [..]
 / / / .../|  |\... \ \ \    _[__]   [__]_
/ / /       \/       \ \ \  [____>   <____]
";
    Console.WriteLine(burn);


}

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

