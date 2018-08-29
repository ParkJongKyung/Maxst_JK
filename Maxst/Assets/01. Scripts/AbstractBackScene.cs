using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class Back : MonoBehaviour {
    protected GameObject ObjPopup;

    public abstract string PopSceneName { get; }
    public abstract void PushSceneName(string SceneName);
    public abstract void EscapeScene();
}

public class AbstractBackScene : Back
{
    public static Stack<string> SceneStack = new Stack<string>();

    public override string PopSceneName
    {
        get { return SceneStack.Pop(); }
    }

    public override void PushSceneName(string SceneName)
    {
        SceneStack.Push(SceneName);
    }

    public override void EscapeScene()
    {
        string EscapeSceneName = SceneStack.Pop();
        if (EscapeSceneName != "Popup")
        {
            SceneManager.LoadScene(EscapeSceneName);
        }
        else
        {
            DestroyImmediate(ObjPopup);
        }        
    }

    public void Update(){
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (SceneStack.Count != 0)
            {
                EscapeScene();
            }
        }    
    }
}
