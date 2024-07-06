using GarajYeri.Data;
using GarajYeri.Repository.Abstract;
using GarajYeri.Repository.Shared.Concrate;
using GarajYeriModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarajYeri.Repository.Concrate
{
    public class VehicleRepository: Repository<Vehicle>,IVehicleRepository
    {
        private readonly ApplicationDbContext _context;

        public VehicleRepository(ApplicationDbContext context):base(context)
        {
            _context = context;
        }

        public IEnumerable<Vehicle> GetAll(bool isAdmin, int userId)
        {
            if (isAdmin)
            {
                var result = _context.Vehicles.Where(v => !v.IsDeleted).Select(v => new Vehicle
                {
                    Name = v.Name,
                    Odometer = v.Odometer,
                    Id = v.Id,
                    LicensePlate = v.LicensePlate,
                    VehicleType = v.VehicleType,
                    AppUser = v.AppUser
                });
                return result;
            }
            else
            {
                
                return _context.Vehicles.Where(v => !v.IsDeleted && v.AppUserId == userId); ; 
            }
        }
    }
}
