using System;
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
        public virtual CookBook CookBook { get; private set; }

        public User(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
            CookBook = new CookBook(this);
        }

        public User(string Username, string Password, CookBook cookbook)
        {
            if(cookbook == null)
                throw new ArgumentNullException();
            this.Username = Username;
            this.Password = Password;
            CookBook = cookbook;
            cookbook.SetUser(this);
        }

        public void SetCookBook(CookBook cookBook)
        {
            if (cookBook != null)
            {
                this.CookBook = cookBook;
                this.CookBook.SetUser(this);
            }
        }
    }
}
