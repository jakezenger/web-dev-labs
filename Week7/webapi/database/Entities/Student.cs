
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[Table("student")]
public class Student
{
    [Column("student_id")]
    [Key]
    public long studentId {get; set;}
    [Column("email_address")]
    public string emailAddress {get; set;}
    [Column("person_id")]
    public long PersonID { get; set; }
    public Person Person { get; set; }
}