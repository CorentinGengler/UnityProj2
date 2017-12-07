using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene  : DualBehaviour
{

    #region Public Members

    #endregion


    #region Public Void

    #endregion


    #region System

    void Start()
    {
        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        MoveScene();
    }
	
	void Update () 
    {
		
	}

    private void MoveScene()
    {
        Singleton temp = Singleton.Instance;
        temp.m_storedI++;
        if (gameObject.name== "ButtonToScene1")
        {
            SceneManager.LoadScene(0);
        }
        if (gameObject.name == "ButtonToScene2")
        {
            SceneManager.LoadScene(1);
        }
        if (gameObject.name == "ButtonToScene3")
        {
            SceneManager.LoadScene(2);
        }

    }
    
    #endregion

    #region Private Void

    #endregion

    #region Tools Debug And Utility

    #endregion


    #region Private And Protected Members

    #endregion

}
