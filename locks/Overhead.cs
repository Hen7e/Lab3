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
    public class Overhead : Locks 
    {
        [DataMember]
        private string typeOfMechanizm;

        public string lockTypeOfMechanizm
        {
            get { return typeOfMechanizm; }
            set { typeOfMechanizm = value; }
        }

        public Overhead(string lockModel,string lockTypeOfMechanizm, string lockLength, string lockWeight, string lockDepth, string lockTypeOfMaterial, string lockPredistination, string lockTypeOfLock) :
        base(lockModel, lockLength, lockWeight, lockDepth, lockTypeOfMaterial, lockPredistination, lockTypeOfLock)
        {
            typeOfMechanizm = lockTypeOfMechanizm;
        }

        public override object Clone()
        {
            return new Overhead();
        }
    }
}
