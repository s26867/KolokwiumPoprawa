namespace KolokwiumPoprawa.Data;

public class PostUser
{
    public int ID { get; set; }
    public string Email { get; set; }
    public IEnumerable<FavDto> Favorites { get; set; }
    
}

public class FavDto
{
    public int ID { get; set; }
}