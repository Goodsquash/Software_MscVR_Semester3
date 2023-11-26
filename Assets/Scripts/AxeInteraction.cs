using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeInteraction : MonoBehaviour
{
    public GameObject target;
    public minigamecontroller miniGame;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        

        {
            miniGame.addPoints();

        }
    }
    
}
