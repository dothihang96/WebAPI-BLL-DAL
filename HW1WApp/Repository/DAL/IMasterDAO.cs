using HW1WApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW1WApp.Repository.DAL
{
    public interface IMasterDAO
    {
        /// <summary>
        /// 取得資料庫
        /// </summary>
        /// <returns></returns>
        Master Get_Master(Guid id);
        IEnumerable<Master> Get_AllMaster();
        Master Post_Master(Master master);
        Master Put_Master(Master master);
        void Delete_Master(Master master);
    }
}
