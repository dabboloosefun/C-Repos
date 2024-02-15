public class Song
{
    public string Title;
    public Artist Singer;
    public Song(string title)
    {
        this.Title = title;
        this.Singer = new Artist("Unknown");
    }


    public void SetSinger(Artist setToArtist)
    {
         this.Singer = setToArtist;
    }


    public string Info()
    {
        return $"{this.Title} is by {this.Singer.Name}";
    }
}