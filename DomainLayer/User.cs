﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class User
    {
        public User()
        {
            UserRoll = Roll.User;
        }
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="نام نباید خالی باشد")]
        [MaxLength(50,ErrorMessage ="نام نباید از 50 بیشتر باشد")]
        public string Name { get; set; }

        [Required(ErrorMessage = "نام کاربری  نباید خالی باشد")]
        [MaxLength(50, ErrorMessage = "نام کاربری نباید بیشتر از 50 باشد")]
        public string Username { get; set; }

        [Required(ErrorMessage = "پسورد نباید خالی باشد")]
        [MaxLength(50, ErrorMessage = "پسورد نباید از 50 بیشتر باشد")]
        [MinLength(6,ErrorMessage ="پسورد نباید از 6 کمتر باشد")]
        public string Password { get; set; }

        public Roll UserRoll { get; set; }
    }
}