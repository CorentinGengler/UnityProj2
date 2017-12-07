using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Guard  : DualBehaviour
{

    #region Public Members
    public float m_NPCMoveSpeed = 1f;
    public float m_moveSpeed = 1f;
    public Text m_canvasTextMidEcran;
    public GameController m_GC;
    public GameObject m_exclamationPoint;
    public GameObject m_patrolLimitL;
    public GameObject m_patrolLimitR;
    public GameObject m_sightL;
    public GameObject m_sightR;
    public bool m_seesPlayer;
    public bool m_hearPlayer;

    public enum e_guardPositionState
    {
        INVALID = -1,
        STANDING,
        WALKING,
        CHASSINGMC,

        MAX
    }

    public enum e_guardAlertnessState
    {
        INVALID = -1,
        ISOK,
        ISWORRIED,
        ISSHOOTING,

        MAX
    }



    #endregion


    #region Public Void

    #endregion


    #region System

    void Awake () 
    {
        m_NPCBody = m_transform.GetComponent<Rigidbody2D>();
        m_NPCCollider2D = m_transform.GetComponent<PolygonCollider2D>();
    }
	
	void Update () 
    {
        ActOnPositionState();
        ActOnAlertness();
    }

    #endregion

    #region Private Void
    private void ActOnPositionState()
    {

    }
    private void ActOnAlertness()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "SoundWave")
        {

        }
        if (collision.tag == "Player")
        {
            m_canvasTextMidEcran.enabled = true;
            m_GC.KillThemAll();
        }

    }
    #endregion

    #region Tools Debug And Utility

    #endregion


    #region Private And Protected Members
    private Rigidbody2D m_NPCBody;
    private PolygonCollider2D m_NPCCollider2D;
    #endregion

}
