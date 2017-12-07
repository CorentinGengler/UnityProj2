using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardView  : DualBehaviour
{

    #region Public Members
    public Guard guard;
    #endregion


    #region Public Void

    #endregion


    #region System

    void Start () 
    {
		
	}
	
	void Update () 
    {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            guard.m_seesPlayer = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            guard.m_seesPlayer = false;
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
