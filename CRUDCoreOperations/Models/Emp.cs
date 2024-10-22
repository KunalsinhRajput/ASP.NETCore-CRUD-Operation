using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDCoreOperations.Models
{
    public class Emp
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Eid { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        public string Ename { get; set; }
        [Required(ErrorMessage ="Addreess Is required")]
        public string Eaddress { get; set; }

        [Required(ErrorMessage ="Mobile Number is Required")]
        public string MobileNo { get; set; }
    }
}
