using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; private set; }
        public string Name { get; set; }
        public string SurName { get; set; }

        [Required]
        public virtual CookBook CookBook { get; set; }

        public User()
        {
            this.Password = "pass";
            CookBook = new CookBook();
        }
    }
}
