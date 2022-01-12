using Atom;
using UnityEngine;

namespace Chemical_Elements.Beryllium
{
    public class BerylliumBehaviour : AtomicBehaviour
    {
        protected new void Start()
        {
            base.Start();
        }
    
        public override string ToString()
        {
            Debug.Log("This is Beryllium");
            return base.ToString();
        }
    }
}
