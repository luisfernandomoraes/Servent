using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servent.Domain
{
    public class UnitType
    {
        [Column(TypeName = "int")]
        public int ID { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Name { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(250)]
        public string Description { get; set; }
         
        public UnitType()
        {
            Name = string.Empty;
            Description = string.Empty;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
