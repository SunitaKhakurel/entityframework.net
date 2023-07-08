using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Country")]
public class Country
{
    [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)] //starts frm 1 or 2
        public int Id { get; set; }
    //data anutation
    [Column(TypeName = "varchar(50)")]
    [Required]
    public string CountryName { get; set; }
    [Column(TypeName = "varchar(50)")]
    [Required]
    public string Continent { get; set; }
}
        


    
