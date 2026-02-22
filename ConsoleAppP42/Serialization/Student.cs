using MessagePack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConsoleAppP42.Serialization;


[MessagePackObject]
public class Student
{
    [Key(0)]
    public int Id { get; set; }
    [Key(1)]
    public string Name { get; set; }
    [Key(2)]
    public int Age { get; set; }
    [Key(3)]
    public double AverageGrade { get; set; }
    [Key(4)]
    public StudentGroup Group { get; set; }
}
