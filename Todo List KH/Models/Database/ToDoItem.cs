using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Todo_List_KH.Models
{
    public class ToDoItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        [Required]
        public DateTime ExecutionTime { get; set; }
        [Required]
        public bool IsCompleted { get; set; }

    }
}
