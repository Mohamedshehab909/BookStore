using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.ViewModels
{
    public class BookVM
    {
        public int Id { get; set; }
        [Required]

        public string Name { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        [Range(0,1000)]
        public int Number { get; set; }
        [Required]
        public string Author { get; set; }
    }
}
