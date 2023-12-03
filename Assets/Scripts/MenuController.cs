using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision1)
    {
        SceneManager.LoadScene("Project version 1.6");
    }
}
