﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Oas.Models.Admin
{
    public class CreateTeacherViewModel
    {
        [Required]
        [DisplayName("用户名")]
        public string Username { get; set; }
        [Required]
        [DisplayName("密码")]
        public string Password { get; set; }
        [Required]
        [DisplayName("课程")]
        public string CourseId { get; set; }
    }
}