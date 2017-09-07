using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FraudeUitwisseling.Fraudeberichten
{
    public class Fraudebericht
    {
        [Key]
        public int BerichtID { get; set; }
        public ICollection<Fraudesignaal> Fraudesignalen { get; set; }
    }


}
