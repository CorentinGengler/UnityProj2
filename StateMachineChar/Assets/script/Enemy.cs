using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy  : DualBehaviour
{

    #region Public Members
    public enum e_characterState
    {
        INVALID = -1,
        STANDING,
        DUCKING,
        JUMPING,
        FLOATING,
        SLEEPING,
        WALKING,

        MAX
    }
    public e_characterState m_characterState = e_characterState.STANDING;

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
        Debug.Log(collision.tag.ToString());
        if (collision.tag == "SoundWave")
        {
            Debug.Log("Enemy found me");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.tag.ToString());
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("Enemy found me");
        }
    }
    #endregion


    #region Tools Debug And Utility

    #endregion


    #region Private And Protected Members

    #endregion

}
