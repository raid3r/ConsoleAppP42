using MessagePack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppP42.Serialization;

[MessagePackObject]
public class StudentGroup
{
    [Key(0)]        
    public int Id { get; set; }
    [Key(1)]
    public string Name { get; set; }
}
