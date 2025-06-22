namespace KolokwiumPoprawa.DTOs;

public class GetUsersDetails
{
    public int ID{ get; set; }
    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
    public IEnumerable<BookDto> Books { get; set; }
}

public class BookDto
{
    public int ID { get; set; }
    public string Title { get; set; } = null!;
    public string Author { get; set; } = null!;
}