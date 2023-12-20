using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class axestrikeaudio : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision1)
    {
        if (collision1.gameObject.name == "Axe Model")
        {
            
            gameObject.GetComponent<AudioSource>().Play();
        }
    }
}
