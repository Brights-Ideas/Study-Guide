using System.Collections.Generic;
using Interfaces;
using Study_Guide.Models;
using Classes;

namespace Study_Guide.Classes
{
    public class MakeTheTea
    {
        private readonly List<TeaMakerModel> _teaboys = new List<TeaMakerModel>();

        private readonly VeryPoshTeaMaker _veryPosh = new VeryPoshTeaMaker();
        private readonly FairlyGoodTeaMaker _fairlyGood = new FairlyGoodTeaMaker();
        private readonly AwfulTeaMaker _awfulTea = new AwfulTeaMaker();

        public List<TeaMakerModel> MakeTheTeaList()
        {
            var teaBoys = new List<ITeaMaker> { _veryPosh, _fairlyGood, _awfulTea };

            foreach (ITeaMaker teaMaker in teaBoys)
            {
                DoSomeFunkyStuff(teaMaker); //_teaboys.Add(teaMaker.MakeTea());
            }

            return _teaboys;
        }

        //public List<TeaMakerModel> MakeTea()
        //{
        //    return _teaboys;
        //}

        public void DoSomeFunkyStuff(ITeaMaker teaboy)
        {
            //var teaMakers = new List<TeaMakerModel>();
            _teaboys.Add(new TeaMakerModel { MakerName = teaboy.MakerName(), MakeTea = teaboy.MakeTea()});
        }
    }
}