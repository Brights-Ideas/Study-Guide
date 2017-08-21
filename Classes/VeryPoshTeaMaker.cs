using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Interfaces;

namespace Classes
{
    public class VeryPoshTeaMaker : ITeaMaker
    {
        public string MakerName()
        {
            return "Very Posh Maker";
        }

        public string MakeTea()
        {
            return "Very Posh tea";
        }
    }
}