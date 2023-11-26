using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class minigamecontroller : MonoBehaviour
{
    public Text Score;
    public float score = 0;

    // Start is called before the first frame update
    void Start()
    {
        Score.text = "Score " + score;
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = "Score: " + score;
    }
    public void addPoints()
    {

        score +- 1;
    }
    public void resetPoints()
    {
        score = 0;
    }
}
