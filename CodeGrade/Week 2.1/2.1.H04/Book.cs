public class Book
{
    public int ID;
    public string Title;
    public Book(int id, string title)
    {
        this.ID = id;
        this.Title = title;
    }


    public string Info()
    {
        return $"ID: {this.ID}, Title: {Title}";
    }
}