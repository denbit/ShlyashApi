using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShlyahApi.UserStore.Entity
{
  public class User
    {
        public int Id { get; set; }
        public int Identity { get; private set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

    }
}
