using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KolokwiumPoprawa.Models;
[Table("Loan")]
public class Loan
{
    [Key]
    public int Book_ID { get; set; }
    [Key]
    public int User_ID { get; set; }
    [Required]
    public DateTime LoanDate { get; set; }
    public DateTime? ReturnDate { get; set; }
    [ForeignKey(nameof(Book_ID))]
    public virtual Book Book { get; set; } = null!;
    
    [ForeignKey(nameof(User_ID))]
    public virtual User User { get; set; } = null!;
    
}