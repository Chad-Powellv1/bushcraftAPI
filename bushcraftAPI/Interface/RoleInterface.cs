using bushcraftAPI.Context;
using bushcraftAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace bushcraftAPI.Interface{
    public class RoleInterface{
        
    private readonly IdentityDbContext _context;
    
        public RoleInterface(IdentityDbContext context)
        {
            _context = context;
        }
        
        public RoleModel? AddRole(RoleModel? roleModel)
        {
            _context.Roles.Add(roleModel);
            _context.SaveChanges();
            return roleModel;
        }
        
        public IdentityRole? DeleteRole(int id)
        {
            var roleModel = _context.Roles.Find(id);
            if (roleModel != null)
            {
                _context.Roles.Remove(roleModel);
                _context.SaveChanges();
            }
            
            return roleModel;
        }
        
        public IdentityRole? GetRole(int id)
        {
            return _context.Roles.Find(id);
        }
        
        public IEnumerable<IdentityRole> GetAllRoles()
        {
            return _context.Roles;
        }
        
        public IdentityRole? UpdateRole(IdentityRole? roleModel)
        {
            var role = _context.Roles.Attach(roleModel);
            role.State = EntityState.Modified;
            return roleModel;
        }
        
    }
}