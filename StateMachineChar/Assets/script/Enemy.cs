using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy  : DualBehaviour
{

    #region Public Members
    public float m_NPCMoveSpeed=1f;
    public float m_moveSpeed=1f;


    public enum e_characterState
    {
        INVALID = -1,
        STANDING,
        WALKING,
        CHASSINGENEMY,

        MAX
    }
    public e_characterState m_characterState = e_characterState.STANDING;

    #endregion


    #region Public Void

    #endregion


    #region System

    void Awake () 
    {
        m_timerStanding = 0f;
        m_timerStanding = 0f;
        m_NPCBody = m_transform.GetComponent<Rigidbody2D>();

    }
	
	void Update () 
    {
        CharStateHandle();


    }

    private void CharStateHandle()
    {

        switch (m_characterState)
        {
            case e_characterState.STANDING:
                m_timerWalking = 0;
                m_timerStanding += Time.deltaTime;
                if(m_timerStanding>5)
                {
                    m_characterState = e_characterState.WALKING;
                }
                break;
            case e_characterState.WALKING:
                m_timerStanding = 0;
                m_timerWalking += Time.deltaTime;
                if(m_timerWalking < 4f)
                {
                    m_moveSpeed = -1 * m_NPCMoveSpeed;
                }
                if (m_timerWalking > 4f)
                {
                    m_moveSpeed = 1 * m_NPCMoveSpeed;
                }

                NPCMoves();
                Debug.Log(m_timerWalking);
                if (m_timerWalking > 8f)
                {
                    m_moveSpeed = 0 ;
                    m_characterState = e_characterState.STANDING;
                }
                break;
            case e_characterState.CHASSINGENEMY:
                break;
        }

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

    private void NPCMoves()
    {
        if (m_characterState == e_characterState.WALKING || m_characterState == e_characterState.CHASSINGENEMY)
        {
            m_NPCBody.velocity = new Vector2( m_moveSpeed , 0f);
        }
    }

    #endregion


    #region Tools Debug And Utility

    #endregion


    #region Private And Protected Members
    private float m_timerStanding;
    private float m_timerWalking;
    private Rigidbody2D m_NPCBody;
    #endregion

}
