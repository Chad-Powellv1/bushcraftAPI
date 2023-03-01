using bushcraftAPI.Models;

namespace bushcraftAPI.Repository{
    /// <summary name="UserRepository">
    /// This interface is used to define the methods used to
    /// Create, Read, Update, and Delete users.
    /// </summary>
    public interface IUserRepository{
        UserModel GetUser(int id);
        IEnumerable<UserModel> GetAllUsers();
        UserModel AddUser(UserModel userModel);
        UserModel UpdateUser(UserModel userModel);
        UserModel DeleteUser(int id);
    }
}