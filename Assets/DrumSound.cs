using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrumSound : MonoBehaviour {
    float time = 0;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            this.gameObject.GetComponent<AudioSource>().Play();
            if(time<0.001f)
                time = 0.6f;
            Debug.Log("drum");
        }
    }

    private void Update()
    {
        time -= Time.deltaTime;
        
        if (time > 0.5f)
        {
            transform.Rotate(Time.deltaTime * 100, 0, 0);
        }
        else if (time > 0.4f)
        {
            transform.Rotate(-Time.deltaTime * 100, 0, 0);
        }
        else if (time > 0.3f)
        {
            transform.Rotate(Time.deltaTime * 50, 0, 0);
        }
        else if (time > 0.2f)
        {
            transform.Rotate(-Time.deltaTime * 50, 0, 0);
        }
        else if (time > 0.1f)
        {
            transform.Rotate(Time.deltaTime * 30, 0, 0);
        }
        else if (time > 0.0f)
        {
            transform.Rotate(-Time.deltaTime * 30, 0, 0);
        }
        else if (time<0)
        {
            transform.rotation = new Quaternion();
            time = 0;
        }
    }
}
