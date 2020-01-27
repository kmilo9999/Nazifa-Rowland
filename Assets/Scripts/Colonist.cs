using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colonist : MonoBehaviour
{
    private  enum Job {
        Engineer,
        Scientist,
        Botanic,
        Officer,
        NoSpecialization
    };

    // Fields
    private int myGender;
    private int myAge;
    private Job myJob;
    private string myName;
    private int myGeneration;

    // Properties
    //public int
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Die()
    {
        if (myAge >= 55)
        {

        }
    }

    
}
