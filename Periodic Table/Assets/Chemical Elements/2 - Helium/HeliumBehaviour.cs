using Atom;
using UnityEngine;

namespace Chemical_Elements.Helium
{
    public class HeliumBehaviour : AtomicBehaviour
    {
        protected new void Start()
        {
            base.Start();
        }
    
        public override string ToString()
        {
            Debug.Log("This is Helium");
            return base.ToString();
        }
    }
}
