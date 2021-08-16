using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class InputOutputEntity
    {
        [Key]
        [StringLength(50)]
        public string IntOutId { get; set; }

        [Required]
        public DateTime IntOutDate { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public bool IsInput { get; set; }

        //Relacion con Almacenamiento

        public string StorageId { get; set; }
        public StorageEntity Storage { get; set; }
    }
}
