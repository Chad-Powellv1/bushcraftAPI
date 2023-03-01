using bushcraftAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace bushcraftAPI.Interface{
    /// <summary name="UserInterface">
    /// This interface connects to the database and allows the user to
    /// Create, Read, Update, and Delete posts from the database, with
    /// methods that are defined in the IUserRepository interface.
    /// </summary>
    public class UserInterface{
        private readonly IdentityDbContext<UserModel> _context;
        
        public UserInterface(IdentityDbContext<UserModel> context)
        {
            _context = context;
        }

        public UserModel? AddUser(UserModel? userModel)
        {
            _context.Users.Add(userModel);
            _context.SaveChanges();
            return userModel;
        }
        
        public UserModel? DeleteUser(int id)
        {
            UserModel? userModel = _context.Users.Find(id);
            if (userModel != null)
            {
                _context.Users.Remove(userModel);
                _context.SaveChanges();
            }
            
            return userModel;
        }
        
        public UserModel? GetUser(int id)
        {
            return _context.Users.Find(id);
        }
        
        public IEnumerable<UserModel?> GetAllUsers()
        {
            return _context.Users;
        }
        
        public UserModel? UpdateUser(UserModel? userModel)
        {
            var user = _context.Users.Attach(userModel);
            user.State = EntityState.Modified;
            return userModel;
        }
        
    }
}