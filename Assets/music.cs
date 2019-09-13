using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class music : MonoBehaviour, ITrackableEventHandler
{
    private AudioSource ambience;
    private TrackableBehaviour mTrackableBehaviour;

    // Start is called before the first frame update
    void Start()
    {
        //ambience.GameObject.Find("musicTrack").GetComponent<AudioSource>();
        
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if(mTrackableBehaviour){
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTrackableStateChanged( 
        TrackableBehaviour.Status previousStatus,
        TrackableBehaviour.Status newStatus)
        {
            if(newStatus == TrackableBehaviour.Status.DETECTED ||
                newStatus == TrackableBehaviour.Status.TRACKED ||
                newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
                {
                    GetComponent<AudioSource>().Play();
                    //ambience.Play();
                }
                else
                {
                    {
                        GetComponent<AudioSource>().Stop();
                        //ambience.Stop();
                    }
                }
        }
}
