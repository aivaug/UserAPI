using System.ComponentModel.DataAnnotations;

namespace UserAPI.Models.Users
{
    public class User : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
