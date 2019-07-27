using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class StickHaptic : MonoBehaviour
{

    public GameObject physParent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        Hand hand = physParent.GetComponentInParent<Hand>(); //Checks to see if the drum stick is in a hand
        if (hand != null)
        {
            hand.TriggerHapticPulse(0.05f, 20, 500* collision.relativeVelocity.magnitude); //sends a vibration based upon velocity to the hand the drum stick is in
        }

    }


}
