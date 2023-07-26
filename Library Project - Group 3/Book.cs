using System;
namespace Library_Project___Group_3
{
	public class Book
	{
		//properties
		public string Title { get; set; }
		public string Author { get; set; }
		public string Status { get; set; }
		public string DueDate { get; set; }
	
		//constructor
		public Book(string _title, string _author, string _status)
		{
			Title = _title;
			Author = _author;
			Status = _status;
			DueDate = "";
		}
		//overload
		public Book(string _title, string _author, string _status, string _dueDate)
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
				Console.WriteLine($"{Title}, by: {Author}, status: {Status}, due by: {DueDate}");
			}
			else if (Status == "on shelf")
			{
                Console.WriteLine( $"{Title}, by: {Author}, status: {Status}");

			}
			else
			{
                Console.WriteLine( "Invalid"); //visit this later
			}
		}

    }
}

