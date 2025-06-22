using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KolokwiumPoprawa.Models;
[Table("Book")]
public class Book
{
    [Column("ID")]
    [Key]
    public int ID { get; set; }

    [Required, MaxLength(100)] public string Title { get; set; } = null!;

    [Required, MaxLength(150)] public string Author { get; set; } = null!;
    public virtual ICollection<UserBookFavorite> UserBookFavorites { get; set; } = null!;
    public virtual ICollection<Loan> Loans { get; set; } = null!;
}