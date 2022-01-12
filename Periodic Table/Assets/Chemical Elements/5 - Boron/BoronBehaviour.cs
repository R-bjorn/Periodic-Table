using Atom;
using UnityEngine;

namespace Chemical_Elements.Boron
{
    public class BoronBehaviour : AtomicBehaviour
    {
        protected new void Start()
        {
            base.Start();
        }
    
        public override string ToString()
        {
            Debug.Log("This is Boron");
            return base.ToString();
        }
    }
}
