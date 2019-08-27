using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HW1WApp.Factory;
using HW1WApp.Repository.BLL;
using HW1WApp.Repository.DAL;
using HW1WApp.ViewModels;
using Newtonsoft.Json;

namespace HW1WApp.Models.BLL
{
    [DependencyRegister]
    public class MasterBLO : IMasterBLO
    {
        private IMasterDAO _iMasterDAO;

        public MasterBLO(IMasterDAO iMasterDAO)
        {
            _iMasterDAO = iMasterDAO;
        }

        public IEnumerable<Master> GetAllMasters()
        {
            try
            {
                IEnumerable<Master> _master = _iMasterDAO.Get_AllMaster();
                return _master;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public Master GetMaster(Guid id)
        {
            try
            {
                Master _master = _iMasterDAO.Get_Master(id);
                return _master;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public Master PostMasters(inUnitResult inUnitResult)
        {
            try
            { 
                Master input = new Master
                {
                    Id = Guid.NewGuid(),
                    Date = DateTime.UtcNow,
                    Value1 = inUnitResult.Value1,
                    Value2 = inUnitResult.Value2
                };
                Master _master = _iMasterDAO.Post_Master(input);
                return _master;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public Master PutMasters(Master master)
        {
            try
            {
                Master _master = _iMasterDAO.Put_Master(master);
                return _master;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void DeleteMasters(Master master)
        {
            try
            {
                _iMasterDAO.Delete_Master(master);
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
    }
}
