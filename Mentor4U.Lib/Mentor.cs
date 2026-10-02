using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mentor4U.Lib;

[Table("table_mentors")]
public record Mentor
{
    [Key]
    [Column("mentor_id")]
    public Guid Id { get; init; }
    
    [Column("mentor_name")]
    public string Name { get; init; }
    
    [Column("mentor_email")]
    public string Email { get; init; }
}