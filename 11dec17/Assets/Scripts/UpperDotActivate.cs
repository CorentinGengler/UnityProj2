using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpperDotActivate  : MonoBehaviour
{

    #region Public Members
    public GameObject m_image;
    #endregion


    #region Public Void
    public void ActivateImg()
    {
        m_image.SetActive(true);
    }
    public void DeActivateImg()
    {
        m_image.SetActive(false);
    }
    #endregion


    #region System


    #endregion

    #region Private Void

    #endregion

    #region Tools Debug And Utility

    #endregion


    #region Private And Protected Members

    #endregion

}
