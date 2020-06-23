﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Calender;

namespace DomainLayer
{
    public class Equipment
    {
        public Equipment()
        {
            DeviceStatus = Status.Defalt;
            ReturnDevice = false;
            ResiveDate = DateTime.Now;
            PersianResiveDate = DateConverter.GetPersianDateOnlyDate(DateTime.Now);
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [Required(ErrorMessage = "شماره اموال نباید خالی باشد")]
        [MaxLength(50)]
        public string AmvalNumber { get; set; }

        [Required(ErrorMessage = "سریال نباید خالی باشد")]
        [MaxLength(50)]
        public string Serial { get; set; }

        [Required(ErrorMessage = "مدل نباید خالی باشد")]
        [MaxLength(50)]
        public string Model { get; set; }

        public Nullable<DateTime> ResiveDate { get; set; }

        [MaxLength(50)]
        public string PersianResiveDate { get; set; }

        public Nullable<DateTime> SendDate { get; set; }

        [MaxLength(50)]
        public string PersianSendDate { get; set; }

        public Status DeviceStatus { get; set; }
        public Boolean ReturnDevice { get; set; }

        #region foregin key

        [ForeignKey("Devicetype")]
        public int DevicetypeId { get; set; }

        public DeviceType Devicetype { get; set; }
        #endregion

    }
}
