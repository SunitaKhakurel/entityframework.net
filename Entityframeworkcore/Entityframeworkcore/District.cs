using System.ComponentModel.DataAnnotations.Schema;

using System.ComponentModel.DataAnnotations;


namespace Entityframeworkcore
{
    [Table("District")]
    public class District
    {

        [Key] [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(TypeName = "varchar(50)")]
       
       
        public string DistrictName { get; set; }
        [Column(TypeName = "varchar(50)")]
       
       
        public string CountryName { get; set; }
    }
}
