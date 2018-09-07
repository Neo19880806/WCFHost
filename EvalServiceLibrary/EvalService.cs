using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace EvalServiceLibrary
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class EvalService : IEvalService
    {
        List<Eval> evals = new List<Eval>();

        #region IEvalService Members

        public void SubmitEval(Eval eval)
        {
            evals.Add(eval);
        }

        public List<Eval> GetEvals()
        {
            return evals;
        }

        #endregion
    }
}
