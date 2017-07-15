using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceclick : MonoBehaviour {

    // Use this for initialization
    public GameObject fire;

    public AudioClip drumaudio;
    public AudioClip djaudio;
    public AudioClip mikeaudio;
    float time = 0;
    int stage = 1;
    // Update is called once per frame

    private void Start()
    {
        GetComponent<AudioSource>().clip = drumaudio;
        GetComponent<AudioSource>().Play();
    }

    void Update () {
        
        if(time>0)
        {
            time -= Time.deltaTime;
         
        }
        else
        {
            fire.SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            time = 4;
            fire.SetActive(true);
        }
        

		if(stage==1 && Input.GetKeyDown(KeyCode.Space))
        {
            stage = 2;
            transform.localPosition = new Vector3(3.75f, 0.74f, 10.48f);
            Quaternion tmpq = new Quaternion();
            tmpq.eulerAngles = new Vector3(0, 180, 0);
            transform.localRotation = tmpq;
            GetComponent<AudioSource>().Stop();
            GetComponent<AudioSource>().clip = djaudio;
            GetComponent<AudioSource>().Play();
            
        }
        else if (stage == 2 && Input.GetKeyDown(KeyCode.Space))
        {
            stage = 3;
            transform.localPosition = new Vector3(-5.773f, 0.74f, -10.91f);
            Quaternion tmpq = new Quaternion();
            tmpq.eulerAngles = new Vector3(0, 30, 0);
            transform.localRotation = tmpq;
            GetComponent<AudioSource>().Stop();
            GetComponent<AudioSource>().clip = mikeaudio;
            GetComponent<AudioSource>().Play();
        }
        else if (stage == 3 && Input.GetKeyDown(KeyCode.Space))
        {
            stage = 1;
            transform.localPosition = new Vector3(-10.5f, 0.713f, 4.4f);
            Quaternion tmpq = new Quaternion();
            tmpq.eulerAngles = new Vector3(0, 120, 0);
            transform.localRotation = tmpq;
            GetComponent<AudioSource>().Stop();
            GetComponent<AudioSource>().clip = drumaudio;
            GetComponent<AudioSource>().Play();
        }
    }
}
