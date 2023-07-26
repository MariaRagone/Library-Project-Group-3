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
		public string GetDetails()
		{
			if (Status == "checked out")
			{
				return $"{Title}, by: {Author}, status: {Status}, due by: {DueDate}";
			}
			else if (Status == "on shelf")
			{
				return $"{Title}, by: {Author}, status: {Status}";

			}
			else
			{
				return "Invalid"; //visit this later
			}
		}

    }
}

