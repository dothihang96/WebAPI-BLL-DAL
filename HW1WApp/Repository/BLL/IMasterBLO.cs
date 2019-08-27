using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HW1WApp.Models;
using HW1WApp.ViewModels;

namespace HW1WApp.Repository.BLL
{
    public interface IMasterBLO
    {
        Master GetMaster(Guid id);
        IEnumerable<Master> GetAllMasters();
        Master PostMasters(inUnitResult inUnitResult);
        Master PutMasters(Master master);
        void DeleteMasters(Master master);
    }
}
