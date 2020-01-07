using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShlyashApi.Models
{
    public static class Entensions
    {
        public  static void PrintLogs( this TokenData logs, out string log)
        {
             log = logs.ToString();
        }
    }
}