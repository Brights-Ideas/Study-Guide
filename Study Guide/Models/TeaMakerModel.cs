using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Study_Guide.Models
{
    public class TeaMakerModel
    {
        public TeaMakerModel()
        {
            //sTeaMakers = teaMakers;
        }

        public string MakerName { get; set; }
        public string MakeTea { get; set; }

        public List<TeaMakerModel> TeaMakers { get; set; }
    }
}