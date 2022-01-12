using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

namespace Atom
{
    public abstract class AtomicBehaviour : MonoBehaviour
    {
        [FormerlySerializedAs("atom")]
        [Header("Atom Has")]
        //This is an Atom. An atom is the smallest unit of ordinary matter that forms a chemical element.
        //Every solid, liquid, gas, and plasma is composed of neutral or ionized atoms.
        //Atoms are extremely small, typically around 100 pico meters across
    
        // Atom has some types that i can thing of easily
        [Tooltip("atom has its own shape")] [SerializeField]
        protected GameObject atomicParticle;
        [Tooltip("atom has its atomic number based on how many protons it has")] [SerializeField]
        protected int atomicNumber;
        [Tooltip("atom has its own symbol")] [SerializeField]
        protected string atomicSymbol;
        [Tooltip("atom has its own name")] [SerializeField]
        protected string atomicName;
        [Tooltip("radius of the atom")] [SerializeField] [Range(00.00003f, 0.003f)]
        protected float atomicRadius;
        [Tooltip("atomic mass of the atom")] [SerializeField] // [Range(00.00003f, 0.003f)]
        protected float atomicMass;
    
        // Atom is made of Sub-Atomic Particles
        // Every atom is made of sub-atomic particles. i.e., proton, neutron, electron
        [Header("1. Elementary Particles")]
        [Header("Atom is made of Sub-Atomic Particles")]
        [Tooltip("electron(s) of the atom i.e., Hydrogen has 1 electron.")] [SerializeField]
        protected GameObject[] electrons;
        [Header("2. Composite Particles")]
        [Tooltip("neutron(s) of the atom")] [SerializeField]
        protected GameObject[] neutrons;
        [Tooltip("proton(s) of the atom")] [SerializeField]
        protected GameObject[] protons;

        // Some TextMeshPro variables to write on the periodic table
        [Header("Periodic Table Info")]
        [SerializeField]protected TextMeshProUGUI atomicNoToTxt;
        [SerializeField]protected TextMeshProUGUI atomicSymToTxt;
        [SerializeField]protected TextMeshProUGUI atomicNameToTxt;
        [SerializeField]protected TextMeshProUGUI atomicRadToTxt;
        [SerializeField]protected TextMeshProUGUI atomicMassToTxt;
    
        protected void Start()
        {
            // radius depends on the which atom it is connected to but for now we can just do a random number between 30 to 300pm
            // so every atom has a different radius. 
            atomicRadius =  Random.Range(0.00003f, 0.003f);
            atomicNumber = protons.Length;
            SetRadius(atomicRadius);
            SetInfo();
        }

        // Function to write all the data about the particular atom to the panel
        private void SetInfo()
        {
            atomicNoToTxt.text = atomicNumber.ToString();
            atomicSymToTxt.text = atomicSymbol;
            atomicNameToTxt.text = atomicName;
            atomicRadToTxt.text = atomicRadius.ToString(CultureInfo.InvariantCulture);
            atomicMassToTxt.text = atomicMass.ToString(CultureInfo.InvariantCulture);
        }

        // function for setting the radius of the atom in pico meters. 
        private void SetRadius(float atomRadius)
        {
            SphereCollider atomShape = atomicParticle.GetComponent<SphereCollider>();
            atomShape.radius = atomRadius;
        }

        // Function to write all the info about atom to output.
        public override string ToString()
        {
            Debug.Log($"Atomic # : {atomicNumber}");
            Debug.Log($"Atomic Symbol : {atomicSymbol}");
            Debug.Log($"Atomic Name : {atomicName}");
            Debug.Log($"Atomic Radius : {atomicRadius}");
            Debug.Log($"Atomic Mass : {atomicMass}");
            Debug.Log($"# of electrons : {electrons.Length}");
            Debug.Log($"# of neutrons : {neutrons.Length}");
            Debug.Log($"# of protons : {protons.Length}");
            return null;
        }
    }
}
