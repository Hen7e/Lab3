using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace locks
{
    [KnownType(typeof(Mortise))]
    [KnownType(typeof(Hinged))]
    [KnownType(typeof(Overhead))]
 
    [Serializable]
    [DataContract]
    public abstract class Locks
    {
        [DataMember]
        private string model;
        [DataMember]
        private string length;
        [DataMember]
        private string weight;
        [DataMember]
        private string depth;
        [DataMember]
        private string typeOfMaterial;
        [DataMember]
        private string predestination;
        [DataMember]
        private string typeOfLock;

        public string lockModel
        {
            get { return model; }
            set { model = value; }
        }
        public string lockTypeOfLock
        {
            get { return typeOfLock; }
            set { typeOfLock = value; }
        }
        public string lockLength
        {
            get { return length; }
            set { length = value; }
        }
        public string lockWeight
        {
            get { return weight; }
            set { weight = value; }
        }
        public string lockDepth
        {
            get { return depth; }
            set { depth = value; }
        }
        public string lockTypeOfMaterial
        {
            get { return typeOfMaterial; }
            set { typeOfMaterial = value; }
        }
        public string lockPredistination
        {
            get { return predestination; }
            set { predestination = value; }
        }
        public Locks(string lockModel, string lockLength, string lockWeight, string lockDepth, string lockTypeOfMaterial, string lockPredistination, string lockTypeOfLock )
        {
            model = lockModel;
            length = lockLength;
            weight = lockWeight;
            depth = lockDepth;
            typeOfMaterial = lockTypeOfMaterial;
            predestination = lockPredistination;
            typeOfLock = lockTypeOfLock;
        }
        
        public abstract object Clone();
    }
}
