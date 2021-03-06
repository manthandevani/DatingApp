using System.Collections.Generic;
using System.Threading.Tasks;
using DattingApp.API.Models;

namespace DattingApp.API.Data
{
    public interface IDatingRepository
    {
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         Task<bool> SavelAll();
         Task<IEnumerable<User>> GetUsers();
         Task<User> GetUser(int Id);
    }
}