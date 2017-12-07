using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager  : DualBehaviour
{

    #region Public Members
    public GameObject m_buttonContinue;
    public GameObject m_buttonLoadGame;
    public GameObject m_buttonNewGame;

    public GameObject m_PanelAreYouSure;

    public AudioSource m_HoverSound;
    #endregion


    #region Public Void
    public void ToggleCampaign(bool _status)
    {
        m_buttonContinue.SetActive(_status);
        m_buttonLoadGame.SetActive(_status);
        m_buttonNewGame.SetActive(_status);
    }
    #endregion
    public void PlayHover()
    {
        m_HoverSound.Play();
    }
    
    #region System
    public void ToggleAreYouSure(bool _status)
    {
        m_PanelAreYouSure.SetActive(_status);
    }

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
