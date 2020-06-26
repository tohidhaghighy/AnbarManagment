using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class DeviceType
    {
        [Key]
        [Display(Name ="شماره")]
        public int Id { get; set; }

        [MaxLength(50)]
        [Display(Name = "نام")]
        public string Name { get; set; }

        public ICollection<Equipment> Equipments { get; set; }
    }
}
