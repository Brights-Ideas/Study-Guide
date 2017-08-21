using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Interfaces;

namespace Classes
{
    public class AwfulTeaMaker : ITeaMaker
    {
        public string MakerName()
        {
            return "Awful Maker";
        }

        public string MakeTea()
        {
            return "Very Terrible tea";
        }
    }
}