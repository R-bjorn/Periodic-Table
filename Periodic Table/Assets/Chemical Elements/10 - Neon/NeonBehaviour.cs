using Atom;
using UnityEngine;

namespace Chemical_Elements.Neon
{
    public class NeonBehaviour : AtomicBehaviour
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
