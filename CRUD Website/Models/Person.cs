namespace CRUD_Website.Models
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    public class Person
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Range(1, 100, ErrorMessage = "Age Must be between 1-100 only!")]
        public int Age { get; set; }

        [DisplayName("Date Created")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
