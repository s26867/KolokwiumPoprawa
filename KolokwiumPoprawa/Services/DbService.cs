using KolokwiumPoprawa.Data;
using KolokwiumPoprawa.DTOs;
using KolokwiumPoprawa.Models;
using Microsoft.EntityFrameworkCore;

namespace KolokwiumPoprawa.Services;

public interface IDbService
{
    Task<IEnumerable<GetUsersDetails>> GetUsers(int id);
    //Task<IEnumerable<PostUser>> PostUsers(int id);
    
}

public class DbService(MyDbContext data) : IDbService
{
    public async Task<IEnumerable<GetUsersDetails>> GetUsers(int id )
    {
        return await data.Users.Select(p => new GetUsersDetails
        {
            ID = id,
            Name = p.Name,
            Email = p.Email,
            Books = p.UserBookFavorites.Select(ee => new BookDto
            {
                ID = ee.Book.ID,
                Title = ee.Book.Title,
                Author = ee.Book.Author
            }).ToList()
        }).ToListAsync();
    }

   
    
    
    
}