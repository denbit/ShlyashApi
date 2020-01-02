using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShlyashApi.Models
{
  public   enum ClientType
    {
        Mobile=0x01,
        OtherClient=0x00
    }
  public  abstract class Client
    {
        public string Name { get; set; }

        public abstract void setSessionId();
        public ClientType Type { get; set; }

           }
}
