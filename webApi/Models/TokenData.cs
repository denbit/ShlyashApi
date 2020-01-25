        using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShlyahApi.Client.Models
{
    public class TokenData
    {
        [Key]
        public int Id { get; set; }
        public  BaseClient client;
     public string Key { get; set; }
    }
}