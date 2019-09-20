using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class switcher : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject vbBtnObj;
    public Animator reviews;
    public Animator video;
    public Animator info;
    public bool on = false;
    //public Video videoPlayer; //VideoPlayer
    public UnityEngine.Video.VideoPlayer vid;

     // Start is called before the first frame update
    void Start()
    {
        vbBtnObj = GameObject.Find("btn2");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        reviews.GetComponent<Animator>();
        video.GetComponent<Animator>();
        info.GetComponent<Animator>();
        
        vid.GetComponent<UnityEngine.Video.VideoPlayer>();
        //videoPlayer = GetComponent<UnityEngine.Video.VideoPlayer>();
        //var videoPlayer = gameObject.AddComponent<UnityEngine.Video.VideoPlayer>();
        //vid = gameObject.GetComponent("video quad") as VideoPlayer;

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb) {

        if(on == false){
            on = true;
            info.Play("info_anim");
            reviews.Play("reviews_anim");
            video.Play("video_anim");

            vid.Play();
        }
        else
        {
            vid.Stop();

            reviews.Play("none");
            video.Play("none");
            info.Play("none");
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
