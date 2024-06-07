using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarajYeriModels
{
    public class Policy:BaseModel
    {
        public string Name { get; set; }
        public string CompanyName { get; set; } // sigorta firması
        public DateTime Validity { get; set; }
        public string? FilePath { get; set; }
        public int PolicyTypeId { get; set; }
        public PolicyType PolicyType { get; set; }
    }
}
