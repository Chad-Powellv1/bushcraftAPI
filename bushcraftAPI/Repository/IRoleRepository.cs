using bushcraftAPI.Models;

namespace bushcraftAPI.Repository{
    /// <summary name="ITagRepository">
    /// This interface is used to define the methods used to
    /// Create, Read, Update, and Delete roles.
    /// </summary>
    public interface IRoleRepository{
        RoleModel GetRole(int id);
        IEnumerable<RoleModel> GetAllRoles();
        RoleModel AddRole(RoleModel roleModel);
        RoleModel UpdateRole(RoleModel roleModel);
        RoleModel DeleteRole(int id);
    }
}