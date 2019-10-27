using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAudio : MonoBehaviour
{
    public GameObject clip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MeshRenderer mesh = this.GetComponent<MeshRenderer>();
        if (mesh.enabled){
            clip.GetComponent<AudioSource>().Play();
        }
    }

}
