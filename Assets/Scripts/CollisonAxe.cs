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
        if (collision1.gameObject.name == "CollisionBox 1")
        {  
            miniGame.addPoints();
        }
        if (collision1.gameObject.name == "CollisionBox 2")
        {
            miniGame.addPoints(); 
        }
        if (collision1.gameObject.name == "CollisionBox 3")
        {
            miniGame.addPoints();
        }
        if (collision1.gameObject.name == "CollisionBox 4")
        {
            miniGame.addPoints();
        }
        if (collision1.gameObject.name == "Skull")
            miniGame.resetPoints();
    }
}
