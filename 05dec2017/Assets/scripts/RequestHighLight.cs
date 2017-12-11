using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RequestHighLight  : DualBehaviour
{

    #region Public Members
    public Vector3 m_desiredRect;
    public RectTransform m_HighlightTran;
    #endregion


    #region Public Void
    public void RequestHihlight()
    {
        m_HighlightTran.localPosition = m_desiredRect;
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
