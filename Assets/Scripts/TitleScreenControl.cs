using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenControl : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Start"))
        {
            SceneManager.LoadScene("MainLevel");
            
        }

        if(Input.GetButtonDown("Exit"))
        {
            Application.Quit();
        }
    }
}
