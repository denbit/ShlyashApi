using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShlyahApi.UserStore.DBContexts;
using ShlyahApi.UserStore.Entity;

namespace ShlyahApi.UserStore.Seeds
{
  public class UserSeed : System.Data.Entity.DropCreateDatabaseAlways<SQLiteDBContext>
    {
        protected override void Seed(SQLiteDBContext context)
        {
            System.Diagnostics.Debug.WriteLine("t3tw3twt3wtrf34g34g34g3gg4wg4westetse");
            List<User> ts = new List<User> {
            new User{
            Id=1,
            Email="info@langivi.technology"
            },
           new User{
            Id=2,
            Email="elika@langivi.technology"
            }
            };
            ts.ForEach(user => context.users.Add(user));
            context.SaveChanges();

        }
    }
}
