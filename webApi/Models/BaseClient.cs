using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShlyahApi.Client.Models
{
   public  abstract class BaseClient
    {
        public string Name { get; set; }

        public abstract void setSessionId();
        public Types.ClientType Type { get; set; }

           }
}
