using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication4.Models;

namespace WebApplication4.ViewModels
{
    public class NewEdirViewModel
    {
        public IEnumerable<EdirType> EdirTypes { get; set; }
        public Edir Edir { get; set; }
    }
}