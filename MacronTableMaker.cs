using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ConsoleSandbox
{
    [Table("MacronTable")]
    public class MacronTable
    {
        [Key]
        public string? Id { get; set; }
        public string Letter1 { get; set; }
        public string Letter2 { get; set; }
        public string Letter3 { get; set; }
        public string Letter4 { get; set; }
        public string Letter5 { get; set; }
        public string Letter6 { get; set; }
    }
}
