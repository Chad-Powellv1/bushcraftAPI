using System.ComponentModel.DataAnnotations;

namespace bushcraftAPI.Models{
    /// <summary name="BaseEntity Model"> 
    /// The base entity model contains the base properties for all entities.
    /// </summary>
    public class BaseEntityModel{
        public int Id { get; set; }
        public bool IsPublished { get; set; }
        [DataType(DataType.Date)] public DateTime CreatedDate { get; set; }
        [DataType(DataType.Date)] public DateTime LastModifiedDate { get; set; }
        [DataType(DataType.Date)] public DateTime? PublishedDate { get; set; }
    }
}