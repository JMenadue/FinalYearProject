using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

[RequireComponent(typeof(AudioSource))] //adds in the audio source on the game object

public class SnareDrum : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip P;//Piano
    public AudioClip MP; //Mezzo Piano
    public AudioClip MF; //Mezzo Forte
    public AudioClip F; //Forte
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>(); //Gets the audiosource component
    }


    //Realistically the if statements need to be changed to a switch statement to allow for further development. 
    //Nesting of if statements can get messy very quickly and the code would be more efficient in future and easier to read as a switch statement.
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.relativeVelocity.magnitude);

        
        if (collision.relativeVelocity.magnitude > 0.1 && collision.relativeVelocity.magnitude <= 0.3)
        {
            audioSource.PlayOneShot(P);

            Debug.Log("PP Collision Occured");
        }
        if (collision.relativeVelocity.magnitude >0.3 && collision.relativeVelocity.magnitude <= 0.5)
        {
            audioSource.PlayOneShot(MP);

            Debug.Log("MP Collision Occured");
        }
        if (collision.relativeVelocity.magnitude > 0.5 && collision.relativeVelocity.magnitude <=0.7)
        {
            audioSource.PlayOneShot(MF);

            Debug.Log("MF Collision Occured");
        }
        if (collision.relativeVelocity.magnitude > 0.7)
        {
            audioSource.PlayOneShot(F);

            Debug.Log("F Collision Occured");
        }
    }
}

