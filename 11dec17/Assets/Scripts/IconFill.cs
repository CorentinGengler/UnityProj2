using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class IconFill  : MonoBehaviour
{

    #region Public Members
    public Image m_imageFiller;
    public float m_filledAmount=0;

    #endregion


    #region Public Void
    public void FillToAmount(float _Amount)
    {
        m_imageFiller.fillAmount = _Amount;
    }
    #endregion


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
