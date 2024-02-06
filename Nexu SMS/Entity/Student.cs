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

        [Column("First Name")]
        public string fName { get; set; }

        [Column("Last Name")]
        public string lName { get; set; }

        [Column("E-mail")]
        public string eMail { get; set; }

        [Column("Mobile")]
        public string number { get; set; }

        public DateTime dob { get; set; }

        [Column("Class")]
        public int clss { get; set; }

        [Column( "Section",TypeName ="varachar")]

        [StringLength(50)]
        public char section { get; set; }

    }
}
