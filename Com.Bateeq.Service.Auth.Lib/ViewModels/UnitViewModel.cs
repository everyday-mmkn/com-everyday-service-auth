using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Bateeq.Service.Auth.Lib.ViewModels
{
    public class UnitViewModel
    {
        public int _id { get; set; }
        public string name { get; set; }
        public string code { get; set; }

        public DivisionViewModel division { get; set; }
    }
}
