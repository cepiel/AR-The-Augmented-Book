using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb_anim : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject vbBtnObj;
    public Animator ani;
    public AudioClip testTrack;
    AudioSource aud;
    public bool on = false;

     // Start is called before the first frame update
    void Start()
    {
        vbBtnObj = GameObject.Find("btn");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        ani.GetComponent<Animator>();
        
        aud = GetComponent<AudioSource>();
        testTrack.LoadAudioData();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb) {
        if(on == false){
            on = true;
            ani.Play("speaker_anim");
            aud.PlayOneShot(testTrack, 2F);
        }
        else
        {
            ani.Play("none");
            on = false;
        }
       
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb) {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
