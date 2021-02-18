using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTS_SimpleBilling.Model
{
    public class Unit
    {
        [Key]
        [MaxLength(60)]
        public int UnitId { get; set; }
        [MaxLength (240)]
        public string UnitName { get; set; }
       
    }
}
