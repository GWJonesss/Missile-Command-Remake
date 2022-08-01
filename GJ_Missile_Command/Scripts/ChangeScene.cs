using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    ////////////////////////////////////Switch Scene Button
    public void MoveToScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
    ////////////////////////////////////QUIT BUTTON FUNCTION
    public void Quit()
    {
        Application.Quit();
        
    }

}