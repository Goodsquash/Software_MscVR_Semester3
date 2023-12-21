using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameMenuManager : MonoBehaviour
{
   public void StartBtn()
   {
    SceneManager.LoadScene("MainScene");
   }

   public void QuitBtn()
   {
    Application.Quit();
   }

}
