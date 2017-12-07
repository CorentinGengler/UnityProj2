using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fakeCode  : DualBehaviour
{

    #region Public Members

    #endregion


    #region Public Void
    public enum e_characterState
    {
        INVALID = -1,
        STANDING,
        DUCKING,
        JUMPING,
        DIVING,

        MAX
    }
    public e_characterState m_characterState = e_characterState.STANDING;


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
