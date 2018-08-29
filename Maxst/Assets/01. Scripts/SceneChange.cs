using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChange : AbstractBackScene
{   
    public void NextScene(string SceneName) {        
        if (SceneName != "Popup")
        {
            PushSceneName(Application.loadedLevelName);
            SceneManager.LoadScene(SceneName);
        }
        else
        {
            PopupStack.Push(Instantiate(Resources.Load<GameObject>("Popup"), GameObject.Find("Canvas").transform));            
        }        
        //Test Git
    }
}
