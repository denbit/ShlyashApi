using ShlyahApi.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShlyahApi.UserStore.Entity;

namespace ShlyahApi.Client.Repo
{
   public  interface ICommonUserRepo
    {
         IQueryable<User> Users { get; }
    }
}
