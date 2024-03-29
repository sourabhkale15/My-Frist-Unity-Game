using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Distordedreality : MonoBehaviour
{
    private float Naumber;
  //  public GameObject okButton;
    public Image ButtonVisibilty;

    private void Start()
    {
        ButtonVisibilty.enabled = false;
        Naumber = 0;
    }
    private void Update()
    {
        if(Naumber<=45)
        {
            Naumber = Naumber+Time.deltaTime;
        }
        else
        {
            Debug.Log("Button will be visible");
            ButtonVisibilty.enabled = true;
        }
        }
    public void ok()
    {
      
            if(0<1)
            {
            Debug.Log("Quit");
            Application.Quit();
            }         
        
       
    }
}
