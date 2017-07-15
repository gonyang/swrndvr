using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrumSound : MonoBehaviour {
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            this.gameObject.GetComponent<AudioSource>().Play();
            Debug.Log("drum");
        }
    }
}
