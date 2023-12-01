using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uimananger : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void manscice()
    {
        SceneManager.LoadScene(0);
    }
    public void startscence()
    {
        SceneManager.LoadScene(1);
    }
    public void exitgame()
    {
        Application.Quit();
    }
}
