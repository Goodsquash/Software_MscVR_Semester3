using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisonAxe : MonoBehaviour
{
    public minigamecontroller miniGame;
    
    
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
        if (collision1.gameObject.name == "Target 1 Socket")
        {  
            miniGame.addPoints();
        }
        if (collision1.gameObject.name == "Target 2 Socket")
        {
            miniGame.addPoints(); 
        }
        if (collision1.gameObject.name == "Target 3 Socket")
        {
            miniGame.addPoints();
        }
        if (collision1.gameObject.name == "Target 3 Socket")
        {
            miniGame.addPoints();
        }
        if (collision1.gameObject.name == "SkullCollision")
            miniGame.resetPoints();
    }
}
