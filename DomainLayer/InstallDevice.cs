using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class InstallDevice
    {
        public InstallDevice()
        {
            IsUnistall = false;
        }
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string PersianDate { get; set; }
        public Nullable<DateTime> InstallDate { get; set; }
        [MaxLength(50)]
        public string StoreName { get; set; }
        [MaxLength(50)]
        public string Marketername { get; set; }
        [MaxLength(50)]
        public string PersianUnistallDate { get; set; }
        public Nullable<DateTime> UnistallDate { get; set; }
        public Boolean IsUnistall { get; set; }
        [MaxLength(50)]
        public string Terminal { get; set; }

        #region foregnkey

        [ForeignKey("Device")]
        public int DeviceId { get; set; }
        public Device Device { get; set; }
        #endregion
    }
}
