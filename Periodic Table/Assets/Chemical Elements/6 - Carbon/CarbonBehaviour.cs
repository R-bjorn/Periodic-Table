using Atom;
using UnityEngine;

namespace Chemical_Elements.Carbon
{
    public class CarbonBehaviour : AtomicBehaviour
    {
        protected new void Start()
        {
            base.Start();
        }
    
        public override string ToString()
        {
            Debug.Log("This is Carbon");
            return base.ToString();
        }
    }
}
