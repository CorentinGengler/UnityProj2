using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy  : DualBehaviour
{

    #region Public Members
    public float m_NPCMoveSpeed=1f;
    public float m_moveSpeed=1f;
    public Text m_canvasTextMidEcran;
    public GameController m_GC;
    public GameObject m_exclamationPoint;
    public GameObject m_detectZone;
    public GameObject m_patrolLimitL;
    public GameObject m_patrolLimitR;
    public enum e_characterState
    {
        INVALID = -1,
        STANDING,
        WALKING,
        SENSESOMETHING,
        CHASSINGMC,

        MAX
    }
    public e_characterState m_characterState = e_characterState.STANDING;

    #endregion


    #region Public Void

    #endregion


    #region System

    void Awake () 
    {
        m_NPCBody = m_transform.GetComponent<Rigidbody2D>();
        m_NPCCollider2D = m_transform.GetComponent<CircleCollider2D>();
    }
	
	void Update () 
    {
        CharStateHandle();


    }

    private void CharStateHandle()
    {
        m_justStopped = false;
        switch (m_characterState)
        {
            case e_characterState.STANDING:
                m_timerStanding += Time.deltaTime;
                if (m_timerStanding > 1)
                {
                    m_characterState = e_characterState.WALKING;
                }
                break;
            case e_characterState.WALKING:
                m_timerStanding = 0;
                Transform Destination = m_transform;
                if (Direction == -1)
                {
                    Destination = m_patrolLimitL.transform;

                }
                if (Direction == 1)
                {
                    Destination = m_patrolLimitR.transform;
                }
                Vector3 displacement = Destination.position - transform.position;
                displacement = displacement.normalized;
                if (Vector2.Distance(Destination.position, transform.position) > 0.1f)
                {
                    transform.position += (displacement * m_moveSpeed * Time.deltaTime);
                }
                else
                {
                    Direction *= -1;
                    m_characterState = e_characterState.STANDING;
                }
                break;
            case e_characterState.CHASSINGMC:
                Transform Player = m_GC.m_MC.transform;
                Vector3 displacement2 = Player.position - transform.position;
                displacement = displacement2.normalized;
                if (Vector2.Distance(Player.position, transform.position) > 0.1f)
                {
                    transform.position += (displacement * m_moveSpeed * 2 * Time.deltaTime);
                }
                else
                {
                    m_canvasTextMidEcran.enabled = true;
                    m_GC.KillThemAll();
                }
                break;
            case e_characterState.SENSESOMETHING:
                m_isPayingAttention = true;
                m_justStopped = true;
                m_timerSensing += Time.deltaTime;
                m_NPCCollider2D.radius = 0.5f + m_timerSensing * 0.3f;
                m_detectZone.transform.localScale = new Vector2(0.5f + m_timerSensing * 0.3f, 0.5f + m_timerSensing * 0.3f);
                if (m_timerSensing>3)
                {
                    m_exclamationPoint.SetActive(false);
                    m_timerSensing = 0;
                    m_NPCCollider2D.radius = 0.5f;
                    m_detectZone.transform.localScale = new Vector2(0.5f , 0.5f );
                    m_isPayingAttention = false;
                    if(m_previousState==e_characterState.STANDING)
                    {
                        m_characterState = e_characterState.STANDING;
                    }
                    else
                    {
                        m_characterState = e_characterState.WALKING;
                    }
                }
                break;
        }
        

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "SoundWave")
        {
            if (m_isPayingAttention)
            {
                if (m_timerSensing > 1)
                {
                    m_justStopped = false;
                    m_characterState = e_characterState.CHASSINGMC;
                }
            }
            else
            {
                m_exclamationPoint.SetActive(true);
                m_previousState = m_characterState;
                m_characterState = e_characterState.SENSESOMETHING;
            }
        }
        if((collision.tag =="PatrolStop")&&(m_characterState == e_characterState.WALKING))
        {
            m_characterState = e_characterState.STANDING;
        }
    }
    

    #endregion


    #region Tools Debug And Utility

    #endregion


    #region Private And Protected Members
    private float m_timerStanding=0f;
    private float m_timerWalking=0f;
    private Rigidbody2D m_NPCBody;
    private CircleCollider2D m_NPCCollider2D;
    private bool m_justStopped;
    private bool m_isPayingAttention;
    private float m_timerSensing=0f;
    private e_characterState m_previousState;
    private int Direction = -1;

    #endregion
}
