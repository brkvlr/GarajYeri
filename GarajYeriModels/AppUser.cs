﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarajYeriModels
{
    public class AppUser:BaseModel
    {
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; } = false;
        public virtual ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
    }
}
