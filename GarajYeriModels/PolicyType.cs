﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarajYeriModels
{
    public class PolicyType:BaseModel
    {
        public string Name { get; set; }
        public virtual ICollection<Policy> Policies { get; set; }   
    }
}
