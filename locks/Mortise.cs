using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace locks
{
    [KnownType(typeof(AdMortise))]
    [Serializable]
    [DataContract]
    class Mortise : Locks
    {
        [DataMember]
        private string typeOfLocking;

        public string lockTypeOfLocking
        {
            get { return typeOfLocking; }
            set { typeOfLocking = value; }
        }

        public Mortise(string lockModel, string lockTypeOfLocking, string lockLength, string lockWeight, string lockDepth, string lockTypeOfMaterial, string lockPredistination, string lockTypeOfLock) :
        base(lockModel, lockLength, lockWeight, lockDepth, lockTypeOfMaterial, lockPredistination,lockTypeOfLock)
        {
            typeOfLocking = lockTypeOfLocking;
        }

        public override object Clone()
        {
            return new Mortise();
        }
    }
}
