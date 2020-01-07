using ShlyashApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShlyashApi.Repo
{
   public  interface IAccessLogsRepo
    {
         IQueryable<TokenData> tokenDatas { get; }
    }
}
