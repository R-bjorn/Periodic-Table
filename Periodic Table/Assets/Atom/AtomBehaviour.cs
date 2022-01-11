using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtomBehaviour : MonoBehaviour
{
    [Header("Atom Has")]
    //This is an Atom. An atom is the smallest unit of ordinary matter that forms a chemical element.
    //Every solid, liquid, gas, and plasma is composed of neutral or ionized atoms.
    //Atoms are extremely small, typically around 100 picometers across
    
    // Atom has some types that i can thing of easily
    [Tooltip("atom has its own shape")] [SerializeField]
    private GameObject atom;
    [Tooltip("radius of the atom")] [SerializeField]
    [Range(00.00003f, 0.003f)]
    private float radius;
    [Tooltip("electron of the atom")] [SerializeField]
    private GameObject electron;
    [Tooltip("neutron of the atom")] [SerializeField]
    private GameObject neutron;
    [Tooltip("proton of the atom")] [SerializeField]
    private GameObject proton;
    
    
    void Start()
    {
        // radius depends on the which atom it is connected to but for now we can just do a random number between 30 to 300pm
        // so every atom has a different radius. 
        radius =  Random.Range(0.00003f, 0.003f);
        SetRadius(radius);
    }

    // function for setting the radius of the atom in pico meters. 
    private void SetRadius(float atomRadius)
    {
        SphereCollider atomShape = atom.GetComponent<SphereCollider>();
        atomShape.radius = atomRadius;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
