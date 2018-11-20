using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InfoWebApplication.Models
{
    public class Info
    {
        [Key]
        public int id { get; set; }
        //[JsonProperty("firstname")]
        public string firstname { get; set; }
        //[JsonProperty("lastname")]
        public string lastname { get; set; }
        //[JsonProperty("gender")]
        public string gender { get; set; }
        //[JsonProperty("favorites")]
        public string[] favorites { get; set; }
        //[JsonProperty("role")]
        public string role { get; set; }
    }
}