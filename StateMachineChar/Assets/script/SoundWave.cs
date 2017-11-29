using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundWave  : DualBehaviour
{

    #region Public Members
    public float m_scaleMax = 0.5f;
    #endregion


    #region Public Void

    #endregion


    #region System

    void Awake () 
    {
        m_transform = this.transform;
    }
	
	void Update () 
    {
        m_timer += Time.deltaTime;
        m_currentScale = new Vector3(m_timer , m_timer , 0f);
        m_transform.localScale = m_currentScale;
        if (m_timer>0.5f)
        {
            Destroy(gameObject);
        }

    }
    /*
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.tag.ToString());
        if (collision.tag=="Enemy")
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
    */
    #endregion


    #region Tools Debug And Utility

    #endregion


    #region Private And Protected Members
    private float m_timer=0f;
    private Vector3 m_currentScale;
    #endregion

}
