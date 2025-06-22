using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KolokwiumPoprawa.Models;
[Table("UserBookFavorite")]
public class UserBookFavorite
{
    [Key]
    public int Book_ID { get; set; }
    [Key]
    public int User_ID { get; set; }
    [ForeignKey(nameof(Book_ID))]
    public virtual Book Book { get; set; } = null!;
    [ForeignKey(nameof(User_ID))]
    public virtual User User { get; set; } = null!;
}