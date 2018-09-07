using ConsoleClient.ServiceReferenceClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            EvalServiceClient proxy = new EvalServiceClient("MybasicHttpBinding");
            Eval eval = new Eval();
            eval.Submitter = "Guojing LIANG";
            eval.Timesent = DateTime.Now;
            eval.Comments = "Just a test";
            proxy.SubmitEval(eval);
            Console.WriteLine("Total number of Eval:{0}", proxy.GetEvals().Length);
            Console.ReadLine();
        }
    }
}
