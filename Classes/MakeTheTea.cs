using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Interfaces;
using Study_Guide.Models;

namespace Classes
{
    public class MakeTheTea
    {
        private readonly TeaMakerModel _teaboys = new TeaMakerModel();

        private readonly VeryPoshTeaMaker _veryPosh = new VeryPoshTeaMaker();
        private readonly FairlyGoodTeaMaker _fairlyGood = new FairlyGoodTeaMaker();
        private readonly AwfulTeaMaker _awfulTea = new AwfulTeaMaker();

        public MakeTheTea()
        {
            var teaBoys = new List<ITeaMaker> { _veryPosh, _fairlyGood, _awfulTea };

            foreach (ITeaMaker teaMaker in teaBoys)
            {
                DoSomeFunkyStuff(teaMaker); //_teaboys.Add(teaMaker.MakeTea());
            }
        }

        //public List<TeaMakerModel> MakeTea()
        //{
        //    return _teaboys;
        //}

        public void DoSomeFunkyStuff(ITeaMaker teaboy)
        {
            var teaMakers = new List<TeaMakerModel>();
            _teaboys.TeaMakers.Add(new TeaMakerModel { MakerName = teaboy.MakerName(), MakeTea = teaboy.MakeTea()});
        }
    }
}