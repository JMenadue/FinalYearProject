using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSwitch : MonoBehaviour
{
    public GameObject AmbisonicSnare;
    public GameObject MonoSnare;
    public GameObject AmbienceAudio;
    public GameObject AmbisonicSnare2;
    public GameObject MonoSnare2;
    public GameObject AmbienceAudio2;

    public bool AmbienceOnOff;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AmbisonicOn()
    {
        AmbisonicSnare.SetActive(true);
        MonoSnare.SetActive(false);
        AmbisonicSnare2.SetActive(true);
        MonoSnare2.SetActive(false);
        Debug.Log("Ambi On");
    }

    public void AmbisonicOff()
    {
        AmbisonicSnare.SetActive(false);
        MonoSnare.SetActive(true);
        AmbisonicSnare2.SetActive(true);
        MonoSnare2.SetActive(false);
        Debug.Log("Ambi Off");
    }

    public void Ambience()
    {
        AmbienceAudio.SetActive(!AmbienceOnOff);
        AmbienceAudio2.SetActive(!AmbienceOnOff);

    }
}
