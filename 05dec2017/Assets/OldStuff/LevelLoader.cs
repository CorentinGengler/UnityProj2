using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LevelLoader  : DualBehaviour
{

    #region Public Members
    public Slider m_slider;
    public Text m_text;
    #endregion


    #region Public Void
    public void LevelLoading(int _levelToLoad)
    {
        StartCoroutine(LoadLevelAsync(_levelToLoad));
    }
    #endregion
    IEnumerator LoadLevelAsync(int _levelToLoad)
    {
        AsyncOperation op = SceneManager.LoadSceneAsync(_levelToLoad);

        while (!op.isDone)
        {
            float progress = Mathf.Clamp01(op.progress / 0.9f);
            m_slider.value = progress;
            m_text.text= progress * 100 + "%";
            yield return new WaitForSeconds(0f);
            
        }


    }
    #region System

    void Start () 
    {
		
	}
	
	void Update () 
    {
		
	}


    #endregion

    #region Private Void

    #endregion

    #region Tools Debug And Utility

    #endregion


    #region Private And Protected Members

    #endregion

}
