using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Interfaces;

namespace Classes
{
    public class FairlyGoodTeaMaker : ITeaMaker
    {
        public string MakerName()
        {
            return "Fairly Good Maker";
        }

        public string MakeTea()
        {
            return "Builders tea";
        }

    }
}