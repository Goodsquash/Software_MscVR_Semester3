using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dummyanimation : MonoBehaviour
{
    public Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<MeshRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Other Object is: " + other.name);
        
        animator.SetTrigger("Topple");
        GetComponent<AudioSource>().Play();
    }
}
