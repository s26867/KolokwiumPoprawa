using Microsoft.EntityFrameworkCore;

namespace KolokwiumPoprawa.Data;

public class MyDbContext : DbContext
{
    //TAvele tutaj
    
    public MyDbContext(DbContextOptions options) : base(options)
    {
    }
    
    //Tutaj polaczenie jesli PKFK 
    
}