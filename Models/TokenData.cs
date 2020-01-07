        using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShlyashApi.Models
{
    public class TokenData
    {
        [Key]
        public int Id { get; set; }
        public  Client client;
     public string Key { get; set; }
    }
}