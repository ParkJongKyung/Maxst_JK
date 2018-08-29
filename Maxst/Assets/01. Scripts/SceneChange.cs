using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChange : AbstractBackScene
{   
    public void NextScene(string SceneName) {
        PushSceneName(Application.loadedLevelName);
        if (SceneName != "Popup")
        {            
            SceneManager.LoadScene(SceneName);
        }
        else
        {            
            ObjPopup = Instantiate(Resources.Load<GameObject>("Popup"), GameObject.Find("Canvas").transform);            
        }        
    }
}
