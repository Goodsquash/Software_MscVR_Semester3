using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeHit : MonoBehaviour
{
    
    public GameObject Axe;
    public minigamecontroller miniGame;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
      if (collision.gameObject.name == "Target")

            miniGame.addPoints();
    }
}