using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine  : DualBehaviour
{

    #region Public Members

    public GameController m_GC;

    public float m_jumpingSpeed = 3;
    public float m_jumpAscendingTime = 0.5f;
    public GameObject m_SoundWave;

    public enum e_characterState
    {
        INVALID=-1,
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

    void Awake () 
    {
        MCBody = m_transform.GetComponent<Rigidbody2D>();
        m_originalGravityScale = MCBody.gravityScale;
        m_timerSoundWaveMaker=0f;
        m_soundSent=false;
    }
	
	void Update () 
    {
        CharStateHandle();
        HeroMoves();
    }

    #endregion

    private void OnCollisionStay2D(Collision2D collision)//collision stay au lieu de enter parcequ'il le detecte pas parfois
    {
        if ((collision.transform.tag == "GROUND")&&(m_isFalling == true))
        {
            m_hasJumped = true;
            m_isFalling = false;
            InstanciateSound();
        }
    }

    private void CharStateHandle()
    {
        switch (m_characterState)
        {
            case e_characterState.STANDING:
                m_hasJumped = false;
                if (Input.GetButtonDown("Submit"))
                {
                    m_characterState = e_characterState.SLEEPING;
                }
                if (Input.GetAxisRaw("Vertical")== -1)
                {
                    m_characterState = e_characterState.DUCKING;
                }
                if (Input.GetAxisRaw("Vertical") == 1)
                {
                    InstanciateSound();
                    m_characterState = e_characterState.JUMPING;
                }
                if (Input.GetAxisRaw("Horizontal") != 0)
                {
                    m_characterState = e_characterState.WALKING;
                }
                break;
            case e_characterState.DUCKING:
                m_transform.localScale = new Vector2(1f, 0.5f);
                if (Input.GetAxisRaw("Vertical") != -1)
                {
                    m_transform.localScale = new Vector2(1f, 1f);
                    m_characterState = e_characterState.STANDING;
                }
                if (Input.GetButtonDown("Submit"))
                {
                    m_characterState = e_characterState.SLEEPING;
                }
                break;
            case e_characterState.JUMPING:
                if ((Input.GetButton("Fire1"))&&(m_isFalling))
                {
                    m_characterState = e_characterState.FLOATING;
                }
                m_AscendingTimer += Time.deltaTime;
                if((!m_isJumping)&&(!m_isFalling)&&(!m_hasJumped))
                {
                    m_hasJumped = false;
                    m_isJumping = true;
                    m_AscendingTimer = 0;
                    m_moveV = m_jumpingSpeed;
                }
                if (m_AscendingTimer > m_jumpAscendingTime)
                {
                    m_AscendingTimer = 0;
                    m_moveV = 0f;
                    m_isJumping = false;
                    m_isFalling = true;
                }
                if (m_hasJumped)
                {
                    m_characterState = e_characterState.STANDING;
                }
                break;
            case e_characterState.FLOATING:
                m_transform.localScale = new Vector2(1f, 0.5f);
                MCBody.gravityScale = m_originalGravityScale*0.2f;
                if (Input.GetButtonUp("Fire1"))
                {
                    m_transform.localScale = new Vector2(1f, 1f);
                    MCBody.gravityScale = m_originalGravityScale;
                    m_characterState = e_characterState.JUMPING;
                }
                m_AscendingTimer += Time.deltaTime;
                if (m_AscendingTimer > m_jumpAscendingTime)
                {
                    m_AscendingTimer = 0;
                    m_moveV = 0f;
                    m_isJumping = false;
                    m_isFalling = true;
                }

                if (m_hasJumped)
                {
                    m_transform.localScale = new Vector2(1f, 1f);
                    MCBody.gravityScale = m_originalGravityScale;
                    m_characterState = e_characterState.STANDING;
                }
                break;
            case e_characterState.SLEEPING:
                m_transform.localScale = new Vector2(3f, 0.5f);
                if (Input.GetButtonDown("Submit"))
                {
                    m_transform.localScale = new Vector2(1f, 1f);
                    m_characterState = e_characterState.STANDING;
                }
                break;
            case e_characterState.WALKING:
                m_transform.localScale = new Vector2(1f, 1.5f);

                if (!m_soundSent)
                {
                    m_timerSoundWaveMaker = 0f;
                    m_soundSent = true;
                    InstanciateSound();
                }
                m_timerSoundWaveMaker += Time.deltaTime;
                if (m_timerSoundWaveMaker > 0.5f)
                {
                    m_timerSoundWaveMaker = 0f;
                    m_soundSent = false;
                }


                if (Input.GetAxisRaw("Horizontal") == 0)
                {
                    m_transform.localScale = new Vector2(1f, 1f);
                    m_characterState = e_characterState.STANDING;
                }
                if (Input.GetAxisRaw("Vertical") == 1)
                {
                    m_transform.localScale = new Vector2(1f, 1f);
                    m_characterState = e_characterState.JUMPING;
                }
                break;
        }
    }

    private void HeroMoves()
    {
        if(m_characterState != e_characterState.SLEEPING)
        {
            MCBody.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), m_moveV);
        }
    }
    private void InstanciateSound()
    {
        Instantiate(m_SoundWave, m_transform.position, Quaternion.identity);
    }
    #region Tools Debug And Utility

    #endregion
    
    #region Private And Protected Members
    private Rigidbody2D MCBody;
    private bool m_hasJumped= true;
    private bool m_isJumping= false;
    private bool m_isFalling = false;
    private float m_AscendingTimer = 0;
    private float m_moveV = 0f;
    private float m_originalGravityScale;
    private float m_timerSoundWaveMaker;
    private bool m_soundSent;
    #endregion

}
