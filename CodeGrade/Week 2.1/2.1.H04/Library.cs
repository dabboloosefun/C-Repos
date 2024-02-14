public class Library
{
    public List<Book> Books;
    public int MaxSize;
    public Library(int maxSize)
    {
        this.MaxSize = maxSize;
        this.Books = new List<Book>{};
    }

    public bool AddBook(int id, string title)
    {
        // list.Count == int elementsInList
        if (this.Books.Count != this.MaxSize)
        {
            this.Books.Add(new Book(id, title));
            return true;
        }
        return false;
    }


    public Book FindBookByID(int id)
    {
        foreach (Book book in this.Books)
        {
            if (book.ID == id) return book;
        }
        return null;
    }


    public void EditBookTitle(int id, string newTitle)
    {
        foreach (Book book in this.Books)
        {
            if (book.ID == id)
            {
                book.Title = newTitle;
                return;
            }
        }
    }


    public void RemoveBookByTitle(string title)
    {
        for (int book = 0; book < this.Books.Count; book++)
        {
            if (this.Books[book].Title == title)
            {
                this.Books.RemoveAt(book);
                book--;
            }
        }
    }
}