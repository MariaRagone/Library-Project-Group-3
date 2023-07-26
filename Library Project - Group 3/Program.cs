//DateTime.ParseExact
using Library_Project___Group_3;

string filePath = "../../../LibraryDatabase.txt";
if (File.Exists(filePath) == false)
{
    StreamWriter tempWriter = new StreamWriter(filePath);
    tempWriter.WriteLine("Where the Sidewalk Ends|", "Shel Silverstein|", "on shelf");
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
        //name|age|grade
        string[] parts = line.Split("|");
        //parts[0] = name
        //parts[1] = age
        //parts[2] = grade
        Book b = new Book(parts[0], int.Parse(parts[1]), int.Parse(parts[2]));
        allBooks.Add(b);
    }
}
reader.Close();