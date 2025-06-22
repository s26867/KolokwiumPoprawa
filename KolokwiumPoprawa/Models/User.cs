using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KolokwiumPoprawa.Models;
[Table("User")]
public class User
{
    [Key]
    public int ID { get; set; }
    [Required, MaxLength(150)] public string Name { get; set; } = null!;
    [Required, MaxLength(150)] public string Email { get; set; } = null!;
    public virtual ICollection<UserBookFavorite> UserBookFavorites { get; set; } = null!;
    public virtual ICollection<Loan> Loans { get; set; } = null!;
}