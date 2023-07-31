using System;
using System.Diagnostics;
using System.Reflection;

namespace Library_Project___Group_3
{
	public class Book
	{
		//properties
		public string Title { get; set; }
		public string Author { get; set; }
		public bool Status { get; set; }
		public DateTime DueDate { get; set; }
	
		//constructor
		public Book(string _title, string _author, bool _status)
		{
			Title = _title;
			Author = _author;
			Status = _status;
			DueDate = DateTime.Now.AddDays(14);
		}
		//overload
		public Book(string _title, string _author, bool _status, DateTime _dueDate)
		{
			Title = _title;
			Author = _author;
			Status = _status;
			DueDate = _dueDate;
		}

		//methods
		//public void GetDetails(bool status)
		//{
		//	//status false = checked out
		//	//status true = on shelf
		//	if (Status == false)
		//	{
		//		Console.WriteLine(String.Format("{0,-40} by: {1, -30} Available: {2, -20} due by:{3, 10}", Title, Author, Status, DueDate));
		//	}
		//	else if (Status == true)
		//	{
  //              Console.WriteLine(String.Format("{0,-40} by: {1, -30} Available: {2, -20}", Title, Author, Status));

  //          }
  //          else
		//	{
  //              Console.WriteLine( "Invalid"); //visit this later
		//	}
		//}

        public override string ToString()
        {
			if (Status == false)
			{

                return String.Format("{0,-50} {1, -30} {2, -15} {3, 10}", Title, Author, "Checked Out", DueDate.ToString("MM/dd/yyyy"));
			}
			else 
			{

                return String.Format("{0,-50} {1, -30} {2, -15}", Title, Author, "On shelf");
			}
        }
    }

    }


