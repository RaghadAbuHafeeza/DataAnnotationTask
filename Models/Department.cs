using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnnotationTask.Models
{
    internal class Department
    {
        public int Id { get; set; }

        [Column(TypeName = "Varchar(200)")]
        public string Name { get; set; }
    }
}
