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
    class AdMortise : Mortise
    {
        public AdMortise(string lockModel, string lockTypeOfLocking, string lockLength, string lockWeight, string lockDepth, string lockTypeOfMaterial, string lockPredistination, string lockTypeOfLock) :
        base(lockModel, lockTypeOfLocking ,lockLength, lockWeight, lockDepth, lockTypeOfMaterial, lockPredistination, lockTypeOfLock)
        {
            lockTypeOfLocking = "Однозапорный замок";
        }

        public override object Clone()
        {
            return new AdMortise(lockModel, lockTypeOfLocking, lockLength, lockWeight, lockDepth, lockTypeOfMaterial, lockPredistination, lockTypeOfLock);
        }

    }
}
