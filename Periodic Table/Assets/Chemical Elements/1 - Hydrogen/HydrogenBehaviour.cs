using Atom;
using UnityEngine;

namespace Chemical_Elements.Hydrogen
{
     
    public class HydrogenBehaviour : AtomicBehaviour
    {
        
        protected new void Start()
        {
            base.Start();
        }
        
        public override string ToString()
        {
            Debug.Log("This is Hydrogen");
            return base.ToString();
        }
    }
}
