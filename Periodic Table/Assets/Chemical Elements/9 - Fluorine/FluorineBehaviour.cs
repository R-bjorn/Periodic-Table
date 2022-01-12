using Atom;
using UnityEngine;

namespace Chemical_Elements.Fluorine
{
    public class FluorineBehaviour : AtomicBehaviour
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
