using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarajYeriModels
{
    public class VehiclePhoto:BaseModel
    {
        public string Path { get; set; } // dosya yolu veya adı
        public int VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
