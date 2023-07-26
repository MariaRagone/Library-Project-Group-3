using System;
namespace Library_Project___Group_3
{
	public class Book
	{
		//properties
		public string Title { get; set; }
		public string Author { get; set; }
		public string Status { get; set; }
		public DateTime DueDate { get; set; }
	
		//constructor
		public Book(string _title, string _author, string _status)
		{
			Title = _title;
			Author = _author;
			Status = _status;
			DueDate = DateTime.Now;
		}
		//overload
		public Book(string _title, string _author, string _status, DateTime _dueDate)
		{
			Title = _title;
			Author = _author;
			Status = _status;
			DueDate = _dueDate;
		}

		//methods
		public void GetDetails()
		{
			if (Status == "checked out")
			{
				Console.WriteLine(String.Format("{0,-40} by: {1, -30} status: {2, -20} due by:{3, 10}", Title, Author, Status, DueDate));
			}
			else if (Status == "on shelf")
			{
                Console.WriteLine(String.Format("{0,-40} by: {1, -30} status: {2, -20}", Title, Author, Status));

            }
            else
			{
                Console.WriteLine( "Invalid"); //visit this later
			}
		}



    }
}

