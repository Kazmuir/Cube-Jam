using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChange : MonoBehaviour
{
    //private void Awake()
    //{
    //    Scene currentScene = SceneManager.GetActiveScene();
    //    string sceneName = currentScene.name;
    //}
    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName == "bombMonster")
        {
            if (Dialogue.dialogue.dialogueEnd == true)
            {
                SceneManager.LoadScene("gameplay");
            }
        }

        if(sceneName == "gameplay")
        {
            if (scoreTally.sT.goalReached == true)
            {
                SceneManager.LoadScene("bombMonster");
            }
        }
    }
}
