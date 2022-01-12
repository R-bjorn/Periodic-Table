using Atom;
using UnityEngine;

namespace Chemical_Elements.Nitrogen
{
    public class NitrogenBehaviour : AtomicBehaviour
    {
        protected new void Start()
        {
            base.Start();
        }
    
        public override string ToString()
        {
            Debug.Log("This is Lithium");
            return base.ToString();
        }
    }
}
