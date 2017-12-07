using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateCanvas  : DualBehaviour
{

    #region Public Members
    
    #endregion


    #region Public Void

    #endregion


    #region System

    void Awake () 
    {
        Text m_t = m_transform.GetComponent<Text>();
        m_t.text += Singleton.Instance.m_storedI.ToString();
	}
	
	void Update () 
    {
		
	}



    void FakeFunction()
    {


        for(int i=0; i <5 ; i++)
        {
            //do something
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
