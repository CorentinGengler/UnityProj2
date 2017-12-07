using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton  : DualBehaviour
{

    #region Public Members
    public int m_storedI;
    #endregion


    #region Public Void
    public static Singleton Instance
    {

        get
        {
            if(inst==null)
            {
                inst = new Singleton();
            }
            return inst;
        }
        set
        {

        }
    }
    public static Singleton inst;

    

    #endregion


    #region System

    void Awake () 
    {
		if(inst==null)
        {
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
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
