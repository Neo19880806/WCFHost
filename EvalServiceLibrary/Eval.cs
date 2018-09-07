using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Data;
namespace EvalServiceLibrary
{

    [DataContract]
    public class Eval
    {
        [DataMember]
        public string Submitter;
        [DataMember]
        public DateTime Timesent;
        [DataMember]
        public string Comments;

    }
}
