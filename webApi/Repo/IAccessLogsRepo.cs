using ShlyahApi.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShlyahApi.Client.Repo
{
   public  interface IAccessLogsRepo
    {
         IQueryable<TokenData> tokenDatas { get; }
    }
}
