using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{   
    bool gameHasEnded =false;
    bool levelCompleted = false;
    public float restartDelay =2f;

    public GameObject completeLevelUI;

    void Awake()
    {
        if (completeLevelUI != null)
        {
            completeLevelUI.SetActive(false);
        }
    }


     public void CompleteLevel()
     {
        if (levelCompleted || completeLevelUI == null)
        {
            return;
        }

        levelCompleted = true;
        completeLevelUI.SetActive(true);
     }
     public void EndGame()

    {   if(gameHasEnded==false)
       {  gameHasEnded = true;
        Debug.Log("Game Over");
        Invoke("Restart", restartDelay);
       }   
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }



}
