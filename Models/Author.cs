using System.ComponentModel.DataAnnotations;

namespace Moldovan_Luminita_Lab2.Models
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public ICollection<Book>? Books { get; set; }
    }
}
