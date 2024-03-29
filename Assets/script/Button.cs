using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class Button : MonoBehaviour
{
    public Image imagerender;
    public Image imagerender2;
   
    public void Option()
    {
        Debug.Log("called");
        imagerender.enabled = false;
        imagerender2.enabled = false;
       
    }

    public void Startgame()
    {
        SceneManager.LoadSceneAsync("SampleScene");
    }

    public void Quietgame()
    {
        Application.Quit();
    }

    public void ResetScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Home()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void ResetSceneLevel2()
    {
        SceneManager.LoadScene("Level-2");
    }
}
