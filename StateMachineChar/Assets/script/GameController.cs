using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController  : DualBehaviour
{

    #region Public Members
    public GameObject m_MC;
    public List<GameObject> m_NPCs;

    #endregion


    #region Public Void
    public void KillThemAll()
    {
        m_MC.SetActive(false);
        foreach(GameObject NPC in m_NPCs)
        {
            NPC.SetActive(false);
        }
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
