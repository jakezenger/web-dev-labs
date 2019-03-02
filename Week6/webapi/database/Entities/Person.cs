using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[Table("person")]
public class Person
{
    [Column("person_id")]
    [Key]
    public long personId {get; set;}

    [Column("first_name")]
    public string firstName {get; set;}

    [Column("middle_name")]
    public string middleName {get; set;}

    [Column("last_name")]
    public string lastName {get; set;}

    public Student Student { get; set; }
}