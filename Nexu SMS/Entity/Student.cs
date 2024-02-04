using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Nexu_SMS.Entity
{
    public class Student
    {
        [Key]
        [Column(TypeName ="varchar")]
        [StringLength(30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)] //disable the identity
        public string id { get; set; }
        [Required]

        [Column("First Name")]
        public string fName { get; set; }

        [Required]
        [Column("Last Name")]
        public string lName { get; set; }

        [Required]
        [Column("Date of birth")]
        public DateTime dob { get; set; }

        [Required]
        [Column("Section")]
        public char section { get; set; }

        [Required]
        [Column("Class")]
        public int std {  get; set; } 

        ///////

 /*       [ForeignKey("id")]*/

    }
}
