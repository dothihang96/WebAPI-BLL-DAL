using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HW1WApp.Factory;
using HW1WApp.Repository.DAL;

namespace HW1WApp.Models.DAL
{
    [DependencyRegister]
    public class MasterDAO : IMasterDAO
    {
        private readonly HW1WebAppDBContext _context;

        public MasterDAO(HW1WebAppDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Master> Get_AllMaster()
        {
            try
            {
                IEnumerable<Master> _master = from x in _context.master
                    select x;
                return _master;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public Master Get_Master(Guid id)
        {
            try
            {
                Master _master = _context.master.Find(id);
                return _master;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public Master Post_Master(Master master)
        {
            try
            {
                _context.master.Add(master);
                _context.SaveChanges();
                return Get_Master(master.Id);
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public Master Put_Master(Master master)
        {
            try
            {
                Master _master = _context.master.Find(master.Id);
                if (_master != null)
                {
                    _context.Entry(_master).CurrentValues.SetValues(master);
                    _context.SaveChanges();
                }
                return Get_Master(master.Id);
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void Delete_Master(Master master)
        {
            try
            {
                Master _master = _context.master.Find(master.Id);
                if (_master != null)
                {
                    _context.master.Remove(_master);
                    _context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
    }
}
