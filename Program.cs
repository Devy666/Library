internal class Program
{
    private static void Main(string[] args)
    {
        // Creating isOn to keep the loop active
        bool isOn = true;
        // Create List with expected objects
        List<Book> BookList = new List<Book>();
        string menu = "What do you want to do? : \n" +
            "[1] Add a book\n" +
            "[2] Show Shelf\n" +
            "[3] Quit";
        Console.WriteLine("Welcome to Book Shelf");
        while (isOn == true)
        {
            // Print Menu
            Console.WriteLine(menu);
            // In case of input that is not int
            Int32.TryParse(Console.ReadLine(), out int result);
            switch (result)
            {
                case 1:
                    //First option: Create new book
                    //Ask and save title and author.
                    Console.WriteLine("What's the title?");
                    string title = Console.ReadLine();
                    Console.WriteLine("What's the author?");
                    string author = Console.ReadLine();
                    // Ask for a genre and save the choice
                    Console.WriteLine("What genre is the book?\n" +
                        "[1] Fantasy\n" +
                        "[2] School Book\n" +
                        "[3] Novel");
                    // In case input is not an int
                    Int32.TryParse(Console.ReadLine(), out int genre);
                    // Depening av choice of genre use different Classes
                    switch (genre)
                    {
                        case 1:
                            // Choice 1 : Fantasy
                            // Creating new object of class Fantasy
                            Fantasy newFantasyBook = new Fantasy(title, author);
                            // Adding object to book list
                            BookList.Add(newFantasyBook);
                            Console.WriteLine("Added! Click enter");
                            Console.ReadLine();
                            break;
                        case 2:
                            // Choice 1 : School Book
                            // Creating new object of class SchoolBook
                            SchoolBook newSchoolBook = new SchoolBook(title, author);
                            // Adding object to book list
                            BookList.Add(newSchoolBook);
                            Console.WriteLine("Added! Click enter");
                            Console.ReadLine();
                            break;
                        case 3:
                            // Choice 1 : Novel
                            // Creating new object of class Novel
                            Novel newNovelBook = new Novel(title, author);
                            // Adding object to book list
                            BookList.Add(newNovelBook);
                            Console.WriteLine("Added! Click enter");
                            Console.ReadLine();
                            break;
                        default:
                            // Response if input wasnt int
                            Console.WriteLine("You need to choose " +
                                "correct genre Click enter.");
                            Console.ReadLine();
                            break;
                    }
                    break;
                case 2:
                    // Choice 2 - Writing all elements from the Shelf
                    // loop going though every element inside the list
                    foreach (Book book in BookList)
                    {
                        // Writing out every element and using ToString Metoden
                        Console.WriteLine(book.ToString());
                    }
                    break;
                case 3:
                    // Choice 3 - Quit
                    // Chaning isOn to false to end the while loop
                    isOn = false;
                    Console.WriteLine("Thanks for using program");
                    Console.ReadLine();
                    break;
                default:
                    // Response if input wasnt int
                    Console.WriteLine("You need to choose between 1-3");
                    break;
            }
        }

    }
}
//Base Class Book
class Book
{
    public string Title;
    public string Author;
    // Contructor with title and author needed at creating new object
    public Book(string Title, string Author)
    {
        this.Title = Title;
        this.Author = Author;
    }
}
// Inherited Class of Book
class Fantasy : Book
{
    // Adding Type variable and setting to type of book.
    private string Type = "Fantasy Book";
    // Contructor for inherited class
    public Fantasy(string Title, string Author) : base(Title, Author)
    {
    }
    // To string Method to make a string that can be written out.
    public override string ToString()
    {
        return "Title: " + Title + "\nAuthor: " + Author + "\n(" + Type + ")";
    }
}
class SchoolBook : Book
{
    // Adding Type variable and setting to type of book.
    private string Type = "School bok";
    // Contructor for inherited class
    public SchoolBook(string Title, string Author) : base(Title, Author)
    {
    }
    // To string Method to make a string that can be written out.
    public override string ToString()
    {
        return "Title: " + Title + "\nAuthor: " + Author + "\n(" + Type + ")";
    }
}
class Novel : Book
{
    // Adding Type variable and setting to type of book.
    private string Type = "Novel";
    // Contructor for inherited class
    public Novel(string Title, string Author) : base(Title, Author)
    {
    }
    // To string Method to make a string that can be written out.
    public override string ToString()
    {
        return "Title: " + Title + "\nAuthor: " + Author + "\n(" + Type + ")";
    }
}