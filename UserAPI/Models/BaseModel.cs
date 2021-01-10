using System;
using System.ComponentModel.DataAnnotations;
using UserAPI.Models.Users;

namespace UserAPI.Models
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedDate
        {
            get; set;
        } = DateTime.Now;
        public bool IsDeleted { get; set; }
        public virtual User CreatedBy { get; set; }
    }
}
