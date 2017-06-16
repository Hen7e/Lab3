using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace locks
{
    [Serializable]
    [DataContract]
    public class Hinged : Locks
    {
        [DataMember]
        private string typeOfKernel;

        public string lockTypeOfKernel
        {
            get { return typeOfKernel; }
            set { typeOfKernel = value; }
        }

        public Hinged(string lockModel,string lockTypeOfKernel, string lockLength, string lockWeight, string lockDepth, string lockTypeOfMaterial, string lockPredistination, string lockTypeOfLock) :
        base(lockModel, lockLength, lockWeight, lockDepth, lockTypeOfMaterial, lockPredistination, lockTypeOfLock)
        {
            typeOfKernel = lockTypeOfKernel;
        }

        public override object Clone()
        {
            return new Hinged();
        }
    }
}

