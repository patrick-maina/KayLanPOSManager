using KayLanPOSDataManager.Library.Internal.DataAccess;
using KayLanPOSDataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KayLanPOSDataManager.Library.DataAccess
{
    public class UserData
    {
        public List<UserModel> GetUserById(string Id)
        {            
            SQLDataAccess sql = new SQLDataAccess();

            var p = new { Id = Id };

            var output = sql.LoadData<UserModel, dynamic>("dbo.spUserLookUp", p, "KayLanPOSData");

            return output;
        }
    }
}
